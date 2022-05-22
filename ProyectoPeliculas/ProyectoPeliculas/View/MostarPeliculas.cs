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

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DAOPeliculas1 dao = new DAOPeliculas1();
        private void Home_Load(object sender, EventArgs e)
        {
            obtenerProductos();
        }
        public void obtenerProductos()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dao.datos();
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
    }
}
