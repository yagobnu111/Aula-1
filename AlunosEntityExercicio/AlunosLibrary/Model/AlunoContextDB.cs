using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosLibrary.Model
{
    public class AlunoContextDB : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}

