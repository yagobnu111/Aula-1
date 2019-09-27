using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> ListaDeCervejas = new List<Cerveja>();
        public int cervejaId = 1;
        public SistemaCervejaContext()
        {
            //listaDeCarros.Add(new Venda(){Id = 1  , Nome ="Risus Company", Valor =  7200 , Quantidade = 18 , DataRelatorio = DateTime.Parse("29 / 01 / 2019" )});
            ListaDeCervejas.Add(new Cerveja() {Id = cervejaId++, Nome = "Brahma", Litros = 350, Alcool = 5, Valor = 2.99 });
            ListaDeCervejas.Add(new Cerveja() {Id = cervejaId++, Nome = "Budweiser", Litros = 550, Alcool = 5, Valor = 3.19 });
            ListaDeCervejas.Add(new Cerveja() {Id = cervejaId++, Nome = "Antarctica Cristal", Litros = 355, Alcool = 5.5, Valor = 3.19 });
            ListaDeCervejas.Add(new Cerveja() {Id = cervejaId++, Nome = "Stella Artois", Litros = 310, Alcool = 5, Valor = 3.99 });
            ListaDeCervejas.Add(new Cerveja() {Id = cervejaId++, Nome = "Bohemia Puro Malte", Litros = 990, Alcool = 5, Valor = 8.99 });
        }

    }
}
