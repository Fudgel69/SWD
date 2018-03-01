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
            ArrayGenerator generated = new ArrayGenerator(10000, 100);
            int[] unsortedInts = generated.unsorted;

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
