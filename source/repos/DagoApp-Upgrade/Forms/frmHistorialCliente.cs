using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DagoApp_.Models;
using DagoApp_.Forms;
using DagoApp_.ReportForms;
using System.Data.SqlClient;
using static DagoApp_.Class.LLENAGRIDVIEW;

namespace DagoApp_.Forms
{
    public partial class frmHistorialCliente : Form
    {
       // SqlConnection conexion = new SqlConnection(@"data source=.;initial catalog=DBIR;persist security info=True;user id=sa;password=admin2022.;MultipleActiveResultSets=True;App=EntityFramework");

        DATA db = new DATA();

        public int? id;

        //frmHistorialCliente HistorialClientes = null;

        public frmHistorialCliente(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                CargaHistorialClientes();
        }

        private void CargaHistorialClientes()
        {

            var dt = DgvFill("EXEC HISTORIAL_CLIENTE_GRID " + id + " ");
            dgvHistorialCliente.DataSource = dt;

                dgvHistorialCliente.RowHeadersVisible = false;
                dgvHistorialCliente.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgvHistorialCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvHistorialCliente.ForeColor = Color.Black;
                dgvHistorialCliente.EnableHeadersVisualStyles = false;
                dgvHistorialCliente.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvHistorialCliente.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                 var dtCabeceraHistorialCliente = DgvFill("EXEC HISTORIAL_CLIENTE_CABECERA " + id + " ");
            try
                {
                    if (dgvHistorialCliente.Rows.Count > 0)
                    {
                        txtIDCliente.Text = dtCabeceraHistorialCliente.Rows[0][0].ToString();
                        txtNombreCliente.Text = dtCabeceraHistorialCliente.Rows[0][1].ToString();
                        txtCorreoCliente.Text = dtCabeceraHistorialCliente.Rows[0][2].ToString();
                        txtNumTarjetCliente.Text = dtCabeceraHistorialCliente.Rows[0][3].ToString();
                        txtFVTarjeta.Text = dtCabeceraHistorialCliente.Rows[0][4].ToString();
                        txtTelefonoCliente.Text = dtCabeceraHistorialCliente.Rows[0][5].ToString();
                        txtPinCliente.Text = dtCabeceraHistorialCliente.Rows[0][6].ToString();

                        //EXTRAEMOS DATOS DE DATATABLE 2 PARA RELLENAR CABECERA EMPRESA
                        txtIDEmpresa.Text = dtCabeceraHistorialCliente.Rows[0][7].ToString();
                        txtEmpresa.Text = dtCabeceraHistorialCliente.Rows[0][8].ToString();
                        txtDireccionE.Text = dtCabeceraHistorialCliente.Rows[0][9].ToString();

                        //EXTRAEMOS DATOS DE DATATABLE 2 PARA RELLENAR CABECERA PRESTAMOS
                        txtInteresRecibido.Text = dtCabeceraHistorialCliente.Rows[0][10].ToString();
                        txtCapitalRecibido.Text = dtCabeceraHistorialCliente.Rows[0][11].ToString();
                    }

                    return;
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void frmHistorialCliente_Load(object sender, EventArgs e)
        {
            CargaHistorialClientes();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (id != null)
            {

                rptHistorialClientes hcfrm = new rptHistorialClientes(id);
            hcfrm.ShowDialog();

            }
        }
    }
}
