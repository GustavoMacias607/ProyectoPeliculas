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
    public partial class AddRenta : Form
    {
        public AddRenta()
        {
            InitializeComponent();
        }



        DAOPeliculas1 dao = new DAOPeliculas1();

        public void obtenerPeliculas()
        {
            
            DataTable dt = new DataTable();
            
            dt.Clear();
            dt = dao.datosNombres();
            //CbPeliculas.Text = dt.Rows[1][1].ToString();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CbPeliculas.Items.Add(dt.Rows[i][0].ToString());
            }
            
            //CbPeliculas.DataSource = dt.Rows[1][1].ToString();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            obtenerPeliculas();
        }





        private void label1_Click(object sender, EventArgs e)
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
             
            };

            bool resultado = dao.agregar(pelicula);
          


        }
        public void limpiarDatos()
        {
            txtNombre.Text = "";
         
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CbPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
