using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowInitAppText();

            string name = string.Empty;
            int age = 0;

            while (AskToContinue() == 1)
            {
                name = AskName();
                age = AskAge(name);
            }

            Console.WriteLine($"Seu nome é : {name} e sua idade é : {age}");
            Console.ReadLine();


        }
        /// <summary>
        /// Mostra tela de bem vindo
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("--Bem vindo !--");
            Console.WriteLine("---------------");
        }
        /// <summary>
        /// Método para perguntar se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
          
        }
        private static int AskAge(string name)
        {
            Console.Clear();
            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"{name}, pode beber!");
            else
                Console.WriteLine($"{name}, não pode beber!");

            Console.ReadKey();
            Console.Clear();
            return idade;
     
        }
        private static string AskName()
        {
            Console.Clear();
            Console.WriteLine("Qual seu nome? ");
            return Console.ReadLine();
        }

    }
}
