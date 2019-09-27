using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    
    public class CervejaController
    {
        public SistemaCervejaContext contextDB = new SistemaCervejaContext();

        public List<Cerveja> RetornaListaCervejas()
        {
            return contextDB.ListaDeCervejas;
        }

        public void AdicionaCerveja(string nome, int litros, double alcool, double valor )
        {
            contextDB.ListaDeCervejas.Add(new Cerveja() { Id = contextDB.cervejaId, Nome = nome, Litros = litros, Alcool = alcool, Valor = valor });
        }

        public double RetornaTotalValorLista()
        {
            var valorTotal = contextDB.ListaDeCervejas.Sum(x => x.Valor);
            return valorTotal;
        }
        public double RetornaTotalLitrosLista()
        {
            var litrosTotal = contextDB.ListaDeCervejas.Sum(x => x.Litros);
            return litrosTotal;
        }
        public double RetornaValorCompra(int id, int quantidade)
        {
            return contextDB.ListaDeCervejas.FindAll(x => x.Id == id).Sum(x => x.Valor * quantidade);
        }

    }
}
