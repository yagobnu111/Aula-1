using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitCarros();
        }

        /// <summary>
        /// Metodo que mostra como podemos utilizar foreach para andar sobre
        /// um array de caracteres, ou seja, um texto, palavra, etc...
        /// </summary>
        private static void IniciandoForeach()
        {
            Console.WriteLine("Informar o texto :");
            var conteudoDoTexto = Console.ReadLine();
            DateTime now = DateTime.Now;

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;

                Console.WriteLine(item);
            }

            Console.WriteLine(now - DateTime.Now);
            Console.ReadKey();
        }
        
        /// <summary>
        /// Metodo de busca com split e informando o nome
        /// </summary>
        private static void ForeachComSplit()
        {
            var conteudoDoTexto = "Aqui vou colocar meu nome Gabriel para realizar a busca";

            Console.WriteLine("Informa a palavra para realizar a busca : ");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');

            foreach ( var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada !");
            }

            Console.ReadKey();
        }
       
        /// <summary>
        /// Exercicio usando split para procurar uma palavra e substituir uma palavra por outra
        /// </summary>
        private static void ForeachExercicio1()
        {
            Console.WriteLine("Informe seu nome : ");

            var texto = $@"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção
e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";
            var textoComSplit = texto.Split(';');
            Console.WriteLine("Digite a palavra a procurar : ");
            var palavra = Console.ReadLine();
            var palavraEncontrada = false;


            foreach (var item in textoComSplit)
            {
                if (palavra == item)
                {
                    Console.WriteLine("Palavra encontrada com sucesso! ");
                    palavraEncontrada = true;           
                }     
                   
            }
            if (!palavraEncontrada)
                Console.WriteLine("Nenhuma palavra encontrada =( ");

            texto.Replace("Gabriel", "Xuxu");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para separar e acessar informações com split
        /// </summary>
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Gabriel,idade:27;nome:Breno,idade:35;nome:Xuxu,idade:18";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema : ");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe um nome do sistema : ");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade");
                }
            }

            Console.ReadKey();
        }

        private static void SplitCarros ()
        {
           
            Console.WriteLine("Informe o nome do veículo cadastrado : ");
            FazBuscaCarro( Console.ReadLine());

        }
        /// <summary>
        /// Método que faz a consulta das informações de um carro no banco de dados
        /// </summary>
        /// <param name="buscaCarro"></param>
        static void FazBuscaCarro (string buscaCarro)
        {
            //base de informações

            var informacoesCadaCarro = BaseDeInformacoes().Split(';');


            foreach (var item in informacoesCadaCarro)
            {
                var splitCarro = item.Split(',');

                var nomeCarro = splitCarro[0].Split(':')[1];
                var marcaCarro = splitCarro[1].Split(':')[1];
                var anoCarro = splitCarro[2].Split(':')[1];

                if (nomeCarro == buscaCarro)
                {
                    Console.WriteLine($"Marca : {marcaCarro}");
                    Console.WriteLine($"Ano : {anoCarro}");
                }

            }

            Console.ReadKey();
        }
        private static string BaseDeInformacoes ()
        {
            return @"carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
        }
    }
}
