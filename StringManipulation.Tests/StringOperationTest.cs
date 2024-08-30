using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulation.Tests
{
    public class StringOperationTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.ConcatenateStrings("Hola", "Pedro");
            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hola Pedro", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.IsPalindrome("Exe");
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.IsPalindrome("Exec");
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.RemoveWhitespace("Exec ute");
            //Assert
            Assert.Equal("Execute", result);
        }
    }
}
