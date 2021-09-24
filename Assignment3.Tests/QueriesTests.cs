using System;
using Xunit;
using System.Collections.Generic;
using static BDSA2020.Assignment03.Queries;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Finds_Wizards_By_Rowling()
        {
            // Arrange & Act
            var wiz = WizardsByAuthor("J.K.Rowling");
            
            // Assert
            Assert.Equal(new HashSet<string> { "Harry Potter", "Hermione Granger", "Ron Weasley", "Severus Snape", "Dumbledore" }, new HashSet<string> (wiz));
        }
    }
}
