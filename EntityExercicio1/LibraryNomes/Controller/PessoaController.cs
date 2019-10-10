using LibraryNomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryNomes.Controller
{
    public class PessoaController
    {
        PessoaContext contextDB = new PessoaContext();

        public IQueryable<Pessoa> GetPessoas()
        {
            return contextDB.Pessoas;
        }
        public bool AddPessoa(Pessoa pessoa)
        {
            var resultado = contextDB.Pessoas.Add(pessoa);

            if (resultado == null)
                return false;

            contextDB.SaveChanges();
            return true;
        }
    }
}
