using SistemaCarro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarro.Controller
{
    public class CarroController
    {
        SistemaCarrosContext contextDB = new SistemaCarrosContext();
        /// <summary>
        /// Método que retorna a lista de carros
        /// </summary>
        /// <returns>Lista de carros</returns>
        public List<Carro> RetornaCarros()
        {
            return contextDB.listaDeCarros;
        }
    }

}