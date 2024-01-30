using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClass
{
    public class FileGenerator
    {        public static bool CreateTextFile(string path, string text)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(text);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
