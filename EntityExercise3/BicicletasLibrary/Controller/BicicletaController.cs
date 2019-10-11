using BicicletasLibrary.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletasLibrary.Controller
{
    public class BicicletaController
    {
        public static BicicletaContext contextDB = new BicicletaContext();

        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contextDB.Bicicletas.Where(x => x.Ativo == true);
        }
        public IQueryable<Bicicleta> GetBicicletasMaiorValor()
        {
            return GetBicicletas().OrderByDescending(x => x.Valor);
        }
        public double ValorTotalBicicletas()
        {
            return GetBicicletas().Sum(x => x.Valor);
        }
        //adicionar
        public void AddBicicleta(Bicicleta bike)
        {
            contextDB.Bicicletas.Add(bike);
            contextDB.SaveChanges();
        }
        //alterar
        public bool AlterarBicicleta(Bicicleta bike)
        {
            var bikeFind = contextDB.Bicicletas.Find(bike.Id);
            if (bikeFind == null)
                return false;
            else
                bike.DataAlteracao = DateTime.Now;

            contextDB.SaveChanges();
            return true;
        }
        //deletar
        public bool DeletarBicicleta(int id)
        {
            var bikeFind = contextDB.Bicicletas.FirstOrDefault(x => x.Id == id);
            if (bikeFind == null)
                return false;

            bikeFind.Ativo = false;
            contextDB.SaveChanges();

            return true;
        }
        public void ExportarInformacoes()
        {
            string json = JsonConvert.SerializeObject(GetBicicletasMaiorValor().ToArray());
            System.IO.File.WriteAllText("C:\\Users\\900091\\Source\\Repos\\yagobnu111\\Treinamento-C-\\EntityExercise3\\TxtTeste.txt", json);
        }

    }
}
