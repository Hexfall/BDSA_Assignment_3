using System;
using Xunit;
using System.Linq;

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
            // Arrange & Act
            var output = new stringConverter((string s) => s.ToCharArray().Aggregate("", (agg, cur) => cur + agg))(org);

            // Assert
            Assert.Equal(expected, output);
        }
    }
}
