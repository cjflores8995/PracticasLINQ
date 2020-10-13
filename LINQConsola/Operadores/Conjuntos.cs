using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Conjuntos
    {
        public void Conjunto()
        {
            //Distinct
            //string[] dias = new string[] {
            //"lunes",
            //"sabado",
            //"martes",
            //"miercoles",
            //"lunes",
            //"jueves",
            //"martes",
            //"lunes",
            //"viernes",
            //"domingo",
            //"sabado",
            //"viernes"
            //};

            //foreach(string dia in dias)
            //{
            //    Console.WriteLine($"{dia}, ");
            //}

            //IEnumerable<string> diasDistinct =
            //    from dia in dias.Distinct()
            //    select dia;

            //Console.WriteLine("\nDIAS DISTINCT");

            //foreach (string dia in diasDistinct)
            //{
            //    Console.WriteLine($"{dia}, ");
            //}

            //Except()

            //string[] meses1 = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Agosto", "Mayo", "Junio" };
            //string[] meses2 = new string[] { "Febrero", "Agosto", "Marzo", "Abril", "Mayo", "Junio", "Diciembre" };

            //IEnumerable<string> meses =
            //    from mes in meses1.Except(meses2)
            //    select mes;

            //Console.WriteLine("Elementos del primer arreglo que no estan en el segundo.");

            //foreach (string mes in meses)
            //{
            //    Console.WriteLine($"{mes}, ");
            //}

            //var mesesQuery =
            //    from mes in meses2.Except(meses1)
            //    select mes;

            //Console.WriteLine("\nElementos del segundo arreglo que no estan en el primero.");

            //foreach (string mes in mesesQuery)
            //{
            //    Console.WriteLine($"{mes}");
            //}

            //Intersect()
            //string[] meses1 = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Agosto", "Mayo", "Junio" };
            //string[] meses2 = new string[] { "Febrero", "Agosto", "Marzo", "Abril", "Mayo", "Junio", "Diciembre" };

            //var meses =
            //    from mes in meses1.Intersect(meses2)
            //    select mes;

            //foreach (string mes in meses)
            //{
            //    Console.WriteLine($"{mes}");
            //}


            //Union()
            string[] meses1 = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Agosto", "Mayo", "Junio", "Septiembre" };
            string[] meses2 = new string[] { "Febrero", "Agosto", "Marzo", "Abril", "Mayo", "Junio", "Octubre", "Diciembre" };

            IEnumerable<string> meses =
                from mes in meses1.Union(meses2)
                select mes;

            foreach(var mes in meses)
            {
                Console.Write($"{mes}, ");
            }
        }
    }
}
