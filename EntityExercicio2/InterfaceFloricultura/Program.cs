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
            MenuFloricultura();
            Console.ReadKey();

        }
        public static void AdicionarFlor()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome da flor : ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade : ");
            int quant = int.Parse(Console.ReadLine());

            florController.AddFlores(new Flor() { Nome = nome, Quantidade = quant });
        }
        public static void ListaFlores()
        {
            Console.Clear();
            Console.WriteLine("--- Lista de flores ---");
            florController.GetFlores().ToList().ForEach(x => TemplateListagem(x.Nome, x.Quantidade));
        }
        public static void ListaFloresMaiorQuantidade()
        {
            Console.Clear();
            Console.WriteLine("--- Lista de flores ordenadas ---");
            florController.FloresOrdenadasPorQuantidade().ForEach(x => TemplateListagem(x.Nome, x.Quantidade));
        }
        public static void MostraTotalFlores()
        {
            Console.WriteLine($"Quantidade total de flores: {florController.TotalFlores()}");
        }
        public static void MenuFloricultura()
        {
            Console.WriteLine("--- Sistema Floricultura ---");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar flores");
            Console.WriteLine("2 - Adicionar Flores   ");
            int choice = Console.ReadKey().KeyChar;

            while (choice != '0')
            {
                switch (choice)
                {
                    case '1':
                        ListaFloresMaiorQuantidade();
                        MostraTotalFlores();
                        break;
                    case '2':
                        AdicionarFlor();
                        break;                
                }
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
