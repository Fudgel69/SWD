using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarnswothsSuperSorter;

namespace Sorter.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayGenerator random = new RandomArray();
            ArrayGenerator nealy = new NealySorted();
            ArrayGenerator reverse = new Reverse();
            ArrayGenerator unique = new NealyRandom();

            unique.GenerateArray(100, 10);
            int[] unsortedInts = unique.unsorted;

            string yn;

            Console.WriteLine("Would you like to see your unsorted array? (Y)");
            yn = Console.ReadLine();

            if (yn == "y" || yn == "Y")
            {
                foreach (int i in unsortedInts)
                {
                    Console.WriteLine($"{i}");
                }
            }
            
            SuperSorter quick = new InsertionSort();

            quick.Sort(unsortedInts);

            Console.WriteLine("Would you like to see your sorted array? (Y)");
            yn = Console.ReadLine();

            if (yn == "y" || yn == "Y")
            {
                foreach (int i in unsortedInts)
                {
                    Console.WriteLine($"{i}");
                }
            }





            Console.ReadKey();
        }
    }
}
