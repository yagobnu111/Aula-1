using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var nome = "Gabriel Yago ";
            var countFind = 0;

            for (int i = 1; i < 10; i++)
            {
                var stringBuilder = $"{nome[i - 1]}-{nome[i]}-{nome[i + 1]}";
                Console.WriteLine(stringBuilder);

                if (stringBuilder.Contains("Y-a"))
                    countFind++;
               
            }

            Console.WriteLine($"Quantidade toda de 'Ya' {countFind}");*/

            ForVer2();
            Console.ReadKey();

        }
        static void ForVer2()
        {
            var nome = "Teus Teus Meus Teus ";
            var countFind = 0;
            Console.WriteLine(nome);
            Console.WriteLine("Encontre a palavra de até 4 caracteres : ");
            var palavra = Console.ReadLine();

            for (int i = 0; i < (nome.Length -3); i++)
            {
                var palavraParaComparar = nome[i].ToString() +
                                          nome[i + 1].ToString() +
                                          nome[i + 2].ToString() +
                                          nome[i + 3].ToString();

                if (palavra == palavraParaComparar)
                    countFind++;

            }
            Console.WriteLine(countFind);

            Console.ReadKey();
        }          
    }
}
