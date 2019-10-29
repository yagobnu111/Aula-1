using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SolucaoListaDeNomes.Models
{
    public class PessoaContext : DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }
    }
}