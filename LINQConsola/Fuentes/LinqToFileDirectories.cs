using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    class LinqToFileDirectories
    {
        // Buscar archivos por extensión en un directorio
        public static void BuscarArchivosEnDirectorios(string carpeta, string extension)
        {
            DirectoryInfo directorio = new DirectoryInfo(carpeta);

            IEnumerable<FileInfo> listadoArchivos = directorio.GetFiles("*.*", SearchOption.AllDirectories);

            IEnumerable<FileInfo> query = from archivo in listadoArchivos
                                          where archivo.Extension.Equals(extension)
                                          orderby archivo.Name
                                          select archivo;

            if (query.Any())
            {
                Console.WriteLine($"Se encontraron {query.Count()} archivos.\n");

                int i = 1;

                foreach(FileInfo archivo in query)
                {
                    Console.WriteLine($"{i++}. {archivo.FullName} - [{archivo.CreationTime}]");
                }
            } 
            else
            {
                Console.WriteLine($"No se encontraron archivos.\n");
            }
        }

        // Obtener el total de bytes de un conjunto de carpetas
        public static void ObtenerTotalBytesCarpeta(string carpeta)
        {
            var listaArchivos = Directory.GetFiles(carpeta, "*.*", SearchOption.AllDirectories);

            var query = from archivo in listaArchivos
                        select ObtenerLongitudArchivo(archivo);

            long[] longitudArchivos = query.ToArray();

            long totalBytes = longitudArchivos.Sum();

            Console.WriteLine($"Hay {totalBytes.ToString("C0")} bytes en {listaArchivos.Count()} archivos, dentro de {carpeta}");
        }

        private static long ObtenerLongitudArchivo(string archivo)
        {
            long longitud;

            try
            {
                FileInfo file = new FileInfo(archivo);
                longitud = file.Length;
            }
            catch (FileNotFoundException)
            {
                longitud = 0;
            }

            return longitud;
        }

        //Buscar una cadena de texto en un directorio de archivos
        public static void BuscarTextoEnArchivos(string carpeta, string terminoBusqueda, string extension)
        {
            DirectoryInfo directorio = new DirectoryInfo(carpeta);

            IEnumerable<FileInfo> listaArchivos = directorio.GetFiles("*.*", SearchOption.AllDirectories);

            var query = from archivo in listaArchivos
                        where archivo.Extension.Equals(extension)
                        let archivoTexto = BuscarEnElArchivo(archivo.FullName)
                        where archivoTexto.Contains(terminoBusqueda)
                        select archivo.FullName;

            if (query.Any())
            {
                Console.WriteLine($"El término {terminoBusqueda} fue encontrado en:\n");

                foreach(var fileName in query)
                {
                    Console.WriteLine(fileName);
                }
            } 
            else
            {
                Console.WriteLine($"El término {terminoBusqueda} no fue encontrado.");
            }


        }

        private static string BuscarEnElArchivo(string nombre)
        {
            string fileContents = string.Empty;

            if (File.Exists(nombre))
            {
                fileContents = File.ReadAllText(nombre);
            }

            return fileContents;
        }
    }
}
