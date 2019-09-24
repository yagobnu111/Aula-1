using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Uma classe para guardar as informações da lista e deixar o prgrama mais organizado
    /// </summary>
    public class LocacaoContext
    {
        // Instanciando uma lista de livros 
        public  List<Livro> ListaDeLivros { get; set; }
        // Instanciamos uma lista de usuários
        public  List<Usuario> ListaDeUsuarios { get; set; }

        //contadores de livros e usuários
        public int contIdLivros { get; set; } = 1;
        public int contIdUsuarios { get; set; } = 1;

        public  LocacaoContext()//construtor, sempre tem o nome da classe
        {
            #region Carregando livros
            ListaDeLivros = new List<Livro>();

            ListaDeLivros.Add(new Livro()
            {
                Id = contIdLivros++,
                Nome = "Senhor dos anéis",

            });

            ListaDeLivros.Add(new Livro()
            {
                Id = contIdLivros++,
                Nome = "O nome do vento"
            });

            ListaDeLivros.Add(new Livro()
            {
                Id = contIdLivros++,
                Nome = "Can't hurt me"
            });
            #endregion

            #region Carregando Usuários
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = contIdUsuarios++,
                Login = "Admin",
                Senha = "Admin"

            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = contIdUsuarios++,
                Login = "Yago",
                Senha = "blablabla"
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = contIdUsuarios++,
                Login = "yagobnu",
                Senha = "xuxu"
            });

            #endregion
        }
    }
}
