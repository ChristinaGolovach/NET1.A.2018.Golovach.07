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
            SortDelegateOnInterface.Sort(input, new AscendingMaxElementSorting().Compare);

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
            SortDelegateOnInterface.Sort(input, new DescendingMaxElementSorting().Compare);
            
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
            SortDelegateOnInterface.Sort(input, new AscendingMinElementSorting().Compare);

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
            SortDelegateOnInterface.Sort(input, new DescendingMinElementSorting().Compare);

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
            SortDelegateOnInterface.Sort(input, new AscendingSumSorting().Compare);

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
            SortDelegateOnInterface.Sort(input, new DescendingSumSorting().Compare);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_PassNullArray_ThrownArgumentNullException()
        {
            // Act - Assert
            Assert.Throws<ArgumentNullException>(() => SortDelegateOnInterface.Sort(null, new DescendingSumSorting().Compare));
        }

        [Test]
        public void Sort_PassEmptyArray_ThrownArgumentException()
        {
            // Arrange
            int[][] input = new int[0][] { };

            // Act - Assert
            Assert.Throws<ArgumentException>(() => SortDelegateOnInterface.Sort(input, new DescendingSumSorting().Compare));
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
            Assert.Throws<ArgumentNullException>(() => SortDelegateOnInterface.Sort(input, null));
        }
    }
}
