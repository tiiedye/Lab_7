using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class OrderManager
    {
        public double CalculateShipping(double weightKG)
        {
            double cost = 0;
            if (weightKG <= 0)
            {
                throw new ArgumentException("Weight must be positive");
            }
            else if (weightKG < 1)
            {
                cost = 2.5;
            }
            else if (weightKG < 5)
    }
}
