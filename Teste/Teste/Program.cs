using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (true)
            {
                ExpBar1();
                Thread.Sleep(200);
                ExpBar2();
                Thread.Sleep(200);
                ExpBar3();
                Thread.Sleep(200);
                ExpBar4();
                Thread.Sleep(200);
                ExpBar5();
                Thread.Sleep(200);
                ExpBar6();
                Thread.Sleep(200);
                ExpBar7();
                Thread.Sleep(200);
                ExpBar8();
                Thread.Sleep(200);
                ExpBar9();
                Thread.Sleep(200);
                ExpBar10();
                Thread.Sleep(200);
                ExpBar11();
                Thread.Sleep(350);
                Console.WriteLine($"Congratulations! You are now level {x}");
                Console.ReadKey(true);
                ++x;
            }
        }
        public static void ExpBar1()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |                                   |");
            Console.WriteLine(" |                                   |");
            Console.WriteLine(" |                                   |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar2()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |///                                |");
            Console.WriteLine(" |///                                |");
            Console.WriteLine(" |///                                |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar3()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |//////                             |");
            Console.WriteLine(" |//////                             |");
            Console.WriteLine(" |//////                             |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar4()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |/////////                          |");
            Console.WriteLine(" |/////////                          |");
            Console.WriteLine(" |/////////                          |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar5()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |////////////                       |");
            Console.WriteLine(" |////////////                       |");
            Console.WriteLine(" |////////////                       |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar6()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |/////////////////                  |");
            Console.WriteLine(" |/////////////////                  |");
            Console.WriteLine(" |/////////////////                  |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar7()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |/////////////////////              |");
            Console.WriteLine(" |/////////////////////              |");
            Console.WriteLine(" |/////////////////////              |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar8()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |/////////////////////////          |");
            Console.WriteLine(" |/////////////////////////          |");
            Console.WriteLine(" |/////////////////////////          |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar9()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |/////////////////////////////      |");
            Console.WriteLine(" |/////////////////////////////      |");
            Console.WriteLine(" |/////////////////////////////      |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar10()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |/////////////////////////////////  |");
            Console.WriteLine(" |/////////////////////////////////  |");
            Console.WriteLine(" |/////////////////////////////////  |");
            Console.WriteLine(" -------------------------------------");
        }
        public static void ExpBar11()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________");
            Console.WriteLine(" |///////////////////////////////////|");
            Console.WriteLine(" |///////////////////////////////////|");
            Console.WriteLine(" |///////////////////////////////////|");
            Console.WriteLine(" -------------------------------------");
        }
    }

}
