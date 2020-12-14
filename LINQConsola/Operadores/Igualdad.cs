using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    class Igualdad
    {
        public void DeIgualdad()
        {
            // SequenceEqual()

            //comparar 2 colecciones de continentes

            using (var db = new CursosVirtualesEntities()) 
            {
                var continentes = db.Continentes.Take(3).ToList();

                var continentes2 = (from continente in db.Continentes
                                   select continente).ToList();

                bool equals = continentes.SequenceEqual(continentes2);

                Console.WriteLine($"Los continentes " + ((equals)? "son iguales": "NO SON IGUALES"));
            }
        }
    }
}
