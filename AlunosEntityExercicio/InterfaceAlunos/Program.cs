using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosLibrary.Controller;
using AlunosLibrary.Model;

namespace InterfaceAlunos
{
    class Program
    {
        public static AlunosController alunos = new AlunosController(); 
        static void Main(string[] args)
        {
            MenuSistemaAlunos();
        } 
        static void AdicionarAlunos()
        {
            Console.WriteLine("Digite o nome a ser cadastrado : ");
            var nome = Console.ReadLine();
            Console.WriteLine($"Digite a idade de {nome}");
            int idade = int.Parse(Console.ReadLine());

            alunos.AddAluno(new Aluno()
            {
                Nome = nome,
                Idade = idade
            }) ;
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu");
            Console.ReadKey(true);

        }
        static void MostrarAlunos()
        {
            alunos.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine(x.Nome, x.Idade));
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu");
            Console.ReadKey(true);
        }
        static void MenuSistemaAlunos()
        {
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine("Cadastrar alunos (1), Mostrar Cadastrados (2), Sair(3)");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AdicionarAlunos();
                        break;
                    case 2:
                        MostrarAlunos();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
            
        }
    }
}