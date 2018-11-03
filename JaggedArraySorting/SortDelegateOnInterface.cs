using System.Collections.Generic;

namespace JaggedArraySortingLogic
{
    /// <summary>
    /// Delegate for method <see cref="Sort"/>
    /// </summary>
    /// <param name="array">
    /// Jagged array for sorting.
    /// </param>
    /// <param name="comparer">
    /// Comparer for set the sorting rule.
    /// </param>
    public delegate void DelegateCallInterface(int[][] array, IComparer<int[]> comparer);

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
        /// <param name="comparer">
        /// Comparer for set the sorting rule.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="array"/> or <paramref name="comparer"/> or <paramref name="delegateCallInterface"/> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="array"/> is empty.
        /// </exception>
        public static void Sort(DelegateCallInterface delegateCallInterface, int[][] array, IComparer<int[]> comparer)
        {
            CheckData.CheckInputData(delegateCallInterface, array, comparer);

            delegateCallInterface(array, comparer);
        }          
    }
}
