using MySql.Data.MySqlClient;
using ProyectoPeliculas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPeliculas.Controller.Rentas
{
    public class DAORentas : BaseDatos
    {
        public bool agregar(DTORentas renta)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                string sentencia =
                    "INSERT INTO peliculas.rentas VALUES(0,  " +
                    "'" + renta.Nombre +
                    "','" + renta.FechaRenta.ToString("yyyy/MM/dd") +
                    "','" + renta.FechaDevolucion.ToString("yyyy/MM/dd") + 
                     "'," + renta.TotalPagar + ",1)";

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
        public bool IdPeliculas(DTORentas renta)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                string sentencia =
                    "INSERT INTO peliculas.auxrentas VALUES(" + renta.idRentaAux +
                     "," + renta.idPeliculaRentada + 
                     "," + renta.Cantidad + ",1)";
                     

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
        public bool IdRentasAux(DTORentas renta)
        {
            int aux = (renta.idRentaAux + 1);
            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                string sentencia =
                    "UPDATE peliculas.indicerentasaux SET IdRentasAux=" + aux;

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
       

        public DataTable IndiceAuxRentas()
        {

            string sentencia = "SELECT * FROM peliculas.indicerentasaux ";
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
        public DataTable MostarAux(DTORentas id)
        {
            
            string sentencia = "Select IdRentas,Nombre,Cantidad,Activo from peliculas.auxrentas,peliculas.pelis,peliculas.indicerentasaux where IdRentas =" + id.idRentaAux + " and IdRentas = IdRentasAux and IdPelicula = IdPeliculas and Activo = 1"; 
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
        
        public bool Modificar(DTORentas renta)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                String sentencia = 
                    "UPDATE peliculas.auxrentas SET Cantidad = 0, Activo = 0 where IdPeliculas = " + renta.idPeliculaRentada + " and IdRentas = " + renta.idRentaAux;

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
        public DataTable PrecioTotal(DTORentas id)
        {

            string sentencia = "Select IdRentas, IdPeliculas, CantidadPeliculasDisponibles, Cantidad, PreciodeRenta, Activo from peliculas.auxrentas, peliculas.pelis, peliculas.indicerentasaux where IdRentas =" + id.idRentaAux + " and IdRentas = IdRentasAux and IdPelicula = IdPeliculas and Activo = 1";
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

        public DataTable ValidacionCantidad()
        {

            string sentencia = "Select IdPelicula,CantidadPeliculasDisponibles from peliculas.pelis where  Estatus = 1";
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
        public bool ModificarCantidad(int cant, int id)
        {

            BaseDatos bd = new BaseDatos();
            bd.Conexion();
            bool result = false;
            try
            {
                String sentencia =
                    "UPDATE peliculas.pelis SET CantidadPeliculasDisponibles =" + cant + " where IdPelicula =" + id;

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
