using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex07Ver2();
        }
        /// <summary>
        /// Dá as boas vindas ao usuário
        /// </summary>
        private static void Ex01()
        {
            Console.WriteLine("Seja bem vindo! Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
        /// <summary>
        /// Pergunta o nome e dá as boas vindas
        /// </summary>
        private static void Ex02()
        {
            Console.WriteLine("Qual seu nome?");
            string name = Console.ReadLine();
            Console.WriteLine($"Seja bem vindo! {name}");
            Console.ReadKey();
        }
        /// <summary>
        /// Pergunta nome e idade e diz se é de maior
        /// </summary>
        private static void Ex03()
        {
            Console.WriteLine("Qual seu nome?");
            string name = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18)
                Console.WriteLine($"Calma {name} tudo ao seu tempo logo você terá 18 anos de idade.");
            else
                Console.WriteLine($"Parabéns {name} você já esta na fase adulta.");

            Console.ReadKey();
        }
        /// <summary>
        /// Informa a quantidade de caracteres em um texto informado
        /// </summary>
        private static void Ex04()
        {
            Console.Write("Escreva uma frase : ");
            string frase = Console.ReadLine();
            // substitui todos os espaços por nada e então lê apenas os caracteres 
            frase = frase.Replace(" ", "");

            Console.WriteLine($"O seu texto tem {frase.Length} caracteres ");
            Console.ReadKey();
        }
        /// <summary>
        /// Retorna o primeiro e último caractere de uma frase
        /// </summary>
        private static void Ex05()
        {
            Console.Write("Escreva alguma coisa : ");
            string frase = Console.ReadLine();

            Console.WriteLine($"O primeiro caractere é '{frase[0]}' e o último é '{frase[frase.Length - 1]}'");
            Console.ReadKey();
        }
        /// <summary>
        /// Substitui a palavra 'banana' por 'laranja' em um texto informado
        /// </summary>
        private static void Ex06()
        {
            Console.WriteLine("Escreva algo que contenha banana !");
            string frase = Console.ReadLine();
            frase = frase.Replace("banana", "laranja");

            Console.WriteLine(frase);
            Console.ReadKey();
        }

        private static void Ex07Ver1()
        {
  
            Console.Write("Escreva alguma coisa : ");
            string frase = Console.ReadLine().ToLower();

            var fraseLength = frase.Length;
            string buscaVogal = "aeiou";
            int contaA = 0;
            int contaE = 0;
            int contaI = 0;
            int contaO = 0;
            int contaU = 0;


            for (int i = 0; i <= frase.Length- 1; i++)
            {
                if ( frase[i] == 'a')
                {
                    contaA++;
                }
                else if (frase[i] == 'e')
                {
                    contaE++;
                }
                else if (frase[i] == 'i')
                {
                    contaI++;
                }
                else if (frase[i] == 'o')
                {
                    contaO++;
                }
                else if (frase[i] == 'u')
                {
                    contaU++;
                }
            }

            Console.WriteLine($"Quantidade de A : {contaA}");
            Console.WriteLine($"Quantidade de E : {contaE}");
            Console.WriteLine($"Quantidade de I : {contaI}");
            Console.WriteLine($"Quantidade de O : {contaO}");
            Console.WriteLine($"Quantidade de U : {contaU}");
            Console.ReadKey();
        } 
    }
}
