using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiExistente.Models;

namespace WebApiExistente.Controllers
{
    public class CarroesController : ApiController
    {
        private DataBaseContext db = new DataBaseContext();

        [HttpGet]
        [Route("Api/Carroes/CustomQuery")] // define a rota a ser usada quando puxar essas informações
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from cr in listaDeCarros
                                select new { NomeCarro = cr.Modelo,
                                             IdCarro = cr.Id
                                };

            return retornoCarros;
        }
        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
                                        //converter em lista para não
                                        //gastar processamento em vão
                                
            var listaDeCarros = db.Carros.ToList();
            var listaDeMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listaDeMarcas
                                  join car in listaDeCarros
                                  on mar.Id equals car.Marca
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome
                                  };

            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Carroes/CarrosComUsuarios")]
        public object CustomUsuarioQueCadastrou(int idCarro)
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from car in listaDeCarros
                                  join usu in listaDeUsuarios
                                  on car.UsuInc equals usu.Id
                                  where usu.Id == idCarro
                                  select new
                                  {
                                      NomeCarro = car.Marca,
                                      UsuCriacao = usu.Usuario1
                                  }; 
                              

            return conteudoRetorno;
        }


        // GET: api/Carroes
        public IQueryable<Carro> GetCarros()
        {
            return db.Carros;
        }

        // GET: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult GetCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            return Ok(carro);
        }

        // PUT: api/Carroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarro(int id, Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carro.Id)
            {
                return BadRequest();
            }

            db.Entry(carro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Carroes
        [ResponseType(typeof(Carro))]
        public IHttpActionResult PostCarro(Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carro.Id }, carro);
        }

        // DELETE: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult DeleteCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carro);
            db.SaveChanges();

            return Ok(carro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarroExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}