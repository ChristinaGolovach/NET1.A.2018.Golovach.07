using System.Collections.Generic;

namespace JaggedArraySorting.Tests.TypeOfSorting
{
    /// <summary>
    /// Class describes comparer for two arrays in descending order by max element in them.
    /// </summary>
    public class DescendingMaxElementSorting : IComparer<int[]>
    {
        /// <summary>
        /// Extension method compares two integer array in descending order by max element in them. 
        /// </summary>
        /// <param name="firstArray">
        /// First array for comparison.
        /// </param>
        /// <param name="secondArray">
        /// Second array for comparison.
        /// </param>
        /// <returns>
        /// 1 - if the first array greater second array.
        /// -1 - if the first array is less than the second.
        /// 0 - if arrays are equal.
        /// </returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray.MaxElement() > secondArray.MaxElement())
            {
                return -1;
            }

            if (firstArray.MaxElement() < secondArray.MaxElement())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
