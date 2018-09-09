using Model.tracker;
using Repository.repositories;
using Service.vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.services
{
    public class ContractService : BaseService, IService<ContractVM>
    {
        private readonly ContractRepository repo;
        public ContractService()
        {
            repo = new ContractRepository();
        }

        public void add(ContractVM entity)
        {
            Contract contract = mapTo<ContractVM, Contract>(entity);
            repo.add(contract);
        }
        public void delete(int id)
        {
            Contract contract = repo.getById(id);
            //mapTo<ContractVM,Contract>()
            repo.delete(contract);
        }

        public List<ContractVM> getAll()
        {
            List<Contract> contracts = this.repo.getAll();

            List<ContractVM> response = null;
            contracts.ToList().ForEach(item => response.Add(mapTo<Contract, ContractVM>(item)));
            return response;
        }

        public ContractVM getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
