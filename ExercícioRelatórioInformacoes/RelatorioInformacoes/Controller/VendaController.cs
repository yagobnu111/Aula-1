using RelatorioInformacoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioInformacoes.Controller
{
    
    public class VendaController
    {
        // aqui eu instancio a classe RelatoriosCarrosContext(meu banco de dados) em memória
        private RelatorioCarrosContext contextDB = new RelatorioCarrosContext();

        /// <summary>
        /// Este método traz todas as vendas de todos os carros por ID sem organizar por mês
        /// </summary>
        public void MostraRelatorioTotal()
        {
            contextDB.listaDeCarros.ForEach(x => TemplateMostraInformacoes(x.Id,x.Nome,x.Valor,x.Quantidade, x.DataRelatorio));
        }
        /// <summary>
        /// Esse método retorna uma lista de vendas realizadas no mês informado
        /// </summary>
        /// <param name="mesInformado">Valor numérico correspondente ao mês buscado</param>
        /// <returns>Retorna uma lista correspondente às vendas daquele m~es, mas não imprime na tela</returns>
        public List<Venda> RetornaRelatorioPorMes(int mesInformado)
        {
            return contextDB.listaDeCarros.FindAll(x => x.DataRelatorio.Month.ToString() == mesInformado.ToString()).ToList();
        }
        /// <summary>
        /// Esse método mostra na tela todas as vendas realizadas no período, traz ID, Carro, Valor, Quantidade,Data
        /// </summary>
        /// <param name="mesInformado">Mês informado pelo usuário para a busca</param>
        public void MostraRelatorioPorMes(int mesInformado)
        {
            RetornaRelatorioPorMes(mesInformado).ForEach(x => TemplateMostraInformacoes(x.Id, x.Nome, x.Valor, x.Quantidade, x.DataRelatorio));
        }
        /// <summary>
        /// Esse método mostra a quantidade de vendas, soma das vendas e média das vendas do período
        /// </summary>
        /// <param name="mesInformado">Mês informado pelo usuário para a busca</param>
        public void MostraInformacoesDoMes(int mesInformado)
        {
            var quantidadeDeVendas = RetornaRelatorioPorMes(mesInformado).Sum(x => x.Quantidade);
            var somaDeVendas = RetornaRelatorioPorMes(mesInformado).Sum(x => x.Quantidade * x.Valor);
            var mediaDeVendas = somaDeVendas / quantidadeDeVendas;

            Console.WriteLine($"\nQuantidade de vendas do período : {quantidadeDeVendas.ToString()}");
            Console.WriteLine($"Soma de vendas do período  : {somaDeVendas.ToString("C")}");
            Console.WriteLine($"Média de vendas do período : {mediaDeVendas.ToString("C")}");
        }
        /// <summary>
        /// Método que lista todas as informações organizadas de janeiro a dezembro
        /// </summary>
        public void MostraInformacoesTodosMeses()
        {
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"\n--------------{TemplateMes(i.ToString())}------------------------------------------------------\n");
                MostraRelatorioPorMes(i);
                MostraInformacoesDoMes(i);
            }
        }
        /// <summary>
        /// Template para o display das informações de cada venda. Define a formatação de ID, Nome, Valor, Quantidade, Data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="valor"></param>
        /// <param name="quantidade"></param>
        /// <param name="dataRelatorio"></param>
        public void TemplateMostraInformacoes(int id, string nome, double valor, int quantidade, DateTime dataRelatorio)
        {
            Console.WriteLine("ID:{0,-3}  Carro: {1,2}  Valor: {2,2}  Quantidade:{3,2}  Data: {4,10}",id, nome, valor.ToString("C"), quantidade, dataRelatorio.ToShortDateString());
        }
        /// <summary>
        /// Método usado com MostraInformacoesTodosMeses() dentro do For, substitui o mês 1 por (janeiro) 2 (fevereiro) etc... 
        /// </summary>
        /// <param name="mes">Recebe o número do laço for</param>
        /// <returns></returns>
        public string TemplateMes(string mes)
        {
            switch (mes)
            {
                case "1":
                    return "Janeiro";
                    break;
                case "2":
                    return "Fevereiro";
                    break;
                case "3":
                    return "Março";
                    break;
                case "4":
                    return "Abril";
                    break;
                case "5":
                    return "Maio";
                    break;
                case "6":
                    return "Junho";
                    break;
                case "7":
                    return "Julho";
                    break;
                case "8":
                    return "Agosto";
                    break;
                case "9":
                    return "Setembro";
                    break;
                case "10":
                    return "Outubro";
                    break;
                case "11":
                    return "Novembro";
                    break;
                case "12":
                    return "Dezembro";
                    break;
                default:
                    return "No existe";
                    break;
            }
        }
    }
   
}
