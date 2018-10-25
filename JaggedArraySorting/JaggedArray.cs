using System;
using System.Collections.Generic;

namespace JaggedArraySortingLogic
{
    public static class JaggedArray
    {
        public static void Sort(int[][] array, IComparer<int[]> comparer)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = length - 1; j < i; j--)
                {
                    if (comparer.Compare(array[j],array[j + 1]) < 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        private static void Swap(ref int[] first, ref int[] second)
        {
            int[] temp = first;
            first = second;
            second = first;
        }

        private static void CheckInputArray(int[][] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"The {nameof(array)} can not be null.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"The {nameof(array)} can not be empty.");
            }
        }
    }
}
