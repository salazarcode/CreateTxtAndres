using System;
using System.IO;

class Test
{
    public static void Main(string[] args)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path = $"{desktopPath}\\{args[0]}";

        string success = "The file was created successfully.";
        string alreadyCreated = "The file already exist.";


        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(args[1]);
                Console.WriteLine(success);
            }
        }
        else
        {
            Console.WriteLine(alreadyCreated);
        }
    }
}