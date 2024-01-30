using FileManipulation;
using System.IO;

namespace ejecutese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = args[0];
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            switch (command)
            {
                case "create":
                    bool created = FileGenerator.CreateTextFile(Path.Combine(desktopPath, args[1]), args[2]);
                    Console.WriteLine(created ? "The file was created successfully..." : "The file already exists...");
                    break;

                case "read":
                    var res = Reader.ReadFileContent(Path.Combine(desktopPath, args[1]));
                    Console.WriteLine(res);
                    break;

                default:
                    Console.WriteLine("Command not found.");
                    break;
            }
        }
    }
}
