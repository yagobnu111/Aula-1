using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Uma classe para guardar as informações da lista e deixar o prgrama mais organizado
    /// </summary>
    public class LocacaoContext : DbContext
    {
         public DbSet<Livro> Livros { get; set; }
         public DbSet<Usuario> Usuarios { get; set; }
    }
}
