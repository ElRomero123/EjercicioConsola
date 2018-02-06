using System;
using System.IO;

namespace CommandPrompt
{
    class Consola
    {
        private DirectoryInfo Directorio;
        private String Opcion;

        public Consola(string ruta)
        {
            this.Directorio = new DirectoryInfo(ruta);
        }

        public void Mostrar()
        {
            Console.WriteLine(Directorio.FullName + " >");
            Opcion = Console.ReadLine();
            Ejecutar();
        }

        private void Ejecutar()
        {
            switch (Opcion)
            {
                case "dir":

                    FileInfo[] Archivos = Directorio.GetFiles();

                    for (int i = 0; i < Archivos.Length; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Archivos[i].FullName + ":::::::::::::::::::::::" + Archivos[i].CreationTime);
                    }

                    break;


                case "cd ..":

                    Directorio = new DirectoryInfo(Directorio.Parent.FullName);

                    break;


                case "cd /":

                    Directorio = new DirectoryInfo(Directorio.Root.FullName);

                    break;


                case "cd":

                    Console.Write("Especifique el directorio: ");
                    Directorio = new DirectoryInfo(Console.ReadLine());

                    break;

                case "cls":

                    Console.Clear();

                    break;

                case "color azul":

                    Console.ForegroundColor = ConsoleColor.Blue;

                    break;

                case "color rojo":

                    Console.ForegroundColor = ConsoleColor.Blue;

                    break;

                case "color verde":

                    Console.ForegroundColor = ConsoleColor.Green;

                    break;

                case "del":

                    Console.Write("Especifique el fichero: ");
                    FileInfo Archivo = new FileInfo(Console.ReadLine());
                    Archivo.Delete();

                    break;

               /* Pendiente esta funcionalidad
                case "compress":

                    Console.Write("Especifique el fichero: ");
                    FileInfo Archivo1 = new FileInfo(Console.ReadLine());

                    break;

               */

            }
        }
    }
}
