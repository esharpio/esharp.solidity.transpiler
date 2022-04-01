using System;
using System.Collections.Generic;
using Xunit;

namespace esharp.solidity.transpiler.tests
{
    public class TranspilerTest
    {
        [Fact]
        public void Should_Lex_Contract()
        {
            // Arrange
            string source = "public contract Greeter";
            Lexer lexer = new Lexer();
            IList<String> tokens = lexer.Lex(source);

            // // Act
            // var transpiler = new Transpiler();
            // var result = transpiler.Transpile(source);

            // // Assert
            // Assert.Equal(4, tokens.Count);
            // Assert.Equal("contract", tokens[0]);
            // Assert.Equal("test", tokens[1]);
            // Assert.Equal("{", tokens[2]);
            // Assert.Equal("}", tokens[3]);
            // Assert.Equal("", result);
        }
    }
}
