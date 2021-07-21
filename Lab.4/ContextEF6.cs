using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using Lab._4.NORTHWND;
using System.Data.Entity;

namespace Lab._4
{
    public class ContextEF6 : DbContext
    {
        
        public DbSet<Person> People { get; set; }
    }
}