using System;
using System.Linq;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                var line = Console.ReadLine().Split(" ");
                string path = line.Last();
                string name = default;
                name = path.Substring(0, path.Length - 4);


                if (line[0] == "--create" || line[0] == "--save" )
                {
                    path += line[1];
                    name = line[1].Substring(0, line[1].Length - 4);
                }               
                
                AbstractHandler file = Path.GetExtension(path) switch
                {
                    ".txt" => new TXTHandler(),
                    ".doc" => new DOCHandler(),
                    ".xml" => new XMLHandler(),
                    _ => throw new Exception("Invalid format of document.")
                };
                

                switch (line[0])
                {
                    case "--open":
                            file.Open(path, name);
                        break;
                    case "--change":
                        file.Change(path, name);
                        break;
                    case "--create":
                        file.Create(path, name);
                        break;
                    case "--save":
                        file.Save(path, name);
                        break;
                    default:
                        Empty();
                        break;

                }

                Console.WriteLine("\n");
            }


        }

        static void Empty()
        {
            Console.WriteLine("Error! \nUsage: [options] [file extension(optional)] [directory]");
            Exemple();
        }
        static void Exemple()
        {
            Console.WriteLine("\nExemple --open C:\\Downloads\\cheats_for_gta.txt");

        }
        static void Help()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("-o, --open \t| Open file");
            Console.WriteLine("-cr, --create \t| Create file");
            Console.WriteLine("-cg, --change \t| Change file");
            Console.WriteLine("-s, --save \t| Save file");
            Exemple();
        }
    }
}
