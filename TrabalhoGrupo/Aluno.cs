using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoGrupo
{
    public  class void Aluno()
    {
        public string Nome{get;set;}
        public int idade{get;set;}
       
    }

    public class Turma
    {
        private List<Aluno> alunos = new List<Aluno>();

        public void AdicionarAluno(Aluno aluno,Aluno idade)
        {
            aluno.Add(aluno);
            aluno.Add(idade);
        }

        public void RemoverAluno(Aluno aluno)
        {
            aluno.Remove(aluno)
        }
    }

     public void Main()
       {

        
        Turma turma = new Turma();

     Console.WriteLine("--Menu--");
     Console.WriteLine("1-AdicionarAluno");
     Console.WriteLine("2-ListarAluno");
     Console.WriteLine("3-AtualizarAluno");
     Console.WriteLine("4-RemoverAluno");
     Console.WriteLine("5-Buscar o aluno por ID");
     Console.WriteLine("0-sair");
     
     int escolha = int.Parse(Console.ReadLine());


    switch (escolha)
     {   
    case 1:
    Console.WriteLine("Quer adiconar quantos?");
    int quantidadeAdicionar  = int.Parse(Console.ReadLine());

    for(int i=0; i<quantidadeAdicionar; i++)
    {
        Console.WriteLine($"Aluno #{i+1}");
        Console.Write("Nome:");
        turma.AdicionarAluno = Console.ReadLine();

        Console.Write("Idade:");
        turma.idade = int.Parse(Console.ReadLine());

        turma.AdicionarAluno(new Aluno{Nome = nome, Idade =idade});
    }
        break;

        case 2:
         turma.ListarAluno();
        break;

        case 3:
        break;

        case 4:


    Console.WriteLine("Quer remover quantos?");
    int remover = int.Parse(Console.Readline());
        for(int i=0; i<remover; i++)
    {
        aluno.
        break;

    }
    
    }


    Console.WriteLine($"Escolha uma opção :{}");
    Console.WriteLine($"Nome:");
    Console.WriteLine($"Idade:");
    Console.WriteLine($"Curso:");


       }

       
       turma.ListarAluno();
        
      
    
}