using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment03.Tests
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

        [Fact]
        public void Filters_By_7_And_42()
        {
            // Arrange
            Predicate<int> pred = (num) => num % 7 == 0 && num > 42;
            int[] ys = { 1, 7, 24, 25, 42, 45, 49, 52, 56, 70, 71 };

            // Act
            var output = ys.Filter(pred);

            // Assert
            Assert.Equal(new int[] { 49, 56, 70 }, output);
        }

        [Fact]
        public void Filters_By_Leap_Years()
        {
            // Arrange
            Predicate<int> pred = (year) => year % 400 == 0 || year % 4 == 0 ^ year % 100 == 0;
            int[] ys = { 101, 100, 400, 510, 512, 1500, 1600, 1604, 1700 };

            // Act
            var output = ys.Filter(pred);

            // Assert
            Assert.Equal(new int[] { 400, 512, 1600, 1604 }, output);
        }

        [Fact]
        public void IsSecure_Returns_True_For_HTTPS()
        {
            // Arrange
            Uri uri = new("https://google.com");

            // Act
            var output = uri.IsSecure();

            // Assert
            Assert.True(output);
        }

        [Fact]
        public void IsSecure_Returns_False_For_HTTP()
        {
            // Arrange
            Uri uri = new("http://google.com");

            // Act
            var output = uri.IsSecure();

            // Assert
            Assert.False(output);
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(0, "!")]
        [InlineData(1, "hej")]
        [InlineData(2, "hej. jeg")]
        [InlineData(2, "hej . . heder")]
        [InlineData(3, "hej ... jeg, heder !!")]
        [InlineData(7, "Wherefore art, thou Romeo? Ya dang,, man !?!")]
        public void WordCount_Returns_Correctly_For_Sample_Strings(int words, string str)
        {
            // Act & Assert
            Assert.Equal(words, str.WordCount());
        }
    }
}
