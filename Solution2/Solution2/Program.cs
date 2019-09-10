using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu nome? ");
            string name = Console.ReadLine();
            Console.Write("Olá {0}, qual a sua idade? ", name);
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(checar_idade(idade));
            Console.Read();
        }
        static string checar_idade(int idade)
        {
            return idade < 18 ? "Menor de idade" : "Maior de idade"; 
        }
    }
}
