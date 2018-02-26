using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockObserver
{
    public class PortDisplay
    {

        public void Display(List<Stock> s, double _totalValue)
        {
            foreach (Stock _s in s)
            {
                Console.WriteLine("Stock name: " + _s.Name);
                Console.WriteLine("Value of the Stock: " + _s.Value);
                Console.WriteLine("The number of stocks owned:" + _s.count);
            }

            Console.WriteLine("Total value of stocks:" + _totalValue);
        }
    }

}
