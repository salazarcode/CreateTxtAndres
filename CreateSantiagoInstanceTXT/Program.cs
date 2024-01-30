using System;
using System.IO;
using FileManipulation;


namespace CreateSantiagoInstanceTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("Arguments error.");
            }

            //Se obtiene la ruta del escritorio
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Se crea la ruta del archivo. Se asume que la "ruta" introducida por el usuario es el nombre del archivo solamente
            string path = Path.Combine(desktopPath, args[0]);

            if (args.Length == 1)
            {
                //Si solo pasan una ruta, se lee el archivo
                var res = Reader.ReadFileContent(path);

                //Se imprime el contenido del archivo
                Console.WriteLine(res);
            }
            else if (args.Length == 2)
            {
                //Si pasan dos rutas, se crea el archivo
                bool created = FileGenerator.CreateTextFile(path, args[1]);

                //Se imprime el mensaje de si se creo o no el archivo
                Messages.FinalMessage(created);
            }
            else
            {
                //Si pasan mas de dos rutas, se imprime un mensaje de error
                Console.WriteLine("To many arguments, please only introduce de file name and content.");
            };
        }
    }
}
