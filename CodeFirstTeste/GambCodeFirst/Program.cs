using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Controller;
using CodeFirstTeste.Model;

namespace GambCodeFirst
{
    class Program
    {
        public static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {

            try
            {
                cerveja.AddCerveja(new Cerveja() { Nome = "Stella"});
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();

        }
    }
}
