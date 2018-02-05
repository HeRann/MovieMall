using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace moviemall.Models
{
    public class AgeValidationForMembership : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cust = (Customer)validationContext.ObjectInstance;
            
            if (cust.MembershipTypeId == MembershipType.Unknown || cust.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (cust.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required.");
            }
            var age = DateTime.Today.Year - cust.Birthdate.Value.Year;
            if (age < 18)
            {
                return new ValidationResult("Must be 18 years old in order to be a Member.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
    