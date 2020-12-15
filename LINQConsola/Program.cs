using LINQConsola.Fuentes;
using LINQConsola.Operadores;
using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cadena = "Bienvenidos      al    curso      de   LINQ     desde   cero hasta     experto.       ";

            //Console.WriteLine(LinqToString.EliminarEspacios(cadena));

            //string text = @"Historically, the world of data and the world of objects" +
            //  @" have not been well integrated. Programmers work in C# or Visual Basic" +
            //  @" and also in SQL or XQuery. On the one side are concepts such as classes," +
            //  @" objects, fields, inheritance, and .NET APIs. On the other side" +
            //  @" are tables, columns, rows, nodes, string and separate languages for dealing with" +
            //  @" them. Data types often require translation between the two worlds; there are" +
            //  @" different standard functions. Because string the object world has string no notion of query, a" +
            //  @" query can only be represented as a string without compile-time type checking or" +
            //  @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
            //  @" objects in memory is often tedious and error-prone.";

            //var repeticiones = LinqToString.RepeticionesPalabra("sql", text);

            //Console.WriteLine(repeticiones);

            //LinqToString.ReordenarListado("../../Archivos/Listado.csv");

            //var ensamblado = new LinqToReflection("MiLibreria");

            //ensamblado.GetInfo();

            //LinqToFileDirectories.BuscarArchivosEnDirectorios(@"C:\xampp", ".jpg");

            //LinqToFileDirectories.ObtenerTotalBytesCarpeta(@"C:\xampp");

            //LinqToFileDirectories.BuscarTextoEnArchivos("../../Archivos/", "visual studio", ".txt");

            //LinqToXml.LeerXmlExistente();

            //LinqToXml.CrearXml();

            //LinqToXml.Agregar();

            //LinqToXml.Eliminar();

            //LinqToXml.Actualizar();

            //LinqToObject.LinqConObjectos();

            //LinqToArrayList.ObtenerEstudiantes();

            //LinqToSql.Agregar();

            //LinqToSql.Actualizar(127);

            //LinqToSql.Eliminar(127);

            //LinqToDataSets.LinqConDataSets();

            int[] enteros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var elementosAlternados = enteros.AlternateElements();

            foreach(var elemento in elementosAlternados)
            {
                Console.WriteLine(elemento);
            }

            Console.ReadKey();
        }
    }
}
