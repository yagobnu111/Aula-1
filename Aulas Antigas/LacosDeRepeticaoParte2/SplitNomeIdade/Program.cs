using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitNomeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = BaseDeInformacoes().Split(';');
            ListaMaiores(pessoas);
            ListaMenores(pessoas);
            

            Console.ReadKey();
        }
        private static string BaseDeInformacoes()
        {
            return @"nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45;nome:Gabriel,idade:16;nome:Beatriz,idade:14";
        }
        /// <summary>
        /// Lista as pessoas maiores de idade na base de dados
        /// </summary>
        /// <param name="pessoas"></param>
        private static void ListaMaiores(string[] pessoas)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Maiores de idade ");
            Console.WriteLine("----------------");

            foreach (var item in pessoas)
            {
                var splitPessoa = item.Split(',');

                var nomePessoa = splitPessoa[0].Split(':')[1];
                var idadePessoa = Int32.Parse(splitPessoa[1].Split(':')[1]);

                if (idadePessoa >= 18)
                    Console.WriteLine($"{nomePessoa} : {idadePessoa} anos ");
            }
        }
        /// <summary>
        /// Lista as pessoas menores de idade na base de dados
        /// </summary>
        /// <param name="pessoas"></param>
        private static void ListaMenores (string[] pessoas)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Menores de idade");
            Console.WriteLine("----------------");
            for (int i = 0; i < pessoas.Length; i++)
            {
                var splitPessoa = pessoas[i].Split(',');

                var nomePessoa = splitPessoa[0].Split(':')[1];
                var idadePessoa = Int32.Parse(splitPessoa[1].Split(':')[1]);

                if (idadePessoa < 18)
                    Console.WriteLine($"{nomePessoa} : {idadePessoa} anos ");
            }
        }

    }
}
