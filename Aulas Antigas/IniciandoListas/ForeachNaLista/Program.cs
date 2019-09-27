using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDecimais();
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019,9,17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));

        }
        /// <summary>
        /// Mostra lista de string definidas
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();
            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            //expressão lambda   essa flecha não significa maior igual
            minhaLista.ForEach(i => Console.WriteLine(i));

        }
        /// <summary>
        /// Mostra lista de números inteiros convertendo para real
        /// </summary>
        private static void ListaInteiros()
        {
            List <int> minhaLista = new List<int>();

            for (int i = 1; i <= 10 ; i++)
            {
                minhaLista.Add(i);
            }

            minhaLista.ForEach(i => Console.WriteLine(i.ToString("C")));
        }
        /// <summary>
        /// minha lista de numeros decimais
        /// </summary>
        private static void ListaDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(i => Console.WriteLine(i.ToString("C") + " " + FormataNumeroDecimalEmEuro(i) + " " + FormataNumeroDecimalEmDolar(i) + " " 
             + FormataNumeroDecimalEmYen(i) + " " + FormataNumeroDecimalEmBitcoin(i)));
        }
       
        /// <summary>
        /// metodo que converte real em Euro
        /// </summary>
        /// <param name="meuNumero">Meu numero em real</param>
        /// <returns>Retorna meu numero formatado em euro</returns>
        private static string FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.5252).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro : ");
        }
         /// <summary>
        /// metodo para converter valor em real em Dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns>retorna o valor formatado em Dolar</returns>
        private static string FormataNumeroDecimalEmDolar (double meuNumero)
        {
            return (meuNumero/4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }/// <summary>
        /// converte real em Yen
        /// </summary>
        /// <param name="meuNumero">meu numero em real</param>
        /// <returns>retorna meu numero formatado em yen</returns>
        private static string FormataNumeroDecimalEmYen (double meuNumero)
        {
            return (meuNumero / 0.0379).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// Converte real em Bitcoin
        /// </summary>
        /// <param name="meuNumero">numero em real</param>
        /// <returns>Retorna meu numero em Bitcoin</returns>
        private static string FormataNumeroDecimalEmBitcoin (double meuNumero)
        {
            return (meuNumero / 41796.93).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC : ");
        }
    }
}
