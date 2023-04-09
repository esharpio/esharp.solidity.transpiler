using System;
using System.Collections.Generic;
using Xunit;
using esharp.solidity.transpiler.Models;

namespace esharp.solidity.transpiler.tests
{
    public class LexerTest
    {
        [Fact]
        public void Should_Lex_Contract()
        {
            // Arrange
            string source = @"Examples/Greeter.es";
            Lexer lexer = new Lexer(source);

            // Act
            IList<Tokens> tokens = lexer.Lex();

            // Assert
            Assert.Equal(10, tokens.Count);
        }

        [Fact]
        public void Should_Find_One_Function()
        {
            // Arrange
            string source = @"Examples/Greeter.es";
            Lexer lexer = new Lexer(source);

            // Act
            IList<Function> functions = lexer.FindFunctions();

            // Assert
            Assert.Equal(1, functions.Count);

            Assert.Equal("setGreeting", functions[0].Name);
        }
    }
}