﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace moviemall.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Customer Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Subscribed to Newsletter?")]
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }//Navigation property - When we want to load the obj that is associated with other type

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        //[Required]
        [Display(Name = "Date of Birth")]
        [AgeValidationForMembership]
        public DateTime? Birthdate { get; set; }
    }
}