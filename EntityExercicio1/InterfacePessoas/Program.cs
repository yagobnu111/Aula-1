using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryNomes.Controller;
using LibraryNomes.Model;

namespace InterfacePessoas
{

    class Program
    {
        public static PessoaController pessoaController = new PessoaController(); 
        static void Main(string[] args)
        {
            AdicionarPessoa();
            ListarPessoas();
        }
        public static void AdicionarPessoa()
        {
            Console.WriteLine("Escreva o nome da pessoa a adicionar na lista");
            var nomePessoa = Console.ReadLine();
            var pessoa = (new Pessoa() { Nome = nomePessoa });

            pessoaController.AddPessoa(pessoa);
        }
        public static void ListarPessoas()
        {
            pessoaController.GetPessoas().ToList().ForEach(x => Console.WriteLine($"Nome: {x.Nome}"));
        }
    }
}
