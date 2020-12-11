using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Proyeccion
    {
        public void Proyectar()
        {
            //Select

            using (var db = new CursosVirtualesEntities())
            {
                //var personas = (from persona in db.Personas
                //               select persona).ToList();

                //seleccionar un solo campo
                //var personas = (from persona in db.Personas
                //               select persona.Nombre).ToList();

                //var personas = db.Personas
                //    .Select(persona => persona.Nombre)
                //    .ToList();

                //concatenar campos con select
                //var personas = (from persona in db.Personas
                //               where persona.TipoPersona.Equals("instructor")
                //               //where persona.TipoPersona == "instructor"
                //               select persona.Nombre + " " + persona.Apellido).ToList();

                //var personas = db.Personas
                //    .Where(persona => persona.TipoPersona.Equals("instructor"))
                //    .Select(persona => persona.Nombre + " " + persona.Apellido)
                //    .ToList();

                //de la tabla personas obtener los campos id, nombre, apellido, correo electronico, pais
                //var personas = (from persona in db.Personas
                //               where persona.Paises.Nombre.Equals("Ecuador")
                //               select new
                //               {
                //                   Id = persona.PersonaId,
                //                   Nombres = persona.Nombre + " " + persona.Apellido,
                //                   Email = persona.CorreoElectronico,
                //                   Pais = persona.Paises.Nombre
                //               }).ToList();

                //var personas = db.Personas
                //    .Where(persona => persona.Paises.Nombre.Equals("Colombia"))
                //    .Select(x => new
                //    {
                //        Id = x.PersonaId,
                //        Nombres = x.Nombre + " " + x.Apellido,
                //        Email = x.CorreoElectronico,
                //        Pais = x.Paises.Nombre
                //    }).ToList();

                //personas.ForEach(persona =>
                //{
                //    Console.WriteLine($"ID: {persona.Id}\t\t" +
                //        $"NOMBRES: {persona.Nombres,-20}\t" +
                //        $"PAIS: {persona.Pais,-15}" +
                //        $"CORREO ELECTRÓNICO: { persona.Email,-10}");
                //});

                //seleccionar personas y almacenar el resultado en una clase persona 

                //var personas = db.Personas
                //    .Where(x => x.Paises.Nombre.Equals("Colombia"))
                //    .Select(x => new
                //    {
                //        Id = x.PersonaId,
                //        Nombres = x.Nombre + " " + x.Apellido,
                //        Email = x.CorreoElectronico,
                //        Pais = x.Paises.Nombre
                //    }).ToList()
                //    .Select(x => new Personas
                //    {
                //        PersonaId = x.Id,
                //        Nombre = x.Nombres,
                //        CorreoElectronico = x.Email
                //    }).ToList();

                //personas.ForEach(persona =>
                //{
                //    Console.WriteLine($"ID: {persona.PersonaId}\t\t" +
                //        $"NOMBRES: {persona.Nombre,-20}\t" +
                //        $"CORREO ELECTRÓNICO: { persona.CorreoElectronico,-10}");
                //});

            }
        }
    }
}
