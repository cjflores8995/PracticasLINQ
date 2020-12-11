using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    class Particionado
    {
        public void Particionar()
        {
            using (var db = new CursosVirtualesEntities())
            {
                // Take()

                //seleccionar los primeras 5 cursos e imprimiremos id, nombre, idioma, precio

                //var cursos = db.Cursos.Take(5);

                //foreach (var c in cursos)
                //{
                //    Console.WriteLine($"ID: {c.CursoId}, NOMBRE: {c.Nombre}, IDIOMA: {c.Idioma}, PRECIO: {c.Precio}");
                //}

                // TakeWhile()

                //var cursos = db.Cursos.AsEnumerable().TakeWhile(c => c.Idioma.Equals("ingles")).ToList();

                //foreach (var c in cursos)
                //{
                //    Console.WriteLine($"ID: {c.CursoId}, NOMBRE: {c.Nombre}, IDIOMA: {c.Idioma}, PRECIO: {c.Precio}");
                //}

                // Skip() 

                //var cursos = db.Cursos.AsEnumerable().Skip(5);

                //foreach (var c in cursos)
                //{
                //    Console.WriteLine($"ID: {c.CursoId}, NOMBRE: {c.Nombre}, IDIOMA: {c.Idioma}, PRECIO: {c.Precio}");
                //}

                // SkipWhile()

                var cursos = db.Cursos.AsEnumerable()
                    .SkipWhile(c => c.Idioma.Equals("ingles"));

                foreach (var c in cursos)
                {
                    Console.WriteLine($"ID: {c.CursoId}, NOMBRE: {c.Nombre}, IDIOMA: {c.Idioma}, PRECIO: {c.Precio}");
                }
            }
        }
    }
}
