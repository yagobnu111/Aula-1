using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListaDeCervejas
    {

        public static void ListaCervejas()
        {

            var listaCervejas = new List<string>
            {
                "Budweiser",
                "Original",
                "Corona",
                "Brahma ",
                "Stella"
            };

            listaCervejas.ForEach(item => Console.WriteLine(item));

                Console.WriteLine(" Gostaria de adicionar mais cervejas ? Aperte S (sim) e qualquer outra tecla para (não) ");
                var resposta = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (resposta)
                {
                    case "S":
                        AdicionarCervejas(listaCervejas).ForEach(item => Console.WriteLine(item));
                        break;
                    default:
                        Console.WriteLine("Beba com moderação!");
                        break;

                Console.ReadKey();
            }
        }
        /// <summary>
        /// Método que adiciona cervejas à lista
        /// </summary>
        /// <param name="bancoCervejas"></param>
        /// <returns></returns>
        public static List<string> AdicionarCervejas(List<string> bancoCervejas)
        {
            Console.WriteLine("Digite uma cerveja para adicionar à lista : ");
            bancoCervejas.Add(Console.ReadLine());

            return bancoCervejas;
        }


    }
}
