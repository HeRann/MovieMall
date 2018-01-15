using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace moviemall.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }//Navigation property - When we want to load the obj that is associated with other type
        public byte MembershipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}