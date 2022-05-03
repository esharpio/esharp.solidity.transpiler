using System;
using System.IO;

namespace esharp.solidity.transpiler
{
    public class Transpiler
    {
        private readonly string _source;

        public Transpiler(String filePath)
        {
            // todo: set solidity version
            if (File.Exists(filePath))
            {
                _source = File.ReadAllText(filePath);
                var source = new FileInfo(filePath);

                // check source extension is .es
                if (source.Extension != ".es")
                {
                    throw new Exception("Source file must have .es extension");
                }
            }
            else
            {
                throw new FileNotFoundException(filePath);
            }
        }

        public string Transpile(string source)
        {
            return "";
        }

        public void AddLicense()
        {
            
        }
    }
}
