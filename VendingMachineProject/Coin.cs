using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject
{
    public class Coin
    {
        public double coinValue { get; set; }
        public Coin(double coinValue)
        {
            this.coinValue = coinValue;
        }
    }
}
