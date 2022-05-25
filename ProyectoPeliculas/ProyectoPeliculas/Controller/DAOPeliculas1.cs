using ProyectoPeliculas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoPeliculas.Controller
{
    public class DAOPeliculas1 : BaseDatos
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


        ///<summary>
        ///Metodo para consultar todos los productos activos 
        ///</summary>
        ///<param> </param>
        ///<returns name = "datatable"> Retorna una DataTable con todos los productos </returns>

        public DataTable datosDisponibles()
        {

            string sentencia = "SELECT * FROM peliculas.pelis WHERE Estatus = 1";
            DataTable datos = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            cone.Close();
            cone.ConnectionString = CadenaConexion;
            cone.Open();
            adaptador = new MySqlDataAdapter(sentencia, cone);
            adaptador.Fill(datos);
            cone.Close();
            return datos;

        }
        public DataTable datosAgotados()
        {

            string sentencia = "SELECT * FROM peliculas.pelis WHERE Estatus = 0";
            DataTable datos = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            cone.Close();
            cone.ConnectionString = CadenaConexion;
            cone.Open();
            adaptador = new MySqlDataAdapter(sentencia, cone);
            adaptador.Fill(datos);
            cone.Close();
            return datos;

        }
        public DataTable datosTodos()
        {

            string sentencia = "SELECT * FROM peliculas.pelis";
            DataTable datos = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            cone.Close();
            cone.ConnectionString = CadenaConexion;
            cone.Open();
            adaptador = new MySqlDataAdapter(sentencia, cone);
            adaptador.Fill(datos);
            cone.Close();
            return datos;

        }
        public DataTable datosLike(string parametro,string sen)
        {

            string sentencia = "SELECT * FROM peliculas.pelis WHERE Nombre Like '%" + parametro + "%'" + sen;
            DataTable datos = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            cone.Close();
            cone.ConnectionString = CadenaConexion;
            cone.Open();
            adaptador = new MySqlDataAdapter(sentencia, cone);
            adaptador.Fill(datos);
            cone.Close();
            return datos;

        }
        public DataTable datosNombres()
        {

            string sentencia = "SELECT Nombre FROM peliculas.pelis WHERE Estatus = 1";
            //BaseDatos bd = new BaseDatos();
            // bd.Conexion();
            DataTable datos = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            cone.Close();
            cone.ConnectionString = CadenaConexion;
            cone.Open();
            adaptador = new MySqlDataAdapter(sentencia, cone);
            adaptador.Fill(datos);
            cone.Close();
            return datos;

        }
        public bool Modificar(DTOPeliculas pelicula)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                string sentencia =
                    "UPDATE peliculas.pelis SET Nombre = '"+ pelicula.Nombre +
                    "',Duracion='" + pelicula.Clasificacion +
                    "',Clasificacion='" + pelicula.Duracion +
                    "',CantidadPeliculasDisponibles=" + pelicula.PeliculasDisponibles +
                    ",PreciodeRenta=" + pelicula.Precio +
                    ",Genero='" + pelicula.Genero +
                    "',Director='" + pelicula.Director +
                    "',AnoLanzamiento='" + pelicula.AnoLanzamiento.ToString("yyyy/MM/dd") +
                    "',Estatus=" + pelicula.Status +
                    " WHERE IdPelicula = " + pelicula.IdPeliculas;

                bool res = bd.insertarDatos(sentencia);
                bd.Cerrar();
                if (res)
                {

                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                result = false;

            }
            return result;
        }
    }
}
