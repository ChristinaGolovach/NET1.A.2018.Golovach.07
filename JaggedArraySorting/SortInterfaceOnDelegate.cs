using System.Collections.Generic;

namespace JaggedArraySortingLogic
{
    /// <summary>
    /// Represents a static class for work with Jagged Array.
    /// </summary>
    public static class SortInterfaceOnDelegate
    {
        /// <summary>
        /// Static method for sorting jagged array.
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

            JaggedArray.Sort(array, comparer.Compare);
        }
    }
}
