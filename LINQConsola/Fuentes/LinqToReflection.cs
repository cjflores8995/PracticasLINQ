using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class LinqToReflection
    {
        // Obtener información sobre los constructores y métodos del ensamblado "MiLibreria".

        private readonly Assembly Ensamblado;

        public LinqToReflection(string ensamblado)
        {
            this.Ensamblado = Assembly.Load(ensamblado);
        }

        public void GetInfo()
        {
            // Obtener informacion de los constructores del ensamblado
            var ensambladoConstructores = from type in this.Ensamblado.GetTypes()
                                          from constructores in type.GetConstructors()
                                          group constructores.ToString()
                                          by type.ToString();

            // Obtener información de los métodos del ensamblado
            var ensambladoMetodos = from type in this.Ensamblado.GetTypes()
                                    from metodos in type.GetMethods()
                                    group metodos.ToString()
                                    by type.ToString();

            foreach(var constructores in ensambladoConstructores)
            {
                Console.WriteLine(constructores.Key);

                foreach(var constructor in constructores)
                {
                    Console.WriteLine($"\t{constructor}");
                }

                var metodos = from metodo in ensambladoMetodos
                              where metodo.Key == constructores.Key
                              select metodo;

                foreach(var metodo in metodos)
                {
                    foreach(var tipo in metodo)
                    {
                        Console.WriteLine($"\t\t{tipo}");
                    }
                }

                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
