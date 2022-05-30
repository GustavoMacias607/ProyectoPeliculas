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
    public partial class MostarPeliculas : Form
    {
        public MostarPeliculas()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            modificarEstatus();
            obtenerPeliculas();
            
        }
        public void modificarEstatus()
        {
            DAOPeliculas dao = new DAOPeliculas();
            dao.ModificarEstatus();
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }
        DAOPeliculas dao = new DAOPeliculas();
        
        public void obtenerPeliculas()
        {
           
            DataTable dt = new DataTable();
            dt.Clear();
            if (cbFiltro.Text == "Disponibles")
            {
                dt = dao.datosDisponibles();
            }
            else if (cbFiltro.Text == "Agotada")
            {
                dt = dao.datosAgotados();
            }
            else if (cbFiltro.Text == "Todas")
            {
                dt = dao.datosTodos();
            }
            
            dgvPeliculas.DataSource = dt;

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

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                DTOPeliculas peliculas = new DTOPeliculas();
                peliculas.IdPeliculas = int.Parse(dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[0].Value.ToString());
                peliculas.Nombre = dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[1].Value.ToString();
                peliculas.Clasificacion = dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[2].Value.ToString();
                peliculas.Duracion = dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[3].Value.ToString();
                peliculas.PeliculasDisponibles = int.Parse(dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[4].Value.ToString());
                peliculas.Precio = double.Parse(dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[5].Value.ToString());
                peliculas.Genero = dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[6].Value.ToString();
                peliculas.Director = dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[7].Value.ToString();
                peliculas.AnoLanzamiento = DateTime.Parse(dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[8].Value.ToString());
                peliculas.Status = Convert.ToBoolean(dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[9].Value.ToString());
                UpdatePelicula modificar = new UpdatePelicula(peliculas);
                modificar.ShowDialog();
                obtenerPeliculas();

            }
            catch (Exception ex)
            {


            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerPeliculas();
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            obtenerPeliculasLike();
        }

        public void obtenerPeliculasLike()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            if(cbFiltro.Text == "Disponibles")
            {
                dt = dao.datosLike(txtBusqueda.Text, " && Estatus = 1");
            }else if (cbFiltro.Text == "Agotada")
            {
                dt = dao.datosLike(txtBusqueda.Text, " && Estatus = 0");
            }
            else if (cbFiltro.Text == "Todas")
            {
                dt = dao.datosLike(txtBusqueda.Text, "");
            }
            dgvPeliculas.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
