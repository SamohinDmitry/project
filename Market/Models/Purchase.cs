using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Market.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int WatchId { get; set; }
        public DateTime DateTime { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}