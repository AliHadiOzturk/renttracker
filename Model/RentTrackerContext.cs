using Model.common;
using Model.tracker;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RentTrackerContext : DbContext
    {
        public RentTrackerContext() : base("rentTrackerConnection")
        {
        }
        public DbSet<Person> person { get; set; }
        public DbSet<Contract> contract { get; set; }
        public DbSet<Owner> owner { get; set; }
        public DbSet<Tenant> tenant { get; set; }

    }
}
