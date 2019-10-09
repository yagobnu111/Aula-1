using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Controller;
using CatalogoCelulares.Model;

namespace CellDu
{
    
    class Program
    {
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {

            MenuCellDu();
        }
        //inserir
        public static void InserirCelular()
        {
            Console.WriteLine("-- Inserir Celular --");
            Console.WriteLine("Informe a marca do celular");
            var marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo do celular");
            var modelo = Console.ReadLine();
            Console.WriteLine("Informe o preço do celular");
            double preco = double.Parse( Console.ReadLine());


            celulares.AddCelular(new Celular() { Marca = marca, Modelo = modelo, Preco = preco });
        }

        //atualizar
        public static void AttCelular()
        {
            Console.WriteLine("-- Atualizar Celular --");
            Console.WriteLine("Informe o Id do celular a atualizar");
            int idAtt = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a marca do celular atualizado ");
            var marcaAtt = Console.ReadLine();
            Console.WriteLine("Informe o modelo do celular atualizado");
            var modeloAtt = Console.ReadLine();
            Console.WriteLine("Informe o preço do celular atualizado");
            double precoAtt = double.Parse(Console.ReadLine());

            var celular = celulares.GetCelulares()
                .SingleOrDefault(x => x.Id == idAtt);

            celular.Marca = marcaAtt;

            celulares.AtualizarCelular(celular);
        }
        //remover
        public static void RemoveCelular()
        {
            Console.WriteLine("-- Remover Celular --");
            Console.WriteLine("Digite o Id do celular a ser removido");
            int idRemove = int.Parse(Console.ReadLine());
            celulares.RemoveCelular(idRemove);

        }
        //listar
        public static void MostraCelular()
        {
            Console.WriteLine("-- Listagem de celulares --");
            celulares.GetCelulares().ToList().ForEach(x => Console.WriteLine($"Id: {x.Id}   Marca: {x.Marca}   Modelo: {x.Modelo}   Preço: {x.Preco}"));
        }
        public static void MenuCellDu()
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir celular");
                Console.WriteLine("2 - Atualizar celular");
                Console.WriteLine("3 - Remover celular");
                Console.WriteLine("4 - Lista celulares");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    case 2:
                        AttCelular();
                        break;
                    case 3:
                        RemoveCelular();
                        break;
                    case 4:
                        MostraCelular();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
                Console.ReadKey(true);

            }
        }
    }
}
