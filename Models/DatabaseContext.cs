﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("abc")
        {
            
        }
        public DbSet<tblEmployee> tblEmployees { get; set; }

    }
}