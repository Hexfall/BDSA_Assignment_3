using System;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public delegate string stringConverter(string s);
    public class DelegatesTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcba")]
        [InlineData("Jeg heder viktor og jeg programmerer, fordi jeg er en stor dreng!", "!gnerd rots ne re gej idrof ,reremmargorp gej go rotkiv redeh geJ")]
        public void Test1(string org, string expected)
        {
            // Arrange
            stringConverter reverser = new stringConverter((string s) => throw new NotImplementedException());

            // Act
            var output = reverser(org);

            // Assert
            Assert.Equal(expected, output);
        }
    }
}
