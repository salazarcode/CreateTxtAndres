using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{
    public class Reader
    {
        public static string ReadFileContent(string filePath)
        {
            string content;

            if (!File.Exists(filePath))
            {
                throw new Exception("File not found."); 
            }

            content = File.ReadAllText(filePath);

            return content;
        }
    }
}
