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


            Stock Stock1 = new Stock("VESTAS", 557.50);
            Stock Stock2 = new Stock("HEJSIMON", 400.56);
            List<Stock> ss = new List<Stock>();
            ss.Add(Stock1); ss.Add(Stock2);


            Portfolio PortFol = new Portfolio(ss);


            Stock1.RegisterObserver(PortFol);
            Stock2.RegisterObserver(PortFol);
            PortFol.BuyStock("VESTAS", 5);
            PortFol.BuyStock("HEJSIMON", 5);
            Randomizer Rand = new Randomizer(ss);
            Stock1.SetValueNotify(123.45);
            PortFol.SellStock("VESTAS", 3);


            Console.WriteLine("End of the Program");
        }
    }
}