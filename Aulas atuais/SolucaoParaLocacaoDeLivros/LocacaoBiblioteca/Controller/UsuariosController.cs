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
        //Carregando banco de dados da classe locacaoContext
        private LocacaoContext contextDB = new LocacaoContext();

        /// <summary>
        /// Método que verifica se o login e senha passados estão na lista de usuários
        /// </summary>
        /// <param name="usuarios">Recebe Usuario e Senha</param>
        /// <returns>se as informações estiverem corretas, retorna (true) do contrário (false)</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            //.Exists verifica se aquilo existe dentro da lista , se sim retorna True se não False
           var resultado = contextDB.Usuarios.FirstOrDefault(i => usuarios.Login == i.Login && usuarios.Senha == i.Senha);
            if (resultado == null)
                return false;
            else
                return true;

        }
        /// <summary>
        /// Método que adiciona um usuário à lista de usuários
        /// </summary>
        /// <param name="parametroUsuario">Recebe usuário e login</param>
        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            contextDB.Usuarios.Add(parametroUsuario);
            contextDB.SaveChanges();
           
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="idRemove">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorId(int idRemove)
        {
            //aqui é usado o método FirstOrDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            contextDB.Usuarios.FirstOrDefault(x => x.Id == idRemove).Ativo = false;
    
        }
        /// <summary>
        /// Método que retorna uma lista com usuários ativos
        /// </summary>
        /// <returns>lista de usuários ativos no sistema</returns>
        public IQueryable<Usuario> GetUsuarios()
        {
            //retorna agora somente a lista com usuarios ativos usando "Where(x => x.Ativo)"
            return contextDB.Usuarios.Where(x => x.Ativo);
        }
        public bool AtualizarUsuario(Usuario usuario)
        {
            var atualiza = contextDB.Usuarios.ToList().Where(x => x.Id == usuario.Id);
            if (atualiza == null)
                return false;
            else
                usuario.DataAlteracao = DateTime.Now;

            contextDB.SaveChanges();
            return true;

        }
    }
}
