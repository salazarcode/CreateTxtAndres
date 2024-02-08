using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClass
{
    public class Reader
    {
        public static void ReadFileContent(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("This is the file content: " + content);
            }
            else
            {
                Console.WriteLine("The file doesn't exist.");
            }
        }
    }
}
