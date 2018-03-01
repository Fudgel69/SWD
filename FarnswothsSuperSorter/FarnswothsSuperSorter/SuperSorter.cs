using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarnswothsSuperSorter
{
    public abstract class SuperSorter
    {
        public abstract void Sort(int[] a);
    }

    public class InsertionSort : SuperSorter
    {
        
        public override void Sort(int[] a)
        {
            Console.WriteLine("Insertion Sort Called");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int temp, j;

            for (int i = 1; i < a.Length; i++)
            {
                temp = a[i];
                j = i - 1;

                while (j >= 0 && a[j] > temp)
                {
                    a[j + 1] = a[j];
                    j--;
                }

                a[j + 1] = temp;

            }

            watch.Stop();
            Console.WriteLine($"The Insertion Sort method took: {watch.ElapsedMilliseconds}ms");
        }
    }
}
