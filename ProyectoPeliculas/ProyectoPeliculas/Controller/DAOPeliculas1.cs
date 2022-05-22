using ProyectoPeliculas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoPeliculas.Controller
{
    public class DAOPeliculas1
    {

        public bool agregar(DTOPeliculas pelicula)
        {
           
            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                string sentencia =
                    "INSERT INTO peliculas.pelis VALUES(0,'" +
                    pelicula.Nombre +
                    "','" + pelicula.Duracion +
                    "','" + pelicula.Clasificacion +
                    "'," + pelicula.PeliculasDisponibles +
                    "," + pelicula.Precio +
                    ",'" + pelicula.Genero +
                    "','" + pelicula.Director +
                    "','" + pelicula.AnoLanzamiento.ToString("yyyy/MM/dd") +
                    "'," + "1)";

                bool res = bd.insertarDatos(sentencia);
                if (res)
                {
                    
                    Console.WriteLine("Insertado correctamente");
                }
                else
                {
                    Console.WriteLine("hubo un error");
                }
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                
            }
            return result;
        }
    }
}
