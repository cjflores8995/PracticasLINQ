using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    class Generacion
    {
        public void Generar()
        {
            // DefaultIfEmpty()

            using (var db = new CursosVirtualesEntities())
            {
                Cursos cursoPorDefecto = new Cursos
                {
                    CursoId = 0,
                    Nombre = "Sin curso",
                    Idioma = "Sin idioma",
                    Precio = 0,
                    FechaRegistro = DateTime.MinValue,
                    FechaModificacion = DateTime.MinValue,
                    Estado = false
                };

                //var cursos = db.Cursos
                //    .Where(x => x.Precio > 1000)
                //    .Take(5);

                //foreach(var curso in cursos.AsEnumerable().DefaultIfEmpty(cursoPorDefecto))
                //{
                //    Console.WriteLine($"Id: {curso.CursoId}, " +
                //        $"Nombre: {curso.Nombre}, " +
                //        $"Idioma: {curso.Idioma}, " +
                //        $"Precio: {curso.Precio.ToString("C2")}");
                //}

                // Empty()

                //var vacio = Enumerable.Empty<int>();

                //Console.WriteLine(vacio.Count());

                // Range()

                //var numeros = Enumerable.Range(50, 10);

                //foreach(var numero in numeros)
                //{
                //    Console.WriteLine(numero);
                //}

                // Repeat()

                var curso = Enumerable.Repeat(cursoPorDefecto, 5);

                foreach(var c in curso)
                {
                    Console.WriteLine(c.Nombre);
                }
            }
        }
    }
}
