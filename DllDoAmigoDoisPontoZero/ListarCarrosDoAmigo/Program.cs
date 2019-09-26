using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static SistemaCarrosContext sistemaContext = new SistemaCarrosContext();
        static void Main(string[] args)
        {
            sistemaContext.ListaDeCarrosPublica.ForEach(x => Console.WriteLine($"ID: {x.Id}  Marca: {x.Marca} Modelo: {x.Modelo} Ano: {x.Ano} Cv:{x.Cv}"));
            Console.ReadKey();
        }
    }
}
