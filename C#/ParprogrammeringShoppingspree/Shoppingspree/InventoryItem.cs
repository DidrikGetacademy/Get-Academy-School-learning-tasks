using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    
    public class InventoryItem : ISellable
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public InventoryItem(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public virtual double CalculateSalePrice()
        {
            return Price;
        }
    }

}
