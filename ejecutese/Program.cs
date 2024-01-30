using FileManipulation;
using System.IO;

namespace ejecutese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                    throw new Exception("Arguments error.");

                string command = args[0];
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                switch (command)
                {
                    case "create":
                        var createPath = Path.Combine(desktopPath, args[1]);
                        bool created = FileGenerator.CreateTextFile(createPath, args[2]);
                        Console.WriteLine(created ? "The file was created successfully..." : "The file already exists...");
                        break;

                    case "read":
                        var readpath = Path.Combine(desktopPath, args[1]);
                        var res = Reader.ReadFileContent(readpath);
                        Console.WriteLine(res);
                        break;

                    default:
                        Console.WriteLine("Command not found.");
                        break;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
