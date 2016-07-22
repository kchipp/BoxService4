using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoxService4.Models
{
    public class Wine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Variety { get; set; }
        public int Vintage { get; set; }
        public string Origin { get; set; }
        public decimal Price { get; set; }
    }
}