using System.Collections.Generic;

namespace JaggedArraySorting.Tests.TypeOfSorting
{
    public class AscendingMaxElementSorting : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray.MaxElement() > secondArray.MaxElement())
            {
                return 1;
            }

            if (firstArray.MaxElement() < secondArray.MaxElement())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
