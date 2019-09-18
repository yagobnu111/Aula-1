using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();


        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu : ");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostrar árvore");
            Console.WriteLine("3 - Listar cervejas e adicionar");
            Console.WriteLine("4 - Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());
            switch (menuEscolhido)
            {
                case 1:
                    CalculosDeArea.CalculaArea();
                    Console.ReadKey();
                    Console.Clear();
                    MenuSistema();
                    break;
                case 2:
                    ArvoreEstatica.ArvoreMostra();
                    Console.ReadKey();
                    Console.Clear();
                    MenuSistema();
                    break;
                case 3:
                    ListaDeCervejas.ListaCervejas()
                        ;
                    Console.ReadKey();
                    Console.Clear();
                    MenuSistema();
                    break;
                case 4:
                    Console.WriteLine("Saindo.");
                    return;
                default:
                    break;
            }

            Console.ReadKey();
                
        }
    }
}
