using DevExpress.XtraEditors;
using System;
using System.Linq;
using facturacionApp.Datos;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.Office;

namespace facturacionApp.Componentes
{
    public partial class Productos : DevExpress.XtraEditors.XtraForm
    {
        public int? id;
        productos oItem = null;

        public Productos()
        {
            InitializeComponent();
            if (id != null)
                CargaDatos();
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            Proveedores();
            ActualizaDatos();
        }
        private void Proveedores()
        {
            try
            {
                using (var db = new DATA())
                {
                    var Proveedores = db.proveedores.ToList();
                    cmbProveedores.DisplayMember = "nombre";
                    cmbProveedores.ValueMember = "id";
                    cmbProveedores.DataSource = Proveedores;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill("SELECT * FROM ViewProductos");
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
            using (var db = new DATA())
            {
                oItem = db.productos.Find(id);
                this.id = id;
                cmbProveedores.SelectedValue = oItem.idProveedor;
                txtCodigo.Text = oItem.codigo;
                txtDescripcion.Text = oItem.descripcion;
                txtPrecio.Text = oItem.precio.ToString();
                txtCosto.Text = oItem.costo.ToString();
                txtISV.Text = oItem.impuesto.ToString();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new DATA())
            {
                try
                {
                    if (id == null)

                    oItem = new productos();

                    oItem.idProveedor = int.Parse(cmbProveedores.SelectedValue.ToString());

                if (id == null)
                {
                        oItem.codigo = txtCodigo.Text;

                }


                    oItem.descripcion = txtDescripcion.Text;
                    oItem.precio = decimal.Parse(txtPrecio.Text);
                    oItem.costo = decimal.Parse(txtCosto.Text);
                    oItem.impuesto = decimal.Parse(txtISV.Text);
                    oItem.fechaRegistro = DateTime.Now;
                    oItem.usuario = "Administrador";
                    oItem.cantidadExistencia = 0;

                    if (id == null)
                        db.productos.Add(oItem);

                    else
                    {
                        db.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
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
                catch (Exception)
                {
                    MessageBox.Show("Estimado asegurese que el codigo que está ingresando no existe en la base de datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var db = new DATA())
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new DATA())
            {
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int? id = GetId();

                    if (id != null)
                    {
                        productos oItem = db.productos.Find(id);
                        db.productos.Remove(oItem);
                        db.SaveChanges();
                        ActualizaDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}