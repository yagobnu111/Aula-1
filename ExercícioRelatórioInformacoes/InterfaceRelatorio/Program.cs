using RelatorioInformacoes.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRelatorio
{
    class Program
    {
        public static CarrosController carrosController = new CarrosController();
        static void Main(string[] args)
        {
            MenuRelatorios();
        }

        public static void MenuRelatorios()
        {
            Console.WriteLine("----------------------Relatórios----------------------");
            Console.WriteLine("Digite 1 - Mostrar todos os períodos  2 - Pesquisar por mês");
            char choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    MostrarRelatorio();
                    break;
                case '2':
                    MostrarRelatorioPorMes();
                    break;

            }
            Console.ReadKey();
        }
        public static void MostrarRelatorio()
        {
            carrosController.RetornaListaCarros();
            Console.ReadKey();
        }
        public static void MostrarRelatorioPorMes()
        {
            Console.Write("Informe o mês a ser pesquisado:");
            var mesInformado = Console.ReadLine();
            carrosController.RetornaListaPorMes(mesInformado).ForEach(x => Console.WriteLine(x));
        }
    }
}
