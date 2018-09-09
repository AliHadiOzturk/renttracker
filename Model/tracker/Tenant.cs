using Model.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.tracker
{
    public class Tenant
    {
        [Key, ForeignKey("contract")]
        public int id { get; set; }
        public Person person { get; set; }
        public string address { get; set; }
        public string workAddress { get; set; }
        public Contract contract { get; set; }
    }
}
