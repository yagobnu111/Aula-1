using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Gabriel",
                "Irineu",
                "Anastácio",
                "Florisbela",
                "Xumineu",
                "Clebson"
            };

            var texto = listaDeNomes.Aggregate((nomeAtual, nomeProximo) => nomeAtual + ";" + nomeProximo);

            Console.WriteLine(texto);

            Console.ReadKey();

        }
    }
}
