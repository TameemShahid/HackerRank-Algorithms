using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using HackerRank_Algorithms._1_Compare_The_Triplets;

namespace Algorithm_Tests._1_Compare_The_Triplets
{
    public class Tests
    {
        [Theory]
        [InlineData("17 28 30", "99 16 8", "2 1")]
        [InlineData("5 6 7", "3 6 10", "1 1")]
        public void Test(string input1, string input2, string answer)
        {
            // Arrange
            List<int> a = input1.Split(' ').ToList().Select(value => Convert.ToInt32(value)).ToList();
            List<int> b = input2.Split(' ').ToList().Select(value => Convert.ToInt32(value)).ToList();

            // Act
            List<int> result = CompareTheTriplets.compareTriplets(a, b);

            // Assert
            List<int> expected = answer.Split(' ').ToList().Select(value => Convert.ToInt32(value)).ToList();
            Assert.Equal(expected, result);
        } 
    }
}
