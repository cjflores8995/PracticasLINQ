using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    class Elementos
    {
        public void Elemento()
        {
            using (var db = new CursosVirtualesEntities())
            {
                // ElementAt()

                // Obtener un listado de 10 paises y despues buscarlos por su índice específico

                //var paises = db.Paises.Take(10);

                //foreach(var pais in paises)
                //{
                //    Console.WriteLine($"{pais.Nombre}");
                //}

                //Console.WriteLine(Environment.NewLine);

                //var paisEspecifico = paises.AsEnumerable().ElementAt(15);

                //Console.WriteLine($"{paisEspecifico.Nombre}");

                // ElementAtOrDefault()

                //var paises = db.Paises.Take(10);

                //foreach (var pais in paises)
                //{
                //    Console.WriteLine($"{pais.Nombre}");
                //}

                //Console.WriteLine(Environment.NewLine);

                //int index = 18;

                //var paisEspecifico = paises.AsEnumerable().ElementAtOrDefault(index);

                //Console.WriteLine("El pais {0} es: {1}",
                //    index,
                //    (paisEspecifico == null? "no hay pais": paisEspecifico.Nombre));

                // First()

                //var cursos_9_99 = db.Cursos.Where(x => x.Precio == 9.99).ToList();

                //var curso = cursos_9_99.First(x => x.Nombre == "curso de $9.99");

                // FirstOrDefault()

                //var curso = cursos_9_99.FirstOrDefault(x => x.Nombre == "curso de $9.99");

                // Last()

                //var cursos = db.Cursos.Where(x => x.Idioma.Equals("portugues") && x.Precio > 85).ToList();

                ////var ultimoCurso = cursos.AsEnumerable().Last(x => x.Precio < 50);

                //var ultimoCurso = cursos.AsEnumerable().LastOrDefault(x => x.Precio < 50);

                // Single()

                //var curso = db.Cursos.Single(x => x.Nombre.Equals("programación orientada a objetos"));

                //var curso = db.Cursos.Single(x => x.Precio == 2.89);


                // SingleOrDefault()

                //var curso = db.Cursos.SingleOrDefault(x => x.Nombre.Equals("programación orientada a objetos"));

                var curso = db.Cursos.SingleOrDefault(x => x.Precio == 1.99);
            }
        }
    }
}
