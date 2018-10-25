using System.Collections.Generic;

namespace JaggedArraySorting.Tests.TypeOfSorting
{
    public class AscendingMinElementSorting : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray.MinElement() > secondArray.MinElement())
            {
                return 1;
            }

            if (firstArray.MinElement() < secondArray.MinElement())
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
