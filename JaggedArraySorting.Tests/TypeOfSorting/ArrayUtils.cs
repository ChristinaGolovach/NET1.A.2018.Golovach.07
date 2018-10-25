namespace JaggedArraySorting.Tests.TypeOfSorting
{
    public static class ArrayUtils
    {
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
