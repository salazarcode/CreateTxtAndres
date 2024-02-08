using ejecutese.DTOs;
using FileManipulation;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
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

                        if (readpath.Contains(".csv"))
                        {
                            var lista = new List<Persona>();

                            var cantidadLineas = res.Split("\n").Length;

                            var lineas = res.Split("\n");

                            for (int i = 1; i < cantidadLineas; i++)
                            {
                                var valores = lineas[i].Split(",");

                                var persona = new Persona
                                {
                                    ID = int.Parse(valores[0]),
                                    Nombre = valores[1],
                                    Apellido = valores[2],
                                    Edad = int.Parse(valores[3]),
                                    CorreoElectronico = valores[4]
                                };

                                lista.Add(persona);
                            }

                            string serialized = JsonConvert.SerializeObject(lista);

                            Console.WriteLine(serialized);
                        }
                        else
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
