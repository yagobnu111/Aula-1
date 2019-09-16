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
            PrimosFor();
            Console.ReadKey();
        }

        static void PrimosFor()
        {
            var n = 0;
            var divisor = 0;
            var x = 2;

            List<string> listaPrimos = new List<string> { };


            Console.WriteLine("Até que número checar por números primos ? ");
            n = (Convert.ToInt32(Console.ReadLine()));
            DateTime agora = DateTime.Now;

            for (int i = 2; i <= n; i++)
            {
                divisor = i / 2;
                var flag = 0;

                for (; x <= divisor; x++)
                {

                    if (i % x == 0)
                        flag = 1;
                    else
                        continue;

                }   
                if (flag == 0) 
                {
                    listaPrimos.Add(i.ToString());
                }

            }

            Console.WriteLine($"Esses são os números primos de 0 a {n}");

            for (int y = 1; y < (listaPrimos.Count +1); y++)
            {
                Console.WriteLine($"{y}° {listaPrimos[y-1]}");
            }

            Console.WriteLine(agora - DateTime.Now);
        }
        static void PrimosWhile()
        {
            var n = 0;
            var divisor = 0;
            var x = 3;
            var i = 3;

            List<string> listaPrimos = new List<string> { };

            Console.WriteLine("Até que número checar por números primos ? ");
            n = (Convert.ToInt32(Console.ReadLine()));

            DateTime agora = DateTime.Now;

            while( i <= n )
            {
                divisor = i / 2;
                var naoPrimo = false;
           


               while(x <= divisor)
                {
                    if (i % x == 0)
                    {
                        naoPrimo = true;
                    }
                    x++;

                }
                if (naoPrimo == false)
                {
                    listaPrimos.Add(i.ToString());
                }

                i++;

            }

            Console.WriteLine($"Esses são os números primos de 0 a {n}");

            for (int y = 1; y < (listaPrimos.Count +1); y++)
            {
                Console.WriteLine($"{y}° {listaPrimos[y-1]}");
            }

    
        }
    }
}
