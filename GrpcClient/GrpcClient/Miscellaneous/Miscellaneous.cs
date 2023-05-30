using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrpcClient.Miscellaneous
{
    public class Misc
    {
        public static string GetPath(string relativePath)
        {
            string[] delimiters = { "bin" };
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] parts = currentDirectory.Split(delimiters, StringSplitOptions.None);

            string fullPath = Path.Combine(parts[0], relativePath);
            return fullPath;
        }
    }
}
