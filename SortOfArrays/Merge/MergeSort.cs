using System;

namespace Merge
{
    /// <summary>
    /// Class MergeSort contains method to work with integer array.
    /// </summary>
    /// <remarks>
    /// This class can sort an array using a merge sort algorithm.
    /// </remarks>
    public static class MergeSort
    {

        /// <returns>
        /// Sorted integer array
        /// </returns>
        /// <param name="array">The source integer array</param>
        public static int[] Sort(int[] array)
        {
            if (array.Length == 1)
                return array;

            int[] firstAr = new int[array.Length / 2];
            int[] secondAr = new int[array.Length - firstAr.Length];

            Array.Copy(array, firstAr, firstAr.Length);
            Array.Copy(array, firstAr.Length, secondAr, 0, secondAr.Length);

            return Merge(Sort(firstAr), Sort(secondAr));
        }

        /// <returns>
        /// Result of merging two subarrays
        /// </returns>
        /// <param name="arr1">First integer subarray</param>
        /// <param name="arr2">Second integer subarray</param>
        private static int[] Merge(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];

            int index = 0;
            int index1 = 0;
            int index2 = 0;
            
            while (index < arr.Length)
            {
                if (index2 > arr2.Length - 1)
                {
                    while (index1 < arr1.Length)
                    {
                        arr[index++] = arr1[index1++];
                    }
                    break;
                }
                else if (index1 > arr1.Length - 1)
                {
                    while (index2 < arr2.Length)
                    {
                        arr[index++] = arr2[index2++];
                    }

                    break;
                }
                else
                {

                    if (arr1[index1] >= arr2[index2])
                    {
                        arr[index++] = arr2[index2++];

                    }
                    else if (arr1[index1] <= arr2[index2])
                    {
                        arr[index++] = arr1[index1++];
                    }
                }
            }
            return arr;
        }
    }
}
