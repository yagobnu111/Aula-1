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
    public class VendasController : ApiController
    {
        private DataBaseContext db = new DataBaseContext();

        [HttpGet]
        [Route("Api/Vendas/CustomQuery")] // define a rota a ser usada quando puxar essas informações
        public object CustomUsuariosQuery()
        {
            var listaDeVendas = db.Vendas.ToList();
            var listaDeCarros = db.Carros.ToList();

            var retornoVendas = from ven in listaDeVendas
                                join car in listaDeCarros
                                on ven.Carro equals car.Id
                                select new
                                {
                                    IdVenda = ven.Id,
                                    NomeCarro = car.Modelo
                                };

            return retornoVendas;
        }


        // GET: api/Vendas
        public IQueryable<Venda> GetVendas()
        {
            return db.Vendas;
        }

        // GET: api/Vendas/5
        [ResponseType(typeof(Venda))]
        public IHttpActionResult GetVenda(int id)
        {
            Venda venda = db.Vendas.Find(id);
            if (venda == null)
            {
                return NotFound();
            }

            return Ok(venda);
        }

        // PUT: api/Vendas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVenda(int id, Venda venda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != venda.Id)
            {
                return BadRequest();
            }

            db.Entry(venda).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendaExists(id))
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

        // POST: api/Vendas
        [ResponseType(typeof(Venda))]
        public IHttpActionResult PostVenda(Venda venda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vendas.Add(venda);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = venda.Id }, venda);
        }

        // DELETE: api/Vendas/5
        [ResponseType(typeof(Venda))]
        public IHttpActionResult DeleteVenda(int id)
        {
            Venda venda = db.Vendas.Find(id);
            if (venda == null)
            {
                return NotFound();
            }

            db.Vendas.Remove(venda);
            db.SaveChanges();

            return Ok(venda);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VendaExists(int id)
        {
            return db.Vendas.Count(e => e.Id == id) > 0;
        }
    }
}