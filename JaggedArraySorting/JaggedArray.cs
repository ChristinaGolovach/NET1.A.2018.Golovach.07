using System;
using System.Collections.Generic;

namespace JaggedArraySortingLogic
{
    /// <summary>
    /// Represents a static class for work with Jagged Array.
    /// </summary>
    public static class JaggedArray
    {
        /// <summary>
        /// Static method for sorting jagged array  according to the given <paramref name="comparer"/> . 
        /// </summary>
        /// <param name="array">
        /// Jagged array for sorting.
        /// </param>
        /// <param name="comparer">
        /// Comparer for set the sorting rule.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="array"/> or <paramref name="comparer"/> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="array"/> is empty.
        /// </exception>
        public static void Sort(int[][] array, IComparer<int[]> comparer)
        {
            CheckData.CheckInputData(array, comparer);

            //  Sort(array, comparer.Compare);

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

        /// <summary>
        /// Static method for sorting jagged array  according to the given <paramref name="comparer"/> . 
        /// </summary>
        /// <param name="array">
        /// Jagged array for sorting.
        /// </param>
        /// <param name="comparer">
        /// Method that implements comparing.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="array"/> or <paramref name="comparer"/> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="array"/> is empty.
        /// </exception>
        public static void Sort(int[][] array, Comparison<int[]> comparer)
        {
            CheckData.CheckInputData(array, comparer);

            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) > 0)
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
            second = temp;
        }        
    }
}
