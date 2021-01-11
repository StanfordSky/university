using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;


namespace lab14_2.Models
{
    public class myContex : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}