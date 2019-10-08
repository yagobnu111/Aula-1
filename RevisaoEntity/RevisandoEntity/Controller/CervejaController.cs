using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;

namespace RevisandoEntity.Controller
{
    public class CervejaController
    {
        CervejaContextDB ContextDB = new CervejaContextDB();
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                ContextDB.Cervejas.Add(item);
                ContextDB.SaveChanges();
            }
        }
        public IQueryable<Cerveja> GetCervejas()
        {
            return ContextDB.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}
