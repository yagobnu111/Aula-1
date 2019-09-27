using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
                                   // new cria uma nova instância e reserva ele na memória
            string[] arrayLinear1 = new string[2] {"Gabriel", "Pizza" };

            string[] arrayLinear2 = new string[2];
            arrayLinear2[0] = "Batata";
            arrayLinear2[1] = "Banana";

            //Na HBSIS usam listas ao invés de arrays ou matrizes
            List<string> listaLinear = new List<string>
            {
                "Gabriel",
                "Yago",
                "Souza"
            };

            Console.WriteLine(arrayLinear1[0]);
            Console.WriteLine(arrayLinear1[1]);
            var keypress = Console.ReadKey().KeyChar.ToString();
 
        }
    }
}
