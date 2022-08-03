using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class Refueling
    {
        public decimal LitresOfFuel { get; }
        public decimal PriceOfFuel { get; }

        public Refueling(decimal litresOfFuel, decimal priceOfFuel)
        {
            this.LitresOfFuel = litresOfFuel;
            this.PriceOfFuel = priceOfFuel;
        }
        
    }
}
