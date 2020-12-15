using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQConsola.Fuentes
{
    public class LinqToXml
    {
        // Leer un archivo Existente
        public static void LeerXmlExistente()
        {
            string rutaArchivo = "../../Archivos/Empleados.xml";

            var xml = XDocument.Load(rutaArchivo);

            var empleados = xml.Element("Empresa").Elements("Empleado");

            foreach(var empleado in empleados)
            {
                Console.WriteLine($"NOMBRES: {empleado.Element("Nombre").Value} {empleado.Element("Apellido").Value}\n" +
                    $"TELÉFONO: {empleado.Element("ContactNo").Value}\n" +
                    $"EMAIL: {empleado.Element("Email").Value}");

                var direcciones = empleado.Elements("Direccion").ToArray()[0];

                Console.WriteLine($"DIRECCIONES:\n" +
                    $"\tCIUDAD: {direcciones.Element("Ciudad").Value}\n" +
                    $"\tESTADO: {direcciones.Element("Estado").Value}");

                Console.WriteLine(Environment.NewLine);
            }
        }

        //Crear un XML a partir de los primeros 10 cursos
        public static void CrearXml()
        {
            using (var db = new CursosVirtualesEntities())
            {
                //IEnumerable<Cursos> cursos = db.Cursos.Take(10).ToList();

                //XDocument documentoXml = new XDocument(
                //    new XDeclaration("1.0", "utf-8", "yes"),
                //    new XComment("Documento generado a partir de la tabla cursos"),

                //    new XElement("Cursos",

                //    from curso in cursos

                //    select new XElement("Curso", new XAttribute("Id", curso.CursoId),
                //    new XElement("NombreCurso", curso.Nombre),
                //    new XElement("Idioma", curso.Idioma),
                //    new XElement("Precio", curso.Precio),
                //    new XElement("FechaRegistro", curso.FechaRegistro),
                //    new XElement("FechaModificacion", curso.FechaModificacion),
                //    new XElement("Estado", curso.Estado))
                //    )
                //    );

                //documentoXml.Save("../../Archivos/Cursos.xml");

                //Console.WriteLine("Documento xml generado correctamente.");
            }
        }

        // Agregar
        public static void Agregar()
        {
            XDocument xDocument = XDocument.Load("../../Archivos/Cursos.xml");

            //xDocument.Element("Cursos").Add(
            //    new XElement("Curso", new XAttribute("Id", 11),
            //        new XElement("NombreCurso", "TRabajando con Linq y Xml"),
            //        new XElement("Idioma", "español"),
            //        new XElement("Precio", 79.99),
            //        new XElement("FechaRegistro", DateTime.UtcNow),
            //        new XElement("FechaModificacion", DateTime.UtcNow),
            //        new XElement("Estado", true))
            //    );

            //Agregar al principio
            //xDocument.Element("Cursos").AddFirst(
            //    new XElement("Curso", new XAttribute("Id", 12),
            //        new XElement("NombreCurso", "Aprende Xml con C#"),
            //        new XElement("Idioma", "ingles"),
            //        new XElement("Precio", 99.52),
            //        new XElement("FechaRegistro", DateTime.UtcNow),
            //        new XElement("FechaModificacion", DateTime.UtcNow),
            //        new XElement("Estado", true))
            //    );

            // Agregar antes de un elemento específico
            //xDocument.Element("Cursos").Elements("Curso")
            //    .Where(x => x.Attribute("Id").Value == "1").FirstOrDefault()
            //    .AddBeforeSelf(
            //    new XElement("Curso", new XAttribute("Id", 13),
            //        new XElement("NombreCurso", "Curso agregado antes de Programacion orientada a objetos"),
            //        new XElement("Idioma", "latin"),
            //        new XElement("Precio", 12.99),
            //        new XElement("FechaRegistro", DateTime.UtcNow),
            //        new XElement("FechaModificacion", DateTime.UtcNow),
            //        new XElement("Estado", true))
            //    );

            // Agregar despues de un elemento específico
            xDocument.Element("Cursos").Elements("Curso")
                .Where(x => x.Attribute("Id").Value == "1").FirstOrDefault()
                .AddAfterSelf(
                new XElement("Curso", new XAttribute("Id", 14),
                    new XElement("NombreCurso", "Curso agregado despues de P.O.O"),
                    new XElement("Idioma", "español"),
                    new XElement("Precio", 59.99),
                    new XElement("FechaRegistro", DateTime.UtcNow),
                    new XElement("FechaModificacion", DateTime.UtcNow),
                    new XElement("Estado", true))
                );


            xDocument.Save("../../Archivos/Cursos.xml");

            Console.WriteLine("Nodo agregado correctamente.");
        }

        //Eliminar

        public static void Eliminar()
        {
            XDocument xDocument = XDocument.Load("../../Archivos/Cursos.xml");

            xDocument.Root.Elements()
                .Where(x => x.Attribute("Id").Value == "14")
                .FirstOrDefault()
                .Remove();

            xDocument.Save("../../Archivos/Cursos.xml");

            Console.WriteLine("Nodo eliminado correctamente.");
        }

        // Actualizar
        public static void Actualizar()
        {
            XDocument xDocument = XDocument.Load("../../Archivos/Cursos.xml");

            xDocument.Element("Cursos").Elements("Curso")
                .Where(x => x.Attribute("Id").Value == "1")
                .FirstOrDefault()
                .SetElementValue("NombreCurso", "Object-oriented programming");

            xDocument.Save("../../Archivos/Cursos.xml");

            Console.WriteLine("Nodo actualizado correctamente.");
        }
    }
}
