using System;
using Ead;

class Program
{
    static void Main()
    {
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n--- Menu CRUD Aluno ---");
            Console.WriteLine("1 - Adicionar Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Atualizar Aluno");
            Console.WriteLine("4 - Remover Aluno");
            Console.WriteLine("5 - Buscar Aluno por ID");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();
            Console.WriteLine($"Você escolheu a opção: {opcao}\n");

            switch (opcao)
            {
                case "1":
                    CrudSystem.AdicionarAluno();
                    break;
                case "2":
                    CrudSystem.ListarAlunos();
                    break;
                case "3":
                    CrudSystem.AtualizarAluno();
                    break;
                case "4":
                    Console.Write("Digite o nome do aluno que deseja remover: ");
                    string nomeRemover = Console.ReadLine();
                    CrudSystem.RemoverAluno(nomeRemover);
                    break;
                case "5":
                    CrudSystem.BuscarAlunoPorId();
                    break;
                case "0":
                    executando = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
