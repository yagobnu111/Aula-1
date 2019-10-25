using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    /// <summary>
    /// retorna nome de aplicação e o que ela faz
    /// </summary>
    /// <returns>Retorna o que o nosso app faz</returns>
    public class CalculoIdadeController : ApiController
    {
        public string Get()
        {
            return "App para poder beber hoje";
        }

        public string Get(int anoNascimento, string nomeUsuario = "Default")
        {   
            if((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return $"Olá {nomeUsuario}, pode beber sem dó, hoje é sexta feiraaaaaaaaa caraiiiiii";
            }
            else
            {
                return $"Olá {nomeUsuario}, refrigerante e energético estão disponíveis para você";
            }     
        } 
    }
}
