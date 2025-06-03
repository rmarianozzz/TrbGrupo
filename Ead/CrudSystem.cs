using System;
using System.Collections.Generic;
using System.Linq;

namespace Ead
{
    public class CrudSystem
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public static void AdicionarAluno()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.Write("Idade inválida. Digite um número inteiro: ");
            }

            Console.Write("Digite o curso do aluno: ");
            string curso = Console.ReadLine();

            Aluno aluno = new Aluno(nome, idade)
            {
                Curso = curso
            };

            alunos.Add(aluno);
            Console.WriteLine("Aluno adicionado com sucesso!\n");
        }

        public static void RemoverAluno(string nome)
        {
            Aluno aluno = alunos.FirstOrDefault(a => a.Nome == nome);

            if (aluno != null)
            {
                alunos.Remove(aluno);
                Console.WriteLine("Aluno removido com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.\n");
            }
        }

        public static void ListarAlunos()
        {
            Console.WriteLine("\n--- Lista de Alunos ---");

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"ID:    {aluno.Id}");
                Console.WriteLine($"Nome:  {aluno.Nome}");
                Console.WriteLine($"Idade: {aluno.Idade}");
                Console.WriteLine($"Curso: {aluno.Curso}");
                Console.WriteLine();
            }
        }

        public static void AtualizarAluno()
        {
            Console.Write("Digite o nome do aluno que deseja atualizar: ");
            string nomeAntigo = Console.ReadLine();

            Aluno aluno = alunos.FirstOrDefault(a => a.Nome == nomeAntigo);

            if (aluno != null)
            {
                Console.Write("Digite o novo nome: ");
                string nomeNovo = Console.ReadLine();

                Console.Write("Digite a nova idade: ");
                int idadeNova;
                while (!int.TryParse(Console.ReadLine(), out idadeNova))
                {
                    Console.Write("Idade inválida. Digite um número válido: ");
                }

                Console.Write("Digite o novo curso: ");
                string novoCurso = Console.ReadLine();

                aluno.Nome = nomeNovo;
                aluno.Idade = idadeNova;
                aluno.Curso = novoCurso;

                Console.WriteLine("Aluno atualizado com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.\n");
            }
        }

        public static void BuscarAlunoPorId()
        {
            Console.Write("Digite o ID do aluno que deseja buscar: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("ID inválido. Digite um número válido: ");
            }

            Aluno aluno = alunos.FirstOrDefault(a => a.Id == id);

            if (aluno != null)
            {
                Console.WriteLine("\n--- Aluno Encontrado ---");
                Console.WriteLine($"ID:    {aluno.Id}");
                Console.WriteLine($"Nome:  {aluno.Nome}");
                Console.WriteLine($"Idade: {aluno.Idade}");
                Console.WriteLine($"Curso: {aluno.Curso}");
            }
            else
            {
                Console.WriteLine("Aluno com esse ID não encontrado.");
            }
        }
    }
}
