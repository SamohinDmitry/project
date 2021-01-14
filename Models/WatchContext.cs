using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Market.Models
{
    public class WatchContext : DbContext
    {
        public DbSet<Watch> Watches { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

    }
}