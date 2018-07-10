using System;
using Xunit;

namespace SQLI.KataNumbersInWords.Tests
{
    public class KataNumbersTests
    {
        [Fact]
        public void Returns_Empty_String_If_param_is_null()
        {
            // Arrange
            // Act
            string result = KataNumbers.ToWords(null);
            // Assert
            Assert.Equal(String.Empty, result);
        }

        [Fact]
        public void Returns_One_for_1()
        {
            // Arrange
            string param = "1";
            // Act
            var result = KataNumbers.ToWords(param);
            // Assert
            Assert.Equal("One", result);
        }
    }
}
