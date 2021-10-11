using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Username { get; set; }
        public string Adress { get; set;}
        public string Tel { get; set; }
        public int BakeId { get; set; }
        public DateTime DateTime { get; set; } = System.DateTime.Now;
        public Bake Bake { get; set; }
    }
}
