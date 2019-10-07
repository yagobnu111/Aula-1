using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da pessoa a ser cadastrada");
            var nomePessoa = Console.ReadLine();

            pessoa.AddPessoa(new Pessoa() { Nome = nomePessoa });

            pessoa.GetPessoas().ToList<Pessoa>().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();

        }
    }
}
