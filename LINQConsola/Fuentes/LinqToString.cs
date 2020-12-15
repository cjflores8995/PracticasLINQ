using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    class LinqToString
    {
        //eliminar espacios de una cadena
        public static string EliminarEspacios(string cadena)
        {
            var result = from c in cadena.ToLowerInvariant().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         select c;

            StringBuilder nuevaCadena = new StringBuilder();

            foreach(var palabra in result)
            {
                nuevaCadena.Append(palabra).Append(" ");
            }

            return nuevaCadena.ToString();
        }

        //contar cuantas veces se repite una palabra en una cadena
        public static string RepeticionesPalabra(string palabra, string texto)
        {
            int repeticiones = 0;

            string[] fuente = texto
                .Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var coincidencias = from palabraBuscada in fuente
                                where palabraBuscada.ToLowerInvariant() == palabra.ToLowerInvariant()
                                select palabraBuscada;

            repeticiones = coincidencias.Count();

            return $"La palabra \"{palabra}\" se repite {repeticiones} veces.";
        }

        // Reordenar campos de un archivo de texto

        public static void ReordenarListado(string rutaArchivo)
        {
            string[] lineas = File.ReadAllLines(rutaArchivo);

            for(int i=0; i< lineas.Length; i++)
            {
                Console.WriteLine(lineas[i]);
            }

            Console.WriteLine(Environment.NewLine);

            var consulta = (from linea in lineas
                            let columna = linea.Split(',')
                            orderby columna[2]
                            select columna[2].Trim() + "," + columna[0] + "," + columna[1]).ToArray();

            for(int i=0; i< consulta.Length; i++)
            {
                Console.WriteLine(consulta[i]);
            }
        }
    }
}
