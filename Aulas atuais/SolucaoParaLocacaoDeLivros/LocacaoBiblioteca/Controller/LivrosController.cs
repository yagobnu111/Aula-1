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

        /// <summary>
        /// Método que adiciona um livro à lista 
        /// </summary>
        /// <param name="livro">Recebe Nome do livro</param>
        public void AdicionarLivro(Livro livro)
        {
            contextDB.Livros.Add(livro);
            contextDB.SaveChanges();
        }   
        /// <summary>
        /// Método que muda o valor de ativo para falso de um livro 
        /// </summary>
        /// <param name="idRemove">Recebe o Id do livro</param>
        public void RemoverLivroPorId(int idRemove)
        {
            contextDB.Livros.FirstOrDefault(x => x.Id == idRemove).Ativo = false;
                
        }
        /// <summary>
        /// Método que retorna os livros ativos na lista
        /// </summary>
        /// <returns>Retorna uma lista com livros ativos</returns>
        public IQueryable<Livro> GetLivros()
        {
            return contextDB.Livros.Where(x => x.Ativo);
        }
        public bool AtualizarLivro(Livro livro)
        {
            var atualiza = contextDB.Livros.ToList().Where(x => x.Id == livro.Id);
            if (atualiza == null)
                return false;
            else
                livro.DataAlteracao = DateTime.Now;

            contextDB.SaveChanges();
            return true;
        }

       
    }
}