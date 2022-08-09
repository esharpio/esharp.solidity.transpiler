using System;
using System.Collections.Generic;
using System.IO;

namespace esharp.solidity.transpiler
{
    public class Lexer
    {
        private readonly string _source;
        
        public Lexer()
        {
        }

        public IList<Tokens> Lex(string source)
        {
            // source must be a .sol file
            List<Tokens> tokens = new List<Tokens>();

            if (!File.Exists(source))
            {
                throw new FileNotFoundException("File not found", source);
            }

            var lines = File.ReadAllLines(source);
            foreach(string line in lines)
            {
                string[] words = line.Split(' ');

                foreach(string word in words)
                {
                    switch(word)
                    {
                        case "contract":
                            tokens.Add(Tokens.Contract);
                            break;
                        case "public":
                            tokens.Add(Tokens.Public);
                            break;
                        case "private":
                            tokens.Add(Tokens.Private);
                            break;
                        case "(":
                            tokens.Add(Tokens.LParen);
                            break;
                        case ")":
                            tokens.Add(Tokens.RParen);
                            break;
                        case "{":
                            tokens.Add(Tokens.LBrace);
                            break;
                        case "}":
                            tokens.Add(Tokens.RBrace);
                            break;
                        case "modifier":
                            tokens.Add(Tokens.Modifier);
                            break;
                        default:
                            break;
                    }
                }
            }

            return tokens;
        }

        public void FindFunctions(string source)
        {

        }

        public void FindModifiers(List<String> lines)
        {

        }
    }
}
