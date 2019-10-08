using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    public class Cerveja
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string  Nome { get; set; }
        [StringLength(30)]
        public string Tipo { get; set; }
        public double Alcool { get; set; }
    }
}
