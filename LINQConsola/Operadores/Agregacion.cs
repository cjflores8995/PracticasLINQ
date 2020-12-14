using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    class Agregacion
    {
        public void OperadoresAgregacion()
        {
            // Aggregate()

            //int[] enteros = new int[] { 1, 4, 87, 6, 24, 9, 41, 9, 36, 82 };

            //int numerosPares = enteros
            //    .Aggregate((total, numero) => numero % 2 == 0 ? total + 1: total);

            //Console.WriteLine("El número de enteros pares es: " + numerosPares);

            //List<int> numeros = new List<int> { 1, 2, 4, 6, 7, 8, 9 };

            //int sumaEnteros = numeros.Aggregate(10, (resultado, numero) => resultado + numero);

            //Console.WriteLine("La suma de los números es: " + sumaEnteros);

            //var letras = new[] { 'l', 'i', 'n', 'q' };

            //var palabra = letras.Aggregate(new StringBuilder(), (actual, siguiente) => actual.Append(siguiente));

            //Console.WriteLine(palabra);


            // Average()

            //List<int> numeros = new List<int> { 1, 2, 4, 6, 7, 8, 9 };

            //var promedio = numeros.Average();

            //for(int i=0; i< numeros.ToArray().Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //Console.WriteLine(Environment.NewLine);

            //Console.WriteLine(promedio);

            // Count()

            using (var db = new CursosVirtualesEntities())
            {
                var cursos = db.Cursos;

                //Console.WriteLine(cursos.Count(x => x.Idioma.Equals("ingles")));

                // LongCount()

                //Console.WriteLine(cursos.LongCount());

                // Max()

                //var mayorPrecio = cursos.Max(x => x.Precio);

                //Console.WriteLine(mayorPrecio);

                // Min()
                //var menorPrecio = cursos.Min(x => x.Precio);

                //Console.WriteLine(menorPrecio);

                // Sum()

                var sumaPrecios = cursos.Sum(x => x.Precio);

                Console.WriteLine(sumaPrecios.ToString("C2"));
            }
        }
    }
}
