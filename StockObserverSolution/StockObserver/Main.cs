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


            Stock Stock1 = new Stock("VESTAS", 557.50); //Creating Stock
            Stock Stock2 = new Stock("HEJSIMON", 400.56);
            List<Stock> ss = new List<Stock>(); //Create a list of Stocks
            ss.Add(Stock1); ss.Add(Stock2); //Adding stocks to list


            Portfolio PortFol = new Portfolio(ss);  //Creating Portfolio


            Stock1.RegisterObserver(PortFol); //Register observer
            Stock2.RegisterObserver(PortFol);
            PortFol.BuyStock("VESTAS", 5); //Buy stock
            PortFol.BuyStock("HEJSIMON", 5);
            Randomizer Rand = new Randomizer(ss); //Randomize list
            Stock1.SetValueNotify(123.45); //Set new value to stock
            PortFol.SellStock("VESTAS", 3); // Sell stock


            Console.WriteLine("End of the Program");
        }
    }
}
