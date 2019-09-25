using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }
        /// <summary>
        /// Método que mostra números inteiros por um tipo primitivo
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos [] em um tipo "primitivo" podemos criar uma coleção desses valores
            int[] colecaoInteiros =
                //alocamos memória para nossa coleção de valores e informamos a quantidade de memória que vamos utilizar
                new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(colecaoInteiros.Sum());

        }

        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                1,2,3,4,5
            };

            Console.WriteLine( listaDeInteiros.Sum());
            
        }
        /// <summary>
        /// Método que somas as balas das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //Nossa lista de crianças foi criada e carregada em memória
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma nova criança dentro da minha lista
                new Crianca()
                {
                    Nome = "Anastácio",
                    Balas = 4
                },//virgula separamos um objeto de outro
                new Crianca()
                {
                    Nome = "Bruno",
                    Balas = 10
                }
            };

            Console.WriteLine("Quantidade total de balas das crianças");
            Console.WriteLine(criancas.Sum(x => x.Balas));

            
        }

    }
}
