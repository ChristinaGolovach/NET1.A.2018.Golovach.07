using System;
using System.Collections.Generic;

namespace JaggedArraySortingLogic
{
    public static class CheckData
    {
        public static void CheckInputData(int[][] array, IComparer<int[]> comparer)
        {
            CheckInputArray(array);

            if (comparer == null)
            {
                throw new ArgumentNullException($"The {nameof(comparer)} can not be null.");
            }
        }

        public static void CheckInputData(int[][] array, Comparison<int[]> comparer)
        {
            CheckInputArray(array);

            if (comparer == null)
            {
                throw new ArgumentNullException($"The {nameof(comparer)} can not be null.");
            }
        }
  
        public static void CheckInputArray(int[][] array)
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
