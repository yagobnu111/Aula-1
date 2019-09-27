using ListagemDeCervejas.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCerveja
{
    class Program
    {
        public static CervejaController cervejaController = new CervejaController();

        static void Main(string[] args)
        {
            MenuSistemaCervejas();

            Console.ReadKey();

        }

        static void MostraListaCervejas()
        {
            Console.Clear();
            FaixaInformativa("Lista Cervejas");
            cervejaController.RetornaListaCervejas().ForEach(x => Console.WriteLine($"Id: {x.Id}    Nome:{x.Nome}   Litros:{x.Litros}    Alcool:{x.Alcool}    Valor: {x.Valor} "));
        }
        static void MostraValorTotalCervejas()
        {
            var valorTotal = cervejaController.RetornaTotalValorLista();
            Console.WriteLine($"O valor total da lista de cervejas é : {valorTotal.ToString("C")}");
        }

        static void MostraLitrosTotalCervejas()
        {
            var litrosTotal = cervejaController.RetornaTotalLitrosLista();
            Console.WriteLine($"O total de litros da lista de cervejas é : {litrosTotal}");
        }
        static void AdicionaCervejasLista()
        {
            Console.Clear();
            FaixaInformativa("Adicionando Cerveja");
            Console.WriteLine("Digite o nome da cerveja :");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite os litros da cerveja :");
            var litros = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de álcool da cerveja :");
            var alcool = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da cerveja :");
            var valor = double.Parse(Console.ReadLine());

            cervejaController.AdicionaCerveja(nome, litros, alcool, valor);
            Console.Clear();
            Console.WriteLine("Cerveja adicionada com sucesso! Aperte qualquer tecla para voltar!");
            Console.ReadKey(true);

        }
        static void MenuSistemaCervejas()
        {
            var choice = 0;

            while (choice != '4')
            {
                Console.Clear();
                FaixaInformativa("Sistema de Cervejas");
                Console.WriteLine("Digite 1 - Listar cervejas  2 - Adicionar cervejas 3 - Fazer Pedido");
                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        MostraListaCervejas();
                        FaixaInformativa("Informações adicionais");
                        MostraValorTotalCervejas();
                        MostraLitrosTotalCervejas();
                        Console.ReadKey(true);
                        break;
                    case '2':
                        AdicionaCervejasLista();
                        break;
                    case '3':
                        FazCompraCerveja();
                        break;
                }

            }
        }
        static void FazCompraCerveja()
        {
            MostraListaCervejas();
            FaixaInformativa("Compras");
            Console.WriteLine("Digite o ID da cerveja que você quer comprar : ");
            int idCompra = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas você quer : ");
            int quantCompra = int.Parse(Console.ReadLine());
            Console.WriteLine($"O valor da compra foi de : {cervejaController.RetornaValorCompra(idCompra, quantCompra)}");
            Console.ReadKey(true);

        }
        static void FaixaInformativa(string identificador)
        {
            Console.WriteLine($"-----------{identificador}-------------------------------------------------------");
        }
    }
}
