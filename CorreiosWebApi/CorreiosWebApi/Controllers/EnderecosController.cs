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
using CorreiosWebApi.Models;

namespace CorreiosWebApi.Controllers
{
    public class EnderecosController : ApiController
    {
        private EnderecoContext db = new EnderecoContext();

        // GET: api/Enderecos
        public IQueryable<Endereco> GetEnderecoes()
        {
            return db.Enderecoes;
        }

        [HttpGet]
        [Route("Api/Enderecos/{cep}/Info")]
        public IQueryable EnderecosByCep(string cep)
        {
            return db.Enderecoes.Where(x => x.Cep == cep);
        }

        [HttpGet]
        [Route("Api/Enderecos/{bairro}/Info")]
        public IQueryable EnderecosByBairro(string bairro)
        {
            return db.Enderecoes.Where(x => x.Bairro == bairro);
        }

        // GET: api/Enderecos/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.Enderecoes.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Enderecos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Update realizado com sucesso!");
        }

        // POST: api/Enderecos
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Enderecoes.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Enderecos/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.Enderecoes.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Enderecoes.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Enderecoes.Count(e => e.Id == id) > 0;
        }
    }
}