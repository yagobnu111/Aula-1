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
            /*
            int n, i, m;
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
            }*/

            primosLista();
            Console.ReadKey(); 
        }
        static void primosLista()
        {
            int n, i, m;
            List<int> listaPrimos = new List<int> { };

            for (i = 2; i <= 10; i++)
            {
                m = i / 2;

                for (n = 2; n <= m; n++)
                {

                    if (i % n == 0)
                    {
                        continue;
                    }
                    else
                    {
                        listaPrimos.Add(i);
                    }

                }
            }    
            Console.WriteLine(listaPrimos[0]);
            Console.ReadKey();
        }
    }
}
