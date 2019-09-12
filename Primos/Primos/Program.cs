using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int n, i, m;
            int flag;
            List<int> listaPrimos = new List<int> { };

            for (i = 2; i <= 10; i++)
            {
                m = i / 2;
                flag = 0;

                for (n = 2; n <= m; n++)
                {

                    if (i % n == 0)
                    {
                        flag = 1;
                    }
                }

                if (flag == 1)
                {
                    Console.WriteLine($"{i} não é primo");
                }
                else
                {
                    Console.WriteLine($"{i} é primo ");
                }
            }

            Console.ReadKey();*/
            PrimosWhile();
            Console.ReadKey();
        }

        static void PrimosWhile()
        {
            var n = 0;
            var divisor = 0;
            List<string> listaPrimos = new List<string> { };

            Console.WriteLine("Até que número checar por números primos ? ");
            n = (Convert.ToInt32(Console.ReadLine()));

            for (int i = 3; i <= n; i++)
            {
                divisor = i / 2;
                var naoPrimo = false;

                for (int x = 3; x <= divisor; x++)
                {
                    if (i % x == 0)
                    {
                        naoPrimo = true;                  
                    }

                }   
                if (naoPrimo == false) 
                {
                    listaPrimos.Add(i.ToString());
                }

            }

            Console.WriteLine($"Esses são os números primos de 0 a {n}");

            for (int y = 1; y < (listaPrimos.Count +1); y++)
            {
                Console.WriteLine($"{y}° {listaPrimos[y-1]}");
            }
        }
    }
}
