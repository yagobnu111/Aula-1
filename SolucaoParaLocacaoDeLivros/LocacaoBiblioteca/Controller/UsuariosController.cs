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
        private int contID = 0;
        private List<Usuario> ListaDeUsuarios = new List<Usuario>();
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
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = contID++,
                Login = "Admin",
                Senha = "Admin"
                
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = contID++,
                Login = "Yago",
                Senha = "blablabla"
            });

        }


        public bool LoginSistema(Usuario usuarios)
        {
            //.Exists verifica se aquilo existe dentro da lista , se sim retorna True se não False
            return ListaDeUsuarios.Exists(i => usuarios.Login == i.Login && usuarios.Senha == i.Senha);


            /*foreach (var i in Usuarios)
            {
                if (i.Login == usuarios.Login && i.Senha == usuarios.Senha)
                {
                    return true;
                }
            }*/
     

        }
        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            contID++;
            parametroUsuario.Id = contID;
            ListaDeUsuarios.Add(parametroUsuario);
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="idRemove">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorId(int idRemove)
        {
            //aqui é usado o método FirstOrDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            ListaDeUsuarios.FirstOrDefault(x => x.Id == idRemove).Ativo = false;
            
            
            
            /* foreach (var i in Usuarios)
            {
                if (i.Id == idRemove)
                {
                    Usuarios.Remove(i);
                    Console.WriteLine("Usuário removido com sucesso! Aperte qualquer tecla para voltar ao menu ");
                    break;
                }
            }*/
                
        }
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somente a lista com usuarios ativos usando "Where(x => x.Ativo)"
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
    }
}
