using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitCarros();
        }
        private static void SplitCarros()
        {

            Console.WriteLine("Informe o nome do veículo cadastrado : ");
            FazBuscaCarro(Console.ReadLine().ToLower());

        }
        /// <summary>
        /// Método que faz a consulta das informações de um carro no banco de dados
        /// </summary>
        /// <param name="buscaCarro"></param>
        static void FazBuscaCarro(string buscaCarro)
        {
            //base de informações

            var informacoesCadaCarro = BaseDeInformacoes().Split(';');


            foreach (var item in informacoesCadaCarro)
            {
                var splitCarro = item.Split(',');

                var nomeCarro = splitCarro[0].Split(':')[1];
                var marcaCarro = splitCarro[1].Split(':')[1];
                var anoCarro = splitCarro[2].Split(':')[1];

                if (nomeCarro == buscaCarro)
                {
                    Console.WriteLine($"Marca : {marcaCarro}");
                    Console.WriteLine($"Ano : {anoCarro}");
                }

            }

            Console.ReadKey();
        }
        private static string BaseDeInformacoes()
        {
            return @"carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015".ToLower();
        }
    }
}
