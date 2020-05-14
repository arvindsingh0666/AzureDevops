using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerWebAPI.Models
{
    public class Customer
    {
        public string Id { get; set; }

        public DateTime Created { get; set; }

        public string Name { get; set; }

        public  Customer()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Created = DateTime.Now;

        }
    }
}