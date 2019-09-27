using CadastroPessoaListagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoaListagem
{
    class Program
    {
        public static List<Pessoa> listaPessoas = new List<Pessoa>();

        static void Main(string[] args)
        {
            MenuPessoas();
        }

        public static void DigitaInformacoes()
        {
            Console.Clear();

            var repeater = '1';

            while (repeater == '1')
            {
                //monto uma variavel para guardar as informaçoes da lista com os mesmos parametros
                var objetoPessoa = new Pessoa();

                Console.Write("Nome: ");
                objetoPessoa.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                objetoPessoa.Idade = int.Parse(Console.ReadLine());
                Console.Write("Sexo: ");
                objetoPessoa.Sexo = Console.ReadKey().KeyChar;
                Console.Write("\nAltura: ");
                objetoPessoa.Altura = double.Parse(Console.ReadLine());

                //adiciono essa variavel montada à lista
                listaPessoas.Add(objetoPessoa);

                Console.WriteLine("Quer adicionar mais informações ? digite (1) sim ou qualquer outra para não  ");
                repeater = Console.ReadKey().KeyChar;
                Console.Clear();

            }
            MostraListaPessoas();

        }

        public static void MostraListaPessoas()
        {
            Console.Clear();
            listaPessoas.ForEach(i => Console.WriteLine($"Nome : {i.Nome} Idade : {i.Idade}  Sexo : {i.Sexo} Altura : {i.Altura}"));
            Console.ReadKey();
            MenuPessoas();

        }

        public static void MenuPessoas()
        {
            Console.Clear();
            Console.WriteLine("------------------Menu de cadastro de pessoas ---------------------");
            Console.WriteLine("Digite (1) para cadastrar e (2) para listar pessoas ");
            var choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    DigitaInformacoes();
                    break;
                case '2':
                    MostraListaPessoas();
                    break;
                default:
                    MenuPessoas();
                    break;
            }

        } 
    }
}
