using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path = $"{desktopPath}\\Santiago.txt";
        
        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hola Mundo!");

                Console.WriteLine("The file was created successfully.");
            }

        }
        else
        {
            Console.WriteLine("The file already exist.");
        }
    }
}