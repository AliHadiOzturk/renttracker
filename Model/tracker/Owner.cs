using Model.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.tracker
{
    public class Owner
    {
        [Key]
        public int id { get; set; }
        public Person person { get; set; }
        public List<Contract> contracts { get; set; }
        public string address { get; set; }


    }
}
