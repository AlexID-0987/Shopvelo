using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage ="Укажите имя покупателя")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Укажите адрес доставки")]
        public string Adress { get; set;}
        [Required(ErrorMessage ="Укажите телефон")]
        public string Tel { get; set; }
        public int? BakeId { get; set; }
        public DateTime DateTime { get; set; } = System.DateTime.Now;
        public Bake Bake { get; set; }
    }
}
