﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class tblEmployeeNew
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "enter youe age")]
        public int Age { get; set; }

    }
}
