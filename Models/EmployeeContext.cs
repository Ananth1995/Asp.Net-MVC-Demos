﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebFormDemo.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}