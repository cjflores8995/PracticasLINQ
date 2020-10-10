using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CursosVirtualesEntities())
            {
                IEnumerable<Continentes> continentes =
                    from cont in db.Continentes
                    select cont;

                foreach(var continente in continentes)
                {
                    Console.WriteLine($"ID: {continente.ContinenteId}, Nombre: {continente.Nombre}");
                }
            }

            Console.ReadKey();
        }
    }
}
