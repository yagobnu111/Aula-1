using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SolucaoListaDeNomes.Models;

namespace SolucaoListaDeNomes.Controllers
{

    public class PessoaController : ApiController
    {
        public static PessoaContext contextDB = new PessoaContext();

        /*List<Pessoa> listaDePessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Gabriel", Idade = 24},
            new Pessoa(){Nome = "Bruna", Idade = 25},
            new Pessoa(){Nome = "Guilherme", Idade = 27},
            new Pessoa(){Nome = "Letícia", Idade = 30},
            new Pessoa(){Nome = "Ana", Idade = 32},
            new Pessoa(){Nome = "Leonardo", Idade = 12},
            new Pessoa(){Nome = "Sofrêncio", Idade = 44},
            new Pessoa(){Nome = "Maria", Idade = 84},
            new Pessoa(){Nome = "Jackson", Idade = 17},
            new Pessoa(){Nome = "Yago", Idade = 105},
            new Pessoa(){Nome = "Pedro", Idade = 27},
        };*/
        public IQueryable<Pessoa> GetPessoas()
        {
            return contextDB.pessoas;
        }

        public List<Pessoa> Get()
        {
            return GetPessoas().OrderByDescending(x => x.Idade).ToList();
        }
          
        public Pessoa Post(Pessoa values)
        {
            /*ObjetoImc imcCalc = values;
            listaDeObjetos.Add(imcCalc);
            return imcCalc;*/

            Pessoa pessoa1 = values;

            contextDB.pessoas.Add(pessoa1);

            return pessoa1;

        }

    }
}
