using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(int pId, string pName, double pPrice)
        {
            this.ProductId = pId;
            this.ProductName = pName;
            this.Price = pPrice;
        }
    }
}
