using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Frames
{
    class Program
    {
        static void Main(string[] args)
        {
            MovingBall();
        }

        private static void Frame1( int vezes)
        {
            while (vezes < 10)
            {
                Console.WriteLine(" ^ ^");
                Console.WriteLine("{o o}");
                Console.WriteLine(" |W|");
                Console.Clear();
                vezes++;
            }
            

        }

        private static void Frame2(int vezes)
        {
            while (vezes < 10)
            {
                Console.WriteLine(" ^ ^");
                Console.WriteLine("{- o}");
                Console.WriteLine(" |W|");
                Console.Clear();
                vezes++;
            } 


        }

        private static void MovingBall()
        {

            string ball1 = " ";
            string ball2 = " ";
            string space1 = "";
            string space2 = "";
            string message = string.Empty;
            int winningBall = 0;

            while (ball1.Length < 100 || ball2.Length < 10022) 
            {

                ball1 = space1 + "(O)";
                ball2 = space2 + "(0)";

                Console.WriteLine($"{ball1}");
                Console.WriteLine($"{ball2}");
                Console.WriteLine("\n" + message);

                string x = Console.ReadKey().KeyChar.ToString();
                if (x == "1")
                    space1 += " ";
                else if (x == "2")
                    space2 += " ";

                Thread.Sleep(10);
                Console.Clear();

                if (ball1.Length > ball2.Length)
                {
                    message = $"Bola 1 está em primeiro lugar!";
                    winningBall = 1;
                }
                else
                {
                    message = $"Bola 2 está em primeiro lugar!";
                    winningBall = 2;
                }
            } 

            //WinnerMessage(winningBall);
        }
        private static void WinnerMessage(int winningBall)
        {
            if (winningBall == 2)
                Console.WriteLine("Bola 2 venceu!!");
            else if (winningBall == 1)
                Console.WriteLine("Bola 1 venceu!!");

            Console.ReadLine();
        }

    }
}
