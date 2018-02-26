using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockObserver
{

    public class Portfolio : IObserver
    {
        //List of Stocks is created
        private List<Stock> stocks = new List<Stock>();
        PortDisplay disp = new PortDisplay();
        private double TotalValue;




        public Portfolio(List<Stock> _stocks)
        {
            stocks = new List<Stock>();
            stocks = _stocks;
        }

        public void update(string _name, double _value)
        {
            stocks.Single(x => x.Name == _name).Value = _value;
            TotalValue = 0;
            foreach (Stock s in stocks)
            {
                TotalValue += s.Value * s.count;
            }
            disp.Display(stocks, TotalValue);
        }


        public void SellStock(string name, int amount)
        {
            if (stocks.Single(x => x.Name == name).count > 0)
            {
                stocks.Single(x => x.Name == name).count -= amount;
            }
            else
            {
                Console.WriteLine("You aint got none of the {0} stocks", name);
            }

        }

        public void BuyStock(string name, int amount)
        {
            stocks.Single(x => x.Name == name).count += amount;
        }

    }

}
