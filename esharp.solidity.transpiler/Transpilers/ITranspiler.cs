using System;
using System.Collections.Generic;
using System.IO;

namespace esharp.solidity.transpiler
{
    public interface ITranspiler
    {
        void Transpile();
    }
}