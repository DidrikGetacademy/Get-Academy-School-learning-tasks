using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
   
    public class ClothingItem : InventoryItem
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public ClothingItem(string name, int quantity, double price, string size, string color)
            : base(name, quantity, price)
        {
            Size = size;
            Color = color;
        }

        public override double CalculateSalePrice()
        {
           
            return base.CalculateSalePrice() * 0.9; 
        }
    }

}
