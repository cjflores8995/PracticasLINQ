using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola
{
    public static class LINQExtension
    {
        // Crear un método que almacene unicamente los elementos de los lugares pares.

        public static IEnumerable<T> AlternateElements<T>(this IEnumerable<T> fuente)
        {
            int i = 0;

            foreach(var elemento in fuente)
            {
                if(i % 2 == 0)
                {
                    yield return elemento;
                }
                i++;
            }
        }
    }
}
