using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();

        /// <summary>
        /// Método que retorna nossa lista de celulares ativos apenas.
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB.Celulares.Where(x => x.Ativo == true);
        }  
        public IQueryable<Celular> GetCelularesDesativados()
        {
            return contextDB.Celulares.Where(x => x.Ativo == false);
        }
        /// <summary>
        /// Método que valida e insere os registros dentro do sistema.
        /// </summary>
        /// <param name="item">Nosso novo celular.</param>
        /// <returns>Retorna verdadeiro para um item válido.</returns>
        public bool AddCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Preco <= 0)
                return false;

            contextDB.Celulares.Add(item);
            contextDB.SaveChanges();
            return true;

        }
        /// <summary>
        /// Método utilizado para apenas desativar o irem dentro de nosso sistema
        /// </summary>
        /// <param name="item">Id que será desativado</param>
        /// <returns>Retorna verdadeiro em caso de sucesso </returns>
        public bool RemoveCelular(int id)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == id);

            if (celular == null)
                return false;

            celular.Ativo = false;

            contextDB.SaveChanges();

            return true;
        }
        /// <summary>
        /// Método que atualiza um registro válido do nosso sistema
        /// </summary>
        /// <param name="item">Os registros atualizados </param>
        /// <returns>Retorna verdadeiro caso item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = contextDB.Celulares.Find(item.Id);
            if (celular == null)
                return false;
            else
            {
                //celular = item;//FirstOrDefault(x => x.Id == item.Id). = item;
                item.DataAlteracao = DateTime.Now;
            }

            contextDB.SaveChanges();

            return true;
        }
        public bool ReativarCelular(int id)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == id && x.Ativo == false);
            var desativados = contextDB.Celulares;

            if (celular == null)
                return false;

            celular.Ativo = true;

            contextDB.SaveChanges();

            return true;
        }
    }
}
