using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Pessoa> = new List<Pessoa>();

            Pessoa p1 = new Pessoa();










            List<int> numeros = new List<int>();
            Random rdm = new Random();
            
            // cria uma lista que não aceita números repetidos 
            HashSet<int> dadosSemRepetir = new HashSet<int>();
            

            for (int i = 0; i < 10; i++)
            {
                // gera número aleatório de 0 a 100
                int valorAleatorio = rdm.Next(100);
                //Verifica se a lista não contem esse número gerado
                if (!numeros.Contains(valorAleatorio))
                {
                    numeros.Add(valorAleatorio);
                }
                else
                {
                    i--;
                }
        
                
            }
            Console.ReadKey();



            int ii = 30;
            HebeFicar(out ii);
            Console.WriteLine(ii);

            int resultadoConversao = 0;
            int.TryParse("42", out resultadoConversao);
        }

        static void HebeFicar(out int idade)
        {
            idade = 16000;
        }

    }
}
