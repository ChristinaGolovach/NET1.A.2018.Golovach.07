using System;
using System.Collections.Generic;

namespace JaggedArraySortingLogic
{
    /// <summary>
    /// Represents a static class for work with Jagged Array.
    /// </summary>
    public static class SortDelegateOnInterface
    {
        /// <summary>
        /// Static method for sorting jagged array.
        /// </summary>
        /// <param name="delegateCallInterface">
        /// Method that impelemnts sorting for given array acording to given comparer.
        /// </param>
        /// <param name="array">
        /// Jagged array for sorting.
        /// </param>
        /// <param name="comparison">
        /// Comparison for set the sorting rule.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="array"/> or <paramref name="comparison"/> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="array"/> is empty.
        /// </exception>
        public static void Sort(int[][] array, Comparison<int[]> comparison)
        {
            CheckData.CheckInputData(array, comparison);

            JaggedArray.Sort(array, new ComparisonAdapter(comparison));
        }

        private class ComparisonAdapter : IComparer<int[]>
        {
            private Comparison<int[]> comparison;

            public ComparisonAdapter(Comparison<int[]> comparison)
            {
                this.comparison = comparison;
            }

            public int Compare(int[] x, int[] y)
            {
                return comparison(x, y);
            }
        }
    }
}
