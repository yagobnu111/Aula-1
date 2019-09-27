using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        { 

        }
        /// <summary>
        /// Método que converte moeda em real para um alvo especificado
        /// para converter digite os alvos : 
        /// -"EURO"
        /// -"YEN"
        /// -"BTC"
        /// -"DOLAR"
        /// </summary>
        /// <param name="minhaMoeda"> Moeda em valor real </param>
        /// <param name="moedaAlvo"> Alvo em que a moeda será convertida</param>
        public static void ConvertMoeda(string moedaAlvo, double minhaMoeda)
        {
            

            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDecimalEmEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataNumeroDecimalEmYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataNumeroDecimalEmBitcoin(minhaMoeda));
                    break;
                default:
                    Console.WriteLine("Essa moeda não foi inventada ainda fera ");
                    break;
            }
            Console.ReadKey();

        }
        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("---Sistema conversor de moedas cabuloso---");
            Console.WriteLine("Informe o valor em real a ser convertido :");

            var minhaMoeda = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("DOLAR,EURO,YEN,BTC");

            var moedaAlvo = Console.ReadLine().ToUpper();

            ConvertMoeda(moedaAlvo,minhaMoeda);

        }


        /// <summary>
        /// metodo para converter valor em real em Dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns>retorna o valor formatado em Dolar</returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private static string FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.5252).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro : ");
        }
        private static string FormataNumeroDecimalEmYen(double meuNumero)
        {
            return (meuNumero / 0.0379).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        private static string FormataNumeroDecimalEmBitcoin(double meuNumero)
        {
            return (meuNumero / 41796.93).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC : ");
        }

    }
}
