using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceBiblioteca
{
    class Program
    {
        //instanciamos (Carregamos para memória) nosso controlador dos livros
        static LivrosController livros = new LivrosController();
        //instanciamos (Carregamos para memória) nosso controlador dos usuarios
        static UsuariosController usuarioController = new UsuariosController();
        static void Main(string[] args)
        {
            TelaInicial();
        }
        /// <summary>
        /// Mostra no console o menu do sistema
        /// </summary>
        private static void MostraMenuSistema()
        {
            int choice = '1';

            while (choice != '0')
            {
                Console.Clear();
                Console.WriteLine("------------------Sistema de locação de livros--------------------");
                Console.WriteLine("Menu sistema");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Listar usuários, 2 - Listar livros");
                Console.WriteLine("3 - Cadastrar livros, 4 - Cadastrar Usuario");
                Console.WriteLine("5 - Remover Usuário");
                Console.WriteLine("6 - Logoff");
                choice = Console.ReadKey(true).KeyChar;

                switch (choice)
                {
                    case '1':
                        MostrarUsuarios();
                        Console.ReadKey(true);
                        break;
                    case '2':
                        MostrarLivro();
                        Console.ReadKey(true);
                        break;
                    case '0':
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    case '3':
                        CadastroDeLivros();
                        break;
                    case '6':
                        Console.WriteLine("Logging off");
                        Thread.Sleep(1000);
                        TelaInicial();
                        break;
                    case '4':
                        CadastroDeUsuario();
                        break;
                    case '5':
                        RemoveUsuario();
                        break;
                    default:
                        Console.WriteLine("I don't understand bro ");
                        Console.ReadKey();
                        break;
                }
            }
        }
        /// <summary>
        /// Método que realiza os procedimentos completos de login
        /// dentro do sistema: solicita login e senha pelo console
        /// e valida como corretas ou não
        /// </summary>
        /// <returns> Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema: ");


            Console.Write("Login: ");
            var loginUsuario = Console.ReadLine();


            Console.Write("Senha: ");
            var senhaUsuario = Console.ReadLine();

            // estanciando usuario só nessa situação, não usa tanta memória
            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginUsuario,
                Senha = senhaUsuario
            });
           
            Console.ReadKey();
        }
        /// <summary>
        /// Método que retorna os livros cadastrados
        /// </summary>
        private static void MostrarLivro()
        {
            Console.Clear();
            livros.RetornaListaDeLivros().ForEach(i => Console.WriteLine($"ID : {i.Id} Nome do livro : {i.Nome}"));

        }
        /// <summary>
        /// Metodo que retorna os usuários cadastrados
        /// </summary>
        private static void MostrarUsuarios()
        {

            Console.Clear();
            usuarioController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"ID : {i.Id} Usuário : {i.Login} "));
        }

        /// <summary>
        /// Faz um cadastro de novos livros no sistema
        /// </summary>
        private static void CadastroDeLivros()
        {
            char continuarAdd = '1';
            while (continuarAdd == '1')
            {
                Console.Clear();
                Console.WriteLine("Cadastrar livro dentro do sistema: ");
                var nomeDoLivro = Console.ReadLine();
                // livros é o objeto em memória, nele há disponível ferramentas para realizar tarefas como adicionar livros
                livros.AdicionarLivro(new Livro()
                {
                    Nome = nomeDoLivro
                    
                });
                Console.WriteLine("Livro adicionado!");
                Console.WriteLine("Gostaria de adicionar mais? 1 - Sim 2 - Voltar menu");
                continuarAdd = Console.ReadKey(true).KeyChar;
                if (continuarAdd == 2)
                    MostraMenuSistema();
            }
        }
        /// <summary>
        /// Faz o cadastro de um novo usuário no sistema
        /// </summary>
        private static void CadastroDeUsuario()
        {
            char continuarAdd = '1';
            while (continuarAdd == '1')
            {
                Console.Clear();
                Console.Write("Digite o Login para cadastro : ");
                var loginDoUsuario = Console.ReadLine();
                Console.Write("Digite a sua senha : ");
                var senhaDoUsuario = Console.ReadLine();

                usuarioController.AdicionarUsuario(new Usuario()
                {
                    
                    Login = loginDoUsuario,
                    Senha = senhaDoUsuario
                    
                });
                Console.WriteLine("Usuario cadastrado! Pressione qualquer tecla para voltar");
                Console.ReadKey(true);
                MostraMenuSistema();
            }
        }
        /// <summary>
        /// Método que remove (desativa) um usuário baseado no ID passado
        /// </summary>
        private static void RemoveUsuario()
        {
 
            MostrarUsuarios();
            Console.Write("Informe o ID do usuario a ser removido: ");
            var idRemove = int.Parse(Console.ReadLine());
            usuarioController.RemoverUsuarioPorId(idRemove);
            Console.WriteLine("Usuario removido com sucesso! ");
            Console.ReadKey(true);
            MostraMenuSistema();
        }
                
        /// <summary>
        /// Apresenta uma tela inicial antes do login ser feito
        /// </summary>
        private static void TelaInicial()
        {
            Console.Clear();
            Console.WriteLine("------------------Sistema de locação de livros--------------------");

            //enquanto não retornar verdadeiro o login no sistema, vai rodar 
            while (!RealizaLoginSistema())
                Console.Clear();
                Console.WriteLine("Login e senha inválidos");

            MostraMenuSistema();
        }
    }
}
