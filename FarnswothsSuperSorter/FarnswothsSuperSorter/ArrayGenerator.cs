using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FarnswothsSuperSorter
{
    public abstract class ArrayGenerator
    {
        public int[] unsorted  {get; set;}
        public abstract void GenerateArray(int n, int seed);
    }

    public class RandomArray : ArrayGenerator
    {
        System.Random rand = new System.Random();
        public override void GenerateArray(int n, int seed)
        {
            
            unsorted = new int[n];
            for (int i = 0; i < n; i++)
            {
                unsorted[i] = rand.Next(0, seed);
            }
        }
    }

    public class NealySorted : ArrayGenerator
    {

        System.Random rand = new System.Random();
        public override void GenerateArray(int n, int seed)
        {
            unsorted = new int[n];

            for (int i = 0; i < n; i++)
            {
                unsorted[i] = rand.Next(0, seed);
            }

            Array.Sort(unsorted);

            for (int i = 0; i < n/10; i++)
            {
                unsorted[rand.Next(0, unsorted.Length)] = rand.Next(0, seed);
            }
        }
    }

    public class Reverse : ArrayGenerator
    {
        System.Random rand = new System.Random();
        public override void GenerateArray(int n, int seed)
        {
            unsorted = new int[n];
            for (int i = 0; i < n; i++)
            {
                unsorted[i] = rand.Next(0, seed);
            }

            Array.Sort(unsorted);
            Array.Reverse(unsorted);
        }
    }

    public class NealyRandom : ArrayGenerator
    {
        System.Random rand = new System.Random();
        public override void GenerateArray(int n, int seed)
        {
            unsorted = new int[n];

            int big, small;

            if (n > seed)
            {
                big = n;
                small = seed;
            } else {
                big = seed;
                small = n;
            }

            for (int i = 0; i < n; i++)
            {
                unsorted[i] = big / small;
            }

            Array.Sort(unsorted);

            for (int i = 0; i < n / 10; i++)
            {
                unsorted[rand.Next(0, unsorted.Length)] = rand.Next(0, seed);
            }
        }
    }
}
