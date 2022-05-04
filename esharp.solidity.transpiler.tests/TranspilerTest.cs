using System;
using System.Collections.Generic;
using Xunit;

namespace esharp.solidity.transpiler.tests
{
    public class TranspilerTest
    {
        [Fact]
        public void Should_Add_License_And_Pragma()
        {
            // Arrange
            string source = @"Examples/Greeter.es";

            // Act
            Transpiler transpiler = new Transpiler(source);

            // Assert
            Assert.Equal(3, transpiler.Lines.Count);
            Assert.Equal(@"// SPDX-License-Identifier: Unlicense", transpiler.Lines[0]);
            Assert.Equal(@"pragma solidity ^0.8.0;", transpiler.Lines[2]);
        }

        [Fact]
        public void Should_Transform_Imports()
        {
            // Arrange
            string source = @"Examples/Greeter.es";
            Transpiler transpiler = new Transpiler(source);

            // Act
            transpiler.TransformImports();

            // Assert
            Assert.Equal(4, transpiler.Lines.Count);
            Assert.Equal(@"import ""hardhat/console.sol"";", transpiler.Lines[3]);
        }
    }
}
