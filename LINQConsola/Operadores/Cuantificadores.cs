using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Cuantificadores
    {
        public void Cuantificar()
        {
            //Any
            //int[] numeros = new int[] { 1, 5, 7, 5, 9, 3 };

            //if (numeros.Any())
            //{
            //    Console.WriteLine("el arreglo contiene datos: " + (numeros.Any()));
            //} else
            //{
            //    Console.WriteLine("el arreglo no contiene datos: " + (numeros.Any()));
            //}

            //validar si existe algun curso de ingles

            using (var db = new CursosVirtualesEntities())
            {
                //string idioma = "frances";

                //bool existenCursos = db.Cursos.Any();

                //if (existenCursos)
                //{
                //    Console.WriteLine("Existen cursos.");
                //} else
                //{
                //    Console.WriteLine("No existen cursos.");
                //}

                //All()
                //string[] palabras = new string[] { "casa", "cocina", "cuarto" };

                //var consulta = palabras
                //    .All(palabra => palabra.StartsWith("c"))? "todas las palabras empiezan con C": "no todas las palabras empiezan con C";

                //Console.WriteLine(consulta);

                //determinar si todos los cursos tienen un precio mayor a $5.00
                //bool precio5 = db.Cursos.All(curso => curso.Precio >= 5);
                //var precio = db.Cursos.All(curso => curso.Precio >= 10)? "correcto": "incorrecto";

                //Console.WriteLine("¿Todos los cursos cuestan mas de $10.00? " + precio);

                //validar si todos los cursos de ingles tienen un precio mayor o igual a 20
                //var idiomaPrecio = db.Cursos.All(
                //    curso => curso.Precio >= 20
                //    && curso.Idioma == "ingles"
                //    );

                //Console.WriteLine("¿todos los cursos de ingles son >= $20.00?: " + idiomaPrecio);

                //comprobar si todos los paises fueron establecidos despues de 1800
                //var paisesEstablecidos = db.Paises.All(pais => pais.Establecido > 1800);

                //Console.WriteLine(paisesEstablecidos);

                //Contains()

                List<Cliente> clientes = new List<Cliente>() {
                    new Cliente{ Nombre = "Juan Perez", Fruta = new string[] { "manzana", "pera", "naranja" } },
                    new Cliente{ Nombre = "Mario Vera", Fruta = new string[] { "limon", "mandarina", "platano" } },
                    new Cliente{ Nombre = "Carmen Andrade", Fruta = new string[] { "pera", "platano", "piña" } },
                    new Cliente{ Nombre = "Fabiola Gonzalez", Fruta = new string[] { "uvas", "sandia", "manzana" } }
                };

                //determinar cual cliente tiene en su listado de frutas: manzana
                string fruta = "platano";

                var listadoClientes = from client in clientes
                                      where client.Fruta.Contains(fruta)
                                      select client.Nombre;

                listadoClientes.ToList().ForEach(cliente => {
                    Console.WriteLine(cliente);
                });
            }
        }
    }

    class Cliente
    {
        public string Nombre { get; set; }
        public string[] Fruta { get; set; }
    }
}
