using System;
using Xunit;
using System.Linq;

namespace BDSA2020.Assignment03.Tests
{
    public delegate string stringConverter(string s);
    public delegate decimal decimalManipulator(decimal d1, decimal d2);
    public class DelegatesTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcba")]
        [InlineData("Jeg heder viktor og jeg programmerer, fordi jeg er en stor dreng!", "!gnerd rots ne re gej idrof ,reremmargorp gej go rotkiv redeh geJ")]
        public void String_Reversal_Works_On_Sample_Strings(string org, string expected)
        {
            // Arrange & Act
            var output = new stringConverter((string s) => s.ToCharArray().Aggregate("", (agg, cur) => cur + agg))(org);

            // Assert
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData(1.1d, 1.0d, 1.1d)]
        [InlineData(1.1d, 1.1d, 1.21d)]
        [InlineData(2d, 1.1d, 2.2d)]
        public void Decimal_Product_Returns_Correctly_For_Sample_Decimals(decimal d1, decimal d2, decimal expectedOutcome)
        {
            // Arrange & Act
            var output = new decimalManipulator((d1, d2) => throw new NotImplementedException())(d1, d2);

            // Assert
            Assert.Equal(expectedOutcome, output);
        }
    }
}
