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
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j]) > 0)
                    {
                        Swap(ref array[i], ref array[j]);
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
