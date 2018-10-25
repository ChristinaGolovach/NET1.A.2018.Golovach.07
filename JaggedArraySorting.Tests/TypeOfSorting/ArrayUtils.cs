namespace JaggedArraySorting.Tests.TypeOfSorting
{
    /// <summary>
    /// This class expands functionality for array of integer value.
    /// </summary>
    public static class ArrayUtils
    {
        /// <summary>
        /// Find sum of array's elements.
        /// </summary>
        /// <param name="array">
        /// Input array.
        /// </param>
        /// <returns>
        /// Sum of array's elements. If array is null or empty - return int.MinValue.
        /// </returns>
        public static int Sum(this int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return int.MinValue;
            }

            int sum = 0;

            foreach (int item in array)
            {
                sum += item;
            }

            return sum;
        }

        /// <summary>
        /// Find max element in array.
        /// </summary>
        /// <param name="array">
        /// Input array.
        /// </param>
        /// <returns>
        /// Max element in array. If array is null or empty - return int.MinValue.
        /// </returns>
        public static int MaxElement(this int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return int.MinValue;
            }

            int maxElement = array[0];

            foreach (int item in array)
            {
                if (item > maxElement)
                {
                    maxElement = item;
                }
            }

            return maxElement;
        }
        
        /// <summary>
        /// Find min element in array.
        /// </summary>
        /// <param name="array">
        /// Input array.
        /// </param>
        /// <returns>
        /// Min element in array. If array is null or empty - return int.MinValue.
        /// </returns>
        public static int MinElement(this int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return int.MinValue;
            }

            int minElement = array[0];

            foreach (int item in array)
            {
                if (item < minElement)
                {
                    minElement = item;
                }
            }

            return minElement;
        }
    }
}
