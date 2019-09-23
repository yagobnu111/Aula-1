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
        /// <summary>
        /// Método construtor que prepara o terreopara já iniciar com livros pré cadastrados
        /// </summary>
        private List<Livro> ListaDeLivros { get; set; }
        private int contId = 0;

        public LivrosController()//construtor, sempre tem o nome da classe
        {
            ListaDeLivros = new List<Livro>();

            ListaDeLivros.Add(new Livro()
            {
                Id = contId++,
                Nome = "Senhor dos anéis",

            });

            ListaDeLivros.Add(new Livro()
            {
                Id = contId++,
                Nome = "O nome do vento"
            });

            ListaDeLivros.Add(new Livro()
            {
                Id = contId++,
                Nome = "Can't hurt me"
            });
        }
        /// <summary>
        /// Método que adiciona o livro em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar </param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            contId++;
            parametroLivro.Id = contId;
            ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }
       
    }
}