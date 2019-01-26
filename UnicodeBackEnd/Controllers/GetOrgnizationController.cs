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
using UnicodeBackEnd.Models;

namespace UnicodeBackEnd.Controllers
{
    public class GetOrgnizationController : ApiController
    {
        private DBEntities db = new DBEntities();

        // GET: api/GetOrgnization
        public IEnumerable<SP_GetOrgnization_Result> GetSP_GetOrgnization_Result()
        {
            return db.SP_GetOrgnization().ToList();
        }

        //// GET: api/GetOrgnization/5
        //[ResponseType(typeof(SP_GetOrgnization_Result))]
        //public IHttpActionResult GetSP_GetOrgnization_Result(int id)
        //{
        //    SP_GetOrgnization_Result sP_GetOrgnization_Result = db.SP_GetOrgnization_Result.Find(id);
        //    if (sP_GetOrgnization_Result == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(sP_GetOrgnization_Result);
        //}

        //// PUT: api/GetOrgnization/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutSP_GetOrgnization_Result(int id, SP_GetOrgnization_Result sP_GetOrgnization_Result)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != sP_GetOrgnization_Result.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(sP_GetOrgnization_Result).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SP_GetOrgnization_ResultExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/GetOrgnization
        //[ResponseType(typeof(SP_GetOrgnization_Result))]
        //public IHttpActionResult PostSP_GetOrgnization_Result(SP_GetOrgnization_Result sP_GetOrgnization_Result)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.SP_GetOrgnization_Result.Add(sP_GetOrgnization_Result);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = sP_GetOrgnization_Result.ID }, sP_GetOrgnization_Result);
        //}

        //// DELETE: api/GetOrgnization/5
        //[ResponseType(typeof(SP_GetOrgnization_Result))]
        //public IHttpActionResult DeleteSP_GetOrgnization_Result(int id)
        //{
        //    SP_GetOrgnization_Result sP_GetOrgnization_Result = db.SP_GetOrgnization_Result.Find(id);
        //    if (sP_GetOrgnization_Result == null)
        //    {
        //        return NotFound();
        //    }

        //    db.SP_GetOrgnization_Result.Remove(sP_GetOrgnization_Result);
        //    db.SaveChanges();

        //    return Ok(sP_GetOrgnization_Result);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool SP_GetOrgnization_ResultExists(int id)
        //{
        //    return db.SP_GetOrgnization_Result.Count(e => e.ID == id) > 0;
        //}
    }
}