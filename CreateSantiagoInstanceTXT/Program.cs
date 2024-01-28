using System;
using System.IO;

namespace CreateSantiagoInstanceTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You should introduce a name and content to your file.");
            } 
            else
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string path = Path.Combine(desktopPath, args[0]);
            
                if (args.Length == 1)
                {
                    MyLibraryClass.Reader.ReadFileContent(path);
                }
                else if(args.Length == 2)
                {
                    bool created = MyLibraryClass.FileGenerator.CreateTextFile(path, args[1]);
                    MyLibraryClass.Messages.FinalMessage(created);
                }
                else
                {
                    Console.WriteLine("To many arguments, please only introduce de file name and content.");
                };
            }
        }
    }
}
