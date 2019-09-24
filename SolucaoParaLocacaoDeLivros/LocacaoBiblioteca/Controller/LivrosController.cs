using LocacaoBiblioteca.Controller;
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
        // carregando o banco de dados da classe locacaoContext
        private LocacaoContext contextDB = new LocacaoContext();

        #region Métodos para manipulação de livros
        /// <summary>
        /// Método que adiciona um livro à lista 
        /// </summary>
        /// <param name="parametroLivro">Recebe Nome do livro</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = contextDB.contIdLivros++;
            contextDB.ListaDeLivros.Add(parametroLivro);
        }   
        /// <summary>
        /// Método que muda o valor de ativo para falso de um livro 
        /// </summary>
        /// <param name="idRemove">Recebe o Id do livro</param>
        public void RemoverLivroPorId(int idRemove)
        {
            contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == idRemove).Ativo = false;
                
        }
        /// <summary>
        /// Método que retorna os livros ativos na lista
        /// </summary>
        /// <returns>Retorna uma lista com livros ativos</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }
        #endregion
    }
}