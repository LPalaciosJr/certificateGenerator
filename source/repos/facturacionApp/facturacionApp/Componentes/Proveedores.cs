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

namespace facturacionApp.Componentes
{
    public partial class Proveedores : DevExpress.XtraEditors.XtraForm
    {
        DATA db = new DATA();
        public int? id;
        proveedores oProveedor = null;

        public Proveedores(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }
        private void Proveedores_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill("SELECT * FROM ViewProveedores");
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
            //using (var db = new DATA())
            //{
            oProveedor = db.proveedores.Find(id);
            this.id = id;
            txtNombreProveedor.Text = oProveedor.nombre;
            txtDireccion.Text = oProveedor.direccion;
            txtTelefono.Text = oProveedor.telefono;
            txtEmail.Text = oProveedor.correoE;
            txtDepto.Text = oProveedor.departamento;
            txtMunicipio.Text = oProveedor.municipio;
            txtNombrePropietario.Text = oProveedor.contacto;
            txtRtn.Text = oProveedor.rtn;
            //}
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //using (var db = new DATA())
            //{
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int? id = GetId();

                if (id != null)
                {
                    proveedores oProveedor = db.proveedores.Find(id);
                    db.proveedores.Remove(oProveedor);
                    db.SaveChanges();
                    ActualizaDatos();
                }
                else
                {
                    MessageBox.Show("No se eliminó", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //}
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //using (var db = new DATA())
            //{
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
            //}
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //using (var db = new DATA())
            //{
            //int ultimoID = db.Supplier.Any() ? db.Supplier.Max(c => c.ID) : 0;
            //ultimoID++;
            //string numeroCuenta = ultimoID.ToString().PadLeft(7, '0');

            if (id == null)

                oProveedor = new proveedores();

            //if (id is null)
            //{
            //    oProveedor.Code = numeroCuenta;
            //}

            oProveedor.nombre = txtNombreProveedor.Text;
            oProveedor.direccion = txtDireccion.Text;
            oProveedor.telefono = txtTelefono.Text;
            oProveedor.correoE = txtEmail.Text;
            oProveedor.departamento = txtDepto.Text;
            oProveedor.municipio = txtMunicipio.Text;
            oProveedor.contacto = txtNombrePropietario.Text;
            oProveedor.rtn = txtRtn.Text;
            oProveedor.usuario = "Administrador";
            oProveedor.fechaCreacion = DateTime.Now;
            oProveedor.fechaActualizacion = DateTime.Now;

            if (id == null)
                db.proveedores.Add(oProveedor);

            else
            {
                db.Entry(oProveedor).State = System.Data.Entity.EntityState.Modified;
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
        //}
    }
}