using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockObserver
{
    public class StockApp
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Beginning of the Program");

            //Creating Stocks
            Stock Stock1 = new Stock("VESTAS", 557.50); 
            Stock Stock2 = new Stock("HEJSIMON", 400.56);

            //Create a list of Stocks
            List<Stock> ss = new List<Stock>();

            //Adding stocks to list
            ss.Add(Stock1); ss.Add(Stock2);

            //Creating Portfolio
            Portfolio PortFol = new Portfolio(ss);

            //Register observer
            Stock1.RegisterObserver(PortFol); 
            Stock2.RegisterObserver(PortFol);

            //Buying stocks
            PortFol.BuyStock("VESTAS", 5); 
            PortFol.BuyStock("HEJSIMON", 5);

            //Randomize list
            Randomizer Rand = new Randomizer(ss);

            //Set new value to stock
            Stock1.SetValueNotify(123.45);

            //Selling stock
            PortFol.SellStock("VESTAS", 3); 


            Console.WriteLine("End of the Program");
        }
    }
}
