using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{
    public class FileGenerator
    {
        public static bool CreateTextFile(string path, string text)
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
