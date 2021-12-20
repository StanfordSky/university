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
using DOTNET_15_new;

namespace DOTNET_15_new.Controllers
{
    public class MusicalInstrumentsController : ApiController
    {
        private dbEntities1 db = new dbEntities1();

        // GET: api/MusicalInstruments
        public IQueryable<MusicalInstrument> GetMusicalInstruments()
        {
            return db.MusicalInstruments;
        }

        // GET: api/MusicalInstruments/5
        [ResponseType(typeof(MusicalInstrument))]
        public async Task<IHttpActionResult> GetMusicalInstrument(int id)
        {
            MusicalInstrument musicalInstrument = await db.MusicalInstruments.FindAsync(id);
            if (musicalInstrument == null)
            {
                return NotFound();
            }

            return Ok(musicalInstrument);
        }

        // PUT: api/MusicalInstruments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMusicalInstrument(int id, MusicalInstrument musicalInstrument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != musicalInstrument.ID)
            {
                return BadRequest();
            }

            db.Entry(musicalInstrument).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicalInstrumentExists(id))
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

        // POST: api/MusicalInstruments
        [ResponseType(typeof(MusicalInstrument))]
        public async Task<IHttpActionResult> PostMusicalInstrument(MusicalInstrument musicalInstrument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MusicalInstruments.Add(musicalInstrument);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = musicalInstrument.ID }, musicalInstrument);
        }

        // DELETE: api/MusicalInstruments/5
        [ResponseType(typeof(MusicalInstrument))]
        public async Task<IHttpActionResult> DeleteMusicalInstrument(int id)
        {
            MusicalInstrument musicalInstrument = await db.MusicalInstruments.FindAsync(id);
            if (musicalInstrument == null)
            {
                return NotFound();
            }

            db.MusicalInstruments.Remove(musicalInstrument);
            await db.SaveChangesAsync();

            return Ok(musicalInstrument);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MusicalInstrumentExists(int id)
        {
            return db.MusicalInstruments.Count(e => e.ID == id) > 0;
        }
    }
}