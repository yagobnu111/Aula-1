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
        static UsuariosController usuarios = new UsuariosController();
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
                Console.WriteLine("0 - Sair, 1 - Listar usuários, 2 - Listar livros, 3 - Cadastrar livros 4 - Logoff");
                choice = Console.ReadKey(true).KeyChar;

                switch (choice)
                {
                    case '1':
                        MostrarUsuario();
                        break;
                    case '2':
                        MostrarLivro();
                        break;
                    case '0':
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    case '3':
                        CadastroDeLivros();
                        break;
                    case '4':
                        Console.WriteLine("Logging off");
                        Thread.Sleep(1000);
                        TelaInicial();
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

            UsuariosController usuarioController = new UsuariosController();

            // estanciando usuario só nessa situação, não usa tanta memória
            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginUsuario,
                Senha = senhaUsuario
            });
           
            Console.ReadKey();
        }
        /// <summary>
        /// Método que mostra os livros cadastrados
        /// </summary>
        private static void MostrarLivro()
        {
            Console.Clear();
            livros.Livros.ForEach(i => Console.WriteLine($"Nome do livro : {i.Nome}"));
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que mostra os usuários cadastrados
        /// </summary>
        private static void MostrarUsuario()
        {

            Console.Clear();
            usuarios.Usuarios.ForEach(i => Console.WriteLine($"Usuário : {i.Login} "));
            Console.ReadKey();
        }

        private static void CadastroDeLivros()
        {
            Console.WriteLine("Essa função ainda não foi adicionada !");
            Console.ReadKey(true);
        }

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
