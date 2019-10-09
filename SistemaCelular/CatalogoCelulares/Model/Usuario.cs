using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    // aqui a minha classe Usuario está herdando a ControleUsuario
    //não posso herdar mais de uma classe, mas posso fazer um efeito cascata
    //a ControleUsuario herda de outra classe, e então a Usuario herda ControleUsuario
    public class Usuario : ControleUsuario
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(30)]
        [Required]
        public string Login { get; set; }
        [MaxLength(30)]
        [Required]
        public string Senha { get; set; }

    }
}
