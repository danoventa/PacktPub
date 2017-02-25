using System;
using System.Collections.Concurrent;

namespace ConsoleApp
{
    public class Sorting
    {
        public static void Quicksort(int[] arroo)
        {
            Quicksort(arroo, 0, arroo.Length - 1);
        }

        public static void Quicksort(int[] arroo, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = arroo[(left + right) / 2];
            int index = Partition(arroo, left, right, pivot);
            Quicksort(arroo, left, index - 1);
            Quicksort(arroo, index, right );
        }

        public static int Partition(int[] arroo, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (arroo[left] < pivot)
                {
                    left++;
                }
                while (arroo[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    Swap(arroo, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        public static void Swap(int[] arroo, int left, int right)
        {
            int temp = arroo[left];
            arroo[left] = arroo[right];
            arroo[right] = temp;
        }
    }
}