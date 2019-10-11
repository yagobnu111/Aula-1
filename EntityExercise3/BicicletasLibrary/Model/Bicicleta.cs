using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletasLibrary.Model
{
    public class Bicicleta : BicicletaControle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Modelo { get; set; }
        [Required]
        [MaxLength(30)]
        public string Marca { get; set; }
        [Required]
        public double Valor { get; set; }
    }
}
