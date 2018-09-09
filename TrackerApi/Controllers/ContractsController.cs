using Service.services;
using Service.vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace TrackerApi.Controllers
{
    [RoutePrefix("contracts")]
    public class ContractsController : ApiController
    {
        ContractService service;
        public ContractsController()
        {
            service = new ContractService();
        }
        // GET: api/Contracts
        [HttpGet]
        public IEnumerable<ContractVM> GetContracts()
        {
            //return new List<string> { "aa", "bb" };
            return service.getAll();
        }

        // GET: api/Contracts/5
        [ResponseType(typeof(ContractVM))]
        [HttpGet]
        public IHttpActionResult GetContractById([FromUri]int id)
        {
            ContractVM vm = service.getById(id);
            if (vm == null)
                return NotFound();
            return Ok(vm);
        }

        // POST: api/Contracts
        [ResponseType(typeof(ContractVM))]
        [HttpPost]
        public void CreateContract([FromBody]ContractVM request)
        {
            service.add(request);
        }

        // DELETE: api/Contracts/5
        [ResponseType(typeof(ContractVM))]
        [HttpDelete]
        public void DeleteContract(int id)
        {
            service.delete(id);
        }
    }
}
