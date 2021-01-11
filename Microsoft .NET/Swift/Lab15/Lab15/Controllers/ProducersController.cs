using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Lab15;

namespace Lab15.Controllers
{
    public class ProducersController : ApiController
    {
        private DB_dotNetEntities db = new DB_dotNetEntities();

        // GET: api/Producers
        public IQueryable<Producer> GetProducer()
        {
            return db.Producer;
        }

        // GET: api/Producers/5
        [ResponseType(typeof(Producer))]
        public async Task<IHttpActionResult> GetProducer(int id)
        {
            Producer producer = await db.Producer.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }

            return Ok(producer);
        }

        // PUT: api/Producers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProducer(int id, Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producer.id)
            {
                return BadRequest();
            }

            db.Entry(producer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducerExists(id))
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

        // POST: api/Producers
        [ResponseType(typeof(Producer))]
        public async Task<IHttpActionResult> PostProducer(Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Producer.Add(producer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = producer.id }, producer);
        }

        // DELETE: api/Producers/5
        [ResponseType(typeof(Producer))]
        public async Task<IHttpActionResult> DeleteProducer(int id)
        {
            Producer producer = await db.Producer.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }

            db.Producer.Remove(producer);
            await db.SaveChangesAsync();

            return Ok(producer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProducerExists(int id)
        {
            return db.Producer.Count(e => e.id == id) > 0;
        }
    }
}