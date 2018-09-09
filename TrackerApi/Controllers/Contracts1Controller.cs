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
using Model;
using Model.tracker;

namespace TrackerApi.Controllers
{
    public class Contracts1Controller : ApiController
    {
        private RentTrackerContext db = new RentTrackerContext();

        // GET: api/Contracts1
        public IQueryable<Contract> Getcontract()
        {
            return db.contract;
        }

        // GET: api/Contracts1/5
        [ResponseType(typeof(Contract))]
        public IHttpActionResult GetContract(int id)
        {
            Contract contract = db.contract.Find(id);
            if (contract == null)
            {
                return NotFound();
            }

            return Ok(contract);
        }

        // PUT: api/Contracts1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContract(int id, Contract contract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != contract.id)
            {
                return BadRequest();
            }

            db.Entry(contract).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContractExists(id))
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

        // POST: api/Contracts1
        [ResponseType(typeof(Contract))]
        public IHttpActionResult PostContract(Contract contract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.contract.Add(contract);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = contract.id }, contract);
        }

        // DELETE: api/Contracts1/5
        [ResponseType(typeof(Contract))]
        public IHttpActionResult DeleteContract(int id)
        {
            Contract contract = db.contract.Find(id);
            if (contract == null)
            {
                return NotFound();
            }

            db.contract.Remove(contract);
            db.SaveChanges();

            return Ok(contract);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContractExists(int id)
        {
            return db.contract.Count(e => e.id == id) > 0;
        }
    }
}