using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Models
{
    public class Bake
    {
        public int BakeId { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Foto { get; set; }
        public DateTime DateTime { get; set; }
    }
}
