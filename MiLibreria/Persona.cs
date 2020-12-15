using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiLibreria
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public string GetSaludo()
        {
            return $"Hola {this.Nombre}";
        }

        public string GetEdad()
        {
            return $"{this.Nombre}, tienes {this.Edad} años";
        }
    }
}
