using System;
using System.IO;

namespace CreateSantiagoInstanceTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopPath, args[0]);

            bool created = MyLibraryClass.FileGenerator.CreateTextFile(path, args[1]);

            MyLibraryClass.Messages.FinalMessage(created);
        }
    }
}
