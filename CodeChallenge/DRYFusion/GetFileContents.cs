using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DRYFusion
{
    internal static class GetFileContents
    {
        internal static bool TryGetFileLines(string filePath, out string[] fileLines)
        {
            bool fileExists = File.Exists(filePath);
            if (fileExists)
            {
                fileLines = File.ReadAllLines(filePath);
            }
            else
            {
                fileLines = new string[] { "Invalid File" };
            }
            return fileExists;
        }
    }
}
