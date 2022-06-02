using ProyectoPeliculas.Controller.Rentas;
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

namespace ProyectoPeliculas.View.Renta
{
    public partial class MostrarRentas : Form
    {
        public MostrarRentas()
        {
            InitializeComponent();
        }
        private void MostrarRentas_Load(object sender, EventArgs e)
        {
            obtenerRentas();
        }
        DAORentas dao = new DAORentas();
        public void obtenerRentas()
        {

            DataTable dt = new DataTable();
            dt.Clear();
            if (cbFiltro.Text == "Activas")
            {
                dt = dao.MostrarRentasActivas();
            }
            else if (cbFiltro.Text == "Inactivas")
            {
                dt = dao.MostrarRentasInactivas();
            }
            else if (cbFiltro.Text == "Todas")
            {
                dt = dao.MostrarRentasTodas();
            }

            dgvRentas.DataSource = dt;

        }

        public void obtenerRentasLike()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            if (cbFiltro.Text == "Activas")
            {
                dt = dao.datosLike(txtBusqueda.Text, " && Activa = 1");
            }
            else if (cbFiltro.Text == "Inactivas")
            {
                dt = dao.datosLike(txtBusqueda.Text, " && Activa = 0");
            }
            else if (cbFiltro.Text == "Todas")
            {
                dt = dao.datosLike(txtBusqueda.Text, "");
            }
            dgvRentas.DataSource = dt;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerRentas();
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            obtenerRentasLike();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DTORentas renta = new DTORentas();
                renta.idRenta = int.Parse(dgvRentas.Rows[dgvRentas.CurrentRow.Index].Cells[0].Value.ToString());
                renta.Nombre = dgvRentas.Rows[dgvRentas.CurrentRow.Index].Cells[1].Value.ToString();
                renta.FechaRenta = DateTime.Parse(dgvRentas.Rows[dgvRentas.CurrentRow.Index].Cells[2].Value.ToString());
                renta.FechaDevolucion = DateTime.Parse(dgvRentas.Rows[dgvRentas.CurrentRow.Index].Cells[3].Value.ToString());
                renta.TotalPagar = double.Parse(dgvRentas.Rows[dgvRentas.CurrentRow.Index].Cells[4].Value.ToString());
                renta.Estatus = Convert.ToBoolean(dgvRentas.Rows[dgvRentas.CurrentRow.Index].Cells[5].Value.ToString());

                ActualizarRenta modificar = new ActualizarRenta(renta);
                modificar.ShowDialog();
                obtenerRentas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una Renta");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
