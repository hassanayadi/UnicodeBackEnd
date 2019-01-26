using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using UnicodeBackEnd.Models;

namespace UnicodeBackEnd.Controllers
{
   // [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
    public class GetRegionsController : ApiController
    {
        private DBEntities db = new DBEntities();

        // GET: api/GetRegions
        public IEnumerable<SP_GetRegions_Result> GetSP_GetRegions_Result(SP_GetRegions_Result param)
        {
            return db.SP_GetRegions(param.ORGANIZATION_ID).ToList();
        }

        //// GET: api/GetRegions/5
        //[ResponseType(typeof(SP_GetRegions_Result))]
        //public IHttpActionResult GetSP_GetRegions_Result(int id)
        //{
        //    SP_GetRegions_Result sP_GetRegions_Result = db.SP_GetRegions_Result.Find(id);
        //    if (sP_GetRegions_Result == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(sP_GetRegions_Result);
        //}

        //// PUT: api/GetRegions/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutSP_GetRegions_Result(int id, SP_GetRegions_Result sP_GetRegions_Result)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != sP_GetRegions_Result.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(sP_GetRegions_Result).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SP_GetRegions_ResultExists(id))
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

        // POST: api/GetRegions
        //[ResponseType(typeof(SP_GetRegions_Result))]

        //[AcceptVerbs("GET", "POST")]
        //[HttpPost]
        //public IEnumerable<SP_GetRegions_Result> GetSP_GetRegions_Result(SP_GetRegions_Result param)
        //{
        //    return db.SP_GetRegions(param.ORGANIZATION_ID).ToList();
        //}

        //// DELETE: api/GetRegions/5
        //[ResponseType(typeof(SP_GetRegions_Result))]
        //public IHttpActionResult DeleteSP_GetRegions_Result(int id)
        //{
        //    SP_GetRegions_Result sP_GetRegions_Result = db.SP_GetRegions_Result.Find(id);
        //    if (sP_GetRegions_Result == null)
        //    {
        //        return NotFound();
        //    }

        //    db.SP_GetRegions_Result.Remove(sP_GetRegions_Result);
        //    db.SaveChanges();

        //    return Ok(sP_GetRegions_Result);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool SP_GetRegions_ResultExists(int id)
        //{
        //    return db.SP_GetRegions_Result.Count(e => e.ID == id) > 0;
        //}
    }
}