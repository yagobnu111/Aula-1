using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlunosLibrary.Controller;
using TesteAlunosLibrary.Model;

namespace InterfaceAlunosV2
{
    class Program
    {
        public static AlunosController alunos = new AlunosController();
        static void Main(string[] args)
        {
            alunos.AddAlunos(new Aluno() { Nome = "Gabriel", Idade = 19 });
            alunos.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine(x.Nome, x.Idade));
            Console.ReadKey();
        }
    }
}
