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
    public partial class UpdatePelicula : Form
    {
        public UpdatePelicula()
        {
            InitializeComponent();

        }

        public UpdatePelicula(DTOPeliculas pelicula)
        {
            InitializeComponent();
            //codigo para mostrar los datos de las peliculas
            txtNombre.Text = pelicula.Nombre;
            txtGenero.Text = pelicula.Genero;
            txtDirector.Text = pelicula.Director;
            txtClasificacion.Text = pelicula.Clasificacion;
            DTPAnoLanzamiento.Value = pelicula.AnoLanzamiento;
            txtDuracion.Text = pelicula.Duracion;
            txtPrecio.Text = pelicula.Precio.ToString();
            txtPeliculasDisponibles.Text = pelicula.PeliculasDisponibles.ToString();
            txtIdPelicula.Text = pelicula.IdPeliculas.ToString();

            if (pelicula.Status)
            {
                chkIsActive.Checked = true;

            }
            else
            {
                chkIsActive.Checked = false;

            }
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
            DAOPeliculas dao = new DAOPeliculas();

            DTOPeliculas pelicula = new DTOPeliculas()
            {
                IdPeliculas = int.Parse(txtIdPelicula.Text),
                Nombre = txtNombre.Text,
                Duracion = txtDuracion.Text,
                Clasificacion = txtClasificacion.Text,
                PeliculasDisponibles = int.Parse(txtPeliculasDisponibles.Text),
                Precio = Convert.ToDouble(txtPrecio.Text),
                Genero = txtGenero.Text,
                AnoLanzamiento = DTPAnoLanzamiento.Value,
                Director = txtDirector.Text
             };


            if (chkIsActive.Checked)
                pelicula.Status = true;
            else
                pelicula.Status = false;

            txtIdPelicula.Text = pelicula.IdPeliculas.ToString();

            bool resultado = dao.Modificar(pelicula);

            if (resultado)
            {
                limpiarDatos();
                MessageBox.Show("Se modifico Correctamente el " + pelicula.Nombre);

            }
            else
            {
                limpiarDatos();
                MessageBox.Show("Hubo un error verifica e intenta mas tarde ");
            }
            this.Close();
            


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
            
        }

        private void labelAgregacion_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
