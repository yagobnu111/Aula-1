using BicicletasLibrary.Controller;
using BicicletasLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biken
{
    class Program
    {
        public static BicicletaController bicicletaController = new BicicletaController();
        static void Main(string[] args)
        {
            MenuSistema();
        }
        public static void MenuSistema()
        {
            var choice = int.MinValue;
            while (choice != '0')
            {
                Console.Clear();
                Console.WriteLine("--- Sistema Bicicletas ---");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Listar Bikes");
                Console.WriteLine("2 - Adicionar Bikes");
                Console.WriteLine("3 - Atualizar Bike");
                Console.WriteLine("4 - Deletar Bike");
                Console.WriteLine("5 - Mostrar valor total");
                Console.WriteLine("6 - Listar e Exportar");

                choice = Console.ReadKey(true).KeyChar;
                    switch (choice )
                    {
                    case '1':
                        Console.Clear();
                        ListarBikesPorValor();
                        break;
                    case '2':
                        Console.Clear();
                        ListarBikes();
                        AddBikes();
                        break;
                    case '3':
                        Console.Clear();
                        ListarBikes();
                        AtualizarBike();
                        break;
                    case '4':
                        Console.Clear();
                        DeletarBike();
                        break;
                    case '5':
                        MostraValorTotal();
                        break;
                    case '6':
                        ListarBikesPorValor();
                        ExportarInformacoes();
                        break;
                    default:
                        Console.WriteLine("Não entendi! ");
                        break;
                }
                    Console.WriteLine("(0) sair (Qualquer outra tecla) Voltar Menu");
                    choice = Console.ReadKey(true).KeyChar;

            }
            
        }
        public static void ListarBikes()
        {
            bicicletaController.GetBicicletas().ToList().ForEach(x => TemplateListagem(x.Id, x.Marca, x.Modelo, x.Valor));
        }
        public static void ListarBikesPorValor()
        {
            bicicletaController.GetBicicletasMaiorValor().ToList().ForEach(x => TemplateListagem(x.Id, x.Marca, x.Modelo, x.Valor));  
        }
        public static void MostraValorTotal()
        {
            Console.WriteLine($"Valor total: {bicicletaController.ValorTotalBicicletas()}");
        }
        public static void AddBikes()
        {
            Console.WriteLine("Digite a Marca da bicicleta: ");
            var marca = Console.ReadLine();
            Console.WriteLine("Digite o Modelo da bicicleta: ");
            var modelo = Console.ReadLine();
            Console.WriteLine("Digite o Valor da bicicleta: ");
            var valor = double.Parse(Console.ReadLine());
            if (valor <= 0)
                return;

            bicicletaController.AddBicicleta(new Bicicleta() { Marca = marca, Modelo = modelo, Valor = valor });
        }
        public static void AtualizarBike()
        {
            Console.WriteLine("Digite o Id da bicicleta a ser alterada : ");
            var idAtt = int.Parse(Console.ReadLine());
            var bicicleta = bicicletaController.GetBicicletas().SingleOrDefault(x => x.Id == idAtt);
            if (bicicleta == null)
            {
                Console.WriteLine("Id informado inválido!");
                return;
            }

            Console.WriteLine("Digite a Marca da bicicleta: ");
            var marcaAtt = Console.ReadLine();
            Console.WriteLine("Digite o Modelo da bicicleta: ");
            var modeloAtt = Console.ReadLine();
            Console.WriteLine("Digite o Valor da bicicleta: ");
            var valorAtt = double.Parse(Console.ReadLine());
            if (valorAtt <= 0)
                return;

            bicicleta.Marca = marcaAtt;
            bicicleta.Modelo = modeloAtt;
            bicicleta.Valor = valorAtt;

            bicicletaController.AlterarBicicleta(bicicleta);


        }
        public static void DeletarBike()
        {
            Console.WriteLine("Digite o Id da bike a ser deletada: ");
            int idDelete = int.Parse(Console.ReadLine());
            Console.WriteLine("Tem certeza que gostaria de deletar ? (1) Sim  (Qualquer outra tecla) Não");
            var choice = Console.ReadKey().KeyChar;
            if (choice != '1')
                return;

            bicicletaController.DeletarBicicleta(idDelete);

        }
        public static void TemplateListagem(int id, string marca, string modelo, double valor)
        {
            Console.WriteLine($"Id: {id} Marca : {marca}    Modelo: {modelo}    Valor:{valor}");
        }
        public static void ExportarInformacoes()
        {
            Console.WriteLine("Exportando as informações...");
            bicicletaController.ExportarInformacoes();
        }
    }
}
