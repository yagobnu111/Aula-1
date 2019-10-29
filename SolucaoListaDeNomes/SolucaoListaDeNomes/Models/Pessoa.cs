using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SolucaoListaDeNomes.Models
{
    public class Pessoa : ControlePessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } 
        public int Idade { get; set; } 
    }
}