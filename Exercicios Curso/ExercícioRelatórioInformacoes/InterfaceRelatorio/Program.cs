using RelatorioInformacoes.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceRelatorio
{
    class Program
    {
        public static VendaController carrosController = new VendaController();
        static void Main(string[] args)
        {
            MenuRelatorios();
        }

        public static void MenuRelatorios()
        {
            char choice = '0';

            while (choice != '4')
            {
                Console.Clear();
                Console.WriteLine("---------------Sistema de relatório de vendas------------------------------------------");
                Console.WriteLine("\nDigite 1 - Mostrar todos os períodos  2 - Pesquisar por mês 3 - Adicionar Relatorio 4 - Sair");
                choice = Console.ReadKey(true).KeyChar;
                switch (choice)
                {
                    case '1':
                        FaixaDivisora("Relatório Total");
                        carrosController.MostraInformacoesTodosMeses();
                        break;
                    case '2':
                        EscolheMes();
                        break;
                    case '3':
                        AdicionaRelatorioVendas();
                        break;
                    case '4':
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Não entendi! Tente de novo!");
                        break;
                }
                Console.ReadKey(true);
            }
        }
        public static void AdicionaRelatorioVendas()
        {
            Console.WriteLine("Essa função ainda não foi adicionada!");
        }
        public static void EscolheMes()
        {
            Console.Write("Informe o mês a ser pesquisado:");
            int mesInformado = int.Parse(Console.ReadLine());
            switch (mesInformado)
            {
                case 1:
                    FaixaDivisora("Janeiro");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 2:
                    FaixaDivisora("Fevereiro");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 3:
                    FaixaDivisora("Março");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 4:
                    FaixaDivisora("Abril");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 5:
                    FaixaDivisora("Maio");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 6:
                    FaixaDivisora("Junho");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 7:
                    FaixaDivisora("Julho");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 8:
                    FaixaDivisora("Agosto");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 9:
                    FaixaDivisora("Setembro");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 10:
                    FaixaDivisora("Outubro");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 11:
                    FaixaDivisora("Novembro");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                case 12:
                    FaixaDivisora("Dezembro");
                    carrosController.MostraRelatorioPorMes(mesInformado);
                    break;
                default:
                    Console.WriteLine("Não entendi.");
                    break;
            }
            Console.WriteLine("\n--------------Informação do mês----------------------------------------------");
            carrosController.MostraInformacoesDoMes(mesInformado);

        }
        public static void FaixaDivisora(string informacao)
        {
            Console.Clear();
            Console.WriteLine("==============={0,4}====================================================\n", informacao);
        }
      
    }
}
