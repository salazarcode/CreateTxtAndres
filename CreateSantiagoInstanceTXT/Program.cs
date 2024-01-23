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

            string success = "The file was created successfully...";
            string alreadyCreated = "The file already exists...";

            bool created = MyLibraryClass.FileGenerator.CreateTextFile(path, args[1]);

            Console.WriteLine(created ? success : alreadyCreated);
        }
    }
}
