using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma sequencia de números : ");
            var textContent = Console.ReadLine();

            Console.WriteLine(textContent.Replace("3", "Banana"));
            Console.ReadKey();

            Console.WriteLine("Informar o nome a ser calculado : ");
            var nomeLength = Console.ReadLine();

            Console.WriteLine($"O tamanho desse nome é {nomeLength.Replace(" ", "").Length}");
            Console.ReadKey();
        }
    }
}
