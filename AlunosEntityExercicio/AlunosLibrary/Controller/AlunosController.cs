using AlunosLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosLibrary.Controller
{
    
    public class AlunosController
    {
        AlunoContextDB contextDB = new AlunoContextDB();

        public IQueryable<Aluno> GetAlunos()
        {
            return contextDB.Alunos;
        } 
        public void AddAluno(Aluno item)
        {
            contextDB.Alunos.Add(item);
            contextDB.SaveChanges();
        }
    }
}
