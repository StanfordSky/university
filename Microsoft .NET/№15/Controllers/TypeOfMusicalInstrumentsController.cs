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
using DOTNET_15_new;

namespace DOTNET_15_new.Controllers
{
    public class TypeOfMusicalInstrumentsController : ApiController
    {
        private dbEntities1 db = new dbEntities1();

        // GET: api/TypeOfMusicalInstruments
        public IQueryable<TypeOfMusicalInstrument> GetTypeOfMusicalInstruments()
        {
            return db.TypeOfMusicalInstruments;
        }

        // GET: api/TypeOfMusicalInstruments/5
        [ResponseType(typeof(TypeOfMusicalInstrument))]
        public IHttpActionResult GetTypeOfMusicalInstrument(int id)
        {
            TypeOfMusicalInstrument typeOfMusicalInstrument = db.TypeOfMusicalInstruments.Find(id);
            if (typeOfMusicalInstrument == null)
            {
                return NotFound();
            }

            return Ok(typeOfMusicalInstrument);
        }

        // PUT: api/TypeOfMusicalInstruments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTypeOfMusicalInstrument(int id, TypeOfMusicalInstrument typeOfMusicalInstrument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != typeOfMusicalInstrument.TypeOfMusInstID)
            {
                return BadRequest();
            }

            db.Entry(typeOfMusicalInstrument).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfMusicalInstrumentExists(id))
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

        // POST: api/TypeOfMusicalInstruments
        [ResponseType(typeof(TypeOfMusicalInstrument))]
        public IHttpActionResult PostTypeOfMusicalInstrument(TypeOfMusicalInstrument typeOfMusicalInstrument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TypeOfMusicalInstruments.Add(typeOfMusicalInstrument);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = typeOfMusicalInstrument.TypeOfMusInstID }, typeOfMusicalInstrument);
        }

        // DELETE: api/TypeOfMusicalInstruments/5
        [ResponseType(typeof(TypeOfMusicalInstrument))]
        public IHttpActionResult DeleteTypeOfMusicalInstrument(int id)
        {
            TypeOfMusicalInstrument typeOfMusicalInstrument = db.TypeOfMusicalInstruments.Find(id);
            if (typeOfMusicalInstrument == null)
            {
                return NotFound();
            }

            db.TypeOfMusicalInstruments.Remove(typeOfMusicalInstrument);
            db.SaveChanges();

            return Ok(typeOfMusicalInstrument);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TypeOfMusicalInstrumentExists(int id)
        {
            return db.TypeOfMusicalInstruments.Count(e => e.TypeOfMusInstID == id) > 0;
        }
    }
}