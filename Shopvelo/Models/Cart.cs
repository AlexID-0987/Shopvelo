using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public void AddItem(Bake bake,int quantity)
        {
            CartLine line = lineCollection.FirstOrDefault(x => x.Bake.BakeId == bake.BakeId);
            if(line==null)
            {
                lineCollection.Add(new CartLine
                {
                    Bake = bake,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine (Bake bake)
        {
            lineCollection.RemoveAll(x => x.Bake.BakeId == bake.BakeId);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }
        public double ComputeTotalValue()
        {
            return lineCollection.Sum(x => x.Bake.Price * x.Quantity);
        }
        public IEnumerable<CartLine> Lines
        {
            get => lineCollection;
        }
    }
    public class CartLine
    {
        public Bake Bake { get; set; }
        public int Quantity { get; set; }
    }
}
