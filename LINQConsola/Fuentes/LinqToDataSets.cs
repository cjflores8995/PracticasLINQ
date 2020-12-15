using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    class LinqToDataSets
    {
        public static void LinqConDataSets()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OperadoresLINQ.Properties.Settings.CursosVirtualesConnectionString"].ToString();

            string sqlQuery = "SELECT * FROM Cursos";

            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, connectionString);

            da.TableMappings.Add("Table", "Cursos");

            DataSet ds = new DataSet();

            da.Fill(ds);

            DataTable cursos = ds.Tables["Cursos"];

            var query = from c in cursos.AsEnumerable()
                        select new
                        {
                            CursoId = c.Field<int>("CursoId"),
                            CursoNombre = c.Field<string>("Nombre")
                        };

            foreach(var curso in query.Take(10))
            {
                Console.WriteLine($"ID: {curso.CursoId}, Nombre: {curso.CursoNombre}");
            }
        }
    }
}
