using ExerciciosDia19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDia19
{
    class Program
    {
        static void Main(string[] args)
        {

            var meusAmigos = new List<Amigos>();

            meusAmigos.Add(new Amigos()
            {
                Nome = "Garibaldo",
                TempoAmizade = 250
            });

            meusAmigos.Add(new Amigos()
            {
                Nome = "Fabio",
                TempoAmizade = 9
            });

            meusAmigos.Add(new Amigos()
            {
                Nome = "Douglas",
                TempoAmizade = 9000


            });

            meusAmigos.ForEach(i => Console.WriteLine($"Eu conheço {i.Nome} há {i.TempoAmizade} dias"));

            Console.ReadKey();





            /* var meusAmigos = new List<Amigos>();

            minhaCestaDeFrutas.Add(new Frutas()
            {
                Nome = "Banana",
                Quantidade = 5
            });

            minhaCestaDeFrutas.Add(new Frutas()
            {
                Nome = "Tomate",
                Quantidade = 2
            });

            minhaCestaDeFrutas.ForEach(i =>
            Console.WriteLine($"Nome: {i.Nome} Quantidade: {i.Quantidade}"));
            Console.ReadKey();*/

        }
    }
}
