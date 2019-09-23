using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrandoListasExercicio
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Carteira { get; set; }


        public Pessoa(int id, string nome, DateTime dataNascimento, double carteira)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Carteira = carteira;
        }
    }
}
