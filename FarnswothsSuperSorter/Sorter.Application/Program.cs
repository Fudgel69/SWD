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
            foreach (int i in unsortedInts)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
            SuperSorter quick = new InsertionSort();

            quick.Sort(unsortedInts);

            foreach (int i in unsortedInts)
            {
                Console.Write($"{i}");
            }



            Console.ReadKey();
        }
    }
}
