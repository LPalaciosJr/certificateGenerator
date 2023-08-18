using DevExpress.Office;
using DevExpress.XtraGrid.Views.Grid;
using facturacionApp.Datos;
using facturacionApp.Reportes.Contenedores;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;

namespace facturacionApp.Componentes
{
    public partial class OrdenDeCompraDetalle : DevExpress.XtraEditors.XtraForm
    {
        DATA db = new DATA();
        public int? id;
        //public int? OC_Detalle;

        ordenCompraDetalle ocd = null;
        public OrdenDeCompraDetalle(int? id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void OrdenDeCompraDetalle_Load(object sender, EventArgs e)
        {
            Productos();
            ActualizaDatos();

            ordenCompra OC = db.ordenCompra.FirstOrDefault(x=> x.id==id);
            if (OC.estado == 1)
            {
                cmbProducto.Enabled= false;
                txtCodigo.Enabled= false;
                txtCantidad.Enabled= false;
                txtCosto.Enabled= false;
                txtImpuesto.Enabled= false;

                btnGuardar.Enabled= false;
                btnEditar.Enabled= false;
                btnEliminar.Enabled= false;
                btnCerrarOC.Enabled= false;
            }
            else
            {
                cmbProducto.Enabled = true;
                txtCodigo.Enabled = true;
                txtCantidad.Enabled = true;
                txtCosto.Enabled = true;
                txtImpuesto.Enabled = true;

                btnGuardar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCerrarOC.Enabled = true;
            }
        }

        private void ActualizaDatos()
        {
            var dt = DgvFill($"EXEC GRIDORDENESCOMPRADETALLE '{id}'");
            dgvDatos.DataSource = dt;
        }

        private void Productos()
        {
            var producto = db.productos.ToList();
            cmbProducto.DisplayMember = "descripcion";
            cmbProducto.ValueMember = "id";
            cmbProducto.DataSource = producto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int ProductoSeleccionado = Convert.ToInt32(cmbProducto.SelectedValue.ToString());
                productos OProductos = db.productos.FirstOrDefault(x => x.id == ProductoSeleccionado);

                txtCodigo.Text = OProductos.codigo.ToString();
                txtCosto.Text = OProductos.costo.ToString();
                txtImpuesto.Text = OProductos.impuesto.ToString();

                ordenCompraDetalle DetalleOC = new ordenCompraDetalle();
                DetalleOC.codigoProducto = OProductos.codigo;
                DetalleOC.descripcionProducto = OProductos.descripcion;
                DetalleOC.costo = decimal.Parse(txtCosto.Text);
                DetalleOC.cantidad = decimal.Parse(txtCantidad.Text);
                DetalleOC.impuesto = decimal.Parse(txtImpuesto.Text);
                DetalleOC.subtotal = DetalleOC.cantidad * DetalleOC.costo;
                DetalleOC.impuestoTotal = (DetalleOC.costo * DetalleOC.impuesto / 100) * DetalleOC.cantidad;
                DetalleOC.total = DetalleOC.subtotal + DetalleOC.impuestoTotal;
                DetalleOC.fechaRegistro = DateTime.Now;
                DetalleOC.fechaActualizacion = DateTime.Now;
                DetalleOC.usuario = "Administrador";
                DetalleOC.IdOrdenCompra = id;

                db.ordenCompraDetalle.Add(DetalleOC);
                db.SaveChanges();

                ordenCompra OC = db.ordenCompra.Where(c => c.id == id).FirstOrDefault();
                OC.subtotal += DetalleOC.subtotal;
                OC.impuesto += DetalleOC.impuestoTotal;
                OC.total += DetalleOC.total;
                db.SaveChanges();

                ActualizaDatos();
                LimpiaControl(this);
            }
            catch (Exception error)
            {
                MessageBox.Show("OCURRIO UN ERROR\n\n"+error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Productos();

            int valorCmb = int.Parse(cmbProducto.SelectedValue.ToString());
            productos oProductos = db.productos.FirstOrDefault(i => i.id == valorCmb);

            txtCodigo.Text = oProductos.codigo;
            txtCosto.Text = oProductos.costo.ToString();
            txtImpuesto.Text = oProductos.impuesto.ToString();
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int? idRowOCDetalle = GetId();

                if (idRowOCDetalle != null)
                {
                    ordenCompraDetalle DetalleOC = db.ordenCompraDetalle.Find(idRowOCDetalle);

                    ordenCompra OC = db.ordenCompra.FirstOrDefault(c => c.id == id);
                    OC.impuesto = OC.impuesto - DetalleOC.impuestoTotal;
                    OC.subtotal = OC.subtotal - DetalleOC.subtotal;
                    OC.total = OC.total - DetalleOC.total;

                    db.ordenCompraDetalle.Remove(DetalleOC);
                    db.SaveChanges();
                    ActualizaDatos();
                    idRowOCDetalle = null;
                }
            }
        }
        private void btnCerrarOC_Click(object sender, EventArgs e)
        {
            ordenCompra OC = db.ordenCompra.FirstOrDefault(oc => oc.id==id);
            OC.fechaCierre = DateTime.Now;
            OC.estado = 1;
            
            ordenCompraDetalle OCD = db.ordenCompraDetalle.FirstOrDefault(o => o.IdOrdenCompra == OC.id);

            productos oProductos = db.productos.Where(p => p.codigo == OCD.codigoProducto).FirstOrDefault();
            oProductos.cantidadExistencia = oProductos.cantidadExistencia + OCD.cantidad;
            db.SaveChanges();

            MessageBox.Show("Su Orden de Compra se ha cerrado exitosamente");

            this.Close();

        }

        private void btnPrintOC_Click(object sender, EventArgs e)
        {
            //int? idOC = GetId();

            Contenedor_OrdenCompra OC = new Contenedor_OrdenCompra(id);
            OC.ShowDialog();
        }

        private void CargaDatos(int? id = null)
        {
            ocd = db.ordenCompraDetalle.Find(id);
            this.id = id;
            cmbProducto.SelectedValue = ocd.codigoProducto;
            txtCodigo.Text = ocd.codigoProducto.ToString();
            txtCosto.Text = ocd.costo.ToString();
            txtImpuesto.Text = ocd.impuesto.ToString();
            txtCantidad.Text = ocd.cantidad.ToString();
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