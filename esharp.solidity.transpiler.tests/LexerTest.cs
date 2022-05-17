using System;
using System.Collections.Generic;
using Xunit;

namespace esharp.solidity.transpiler.tests
{
    public class LexerTest
    {
        [Fact]
        public void Should_Lex_Contract()
        {
            // Arrange
            string source = @"Examples/Greeter.es";
            Lexer lexer = new Lexer();

            // Act
            IList<Tokens> tokens = lexer.Lex(source);

            // Assert
            Assert.Equal(10, tokens.Count);
        }
    }
}