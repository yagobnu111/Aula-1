using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculandoImcV3.Models
{
    public class ObjetoImc
    {
        public string Nome { get; set; } = string.Empty;
        public double Peso { get; set; } = 0;
        public double Altura { get; set; } = 0;
        public double ImcValue { get; set; } = 0;
        public string Situacao { get; set; } = "";

    }
}