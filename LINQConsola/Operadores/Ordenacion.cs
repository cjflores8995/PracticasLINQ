using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Ordenacion
    {
        public void Ordenar()
        {
            //ordenando un array de palabras
            string[] colores = new string[] { "azul", "rojo", "verde", "amarillo", "negro", "celeste", "blanco", "gris" };

            //orden ascendente principal
            //IEnumerable<string> coloresOrden =
            //    from color in colores
            //    orderby color ascending
            //    select color;

            //orden descendente principal
            //IEnumerable<string> coloresOrden =
            //    from color in colores
            //    orderby color descending
            //    select color;


            //foreach (string color in coloresOrden)
            //{
            //    Console.WriteLine($"{color}");
            //}

            using (var db = new CursosVirtualesEntities())
            {
                //IEnumerable<Cursos> cursos =
                //    from curso in db.Cursos
                //    select curso;

                //Orden ascendente principal por defecto
                //IEnumerable<Cursos> cursos =
                //    from curso in db.Cursos
                //    orderby curso.Idioma ascending
                //    select curso;

                //orden descendente
                //IEnumerable<Cursos> cursos =
                //    from curso in db.Cursos
                //    orderby curso.Idioma descending
                //    select curso;

                //Orden secundario
                //IEnumerable<Cursos> cursos =
                //    from curso in db.Cursos
                //    orderby curso.Idioma ascending, curso.Nombre ascending
                //    select curso;

                //Orden secundario descendente
                //IEnumerable<Cursos> cursos =
                //    from curso in db.Cursos
                //    orderby curso.Idioma ascending, curso.Nombre descending
                //    select curso;

                //SINTAXIS DE METODO
                //IEnumerable<Cursos> cursos =
                //    db.Cursos;

                //orden ascendente principal
                //IEnumerable<Cursos> cursos =
                //    db.Cursos.OrderBy(curso => curso.Idioma);

                //orden descendente principal
                //IEnumerable<Cursos> cursos =
                //    db.Cursos.OrderByDescending(curso => curso.Idioma);

                //orden secundario thenBy
                //IEnumerable<Cursos> cursos =
                //    db.Cursos.OrderBy(curso => curso.Idioma)
                //    .ThenBy(curso => curso.Nombre);

                //orden secundario ThenByDescending
                //IEnumerable<Cursos> cursos =
                //    db.Cursos.OrderBy(curso => curso.Idioma)
                //    .ThenByDescending(curso => curso.Nombre);


                //foreach (Cursos curso in cursos)
                //{
                //    Console.WriteLine($"IDIOMA: {curso.Idioma}, NOMBRE: {curso.Nombre}");
                //}

                //Reverse solo en sintaxis de metodo

                var continentes = db.Continentes;

                foreach(Continentes continente in continentes)
                {
                    Console.WriteLine($"ID: {continente.ContinenteId}, NOMBRE: {continente.Nombre}");
                }

                Console.WriteLine("\n");

                var continentes2 = db.Continentes.AsEnumerable().Reverse();

                foreach (Continentes continente in continentes2)
                {
                    Console.WriteLine($"ID: {continente.ContinenteId}, NOMBRE: {continente.Nombre}");
                }
            }
        }
    }
}
