using System.Collections.Generic;

namespace JaggedArraySorting.Tests.TypeOfSorting
{
    public class AscendingSumSorting : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Sum() > secondArray.Sum())
            {
                return 1;
            }

            if (firstArray.Sum() < secondArray.Sum())
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
