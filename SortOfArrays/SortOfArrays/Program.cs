using System;
using Sorting;

namespace SortOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The example of working QuickSort method*/

            Console.WriteLine("Sorting by QuickSort alghoritm");

            Random rand = new Random();
            int size = rand.Next(5, 40);
            int[] array = new int[size];
            for(int i = 0; i < size;i++)
            {
                array[i] = rand.Next(0, 50);
            }

            Console.WriteLine("The source array:");
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }

            QuickSort.Sort(array,0,size-1);
            Console.WriteLine("Sorted array:");
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }

            /*The example of working MergeSort method*/

            Console.WriteLine(new string('-',30));

            Console.WriteLine("Sorting by MergeSort alghoritm");

            size = rand.Next(5, 40);
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(0, 50);
            }

            Console.WriteLine("The source array:");
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }

            array = MergeSort.Sort(array);
            Console.WriteLine("Sorted array:");
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
