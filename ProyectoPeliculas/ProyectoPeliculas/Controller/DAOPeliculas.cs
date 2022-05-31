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
    public class DAOPeliculas : BaseDatos
    {
        #region pruebas unitarias
        public bool agregarUni(string sentencia)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
              

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

        public bool ModificarUni(string sentencia)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
               

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

        public bool ModificarEstatusUni(string sentencia)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                
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
        public bool MostrarPeliculasUni(string sentencia)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {


                bool res = bd.insertarDatos(sentencia);
                if (res)
                {

                    Console.WriteLine("Se han Mostrado los datos correctamente");
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
        #endregion


        #region Mostrar Datos
        public DataTable DatosDisponibles()
        {

            string sentencia = "SELECT * FROM peliculas.pelis WHERE Estatus = 1 and CantidadPeliculasDisponibles >= 1";
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
        public DataTable datosDisponibles()
        {

            string sentencia = "SELECT * FROM peliculas.pelis WHERE Estatus = 1 and CantidadPeliculasDisponibles >= 1";
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
        public DataTable MostarPel()
        {

            string sentencia = "Select Nombre,CantidadPeliculasDisponibles,PreciodeRenta from peliculas.pelis where Estatus = 1";
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

            string sentencia = "SELECT * FROM peliculas.pelis WHERE Estatus = 0 or CantidadPeliculasDisponibles = 0";
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
        public DataTable datosLike(string parametro, string sen)
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
        public DataTable datosNombresId()
        {

            string sentencia = "SELECT Nombre FROM peliculas.pelis";
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
        public DataTable MostrarAuxTalcual(DTORentas id)
        {

            string sentencia = "select IdRentas,IdPeliculas,Cantidad,Activo from peliculas.auxrentas,peliculas.indicerentasaux where IdRentas =" + id.idRentaAux + " and Activo = 1";
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

        #endregion


        #region Agregar Datos
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


        #endregion


        #region Modificar Datos
        public bool Modificar(DTOPeliculas pelicula)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                string sentencia =
                    "UPDATE peliculas.pelis SET Nombre = '" + pelicula.Nombre +
                    "',Duracion='" + pelicula.Duracion +
                    "',Clasificacion='" + pelicula.Clasificacion +
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

        public bool ModificarEstatus()
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                string sentencia =
                    "update peliculas.pelis set Estatus = 0 where CantidadPeliculasDisponibles = 0";

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
        public bool ModificarEstatusM()
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                string sentencia =
                    "update peliculas.pelis set Estatus = 1 where CantidadPeliculasDisponibles > 0";

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


        #endregion




       



    }

}
