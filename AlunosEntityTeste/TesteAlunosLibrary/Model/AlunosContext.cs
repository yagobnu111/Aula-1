using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlunosLibrary.Model
{
    public class AlunosContext : DbContext
    {
        public DbSet<Aluno> ListaDeAlunos { get; set; }
    }
}
