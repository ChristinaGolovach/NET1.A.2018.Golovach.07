using System;
using NUnit.Framework;
using JaggedArraySorting.Tests.TypeOfSorting;
using JaggedArraySortingLogic;

namespace JaggedArraySorting.Tests
{
    [TestFixture]
    public class SortDelegateOnInterfaceTests
    {
        [Test]
        public void Sort_AscendingMaxElementSorting_RerurnSortedArray()
        {
            // Arrange
            int[][] input = new int[][]
            {
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 },
                null,
                new int[] { 11, -22 },
                new int[0]
            };

            int[][] expected = new int[][]
            {
                null,
                new int[0],
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 11, -22 },
                new int[] { 0, 2, 4, 989 }
            };

            // Act
            SortDelegateOnInterface.Sort(JaggedArray.Sort, input, new AscendingMaxElementSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_DescendingMaxElementSorting_RerurnSortedArray()
        {
            // Arrange
            int[][] input = new int[][]
            {
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 },
                null,
                new int[] { 11, -22 },
                new int[0]
            };

            int[][] expected = new int[][]
            {
                new int[] { 0, 2, 4, 989 },
                new int[] { 11, -22 },
                new int[] { 1, -3, 5, 7, 9 },
                null,
                new int[0]
            };

            // Act
            SortDelegateOnInterface.Sort(JaggedArray.Sort, input, new DescendingMaxElementSorting());
            
            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_AscendingMinElementSorting_RerurnSortedArray()
        {
            // Arrange
            int[][] input = new int[][]
            {
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 },
                null,
                new int[] { 11, -22 },
                new int[0]
            };

            int[][] expected = new int[][]
            {
                null,
                new int[0],
                new int[] { 11, -22 },
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 }
            };

            // Act
            SortDelegateOnInterface.Sort(JaggedArray.Sort, input, new AscendingMinElementSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_DescendingMinElementSorting_RerurnSortedArray()
        {
            // Arrange
            int[][] input = new int[][]
            {
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 },
                null,
                new int[] { 11, -22 },
                new int[0]
            };

            int[][] expected = new int[][]
            {
                new int[] { 0, 2, 4, 989 },
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 11, -22 },
                null,
                new int[0]
            };

            // Act
            SortDelegateOnInterface.Sort(JaggedArray.Sort, input, new DescendingMinElementSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_AscendingSumSorting_RerurnSortedArray()
        {
            // Arrange
            int[][] input = new int[][]
            {
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 },
                null,
                new int[] { 11, -22 },
                new int[0]
            };

            int[][] expected = new int[][]
            {
                null,
                new int[0],
                new int[] { 11, -22 },
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 }
            };

            // Act
            SortDelegateOnInterface.Sort(JaggedArray.Sort, input, new AscendingSumSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_DescendingSumSorting_RerurnSortedArray()
        {
            // Arrange
            int[][] input = new int[][]
            {
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 },
                null,
                new int[] { 11, -22 },
                new int[0]
            };

            int[][] expected = new int[][]
            {
                new int[] { 0, 2, 4, 989 },
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 11, -22 },
                null,
                new int[0]
            };

            // Act
            SortDelegateOnInterface.Sort(JaggedArray.Sort, input, new DescendingSumSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_PassNullArray_ThrownArgumentNullException()
        {
            // Act - Assert
            Assert.Throws<ArgumentNullException>(() => SortDelegateOnInterface.Sort(JaggedArray.Sort, null, new DescendingSumSorting()));
        }

        [Test]
        public void Sort_PassEmptyArray_ThrownArgumentException()
        {
            // Arrange
            int[][] input = new int[0][] { };

            // Act - Assert
            Assert.Throws<ArgumentException>(() => SortDelegateOnInterface.Sort(JaggedArray.Sort, input, new DescendingSumSorting()));
        }

        [Test]
        public void Sort_PassEmptyComparer_ThrownArgumentException()
        {
            // Arrange
            int[][] input = new int[][]
            {
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 },
                null,
                new int[] { 11, -22 },
                new int[0]
            };

            // Act - Assert            
            Assert.Throws<ArgumentNullException>(() => SortDelegateOnInterface.Sort(JaggedArray.Sort, input, null));
        }
    }
}
