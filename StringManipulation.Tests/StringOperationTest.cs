using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using Moq;
using Microsoft.Extensions.Logging;

namespace StringManipulation.Tests
{
    public class StringOperationTest
    {
        [Fact (Skip = "Se omite prueba unitaria con la finalidad de mostrar la funcionalidad de Skip, Ticket-001")]
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

        [Fact]
        public void QuantintyInWords()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.QuantintyInWords("Exec", 7);
            //Assert
            Assert.StartsWith("siete", result);
            Assert.Contains("Exec", result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            //Para esta funcion en particular se dispara una excepcion por lo tanto no puede llevarse acabo el AAA
            //Assert
            Assert.ThrowsAny<ArgumentNullException>(()=>strOperations.GetStringLength(null));
        }

        [Fact]
        public void GetStringLength_String()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var stringText = "Pedro";

            var lengthText = strOperations.GetStringLength(stringText); ;

            //Assert
            Assert.Equal(stringText.Length, lengthText);
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        public void FromRomanToNumber(string numeroRomano, int numero)
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.FromRomanToNumber(numeroRomano);
            //Assert
            Assert.Equal(numero, result);
        }

        [Fact]
        public void CountOccurrences()
        {
            //Arrange

            var mockLogger = new Mock<ILogger<StringOperations>>();

            var strOperations = new StringOperations(mockLogger.Object);

            var result = strOperations.CountOccurrences("Hola Karol", 'a'); ;

            //Assert
            Assert.Equal(2, result);
        }
    }
}
