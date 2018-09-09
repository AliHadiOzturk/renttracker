using Model.tracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.vm
{
    public class ContractVM
    {
        public int id { get; set; }
        public string dairesi { get; set; }
        public string mahallesi { get; set; }
        public string street { get; set; }
        public string type { get; set; }
        public double oneMonthRent { get; set; }
        public double oneYearRent { get; set; }
        public string rentPeriod { get; set; }
        public string paymentMethod { get; set; }
        public DateTime rentStartingDate { get; set; }
        public string purposeOf { get; set; }
        public Owner owner { get; set; }
        public Tenant tenant { get; set; }
    }
}
