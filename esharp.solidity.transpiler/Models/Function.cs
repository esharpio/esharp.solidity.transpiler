using System;

namespace esharp.solidity.transpiler.Models
{
    public class Function
    {
        public string Name { get; set; }
        public string ReturnType { get; set; }
        public string Parameters { get; set; }
        public string Body { get; set; }
    }
}