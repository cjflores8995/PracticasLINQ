using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    class LinqToSql
    {
        // Agregar()
        public static void Agregar()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OperadoresLINQ.Properties.Settings.CursosVirtualesConnectionString"].ToString();
            LINQToSQLDataContext dbCon = new LINQToSQLDataContext(connectionString);

            Cursos nuevoCurso = new Cursos { 
                Nombre = "Aprendiendo Linq to SQL",
                Idioma = "español",
                Precio = 45.99,
                FechaRegistro = DateTime.UtcNow,
                FechaModificacion = DateTime.Now,
                Estado = true
            };

            dbCon.Cursos.InsertOnSubmit(nuevoCurso);

            dbCon.SubmitChanges();

            Cursos cursoInsertado = (from curso in dbCon.Cursos
                                     where curso.Nombre.Equals("Aprendiendo Linq to SQL")
                                     select curso).FirstOrDefault();

            Console.WriteLine($"El curso {cursoInsertado.Nombre} se agrego correctamente.");

            
        }

        // Actualizar()
        public static void Actualizar(int cursoId)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OperadoresLINQ.Properties.Settings.CursosVirtualesConnectionString"].ToString();
            LINQToSQLDataContext dbCon = new LINQToSQLDataContext(connectionString);

            Cursos curso = dbCon.Cursos.FirstOrDefault(x => x.CursoId == cursoId);

            curso.Nombre = "Trabajando solamente con SQL";
            curso.Precio = 250.99;
            curso.FechaModificacion = DateTime.UtcNow;

            dbCon.SubmitChanges();

            Cursos cursoActualizado = dbCon.Cursos.FirstOrDefault(x => x.CursoId == cursoId);

            Console.WriteLine($"ID: {cursoActualizado.CursoId}\n" +
                $"Nombre: {cursoActualizado.Nombre}\n" +
                $"Precio: {cursoActualizado.Precio}\n" +
                $"Fecha Registro: {cursoActualizado.FechaRegistro}\n" +
                $"Fecha Modificación: {cursoActualizado.FechaModificacion}");
        }

        // Eliminar()

        public static void Eliminar(int cursoId)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OperadoresLINQ.Properties.Settings.CursosVirtualesConnectionString"].ToString();
            LINQToSQLDataContext dbCon = new LINQToSQLDataContext(connectionString);

            Cursos cursoEliminar = dbCon.Cursos.FirstOrDefault(x => x.CursoId == cursoId);

            dbCon.Cursos.DeleteOnSubmit(cursoEliminar);

            dbCon.SubmitChanges();

            Cursos cursoEliminado = dbCon.Cursos.FirstOrDefault(x => x.CursoId == cursoId);

            if(cursoEliminado == null)
            {
                Console.WriteLine("Curso eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Algo salio mal!");
            }
        }
    }
}
