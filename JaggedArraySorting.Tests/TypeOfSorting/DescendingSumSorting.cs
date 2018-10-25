using System.Collections.Generic;

namespace JaggedArraySorting.Tests.TypeOfSorting
{
    /// <summary>
    /// Class describes comparer for two arrays in descending order by sum of arrays' elements.
    /// </summary>
    public class DescendingSumSorting : IComparer<int[]>
    {
        /// <summary>
        /// Extension method compares two integer array in descending order by sum elements in arrays. 
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
            if (firstArray.Sum() > secondArray.Sum())
            {
                return -1;
            }

            if (firstArray.Sum() < secondArray.Sum())
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
