using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Combinacion
    {
        public void Combinaciones()
        {
            IList<Curso> cursos = new List<Curso> {
                new Curso(1, "Programación orientada a objetos"),
                new Curso(2, "Principios SOLID"),
                new Curso(3, "Patrones de diseño"),
                new Curso(4, "Arquitectura de software")
            };

            IList<Estudiante> estudiantes = new List<Estudiante> {
                new Estudiante(1, "Juan", "Perez", 1),
                new Estudiante(2, "Maria", "Suarez", 1),
                new Estudiante(3, "Joaquin", "Espinoza", 2),
                new Estudiante(4, "Frank", "Marquez", 3),
                new Estudiante(5, "Marcela", "Flores", 4),
                new Estudiante(6, "Teresa", "Almeida", 1),
                new Estudiante(7, "Emilia", "Olmedo", 3),
                new Estudiante(8, "Jose", "Velez", 4),
                new Estudiante(9, "Erika", "Basantes", 4),
                new Estudiante(10, "Clara", "Mendez", 1)
            };

            //Join()

            // Obtener un listado de estudiantes y el cuarso al que pertenecen

            //var estudiantesCursos = from estudiante in estudiantes
            //                        join curso in cursos
            //                        on estudiante.CursoId equals curso.Id
            //                        select new { 
            //                            EstudianteId = estudiante.Id,
            //                            Nombres = estudiante.Nombre + " " + estudiante.Apellido,
            //                            Curso = curso.Nombre
            //                        };

            //var estudiantesCursos = estudiantes.Join(
            //    cursos,
            //    estudiante => estudiante.CursoId,
            //    curso => curso.Id,
            //    (estudiante, curso) => new {
            //        EstudianteId = estudiante.Id,
            //        Nombres = estudiante.Nombre + " " + estudiante.Apellido,
            //        Curso = curso.Nombre
            //    }
            //    );

            //foreach (var item in estudiantesCursos)
            //{
            //    Console.WriteLine($"" +
            //    $"Id: {item.EstudianteId,-5}" +
            //    $"Nombres: {item.Nombres,-15}" +
            //    $"\tCurso: {item.Curso}");
            //}

            //GroupJoin()

            // Obtener un listado de estudiantes agrupado por su curso

            //var groupJoin = from curso in cursos
            //                join estudiante in estudiantes
            //                on curso.Id equals estudiante.CursoId
            //                into grupoEstudiantes
            //                select new
            //                {
            //                    CursoNombre = curso.Nombre,
            //                    Estudiantes = grupoEstudiantes
            //                };

            var groupJoin = cursos.GroupJoin(
                estudiantes,
                curso => curso.Id,
                estudiante => estudiante.CursoId,
                (curso, estudiante) => new {
                    CursoNombre = curso.Nombre,
                    Estudiantes = estudiante
                }
                );

            foreach (var item in groupJoin.OrderBy(x => x.CursoNombre))
            {
                Console.WriteLine($"Estudiantes en: {item.CursoNombre}");

                foreach (var estudiante in item.Estudiantes)
                {
                    Console.WriteLine($"\t{estudiante.Nombre} {estudiante.Apellido}");
                }

                Console.WriteLine(Environment.NewLine);
            }
        }
    }

    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Curso(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CursoId { get; set; }

        public Estudiante(int id, string nombre, string apellido, int cursoId)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            CursoId = cursoId;
        }
    }
}
