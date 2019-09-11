using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usado para compactação de informação. o Winrar faz isso

            var primeiroTexto = "meu nome é Gabriel, meu cachorro dudu gosta de comida, meu deus que texto palha - Gabriel";

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"O texto contém {primeiroTexto.Length} caracteres");

            primeiroTexto = primeiroTexto.Replace("Gabriel", "1")
                .Replace("meu", "2");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"O texto contém {primeiroTexto.Length} caracteres");


            //Descompactando invertendo as palavras
            primeiroTexto = primeiroTexto.Replace("1", "Gabriel")
                .Replace("2", "meu");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"O texto contém {primeiroTexto.Length} caracteres");


            Console.ReadKey();


        }
    }
}
