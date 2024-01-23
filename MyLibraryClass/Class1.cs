using System;
using System.IO;

namespace MyLibraryClass
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

    public class Messages
    {
        public static void FinalMessage(bool result)
        {
            string success = "The file was created successfully...";
            string alreadyCreated = "The file already exists...";

            Console.WriteLine(result ? success : alreadyCreated);
        }
    }
}
