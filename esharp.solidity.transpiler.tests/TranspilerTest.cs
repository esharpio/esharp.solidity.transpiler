using System;
using System.Collections.Generic;
using Xunit;

namespace esharp.solidity.transpiler.tests
{
    public class TranspilerTest
    {
        [Fact]
        public void Should_Transform_Imports()
        {
            // Arrange
            string source = @"Examples/Greeter.es";
            Transpiler transpiler = new Transpiler(source);

            // Act
            transpiler.TransformImports();

            // Assert
            Assert.Equal(1, transpiler.Lines.Count);
            Assert.Equal(@"import ""hardhat/console.sol"";", transpiler.Lines[0]);
        }
    }
}
