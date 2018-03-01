using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarnswothsSuperSorter
{
    public class ArrayGenerator
    {
        Random rand = new Random();
        public int[] unsorted  {get; set;}
        public ArrayGenerator(int n, int seed)
        {
            unsorted = new int[n];
            for (int i = 0; i < n; i++)
            {
                unsorted[i] = rand.Next(0, seed);
            }
        }
    }
}
