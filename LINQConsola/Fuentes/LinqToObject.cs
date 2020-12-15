using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    class LinqToObject
    {
        public static void LinqConObjectos()
        {
            //string[] lenguajes = new string[] { "C#", "Java", "JavaScript", "C++", "Python", "Asp.Net", "Cobol" };

            //var lista = from lenguaje in lenguajes
            //            where lenguaje.ToLower().Substring(0, 1).Equals("j")
            //            select lenguaje;

            //foreach(var lenguaje in lista)
            //{
            //    Console.WriteLine(lenguaje);
            //}

            List<Person> personas = new List<Person> { 
                new Person(1, "Carlos"),
                new Person(2, "Jhosef"),
                new Person(3, "Kathy"),
                new Person(4, "Emilia")
            };

            var listaPersonas = from persona in personas
                                where persona.Id > 2
                                select persona;

            foreach(var persona in listaPersonas)
            {
                Console.WriteLine($"{persona.Id}. {persona.Name}");
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
