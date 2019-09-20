using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        public List<Livro> Livros { get; set; }

        public LivrosController()//construtor, sempre tem o nome da classe
        {
            Livros = new List<Livro>();

            Livros.Add(new Livro()
            {
                Nome = "Senhor dos anéis"
            });

            Livros.Add(new Livro()
            {
                Nome = "O nome do vento"
            });
        }
       
    }
}