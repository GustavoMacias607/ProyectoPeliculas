using ProyectoPeliculas.Controller;
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

namespace ProyectoPeliculas
{
    public partial class ActualizarRenta : Form
    {
        public ActualizarRenta()
        {
            InitializeComponent();
        }


        public ActualizarRenta (DTORentas rentas)
        {
            InitializeComponent();
            //codigo para mostrar los datos de las peliculas
            txtNombre.Text = rentas.Nombre;
            DTPFechaRenta.Value = rentas.FechaRenta;
            DTPFechaDevolucion.Value = rentas.FechaDevolucion;
            lblTotal.Text = rentas.TotalPagar.ToString();
            txtIdRenta.Text = rentas.idRenta.ToString();

            if (rentas.Estatus)
            {
                chkIsActive.Checked = true;

            }
            else
            {
                chkIsActive.Checked = false;

            }
        }

        public bool ValCantidades()
        {
            bool result = false;
            idpel();
            DAORentas dao = new DAORentas();
            DAOPeliculas da = new DAOPeliculas();
            DataTable dt = new DataTable();
            dt.Clear();
            

            dt = dao.IndiceAuxRentas();
            DTORentas id = new DTORentas()
            {
                idRentaAux = int.Parse(txtIdRenta.Text)
            };
            dt.Clear();
            dt = dao.ValidacionCantidad();
            int con = idContPelis - 1;


            int cant = int.Parse(txtCantidad.Text);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (idContPelis == int.Parse(dt.Rows[i][0].ToString()))
                {
                    if (int.Parse(txtCantidad.Text.ToString()) <= int.Parse(dt.Rows[i][1].ToString()))
                    {
                        
                            MessageBox.Show("bien");
                            result = true;
                        cant = int.Parse(dt.Rows[i][1].ToString()) - int.Parse(txtCantidad.Text.ToString());
                        dao.ModificarCantidad(cant, idContPelis);
                        break;
                    }
                    else
                    {
                            MessageBox.Show("mal");
                            result = false;
                    }
                    
                }
            }
            

            

            return result; 
        }

        public void modificarEstatus()
        {
            DAOPeliculas dao = new DAOPeliculas();
            dao.ModificarEstatus();
            
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dao.MostarPel();
            DGVPel.DataSource = dt;
        }
        public void modificarEstatusM()
        {
            DAOPeliculas dao = new DAOPeliculas();
            dao.ModificarEstatusM();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dao.MostarPel();
            DGVPel.DataSource = dt;
            
            
        }
        public void mostrarTablita()
        {
            DAOPeliculas dao = new DAOPeliculas();
            
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dao.MostarPel();
            DGVPel.DataSource = dt;
        }


