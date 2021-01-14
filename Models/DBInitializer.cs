﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Market.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<WatchContext>
    {
        protected override void Seed(WatchContext context)
        {
            context.Watches.Add(new Watch() { Name = "Day date", Price = 25000, Producer = "Swiss", Img = "/data/w1.png" });
            context.Watches.Add(new Watch() { Name = "Sky Dweller", Price = 23000, Producer = "Swiss", Img = "/data/w2.png" });
            context.Watches.Add(new Watch() { Name = "Cosmograph", Price = 30000, Producer = "Swiss", Img = "/data/w3.png" });
            context.Watches.Add(new Watch() { Name = "Milgauss", Price = 37600, Producer = "Swiss", Img = "/data/w4.png" });
            context.Watches.Add(new Watch() { Name = "Deepsea", Price = 10200, Producer = "Swiss", Img = "/data/w5.png" });
            context.Watches.Add(new Watch() { Name = "Oyster", Price = 31240, Producer = "Swiss", Img = "/data/w6.png" });
            context.Watches.Add(new Watch() { Name = "Montre", Price = 12000, Producer = "Swiss", Img = "/data/w7.png" });
            context.Watches.Add(new Watch() { Name = "Yacht", Price = 11080, Producer = "Swiss", Img = "/data/w8.png" });
            context.Watches.Add(new Watch() { Name = "Submariner", Price = 29500, Producer = "Swiss", Img = "/data/w9.png" });
            base.Seed(context);
        }
    }
}