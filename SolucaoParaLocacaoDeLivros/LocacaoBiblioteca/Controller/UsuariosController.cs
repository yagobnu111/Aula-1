using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{   /// <summary>
/// Classe que contém os metodos de usuários do sistema
/// </summary>
    public class UsuariosController
    {
        public List<Usuario> Usuarios = new List<Usuario>();
        /// <summary>
        /// Método que realiza login dentro do nosso sistema
        /// Para realizar o login padrão use :
        /// Login : Admin
        /// Senha : Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuario como parâmetro</param>
        /// <returns>Retorna verdadeiro quando existir o usuário com este login e senha</returns>
        public UsuariosController()
        {
            Usuarios = new List<Usuario>();

            Usuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin"
                
            });

            Usuarios.Add(new Usuario()
            {
                Login = "Yago",
                Senha = "blablabla"
            });

        }


        public bool LoginSistema(Usuario usuarios)
        {
            //.Exists verifica se aquilo existe dentro da lista , se sim retorna True se não False
            return Usuarios.Exists(i => usuarios.Login == i.Login && usuarios.Senha == i.Senha);


            /*foreach (var i in Usuarios)
            {
                if (i.Login == usuarios.Login && i.Senha == usuarios.Senha)
                {
                    return true;
                }
            }*/
     

        }
    }
}
