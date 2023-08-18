using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using facturacionApp.Datos;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;

namespace facturacionApp.Componentes
{
    public partial class OrdenDeCompra : DevExpress.XtraEditors.XtraForm
    {
        DATA db = new DATA();
        public int? id;
        ordenCompra OC = null;

        public OrdenDeCompra()
        {
            InitializeComponent();
        }

        private void OrdenDeCompra_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
            Proveedores();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                // Obtén el valor de la columna que determinará el color de la fila
                string valorColumna = view.GetRowCellDisplayText(e.RowHandle, view.Columns["ESTADO"]);

                // Verifica la condición y establece el estilo si se cumple
                if (valorColumna == "CERRADA")
                {
                    e.Appearance.BackColor = Color.Red;  // Establece el color de fondo de la fila
                    e.Appearance.ForeColor = Color.White;  // Establece el color del texto de la fila
                }
            }
        }

        private void ActualizaDatos()
        {
            var dt = DgvFill("SELECT * FROM ViewOrdenesCompra");
            dgvDatos.DataSource = dt;
        }

        private void Proveedores()
        {
            var proveedor = db.proveedores.ToList();
            cmbProveedor.DisplayMember = "nombre";
            cmbProveedor.ValueMember = "id";
            cmbProveedor.DataSource = proveedor;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int ProveedorSeleccionado = Convert.ToInt32(cmbProveedor.SelectedValue.ToString());

            proveedores oProveedor = db.proveedores.FirstOrDefault(x => x.id == ProveedorSeleccionado);


            if (id == null)
                OC = new ordenCompra();

            OC.numeroOC = txtNumOC.Text;
            OC.idProveedor = oProveedor.id;
            OC.nombreProveedor = oProveedor.nombre;
            OC.nota = txtNota.Text;

            if (id == null)
            {
                OC.fechaRegistro = DateTime.Now;
            }

            OC.fechaCierre = DateTime.Now;
            OC.fechaActualizacion = DateTime.Now;
            OC.numeroReferenciaFactura = txtNumReferencia.Text;
            OC.subtotal = 0;
            OC.impuesto = 0;
            OC.total = 0;
            OC.estado = 0;
            OC.usuario = "Administrador";

            if (id == null)
                db.ordenCompra.Add(OC);
            else
            {
                db.Entry(OC).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();

            ActualizaDatos();
            LimpiaControl(this);
            id = null;
        }
        private void CargaDatos(int? id = null)
        {
            OC = db.ordenCompra.Find(id);
            this.id = id;
            cmbProveedor.SelectedValue = OC.idProveedor;
            txtNumReferencia.Text = OC.numeroReferenciaFactura.ToString();
            txtNota.Text = OC.nota;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int? id = GetId();

                if (id != null)
                {
                    ordenCompra OC = db.ordenCompra.Find(id);

                    if (OC.subtotal == 0 && OC.total == 0)
                    {
                        db.ordenCompra.Remove(OC);
                        db.SaveChanges();
                        ActualizaDatos();
                    }
                    else
                    {
                        MessageBox.Show("Ésta Orden de Compra tiene productos, asegurese de que esté vacia para proceder a eliminarla.", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros para eliminar.", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception error)
            {
                MessageBox.Show("No se editó\n\n" + error, "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnOCDetalle_Click(object sender, EventArgs e)
        {
            GridView dataGridView1 = gridView1 as GridView;
            int[] SelectedRowHandles = dataGridView1.GetSelectedRows();

            if (SelectedRowHandles != null)
            {
                int? id = GetId();

                if (id != null)
                {
                    OrdenDeCompraDetalle oDetalleOC = new OrdenDeCompraDetalle(id);
                    oDetalleOC.MdiParent = this.MdiParent;
                    oDetalleOC.Show();

                    ActualizaDatos();
                }
            }
            else
            {
                MessageBox.Show("No haz seleccionado una fila valida ó asegurate de tener registros en la tabla!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}