        public void costoTotal()
        {
            
            DAORentas dao = new DAORentas();

            DataTable dt = new DataTable();
            dt.Clear();
            dt = dao.IndiceAuxRentas();
            DTORentas id = new DTORentas()
            {
                idRentaAux = int.Parse(txtIdRenta.Text)
            };
            dt.Clear();
            dt = dao.PrecioTotalActu(id);
            double costo = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                costo += double.Parse(dt.Rows[i][3].ToString()) * double.Parse(dt.Rows[i][4].ToString());

            }
            lblTotal.Text = costo.ToString();
        }


        public void obtenerPeliculas()
        {
            DAOPeliculas dao = new DAOPeliculas();

            DataTable dt = new DataTable();

            dt.Clear();
            dt = dao.datosDisponibles();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CbPeliculas.Items.Add(dt.Rows[i][1].ToString());

            }

        }
        public void mostrarAux()
        {
            DAORentas dao = new DAORentas();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dao.IndiceAuxRentas();
            DTORentas id = new DTORentas()
            {
                idRentaAux = int.Parse(txtIdRenta.Text)

            };

            dt = dao.MostarAuxActu(id);
            DGVPeliculas.DataSource = dt;
            DGVPeliculas.Columns[0].Visible = false;
            DGVPeliculas.Columns[3].Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            obtenerPeliculas();
           
            mostrarAux();
            costoTotal();
            DAOPeliculas dao = new DAOPeliculas();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dao.MostarPel();
            DGVPel.DataSource = dt;
            DTPFechaDevolucion.Value = DTPFechaRenta.Value.AddDays(5);
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
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Favor de ingresar un Nombre");
                txtNombre.Focus();
            }
            else
            {


                DAORentas dao = new DAORentas();

                DTORentas renta = new DTORentas()
                {
                    idRenta = int.Parse(txtIdRenta.Text),
                    Nombre = txtNombre.Text,
                    FechaRenta = DTPFechaRenta.Value,
                    FechaDevolucion = DTPFechaDevolucion.Value,
                    TotalPagar = double.Parse(lblTotal.Text),

                };


                if (chkIsActive.Checked)
                    renta.Estatus = true;
                else
                    renta.Estatus = false;

                txtIdRenta.Text = renta.idRenta.ToString();

                bool resultado = dao.ModificarRenta(renta);

                if (resultado)
                {
                    limpiarDatos();
                    MessageBox.Show("Se modifico Correctamente el " + renta.Nombre);
                    limpiarNombre();

                }
                else
                {
                    limpiarDatos();
                    MessageBox.Show("Hubo un error verifica e intenta mas tarde ");
                }
                this.Close();
            }
        }
        public void limpiarDatos()
        {
            
            
            lblTotal.Text = "0";
            CbPeliculas.Text = "";
            
        }
        public void limpiarNombre()
        {
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void lad_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CbPeliculas.Items.Clear();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
        static int idContPelis = 0;
        public void idpel()
        {
            DataTable dn = new DataTable();
            DAOPeliculas da = new DAOPeliculas();
            dn.Clear();
            dn = da.datosNombresId();

            for (int i = 0; i < dn.Rows.Count; i++)
            {

                if (CbPeliculas.Text == dn.Rows[i][0].ToString())
                {
                    idContPelis = i + 1;
                }


            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (txtCantidad.Text == "" ||int.Parse(txtCantidad.Text.ToString()) <= 0  || CbPeliculas.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos o ingrese una cantidad valida");
            }
            else
            {



                if (ValCantidades())
                {




                    idpel();
                    DAORentas dao = new DAORentas();
                    DataTable dt = new DataTable();

                    dt.Clear();
                    dt = dao.IndiceAuxRentas();

                    DTORentas aux = new DTORentas()
                    {
                        idRentaAux = int.Parse(txtIdRenta.Text),

                        idPeliculaRentada = int.Parse(idContPelis.ToString()),
                        Cantidad = int.Parse(txtCantidad.Text.ToString())







                    };


                    bool resultado = dao.IdPeliculas(aux);
                    modificarEstatus();

                    mostrarAux();
                    costoTotal();

                    if (resultado)
                    {
                        limpiarDatos();
                        costoTotal();
                        CbPeliculas.Items.Clear();
                        obtenerPeliculas();

                    }
                    else
                    {
                        limpiarDatos();

                    }
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor de Ingresar los Valores Correspondientes");

            }
        } 
        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string nombrePeli;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               
                DAORentas dao = new DAORentas();
                DataTable dt = new DataTable();

                dt.Clear();
                dt = dao.IndiceAuxRentas();

                DataTable dn = new DataTable();
                DAOPeliculas da = new DAOPeliculas();
                dn.Clear();
                dn = da.datosNombresId();
                nombrePeli = DGVPeliculas.Rows[DGVPeliculas.CurrentRow.Index].Cells[1].Value.ToString();
                int AuxIdPelicula = 0;
                for (int i = 0; i < dn.Rows.Count; i++)
                {

                    if (nombrePeli == dn.Rows[i][0].ToString())
                    {
                        AuxIdPelicula = i + 1;
                    }


                }

            
                DTORentas aux = new DTORentas()
                {
                    idRentaAux = int.Parse(txtIdRenta.Text),
                    idPeliculaRentada = int.Parse(AuxIdPelicula.ToString()),
               

                };
            
           

                int cant = 0; 

                dt = dao.ValidacionCantidad();
                dn = da.MostrarAuxTalcual(aux);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (int.Parse(dt.Rows[i][0].ToString()) == AuxIdPelicula)
                    {
                        cant =  int.Parse(dt.Rows[i][1].ToString());
                    }
                }
                for (int i = 0; i < dn.Rows.Count; i++)
                {
                    if (int.Parse(dn.Rows[i][1].ToString()) == AuxIdPelicula)
                    {
                        cant = int.Parse(dn.Rows[i][2].ToString()) + cant;
                    }
                }
                DAOPeliculas mo = new DAOPeliculas();
                dao.ModificarCantidad(cant, AuxIdPelicula);
                mostrarAux();
                costoTotal();
                mostrarTablita();
                bool resultado = dao.Modificar(aux);
                if (resultado)
                {
                    mostrarAux();
                    limpiarDatos();
                    costoTotal();
                    mo.ModificarEstatusM();
                    CbPeliculas.Items.Clear();
                    obtenerPeliculas();
                    mostrarTablita();
                }
                else
                {
                    limpiarDatos();
                
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Favor de seleccionar una Opcion");
            }

        }

       
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            DTPFechaDevolucion.Value = DTPFechaRenta.Value.AddDays(5);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (DGVPel.Visible == false)
            {
                DGVPel.Visible = true;
            }
            else
            {
                DGVPel.Visible = false;
            }
        }

        private void DGVPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
