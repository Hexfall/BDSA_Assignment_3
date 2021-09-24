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

        [Fact]
        public void Gets_First_Sith_Lord_Appearance()
        {
            // Arrange & Act
            int year = FirstAppearanceOfSith();

            // Assert
            Assert.Equal(1977, year);
        }

        [Fact]
        public void Gets_Unique_Wizards_From_HP()
        {
            // Arrange
            HashSet<(string, int)> expectedOutput = new HashSet<(string, int)> {
                ("Harry Potter", 1997),
                ("Hermione Granger", 1997),
                ("Ron Weasley", 1997),
                ("Severus Snape", 1997),
                ("Dumbledore", 1997),
            };

            // Act
            var output = WizardsFromProperty("Harry Potter");

            // Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Groups_By_Creator()
        {
            // Arrange
            IEnumerable<(string, IEnumerable<string>)> expectedOutput = (IEnumerable<(string, IEnumerable<string>)>) new (string, IEnumerable<string>)[] {
                ("T.H. White", (IEnumerable<string>)new string[] { "Merlin" }),
                ("J.R.R. Tolkien", (IEnumerable<string>)new string[] {
                    "Sauron",
                    "Sauroman",
                    "Radagast",
                    "Gandalf",
                }),
                ("J.K.Rowling", (IEnumerable<string>)new string[] {
                    "Severus Snape",
                    "Ron Weasley",
                    "Hermione Granger",
                    "Harry Potter",
                    "Dumbledore",
                }),
                ("George Lucas", (IEnumerable<string>)new string[] {
                    "Yoda",
                    "Darth Vader",
                    "Darth Sidius",
                    "Darth Plagueis",
                    "Darth Maul",
                }),
            };

            // Act
            var output = WizardsByCreators();

            // Assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
