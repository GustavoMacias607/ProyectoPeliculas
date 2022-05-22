using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPeliculas.Controller
{
    public class BaseDatos
    {
        public static MySqlConnection cone = new MySqlConnection();
        static string server = "Server = 127.0.0.1;";
        static string db = " Database = peliculas;";
        static string user = " UID=root;";
        static string password = " Password=rest;";
        public string CadenaConexion = server + db + user + password;

        static MySqlCommand comando = new MySqlCommand();
        static MySqlDataAdapter adaptador = new MySqlDataAdapter();

        public void Conexion()
        {
            try
            {
                cone.ConnectionString = CadenaConexion;
                cone.Open();
                Console.WriteLine("Se conecto de manera correcta");
                
            }

            catch (Exception e)
            {
                Console.WriteLine("No se conecto" + e.ToString());

            }
        }
        public void Cerrar()
        {
            cone.Close();
        }
        public bool insertarDatos(string sentencia)
        {
            bool resultado = false;
            try
            {
                comando.CommandText = sentencia;
                comando.Connection = cone;
                comando.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }
             return resultado;

        }

    }
}
