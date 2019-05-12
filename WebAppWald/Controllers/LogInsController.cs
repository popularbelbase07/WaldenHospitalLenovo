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
using WebAppWald;

namespace WebAppWald.Controllers
{
    public class LogInsController : ApiController
    {
        private HospitalContextDataModel db = new HospitalContextDataModel();

        // GET: api/LogIns
        public IQueryable<LogIn> GetLogIns()
        {
            return db.LogIns;
        }

        // GET: api/LogIns/5
        [ResponseType(typeof(LogIn))]
        public IHttpActionResult GetLogIn(int id)
        {
            LogIn logIn = db.LogIns.Find(id);
            if (logIn == null)
            {
                return NotFound();
            }

            return Ok(logIn);
        }

        // PUT: api/LogIns/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLogIn(int id, LogIn logIn)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != logIn.User_Id)
            {
                return BadRequest();
            }

            db.Entry(logIn).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogInExists(id))
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

        // POST: api/LogIns
        [ResponseType(typeof(LogIn))]
        public IHttpActionResult PostLogIn(LogIn logIn)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LogIns.Add(logIn);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LogInExists(logIn.User_Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = logIn.User_Id }, logIn);
        }

        // DELETE: api/LogIns/5
        [ResponseType(typeof(LogIn))]
        public IHttpActionResult DeleteLogIn(int id)
        {
            LogIn logIn = db.LogIns.Find(id);
            if (logIn == null)
            {
                return NotFound();
            }

            db.LogIns.Remove(logIn);
            db.SaveChanges();

            return Ok(logIn);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LogInExists(int id)
        {
            return db.LogIns.Count(e => e.User_Id == id) > 0;
        }
    }
}