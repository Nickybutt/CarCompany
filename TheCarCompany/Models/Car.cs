﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCarCompany.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public double Range { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Mileage { get; set; }
        public string CompanyId { get; set; }
        public User User { get; set; }
        public Company CompanyID { get; set; }

    }
}
