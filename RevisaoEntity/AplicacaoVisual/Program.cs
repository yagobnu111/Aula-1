using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;
using System.Data.Entity;
using RevisandoEntity.Controller;

namespace AplicacaoVisual
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            NewCerveja();
           

            Console.ReadKey();
        }
        static void NewCerveja()
        {
            Console.WriteLine("Digite o nome da cerveja a adicionar");
            var cervejaNome = Console.ReadLine();

            cervejaController.AddCerveja(new Cerveja() { Nome = cervejaNome });
        }
        static void ListaCerveja()
        {
            cervejaController.GetCervejas()
                .ToList<Cerveja>()
                .ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
