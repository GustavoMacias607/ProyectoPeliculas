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
            cbGenero.Text = pelicula.Genero;
            txtDirector.Text = pelicula.Director;
            CbClasificacion.Text = pelicula.Clasificacion;
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
            try
            {
                if (txtNombre.Text == "" || cbGenero.Text == "" || txtDirector.Text == "" || CbClasificacion.Text == ""
                    || txtDuracion.Text == "" || txtPrecio.Text == "" || txtPeliculasDisponibles.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {

                    if (int.Parse(txtPrecio.Text) <= 0)
                    {
                        MessageBox.Show("Ingrese un Precio mayor a 0");
                    }
                    else
                    {
                        DAOPeliculas dao = new DAOPeliculas();

                        DTOPeliculas pelicula = new DTOPeliculas()
                        {
                            IdPeliculas = int.Parse(txtIdPelicula.Text),
                            Nombre = txtNombre.Text,
                            Duracion = txtDuracion.Text,
                            Clasificacion = CbClasificacion.Text,
                            PeliculasDisponibles = int.Parse(txtPeliculasDisponibles.Text),
                            Precio = Convert.ToDouble(txtPrecio.Text),
                            Genero = cbGenero.Text,
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
                            MessageBox.Show("Se modifico Correctamente la Renta");

                        }
                        else
                        {
                            limpiarDatos();
                            MessageBox.Show("Hubo un error verifica e intenta mas tarde ");
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Favor de Ingresar los caracteres correspondientes ");
            }

        }
        public void limpiarDatos()
        {
            txtNombre.Text = "";
            cbGenero.Text = "";
            txtDirector.Text = "";
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
