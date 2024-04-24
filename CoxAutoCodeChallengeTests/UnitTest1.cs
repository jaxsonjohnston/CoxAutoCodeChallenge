using CoxAutoCodeChallenge;
using FluentAssertions;

namespace CoxAutoCodeChallengeTests
{
    public class UnitTests
    {
        private CodeChallengeClass _codeChallengeClass;

        public UnitTests() 
        {
            _codeChallengeClass = new CodeChallengeClass();
        }

        [Fact]
        public void TestFormatInput1()
        {
            // Arrange
            string fakeInput = "It was many and many a year ago";
            string expectedOuput = "I0t w1s m2y a1d m2y a y2r a1o";
             
            // Act
            var actual = _codeChallengeClass.FormatInput(fakeInput);

            // Assert
            actual.Should().BeEquivalentTo(expectedOuput);
        }

        [Fact]
        public void TestFormatInput2()
        {
            // Arrange
            string fakeInput = "Copyright,Microsoft:Corporation";
            string expectedOuput = "C7t,M6t:C6n";

            // Act
            var actual = _codeChallengeClass.FormatInput(fakeInput);

            // Assert
            actual.Should().BeEquivalentTo(expectedOuput);
        }

        [Fact]
        public void TestFormatInput3()
        {
            // Arrange
            string fakeInput = "Here I am, once again, I'm torn into pieces";
            string expectedOuput = "H2e I a0m, o2e a3n, I'm t2n i2o p3s";

            // Act
            var actual = _codeChallengeClass.FormatInput(fakeInput);

            // Assert
            actual.Should().BeEquivalentTo(expectedOuput);
        }
    }
}