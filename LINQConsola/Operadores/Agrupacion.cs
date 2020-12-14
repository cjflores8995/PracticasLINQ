using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Agrupacion
    {
        public void Agrupaciones()
        {
            //GroupBy()

            // agrupar números por pares e impares

            //List<int> numeros = new List<int> { 1, 45, 78, 54, 65, 99, 13, 75, 68, 74, 11 };

            //var grupoNumeros = numeros.GroupBy(x => x % 2);

            //foreach(var item in grupoNumeros)
            //{
            //    if(item.Key % 2 == 0)
            //    {
            //        Console.WriteLine("Números Pares");
            //    } else
            //    {
            //        Console.WriteLine("Números Impares");
            //    }

            //    foreach(var numero in item)
            //    {
            //        Console.WriteLine($"\t{numero}");
            //    }

            //    Console.WriteLine(Environment.NewLine);
            //}



            /*
                Agrupar los cursos por 3 rangos de precio:

                (barato 0 - 9.99, promedio 10 - 29.99, caro > 29.99)
             */

            using (var db = new CursosVirtualesEntities())
            {
                //var grupoPrecios = db.Cursos.ToList().GroupBy(x => 
                //{ 
                //    if(x.Precio <= 9.99)
                //    {
                //        return "$0.00 - $9.99 (Barato)";
                //    } 
                //    else if(x.Precio <= 24.99)
                //    {
                //        return "$10.00 - $24.99 (Promedio)";
                //    }
                //    else
                //    {
                //        return "$25.00 - $-- (Caro)";
                //    }
                //});


                //foreach(var item in grupoPrecios)
                //{
                //    Console.WriteLine($"Cursos con un precio de {item.Key}: {item.Count()}");

                //    foreach(var curso in item)
                //    {
                //        Console.WriteLine($"\t{curso.Precio.ToString("C2")} {curso.Nombre}");
                //    }

                //    Console.WriteLine(Environment.NewLine);
                //}


                // Agrupar personas por pais

                //var result = db.Personas.GroupBy(x => x.Paises.Nombre);

                //var result = from persona in db.Personas
                //             group persona by persona.Paises.Nombre;

                //foreach(var item in result)
                //{
                //    Console.WriteLine(item.Key);

                //    foreach(var persona in item)
                //    {
                //        Console.WriteLine($"\t{persona.Nombre} {persona.Apellido}");
                //    }
                //}

                // ToLookup()

                //var result = db.Personas.ToLookup(x => x.Paises.Nombre);

                var result = (from persona in db.Personas
                              select persona).ToLookup(x => x.Paises.Nombre);

                foreach (var item in result)
                {
                    Console.WriteLine(item.Key);

                    foreach (var persona in item)
                    {
                        Console.WriteLine($"\t{persona.Nombre} {persona.Apellido} ");
                    }
                }
            }
        }
    }
}
