using System;
using System.Collections.Generic;
using System.IO;

namespace esharp.solidity.transpiler
{
    public class Transpiler
    {
        private readonly string[] _source;

        public IList<String> Lines { get; private set; }

        public Transpiler(string source)
        {
            if (!File.Exists(source))
            {
                throw new FileNotFoundException("File not found", source);
            }

            _source = File.ReadAllLines(source);
            Lines = new List<String>();
        }

        public Boolean Transform()
        {
            return true;
        }

        public string TransformLicence()
        {
            return "";
        }

        public void TransformImports()
        {
            foreach (string line in _source)
            {
                if (line.StartsWith("using")) // && line.EndsWith(";")
                {
                    string result = line.Replace("using", "import");
                    result = result.Replace(".es", ".sol");
                    Lines.Add(result);
                }
            }
        }
    }
}
