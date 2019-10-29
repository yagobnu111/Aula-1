using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SolucaoListaDeNomes.Models
{
    public class ControlePessoa
    {
        public bool Ativo { get; set; } = true;
        public int UsuarioCriacao { get; set; } = 0;
        public int UsuarioAlteracao { get; set; } = 0;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        [Required]
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}