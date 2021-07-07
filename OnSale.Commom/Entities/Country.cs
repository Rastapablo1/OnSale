﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Commom.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} charecteres.")]
        [Required]
        public string Name { get; set; }
    }
}
