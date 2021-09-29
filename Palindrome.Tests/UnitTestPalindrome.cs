using Xunit;


namespace Palindrome.Tests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("This is not a palindrome.", false)]
        [InlineData("A car, a man, a maraca.", true)]
        [InlineData("Barge in! Relate mere war of 1991 for a were-metal Ernie grab!", true)]
        [InlineData("Bombard a drab mob.", true)]
        [InlineData("The rain in Main falls mainly in the plain.", false)]
        [InlineData("Goldenrod-adorned log", true)]
        [InlineData("Golf? No sir, prefer prison-flog", true)]
        [InlineData("Golf? No sire, prefer prison-flog", false)]
        [InlineData("Margot trades used art to gram.", true)]
        [InlineData("May a moody baby doom a yam?", true)]
        public void palindrome_theory_test(string stringToTest, bool expectedResult)
        {
            // Arrange
            bool actualResult = false;

            // Act
            var palindrome = new PalindromeValidator();
            actualResult = palindrome.IsPalindrome(stringToTest);

            // Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
