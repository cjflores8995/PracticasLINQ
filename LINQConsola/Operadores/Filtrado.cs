using LINQDataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Filtrado
    {
        public void Filtrar()
        {
            ////Operadores de comparación

            ////Mayor           (>)
            //Console.WriteLine("2 > 1: " + (2 > 1));

            ////Mayor que       (>=)
            //Console.WriteLine("2 >= 1: " + (2 >= 1));

            ////Menor           (<)
            //Console.WriteLine("2 < 1: " + (2 < 1));

            ////Menor que       (<=)
            //Console.WriteLine("2 <= 1: " + (2 <= 1));

            ////Operadores Lógicos

            ////Igualdad        (==) 
            //Console.WriteLine("1 == 1: " + (1 == 1));

            ////Diferencia      (!=) 
            //Console.WriteLine("1 != 1: " + (1 != 1));

            ////Negación        (!)
            //Console.WriteLine("true: " + (!true));

            //where
            //string[] palabras = new string[] {
            //    "mesa",
            //    "silla",
            //    "patio",
            //    "cocina",
            //    "cuarto",
            //    "habitación",
            //    "cama",
            //    "mueble",
            //    "casa"
            //};

            //IEnumerable<string> consulta =
            //    from palabra in palabras
            //    where palabra.Length == 5
            //    select palabra;

            //foreach(string p in consulta)
            //{
            //    Console.WriteLine(p);
            //}

            //using (CursosVirtualesEntities db = new CursosVirtualesEntities())
            //{
            //    var paises =
            //        from pais in db.Paises
            //        orderby pais.ContinenteId ascending, pais.Nombre ascending
            //        select pais;

            //    var paisesAmerica =
            //        from pais in db.Paises
            //        where pais.Continentes.Nombre.Contains("América")
            //        && pais.Poblacion > 10000000
            //        && pais.Establecido >= 1930
            //        orderby pais.ContinenteId ascending, pais.Nombre ascending
            //        select pais;

            //    //var paisesAmericaOEuropa =
            //    //    from pais in db.Paises
            //    //    where pais.Continentes.Nombre.Contains("América") || pais.Continentes.Nombre.Contains("Europa")
            //    //    orderby pais.ContinenteId ascending, pais.Nombre ascending
            //    //    select pais;

            //    paisesAmerica.ToList().ForEach(pais => {
            //        Console.WriteLine($"" +
            //            $"CONTINENTE: {pais.Continentes.Nombre}, " +
            //            $"PAIS: {pais.Nombre}, " +
            //            $"CAPITAL: {pais.Capital}, " +
            //            $"POBLACIÓN: {pais.Poblacion}, " +
            //            $"ESTABLECIDO: {pais.Establecido}");
            //    });


            //}

            //OfType

            ArrayList mixElementos = new ArrayList();

            mixElementos.Add(3.14159);
            mixElementos.Add("Rodrigo Bueno");
            mixElementos.Add(27);
            mixElementos.Add(new CursosVirtualesEntities().Continentes.FirstOrDefault());
            mixElementos.Add("Juan Perez");
            mixElementos.Add(new CursosVirtualesEntities().Continentes.AsEnumerable().Last());
            mixElementos.Add(12);
            mixElementos.Add("Fanny Vera");
            mixElementos.Add(19);
            mixElementos.Add(1500.99);
            mixElementos.Add(new Continentes { 
                ContinenteId = 7,
                Nombre = "Nueva América",
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now,
                Estado = true
            });

            //IEnumerable<int> enteros = mixElementos.OfType<int>();
            //IEnumerable<int> enteros =
            //    from entero in mixElementos.OfType<int>()
            //    select entero;

            //enteros.ToList().ForEach(entero => {
            //    Console.WriteLine(entero);
            //});

            //var nombres = mixElementos.OfType<string>();

            //nombres.ToList().ForEach(nombre => {
            //    Console.WriteLine(nombre);
            //});

            var continentes = from continente in mixElementos.OfType<Continentes>() select continente;

            continentes.ToList().ForEach(continente => {
                Console.WriteLine($"" +
                    $"ID: {continente.ContinenteId}, " +
                    $"NOMBRE: {continente.Nombre}");
            });

        }
    }
}
