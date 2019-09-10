using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o livro a ser consultado : ");
            var numeroDoLivro = Console.ReadLine();

            if (numeroDoLivro == "123456")
            {
                Console.WriteLine("Livro indisponível");
                Console.ReadKey();
                //finaliza o método
                return;
            }
            else
            {

                Console.WriteLine("Deseja alocar o livro? (1) sim (2) não");
                var resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.WriteLine("Livro alocado.");
                    Console.ReadKey();
                    return;
                }
            }

            Console.ReadKey();

        }
    }
}
