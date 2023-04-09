using System;
using System.Collections.Generic;
using System.IO;
using esharp.solidity.transpiler.Models;

namespace esharp.solidity.transpiler
{
    public class Lexer
    {
        private readonly string _source;
        
        public Lexer(string source)
        {
            _source = source;
        }

        public IList<Tokens> Lex()
        {
            // source must be a .sol file
            List<Tokens> tokens = new List<Tokens>();

            if (!File.Exists(_source))
            {
                throw new FileNotFoundException("File not found", _source);
            }

            var lines = File.ReadAllLines(_source);
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

        public IList<Function> FindFunctions()
        {
            if (!File.Exists(_source))
            {
                throw new FileNotFoundException("File not found", _source);
            }

            List<Function> functions = new List<Function>();

            String[] lines = File.ReadAllLines(_source);

            for(int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.Trim().StartsWith("public"))
                {
                    string nextLine = lines[i + 1];
                    if (nextLine.Trim().StartsWith("{"))
                    {
                        Function function = new Function();
                        function.ReturnType = nextLine.Trim().Split(' ')[1];
                        function.Name = line.Trim().Split(' ')[2];
                        
                        // function.Parameters = nextLine.Trim().Split(' ')[3];
                        // function.Body = lines[i + 2];
                        functions.Add(function);
                    }
                }
            }

            return functions;
        }

        public void FindModifiers(List<String> lines)
        {

        }
    }
}
