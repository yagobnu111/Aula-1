using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoList
{
    class Program
    {
        //não preciso passar a lista como parâmetro pois a lista pode ser acessada por qualquer método
        static List<string> minhaListaPulgmatica = new List<string>
            {
                "Gabriel",
                "Irineu",
                "Serilop"
            };
        static void Main(string[] args)

        {
            
            AdicionarItensALista();
            ListaInformacoes();

            Console.ReadKey();
        }
        /// <summary>
        /// Método que adiciona um item à lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome : ");
            var nomeAdicionado = (Console.ReadLine());
            minhaListaPulgmatica.Add(nomeAdicionado);
            Console.Clear();
            Console.WriteLine($"{nomeAdicionado} foi adicionado à lista");

            Console.WriteLine("Deseja informar mais valores? sim(s) qualquer outra tecla para não");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();//função recursiva, chamo minha função dentro dela mesma (perigoso), não preciso de while
        }

        /// <summary>
        /// Método que mostra a lista
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados à lista : ");
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine(item);
        }
    }
}
