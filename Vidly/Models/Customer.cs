using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Tellphone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string StatusID { get; set; }
        public bool  IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeID { get; set; }
    }
}