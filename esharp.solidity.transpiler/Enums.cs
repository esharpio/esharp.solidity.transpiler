using System;

namespace esharp.solidity.transpiler
{
    public enum Type 
    {
        Contract,
        Interface,
        Library
    }

    public enum Tokens
    {
        Contract,
        Public,
        Private,
        LParen,
        RParen,
        LBrace,
        RBrace
    }
}