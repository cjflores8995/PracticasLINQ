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
            int[] numeros = new int[] { 1, 4, 3, 56, 23, 22, 54, 87, 1, 33 };

            //Sintaxis de consulta
            IEnumerable<int> sintaxisConsulta =
                from num in numeros
                where num % 2 == 0
                orderby num
                select num;

            Console.WriteLine("Sintaxis de consulta");

            foreach (var numero in sintaxisConsulta)
            {
                Console.Write($"{numero} ");
            }

            //Sintaxis de metodo
            IEnumerable<int> sintaxisMetodo = numeros
                .Where(num => num % 2 == 0)
                .OrderBy(num => num);

            Console.WriteLine("\n\nSintaxis de método");

            foreach (var numero in sintaxisConsulta)
            {
                Console.Write($"{numero} ");
            }



            Console.ReadKey();
        }
    }
}
