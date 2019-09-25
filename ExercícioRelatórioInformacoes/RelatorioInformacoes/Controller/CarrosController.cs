using RelatorioInformacoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioInformacoes.Controller
{
    
    public class CarrosController
    {
        private InformacoesContext contextDB = new InformacoesContext();

        public void  RetornaListaCarros()
        {
            //contextDB.ListaDeCarros.ForEach(x => Console.WriteLine($"ID : {x.Id} Carro:{x.Nome} Valor: {x.Valor} Quantidade: {x.Quantidade}Data: {x.DataRelatorio} "));
            contextDB.ListaDeCarros.ForEach(x => Console.WriteLine($"ID : {x.Id} Carro:{x.Nome} Valor: {x.Valor} Quantidade: {x.Quantidade}Data: {x.DataRelatorio} "));
        }
        public  List<Carro> RetornaListaPorMes(string mesInformado)
        {
            return contextDB.ListaDeCarros.Where(x => x.DataRelatorio.Month.ToString() == mesInformado).ToList();
        }

    }
   
}
