using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StockObserver
{
    public class Randomizer
    {
        public Random rand = new Random();


        //Creating and start Thread for Randomization
        public Randomizer(List<Stock> _stocks) 
        {
            Thread newThread = new Thread(() => Randomizer.StockRandomizer(_stocks, rand));
            newThread.Start();
        }

        //Randomizing Stock
        public static void StockRandomizer(List<Stock> Stocks, Random rand) 
        {
            while (true)
            {
                Thread.Sleep(1000);
                Stock last = Stocks.Last();
                foreach (Stock s in Stocks) //Randomize each stock in list
                {
                    double incDec = (100.00 + rand.Next(-5, 5)) / 100.00;
                    s.Value *= incDec;
                }
                last.NotifyObserver();
            }
        }
    }
}
