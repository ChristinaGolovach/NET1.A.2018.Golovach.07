using System;
using JaggedArraySorting.Tests.TypeOfSorting;
using NUnit.Framework;

namespace JaggedArraySortingLogic.Tests
{
    [TestFixture]
    public class JaggedArrayTests
    {
        [Test]
        public void Sort_AscendingMaxElementSorting_RerurnSortedArray()
        {
            // Arange
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
            JaggedArray.Sort(input, new AscendingMaxElementSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);            
        }

        [Test]
        public void Sort_DescendingMaxElementSorting_RerurnSortedArray()
        {
            // Arange
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
            JaggedArray.Sort(input, new DescendingMaxElementSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_AscendingMinElementSorting_RerurnSortedArray()
        {
            // Arange
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
            JaggedArray.Sort(input, new AscendingMinElementSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_DescendingMinElementSorting_RerurnSortedArray()
        {
            // Arange
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
            JaggedArray.Sort(input, new DescendingMinElementSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_AscendingSumSorting_RerurnSortedArray()
        {
            // Arange
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
            JaggedArray.Sort(input, new AscendingSumSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_DescendingSumSorting_RerurnSortedArray()
        {
            // Arange
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
            JaggedArray.Sort(input, new DescendingSumSorting());

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [Test]
        public void Sort_PassNullArray_ThrownArgumentNullException()
        {
            // Act - Assert
            Assert.Throws<ArgumentNullException>(() => JaggedArray.Sort(null, new DescendingSumSorting()));
        }

        [Test]
        public void Sort_PassEmptyArray_ThrownArgumentException()
        {
            // Arange
            int[][] input = new int[0][] { };

            // Act - Assert
            Assert.Throws<ArgumentException>(() => JaggedArray.Sort(input, new DescendingSumSorting()));
        }

        [Test]
        public void Sort_PassEmptyComparer_ThrownArgumentException()
        {
            // Arange
            int[][] input = new int[][]
            {
                new int[] { 1, -3, 5, 7, 9 },
                new int[] { 0, 2, 4, 989 },
                null,
                new int[] { 11, -22 },
                new int[0]
            };

            // Act - Assert
            Assert.Throws<ArgumentNullException>(() => JaggedArray.Sort(input, null));
        }
    }
}
