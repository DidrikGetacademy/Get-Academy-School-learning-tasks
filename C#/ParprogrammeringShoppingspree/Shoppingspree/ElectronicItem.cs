using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
   
    public class ElectronicItem : InventoryItem
    {
        public string InsuranceInfo { get; set; }

        public ElectronicItem(string name, int quantity, double price, string insuranceInfo)
            : base(name, quantity, price)
        {
            InsuranceInfo = insuranceInfo;
        }

        public override double CalculateSalePrice()
        {
            
            return base.CalculateSalePrice() * 1.05; 
        }
    }

}
