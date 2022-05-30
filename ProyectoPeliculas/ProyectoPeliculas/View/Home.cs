using ProyectoPeliculas.View.Renta;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        AddPelicula agregar = new AddPelicula();
        MostarPeliculas mostrar = new MostarPeliculas();
        AddRenta renta = new AddRenta();
        MostrarRentas mosRentas = new MostrarRentas();
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agregar.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar.ShowDialog();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            renta.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mosRentas.ShowDialog();
        }
    }
}
