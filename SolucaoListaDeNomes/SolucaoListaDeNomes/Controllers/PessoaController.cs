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
        List<Pessoa> listaDePessoas = new List<Pessoa>()
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
        };

        public List<Pessoa> Get()
        {
            return listaDePessoas;
        }
    }
}
