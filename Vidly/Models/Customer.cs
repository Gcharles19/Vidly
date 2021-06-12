using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Tellphone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string StatusID { get; set; }
    }
}