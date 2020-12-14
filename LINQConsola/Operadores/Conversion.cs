using LINQDataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    class Conversion
    {
        public void ConversionDeTipos()
        {
            using (var db = new CursosVirtualesEntities())
            {
                // AsEnumerable()

                //var persona = db.Personas.AsEnumerable().Last();

                //Console.WriteLine(persona.Nombre);


                // Cast()

                //IEnumerable<IComparable> enteros = new List<IComparable> { 1, 75, 5, 35, 98, 14 };

                //var result = enteros.Cast<int>();

                //foreach(var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                //ArrayList frutas = new ArrayList();

                //frutas.Add("pera");
                //frutas.Add("manzana");
                //frutas.Add("uva");
                //frutas.Add("naranja");

                //IEnumerable<string> stringFrutas = frutas.Cast<string>();

                //foreach(var item in stringFrutas)
                //{
                //    Console.WriteLine(item);
                //}

                // ToArray()

                //IQueryable<Cursos> cursos = db.Cursos.Take(10);

                //string[] cursosNombre = cursos.Select(x => x.Nombre).ToArray();

                //for (int i = 0; i< cursosNombre.Length; i++)
                //{
                //    Console.WriteLine($"{i}. {cursosNombre[i]}");
                //}

                // ToDictionary()

                //Dictionary<int, string> continentes = db.Continentes.ToDictionary(x => x.ContinenteId, x => x.Nombre);

                //foreach(KeyValuePair<int, string> item in continentes)
                //{
                //    Console.WriteLine($"Key: {item.Key}. Value: {item.Value}");
                //}

                //var cursos = from curso in db.Cursos.Take(10)
                //             select curso;

                //Dictionary<int, Cursos> cursosDictionary = cursos.ToDictionary(x => x.CursoId);

                //foreach(KeyValuePair<int, Cursos> curso in cursosDictionary)
                //{
                //    Console.WriteLine($"ID: {curso.Key} NOMBRE: {curso.Value.Nombre}, PRECIO: {curso.Value.Precio}");
                //}


                // ToList()

                //string[] dias = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

                //List<string> diasLista = dias.ToList();

                //foreach(var item in diasLista)
                //{
                //    Console.WriteLine(item);
                //}

                IQueryable<Personas> personas = from persona in db.Personas.Take(10)
                                                select persona;

                List<Personas> personasLista = personas.ToList();

                foreach(var persona in personasLista)
                {
                    Console.WriteLine($"ID: {persona.PersonaId}. NOMBRES: {persona.Nombre} {persona.Apellido}");
                }
            }
        }
    }
}
