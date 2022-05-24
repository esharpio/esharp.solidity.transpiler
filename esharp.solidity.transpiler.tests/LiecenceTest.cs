using System;
using System.Collections.Generic;
using Xunit;

namespace esharp.solidity.transpiler.tests
{
    public class LicenseTest
    {
        [Fact]
        public void Should_Add_Missing_License()
        {
            // Arrange
            Transpiler lexer = new Transpiler("Examples/Greeter.es");
        }
    }
}
