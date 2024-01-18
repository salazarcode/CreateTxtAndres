using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path = $"{desktopPath}\\Santiago.txt";

        string text = "Hola Mundo!";

        string success = "The file was created successfully.";
        string alreadyCreated = "The file already exist.";


        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(text);
                Console.WriteLine(success);
            }

        }
        else
        {
            Console.WriteLine(alreadyCreated);
        }
    }
}