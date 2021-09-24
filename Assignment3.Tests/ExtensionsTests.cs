using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Flattening_Works_On_Sample()
        {
            // Arrange
            IEnumerable<int>[] xs = { new int[]{ 1, 2, 3 }, new int[]{ 4, 5 }, new int[]{ 6, 7, 8, 9 } };
            // Act
            var output = xs.Flatten();
            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, output);
        }
    }
}
