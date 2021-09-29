using Xunit;


namespace Palindrome.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void a_santa_at_nasa()
        {
            // Arrange
            var stringToTest = "A Santa at Nasa";
            bool expectedResult = true;
            bool actualResult = false;

            // Act
            var palindrome = new PalindromeValidator();
            actualResult = palindrome.IsPalindrome(stringToTest);

            // Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
