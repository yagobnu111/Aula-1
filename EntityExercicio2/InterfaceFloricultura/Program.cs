using FloresLibrary.Model;
using FloresLibrary.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFloricultura
{
    public class Program
    {
        public static FlorController florController = new FlorController();
        static void Main(string[] args)
        {
            ListaFloresMaiorQuantidade();
            MostraTotalFlores();
            Console.ReadKey();

        }
        public static void AdicionarFlor()
        {
            Console.WriteLine("Digite o nome da flor : ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade : ");
            int quant = int.Parse(Console.ReadLine());

            florController.AddFlores(new Flor() { Nome = nome, Quantidade = quant });
        }
        public static void ListaFlores()
        {
            Console.WriteLine("--- Lista de flores ---");
            florController.GetFlores().ToList().ForEach(x => TemplateListagem(x.Nome, x.Quantidade));
        }
        public static void ListaFloresMaiorQuantidade()
        {
            Console.WriteLine("--- Lista de flores ordenadas ---");
            var floresOrdenadas = florController.GetFlores().ToList().OrderByDescending(x => x.Quantidade);
            floresOrdenadas.ToList().ForEach(x => TemplateListagem(x.Nome, x.Quantidade));
        }
        public static void MostraTotalFlores()
        {
            var somaFlores = florController.GetFlores().Sum(x => x.Quantidade);
            Console.WriteLine($"Quantidade total de flores {somaFlores}");
        }
        public static void MenuFloricultura()
        {
            Console.WriteLine("--- Sistema Floricultura ---");
            var choice = '1';

            while (choice != '0')
            {
                AdicionarFlor();
                Console.WriteLine("(0) sair (Qualquer outra tecla) continuar");
                choice = Console.ReadKey().KeyChar;
            }
        }
        public static void TemplateListagem(string nome, int quant)
        {
            Console.WriteLine($"Nome: {nome}, Quantidade: {quant}");
        }

    }
}
