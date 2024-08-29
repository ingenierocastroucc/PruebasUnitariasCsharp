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
            var strOperations = new StringOperations();

            var result = strOperations.ConcatenateStrings("Hola", "Pedro");

            Assert.Equal("Hola Pedro", result);
        }
    }
}
