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

    public class Reader
    {
        public static void ReadFileContent(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                WriteLine.PrintMessage("This is the file content: " + content);
            }
            else
            {
                WriteLine.PrintMessage("The file doesn't exist.");
            }
        }
    }

    public class Messages
    {
        public static void FinalMessage(bool result)
        {
            string success = "The file was created successfully...";
            string alreadyCreated = "The file already exists...";

            WriteLine.PrintMessage(result ? success : alreadyCreated);
        }
    }

    public class WriteLine
    {
        public static void PrintMessage(string messageText)
        {
            Console.WriteLine(messageText);
        }
    }
}
