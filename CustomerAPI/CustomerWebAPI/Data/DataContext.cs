using CustomerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerWebAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext() : base("Default Connection")
        { 
        
        }

        public DbSet<Customer> Customers { get; set; }

        //public System.Data.Entity.DbSet<CustomerWebAPI.Models.Customer> Customers { get; set; }
    }
}