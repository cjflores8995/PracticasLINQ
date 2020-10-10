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
            //List<T>

            List<string> listaNombres = new List<string>()
            {
                "Carlos", "Jhosef", "Maria", "Ana", "Juanita"
            };

            //List<T>
            List<Estudiante> listaEstudiantes = new List<Estudiante>()
            {
                new Estudiante{ EstudianteId = 1, Nombre = "Jose", Apellido = "Flores", Grado = 3},
                new Estudiante{ EstudianteId = 2, Nombre = "Marcia", Apellido = "Villanueva", Grado = 6},
                new Estudiante{ EstudianteId = 3, Nombre = "David", Apellido = "Fernandez", Grado = 1},
                new Estudiante{ EstudianteId = 4, Nombre = "Rodrigo", Apellido = "Bueno", Grado = 3},
                new Estudiante{ EstudianteId = 5, Nombre = "David", Apellido = "Fernandez", Grado = 1},
                new Estudiante{ EstudianteId = 6, Nombre = "Walter", Apellido = "Olmos", Grado = 3},
            };

            //IEnumerable<T> 
            IEnumerable<Estudiante> estudiantes = from estudiante in listaEstudiantes
                                                  where estudiante.Grado == 3
                                                  select estudiante;

            foreach (Estudiante est in estudiantes)
            {
                Console.WriteLine($"ID: {est.EstudianteId}, Nombre: {est.Nombre} {est.Apellido}, Grado: {est.Grado}");
            }

            Console.WriteLine("\n");

            //var
            var estudantes2 = from estudiante in listaEstudiantes
                              where estudiante.Grado != 3
                              select estudiante;

            foreach (Estudiante est in estudiantes)
            {
                Console.WriteLine($"ID: {est.EstudianteId}, Nombre: {est.Nombre} {est.Apellido}, Grado: {est.Grado}");
            }

            Console.ReadKey();
        }

        public class Estudiante
        {
            public int EstudianteId { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Grado { get; set; }
        }
    }
}
