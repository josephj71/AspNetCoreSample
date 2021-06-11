﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreSample.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
#nullable enable
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
#nullable disable
        public ICollection<Order> Orders { get; set; }
    }
}