using Abc.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
    public class Customer : IEntity
    {
        [Required]
        public string CustomerId { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string CompanyName { get; set; }

    }
}
