using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlunosLibrary.Model;


namespace TesteAlunosLibrary.Controller
{
    public class AlunosController
    {
        AlunosContext ContextDB = new AlunosContext();

        public IQueryable<Aluno> GetAlunos()
        {
            return ContextDB.ListaDeAlunos;
        }
        public void AddAlunos(Aluno item)
        {
            ContextDB.ListaDeAlunos.Add(item);
            ContextDB.SaveChanges();
        }
    }
}
