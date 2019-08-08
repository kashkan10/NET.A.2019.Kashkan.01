namespace Quick
{
    /// <summary>
    /// Class QuickSOrt contains method to work with integer array.
    /// </summary>
    /// <remarks>
    /// This class can sort an array using a quick sort algorithm.
    /// </remarks>
    public static class QuickSort
    {
        /// <param name="arr">The source integer array</param>
        /// <param name="left">Left border of array</param>
        /// <param name="right">Right border of array</param>
        public static void Sort(int[] arr, int left, int right)
        {

            if (right - left <= 0)
                return;

            int l = left;
            int r = right;
            int mid = arr[(right + left) / 2];
            int swap;

            while (l < r)
            {
                while (arr[l] < mid)
                {
                    l++;
                }

                while (arr[r] > mid)
                {
                    r--;
                }

                if (l <= r)
                {
                    swap = arr[l];
                    arr[l] = arr[r];
                    arr[r] = swap;
                    l++;
                    r--;
                }
            }

            Sort(arr, left, r);
            Sort(arr, l, right);
        }
    }
}
