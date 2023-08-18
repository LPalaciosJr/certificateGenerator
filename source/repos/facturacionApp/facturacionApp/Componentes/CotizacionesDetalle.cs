using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using facturacionApp.Datos;
using facturacionApp.Reportes.Contenedores;
using System;
using System.Linq;
using System.Windows.Forms;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;

namespace facturacionApp.Componentes
{
    public partial class CotizacionesDetalle : DevExpress.XtraEditors.XtraForm
    {
        DATA db = new DATA();
        public int? id;
        public int? idCotizacionDetalle;
        int valorCmb = 1;

        public CotizacionesDetalle(int? id, int? idCotizacionDetalle)
        {
            InitializeComponent();
            this.id = id;
            this.idCotizacionDetalle = idCotizacionDetalle;
        }
        private void CotizacionesDetalle_Load(object sender, EventArgs e)
        {
            lblNumCotizacion.Text = "COTIZACIÓN " + id.ToString();

            txtCodigo.Enabled = false;
            txtImpuesto.Enabled = false;

            ActualizaDatos();
            Productos();
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill($"select * from cotizacionesDetalle where idCotizacion = '{id}'");
            dgvDatos.DataSource = dt;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new DATA())
            {
                productos oItem = db.productos.Where(i => i.codigo == cmbProducto.SelectedValue.ToString()).FirstOrDefault();

                txtCodigo.Text = oItem.codigo.ToString();
                txtPrecio.Text = oItem.precio.ToString();
                txtImpuesto.Text = oItem.impuesto.ToString();

                cotizacionesDetalle oDetalleCotizacion = new cotizacionesDetalle();
                oDetalleCotizacion.idProducto = int.Parse(oItem.codigo);
                oDetalleCotizacion.descripcion = oItem.descripcion;
                oDetalleCotizacion.costo = decimal.Parse(txtPrecio.Text);
                oDetalleCotizacion.cantidad = decimal.Parse(txtCantidad.Text);
                oDetalleCotizacion.impuesto = decimal.Parse(oItem.impuesto.ToString());
                oDetalleCotizacion.usuario = "Administrador";
                oDetalleCotizacion.fechaRegistro = DateTime.Now;
                oDetalleCotizacion.subtotal = oDetalleCotizacion.costo * oDetalleCotizacion.cantidad;
                oDetalleCotizacion.impuestoTotal = (oDetalleCotizacion.costo * oDetalleCotizacion.impuesto / 100) * oDetalleCotizacion.cantidad;
                oDetalleCotizacion.total = oDetalleCotizacion.subtotal + oDetalleCotizacion.impuestoTotal;
                oDetalleCotizacion.idCotizacion = id;

                db.cotizacionesDetalle.Add(oDetalleCotizacion);
                db.SaveChanges();

                cotizaciones oCotizacion = db.cotizaciones.Where(c => c.idCotizacion == id).FirstOrDefault();
                oCotizacion.subtotal += oDetalleCotizacion.subtotal;
                oCotizacion.impuesto += oDetalleCotizacion.impuestoTotal;
                oCotizacion.total += oDetalleCotizacion.total;
                db.SaveChanges();

                ActualizaDatos();
                LimpiaControl(this);
            }
        }
        private void Productos()
        {
            try
            {
                using (var db = new DATA())
                {
                    var producto = db.productos.ToList();
                    cmbProducto.DisplayMember = "descripcion";
                    cmbProducto.ValueMember = "codigo";
                    cmbProducto.DataSource = producto;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DATA())
            {
                int valorCmb = int.Parse(cmbProducto.SelectedValue.ToString());

                productos oProductos = db.productos.FirstOrDefault(i => i.codigo == valorCmb.ToString());

                txtCodigo.Text = oProductos.codigo;
                txtPrecio.Text = oProductos.precio.ToString();
                txtImpuesto.Text = oProductos.impuesto.ToString();
            }
        }
        private void CargaDatos()
        {
            int[] selectedRows = gridView1.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                int rowHandle = selectedRows[0];

                string idProducto = gridView1.GetRowCellValue(rowHandle, "idProducto").ToString();
                string cantidad = gridView1.GetRowCellValue(rowHandle, "cantidad").ToString();
                string precio = gridView1.GetRowCellValue(rowHandle, "precio").ToString();

                cmbProducto.SelectedValue = idProducto;
                txtCantidad.Text = cantidad;
                txtPrecio.Text = precio;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private int? GetId_CotizacionDetalle()
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
                int? IdCotizacionDetalle = GetId_CotizacionDetalle();

                if (IdCotizacionDetalle != null)
                {
                    cotizacionesDetalle oCotizacionDetalle = db.cotizacionesDetalle.Find(IdCotizacionDetalle);

                    cotizaciones oCotizaciones = db.cotizaciones.FirstOrDefault(c => c.idCotizacion == id);
                    oCotizaciones.impuesto = oCotizaciones.impuesto - oCotizacionDetalle.impuestoTotal;
                    oCotizaciones.subtotal = oCotizaciones.subtotal - oCotizacionDetalle.subtotal;
                    oCotizaciones.total = oCotizaciones.total - oCotizacionDetalle.total;

                    db.cotizacionesDetalle.Remove(oCotizacionDetalle);
                    db.SaveChanges();
                    ActualizaDatos();
                    IdCotizacionDetalle = null;
                }
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Contenedor_Cotizaciones ReporteCotizacion = new Contenedor_Cotizaciones();
            ReporteCotizacion.Show();
        }
    }
}