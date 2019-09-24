using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrandoListasExercicio
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Carregando a lista com as informações
            var listaPessoas= new List<Pessoa>();
            var inf = @"1,Spears,07/11/2004,846.96;
2,Swanson,20/06/2003,233.09;
3,Gay,03/12/2001,911.92;
4,Gregory,02/01/2000,469.01;
5,Olson,18/07/2001,261.90;
6,Garza,01/04/2000,360.41;
7,Sweet,12/03/2003,312.76;
8,Cline,26/03/2002,484.51;
9,Oliver,05/07/2004,513.76;
10,Vang,10/07/2000,271.05;
11,Maddox,29/05/2004,783.97;
12,Garrett,03/06/2006,154.11;
13,Mcintosh,06/07/2006,902.80;
14,Yang,29/04/2005,550.48;
15,Hendricks,05/09/2003,410.56;
16,Cain,12/01/2002,221.13;
17,Blackburn,10/05/2000,135.67;
18,Howe,27/09/2005,360.14;
19,Pratt,18/09/2000,991.83;
20,Sherman,20/02/2003,667.00";
;

            var pessoaSplitter = inf.Split(';');
            var id = 0;
            var nome = "";
            DateTime data ;
            double carteira = 0;

            for (int i = 0; i < 20; i++)
            {
                id = int.Parse(pessoaSplitter[i].Split(',')[0]);
                nome = pessoaSplitter[i].Split(',')[1];
                data = DateTime.Parse(pessoaSplitter[i].Split(',')[2]);
                carteira = Double.Parse(pessoaSplitter[i].Split(',')[3].Replace('.', ','));

                listaPessoas.Add(new Pessoa(id, nome, data, carteira));
                /*listaPessoas.Add(new Pessoa()
                {
                    Id = id,
                    Nome = nome,
                    DataNascimento = data,
                    Carteira = carteira
                });*/



            }
            #endregion

            MostraListaPorId(listaPessoas);
            MostraListaCrescentePorNome(listaPessoas);
            MostraListaDecrescentePorData(listaPessoas);
            MostraListaPorCarteiraMaiorQue(listaPessoas);
            MostraListaPorMaioresQue(listaPessoas, 16);
            MostraListaPorMenoresQue(listaPessoas, 12);

            Console.ReadKey(true);
 
        }
        /// <summary>
        /// Método que define um template para a impressão de informações passadas
        /// </summary>
        /// <param name="pessoa">Recebe informações da pessoa informada</param>
        public static void ImprimeInformacao(Pessoa pessoa)
        {
            string template = "ID {0,3} Nome {1,10} Nascimento {2,10} Carteira {3,5} ";

            string textoFormatado = string.Format(template, pessoa.Id, pessoa.Nome, pessoa.DataNascimento.ToShortDateString(), pessoa.Carteira.ToString("C"));

            Console.WriteLine(textoFormatado);
        }
        /// <summary>
        /// Método que retorna a lista de acordo com a ID em ordem ascendente
        /// </summary>
        /// <param name="listaPessoas">Recebe a lista de pessoas criada</param>
        public static void MostraListaPorId(List <Pessoa> listaPessoas)
        {
            MostraIdentificador("Lista por ID");
            listaPessoas.ForEach(i => ImprimeInformacao(i));
        }
        /// <summary>
        /// Método que retorna a lista em ordem alfabética por nome
        /// </summary>
        /// <param name="listaPessoas">Recebe a lista de pessoas criada</param>
        private static void MostraListaCrescentePorNome(List<Pessoa> listaPessoas)
        {
            MostraIdentificador("Lista por ordem alfabética");
            listaPessoas.OrderBy(x => x.Nome).ToList().ForEach(i => ImprimeInformacao(i));
        }
        /// <summary>
        /// Método que retorna a lista pela data em ordem decrescente
        /// </summary>
        /// <param name="listaPessoas">recebe a lista informada</param>
        private static void MostraListaDecrescentePorData(List<Pessoa> listaPessoas)
        {
            MostraIdentificador("Lista Data Decrescente");
            //ordenando pelo nome e convertendo em uma lista
            //listando essa lista ordenada
            listaPessoas.OrderByDescending(x => x.DataNascimento).ToList().ForEach(i => ImprimeInformacao(i));
        }
        /// <summary>
        /// Método que retorna a lista pela quantidade de dinheiro na carteira informado ou default
        /// </summary>
        /// <param name="listaPessoas">Lista Informada</param>
        /// <param name="valor">O valor default é 500</param>
        private static void MostraListaPorCarteiraMaiorQue(List<Pessoa> listaPessoas, double valor = 500)
        {
            MostraIdentificador("Lista de Ricos");
            listaPessoas.FindAll(x => x.Carteira > valor).ToList().ForEach(i => ImprimeInformacao(i));
        }
        /// <summary>
        /// Método que retorna a lista por maiores que idade definida ou default 
        /// </summary>
        /// <param name="idade">Idade default = 18 </param>
        /// <param name="listaPessoas">Lista Informada</param>
        private static void MostraListaPorMaioresQue(List<Pessoa> listaPessoas, int idade = 18)
        {
            MostraIdentificador($"Lista maiores que {idade}");
            listaPessoas.FindAll(x => DateTime.Now.Year - x.DataNascimento.Year >= idade).ToList().ForEach(i => ImprimeInformacao(i));
        }
        /// <summary>
        /// Método que retorna a lista por menores que uma idade definida ou default 
        /// </summary>
        /// <param name="idade">Idade default = 16</param>
        /// <param name="listaPessoas"></param>
        private static void MostraListaPorMenoresQue(List<Pessoa> listaPessoas, int idade = 16)
        {
            MostraIdentificador($"Lista Menores que {idade}");
            listaPessoas.FindAll(x => DateTime.Now.Year - x.DataNascimento.Year <= idade).ToList().ForEach(i => ImprimeInformacao(i));

        }
        /// <summary>
        /// Define um template para o identificador de cada filtro
        /// </summary>
        /// <param name="msg">Recebe uma string que identifica o filtro</param>
        private static void MostraIdentificador(string msg)
        {
            Console.WriteLine("\n------------------------{0,10}-------------------------\n", msg);
        } 
    }
}
