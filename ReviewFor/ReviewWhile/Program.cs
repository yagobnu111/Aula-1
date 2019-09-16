using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto");
            var conteudoDoTexto = Console.ReadLine();
            var x = 0;

            while (x < conteudoDoTexto.Length)
            {
                Console.WriteLine(conteudoDoTexto[x]);
                x++;
            }

            Console.ReadLine();

        }
    }
}
