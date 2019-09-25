using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioInformacoes.Model
{
    public class Carro
    {
        public int Id  { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataRelatorio { get; set; }

    }
}
