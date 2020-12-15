using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int[] Notas { get; set; }

        public Estudiante(string nombre, string apellido, int[] notas)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Notas = notas;
        }
    }

    class LinqToArrayList
    {
        public static void ObtenerEstudiantes()
        {
            ArrayList arrayListEstudiantes = new ArrayList();

            arrayListEstudiantes.Add(new Estudiante("Carlos", "Flores", new int[] { 9, 8, 10}));
            arrayListEstudiantes.Add(new Estudiante("Emilia", "Fonseca", new int[] { 7, 7, 9 }));
            arrayListEstudiantes.Add(new Estudiante("Francisco", "Perez", new int[] { 6, 5, 7 }));
            arrayListEstudiantes.Add(new Estudiante("Ernesto", "Bronson", new int[] { 8, 8, 5 }));
            arrayListEstudiantes.Add(new Estudiante("Manuel", "Triangle", new int[] { 4, 7, 6 }));

            var estudiantes = from Estudiante estudiante in arrayListEstudiantes
                              where estudiante.Notas[0] < 7
                              select estudiante;

            foreach(var est in estudiantes)
            {
                Console.WriteLine($"{est.Nombre} {est.Apellido} - Nota 1: {est.Notas[0]}");
            }
        }
    }
}
