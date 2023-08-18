using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using facturacionApp.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;
using ComboBox = System.Windows.Forms.ComboBox;

namespace facturacionApp.Componentes
{
    public partial class Clientes : DevExpress.XtraEditors.XtraForm
    {
        DATA db = new DATA();

        public int? id;

        clientes oClientes = null;

        public Clientes(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
        }

        private void ActualizaDatos()
        {
            var dt = DgvFill("SELECT * FROM ViewClientes");
            dgvDatos.DataSource = dt;
        }

        private int? GetId()
        {
            try
            {
                GridView dataGridView1 = gridView1 as GridView;
                int[] SelectedRowHandles = dataGridView1.GetSelectedRows();
                string Valor = dataGridView1.GetRowCellValue(SelectedRowHandles[0], dataGridView1.Columns[0]).ToString();
                return int.Parse(Valor.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void CargaDatos(int? id = null)
        {
            oClientes = db.clientes.Find(id);
            this.id = id;
            txtNombreEmpresa.Text = oClientes.nombre;
            txtDireccion.Text = oClientes.direccion;
            txtTelefono.Text = oClientes.telefono;
            txtEmail.Text = oClientes.correoE;
            txtDepto.Text = oClientes.departamento;
            txtMunicipio.Text = oClientes.municipio;
            txtNombrePropietario.Text = oClientes.contacto;
            txtPrecioSugerido.Text = oClientes.precioSugerido.ToString();
            txtRtn.Text = oClientes.rtn;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id == null)

                oClientes = new clientes();

            oClientes.nombre = txtNombreEmpresa.Text;
            oClientes.direccion = txtDireccion.Text;
            oClientes.telefono = txtTelefono.Text;
            oClientes.correoE = txtEmail.Text;
            oClientes.departamento = txtDepto.Text;
            oClientes.municipio = txtMunicipio.Text;
            oClientes.contacto = txtNombrePropietario.Text;
            oClientes.rtn = txtRtn.Text;
            oClientes.precioSugerido = Convert.ToDecimal(txtPrecioSugerido.Text);
            oClientes.usuario = "Administrador";
            oClientes.fechaCreacion = DateTime.Now;
            oClientes.fechaActualizacion = DateTime.Now;


            if (id == null)
                db.clientes.Add(oClientes);

            else
            {
                db.Entry(oClientes).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();

            ActualizaDatos();
            LimpiaControl(this);

            if (id != null)
            {
                gridView1.FocusedRowHandle = (int)id;
            }
            else
            {
                gridView1.FocusedRowHandle = 0;
            }
            id = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int? id = GetId();

                if (id != null)
                {
                    clientes oCliente = db.clientes.Find(id);
                    db.clientes.Remove(oCliente);
                    db.SaveChanges();
                    ActualizaDatos();
                }
                else
                {
                    MessageBox.Show("No se eliminó", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = GetId();
                if (id != null)
                {
                    CargaDatos(id);
                    ActualizaDatos();
                    gridView1.FocusedRowHandle = (int)id - 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se editó", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}