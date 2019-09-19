using CadastroCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarros
{
    class Program
    {
        public static List<Carro> listaCarros = new List<Carro>();

        static void Main(string[] args)
        {

            MenuCarro();
        }
        public static void InformaCarro()
        {
            var choice = '1';
            
            while (choice == '1')
            {
                Console.Clear();
                Console.WriteLine("----------------- Cadastro de carros -------------------");
                Console.Write("Marca : ");
                string marca = Console.ReadLine();
                Console.Write("Modelo : ");
                string modelo = Console.ReadLine();
                Console.Write("Ano : ");
                int ano = int.Parse(Console.ReadLine());
                Console.Write("Valor : ");
                double valor = double.Parse(Console.ReadLine());

                listaCarros.Add(new Carro

                {
                    Marca = marca,
                    Modelo = modelo,
                    Ano = ano,
                    Valor = valor
                });
                Console.Clear();
                Console.WriteLine("Cadastro finalizado! Gostaria de continuar? (1) sim (2)voltar menu");
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        break;
                    case '2':
                        MenuCarro();
                        break;
                }

            }

        }
        public static void MostraInformacao()
        {
            Console.Clear();
            Console.WriteLine("-------------------Carros Cadastrados ---------------------");
            listaCarros.ForEach(i => Console.WriteLine($"Marca : {i.Marca} Modelo : {i.Modelo} Ano : {i.Ano} Valor : {i.Valor.ToString("C")}"));
            Console.ReadKey();
            MenuCarro();
        }

        public static void MenuCarro()

        {
            Console.Clear();
            Console.WriteLine("------------- Menu de sistema de carros --------------");
            Console.WriteLine("O que gostaria de fazer? (1) Cadastro carros (2) Mostrar carros cadastrados ");
            var choiceMenu = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (choiceMenu)
            {
                case '1':
                    InformaCarro();
                    break;
                case '2':
                    MostraInformacao();
                    break;
            }

        }

    }
}
