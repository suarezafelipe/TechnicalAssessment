﻿using System.ComponentModel.DataAnnotations;

namespace SanaWebShop.Core.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    
        public string Address { get; set; }

        public string PersonalId { get; set; }
        
    }
}
