using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    class Concatenacion
    {
        public void Concatenar()
        {
            using (var db = new CursosVirtualesEntities())
            {
                var instructores = from instructor in db.Personas.Take(10)
                                   where instructor.TipoPersona.Equals("instructor")
                                   select instructor;

                var estudiantes = db.Personas
                    .Where(x => x.TipoPersona.Equals("estudiante"))
                    .Take(10);


                foreach (var instructor in instructores)
                {
                    Console.WriteLine(instructor.Nombre + " " + instructor.Apellido);
                }

                Console.WriteLine(Environment.NewLine);

                foreach (var estudiante in estudiantes)
                {
                    Console.WriteLine(estudiante.Nombre + " " + estudiante.Apellido);
                }

                Console.WriteLine(Environment.NewLine);

                var concatenar = instructores.Concat(estudiantes);

                foreach(var item in concatenar)
                {
                    Console.WriteLine($"{item.Nombre} {item.Apellido} - {item.TipoPersona}");
                }

                Console.WriteLine(Environment.NewLine);

                var concatenar2 = instructores.Select(x => x.Nombre).Concat(estudiantes.Select(x => x.Nombre));

                foreach(var item in concatenar2)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
