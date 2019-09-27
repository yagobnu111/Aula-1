using CadastroPessoaListagemV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoaListagemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Sexo = 'M';
            p1.Altura = 2.01;
            p1.Idade = 29;

            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p1.Nome = "Elóra";
            p1.Sexo = 'F';
            p1.Altura = 1.53;
            p1.Idade = 21;

            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "João";
            p3.Sexo = 'M';
            p3.Altura = 1.70;
            p3.Idade = 17;

            pessoas.Add(p2);

            List<Pessoa> menoresIdade = new List<Pessoa>();
            List<Pessoa> pessoasOrdenadasPorAltura = pessoas.OrderByDescending(p => p.Altura).ThenBy(c => c.Idade).ToList();

            foreach (Pessoa p in pessoas)
            {
                if (p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }
            }
            //expressão lambda

            pessoas.Where(pes => pes.Idade < 18);


        }
        public static void MostraListaPessoas(List<Pessoa> listaPessoas)
        {
            listaPessoas.ForEach(i => Console.WriteLine($"Nome : {i.Nome} Idade : {i.Idade} Sexo : {i.Sexo} Altura : {i.Altura}"));
            Console.ReadKey();
        }

        public static  List<Pessoa> RecebeDados()
        {
            var listaPessoas = new List<Pessoa>();
            var repeater = 's';

            while (repeater == 's')
            {
                Console.WriteLine("Digite o nome a ser cadastrado : ");
                string nome = Console.ReadLine();
                Console.WriteLine($"Digite a idade de {nome} : ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine($"Masculino (m) ou Feminino (f)");
                char sexo = Console.ReadKey().KeyChar;
                Console.WriteLine("\nAltura :  ");
                double altura = double.Parse(Console.ReadLine());

                listaPessoas.Add(new Pessoa()
                {
                    Nome = nome,
                    Idade = idade,
                    Sexo = sexo,
                    Altura = altura
                });
                Console.Clear();
                Console.WriteLine("Gostaria de continuar ? (s) para sim e qualquer outra tecla para sair");
                repeater = Console.ReadKey().KeyChar;
                Console.Clear();
            }
            return listaPessoas;
        }
    }   
}
