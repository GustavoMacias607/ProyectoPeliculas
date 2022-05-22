using ProyectoPeliculas.Controller;
using ProyectoPeliculas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPeliculas
{
    public partial class AddPelicula : Form
    {
        public AddPelicula()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DTPAñoLanzamiento_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DAOPeliculas1 dao = new DAOPeliculas1();

            DTOPeliculas pelicula = new DTOPeliculas()
            {
                Nombre = txtNombre.Text,
                Duracion = txtDuracion.Text,
                Clasificacion = txtClasificacion.Text,
                PeliculasDisponibles = int.Parse(txtPeliculasDisponibles.Text),
                Precio = Convert.ToDouble(txtPrecio.Text),
                Genero = txtGenero.Text,
                AnoLanzamiento = DTPAnoLanzamiento.Value,
                Director = txtDirector.Text
                
             
            };

            bool resultado = dao.agregar(pelicula);
            if (resultado)
            {
                limpiarDatos();
                labelAgregacion.Text = "Producto Guardado";

            }
            else
            {
                limpiarDatos();
                labelAgregacion.Text = "ERROR. Intente mas Tarde!";
            }

            


        }
        public void limpiarDatos()
        {
            txtNombre.Text = "";
            txtGenero.Text = "";
            txtDirector.Text = "";
            txtClasificacion.Text = "";
            txtDuracion.Text = "";
            txtPrecio.Text = "";
            txtPeliculasDisponibles.Text = "";
            txtNombre.Focus();
        }

        private void lad_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelAgregacion_Click(object sender, EventArgs e)
        {

        }
    }
}
