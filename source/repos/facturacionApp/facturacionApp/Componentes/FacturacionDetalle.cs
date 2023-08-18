using DevExpress.XtraEditors;
using System;
using facturacionApp.Datos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;
using facturacionApp.Reportes.Contenedores;

namespace facturacionApp.Componentes
{
    public partial class FacturacionDetalle : DevExpress.XtraEditors.XtraForm
    {
        public int? id;
        public int? idFacturacionDetalle;
        int valorCmb = 1;

        //facturaDetalle oDetalleFactura = null;
        public FacturacionDetalle(int? id)
        {
            InitializeComponent();
            this.id = id;
            this.idFacturacionDetalle = idFacturacionDetalle;
        }
        private void FacturacionDetalle_Load(object sender, EventArgs e)
        {
            lblNumCotizacion.Text = "FACTURA #" + id.ToString();

            txtCodigo.Enabled = false;
            txtImpuesto.Enabled = false;
            btnEditar.Enabled = false;

            ActualizaDatos();
            Productos();
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill($"select * from facturaDetalle where idFactura = '{id}'");
            dgvDatos.DataSource = dt;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new DATA())
            {
                int valorCmb = int.Parse(cmbProducto.SelectedValue.ToString());
                productos oItem = db.productos.Where(i => i.codigo == valorCmb.ToString()).FirstOrDefault();

                txtCodigo.Text = oItem.codigo.ToString();
                txtPrecio.Text = oItem.precio.ToString();
                txtImpuesto.Text = oItem.impuesto.ToString();

                facturaDetalle oDetalleFactura = new facturaDetalle();
                oDetalleFactura.codigoProducto = oItem.codigo;
                oDetalleFactura.descripcion = oItem.descripcion;
                oDetalleFactura.costo = oItem.costo;
                oDetalleFactura.precio = Convert.ToDecimal(txtPrecio.Text);
                oDetalleFactura.cantidad = Convert.ToDecimal(txtCantidad.Text);
                oDetalleFactura.impuesto = Convert.ToDecimal(oItem.impuesto.ToString());
                oDetalleFactura.subtotal = oDetalleFactura.precio * oDetalleFactura.cantidad;
                if (oDetalleFactura.impuesto > 0)
                {
                    oDetalleFactura.impuestoTotal = (oDetalleFactura.precio * oDetalleFactura.impuesto / 100) * oDetalleFactura.cantidad;
                }
                else
                {
                    oDetalleFactura.impuestoTotal = 0;
                }

                oDetalleFactura.total = oDetalleFactura.subtotal + oDetalleFactura.impuestoTotal;
                oDetalleFactura.idFactura = id;

                db.facturaDetalle.Add(oDetalleFactura);
                db.SaveChanges();

                facturas oFactura = db.facturas.Where(c => c.id == id).FirstOrDefault();

                oFactura.subtotal += oDetalleFactura.subtotal;
                oFactura.impuesto += oDetalleFactura.impuestoTotal;
                oFactura.total += oDetalleFactura.total;
                db.SaveChanges();

                ActualizaDatos();
                LimpiaControl(this);
                id = null;
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
        private void CargaDatos(int? id = null)
        {
            //using (var db = new DATA())
            //{
            //    oDetalleFactura = db.facturaDetalle.Find(id);
            //    this.id = id;

            //    var productos = db.productos.ToList();
            //    cmbProducto.DisplayMember = "descripcion";
            //    cmbProducto.ValueMember = "codigo";
            //    cmbProducto.DataSource = productos;

            //    cmbProducto.SelectedValue = oDetalleFactura.codigoProducto;

            //    txtCodigo.Text = oDetalleFactura.codigoProducto;
            //    txtPrecio.Text = oDetalleFactura.precio.ToString();
            //    txtCantidad.Text = oDetalleFactura.cantidad.ToString();
            //    txtImpuesto.Text = oDetalleFactura.impuesto.ToString();
            //}
            //int[] selectedRows = gridView1.GetSelectedRows();

            //if (selectedRows.Length > 0)
            //{
            //    int rowHandle = selectedRows[0];

            //    string idProducto = gridView1.GetRowCellValue(rowHandle, "codigoProducto").ToString();
            //    string cantidad = gridView1.GetRowCellValue(rowHandle, "cantidad").ToString();
            //    string precio = gridView1.GetRowCellValue(rowHandle, "precio").ToString();

            //    cmbProducto.SelectedValue = idProducto;
            //    txtCantidad.Text = cantidad;
            //    txtPrecio.Text = precio;
            //}
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //using (var db = new DATA())
            //{
            //    try
            //    {
            //        int? id = GetId();
            //        if (id != null)
            //        {
            CargaDatos();
            //            ActualizaDatos();
            //            gridView1.FocusedRowHandle = (int)id - 1;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("No se editó", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
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
            using (var db = new DATA())
            {
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int? IdCotizacionDetalle = GetId();

                    if (IdCotizacionDetalle != null)
                    {
                        facturaDetalle oDetalleFactura = db.facturaDetalle.Find(IdCotizacionDetalle);

                        facturas oFactura = db.facturas.FirstOrDefault(c => c.id == id);
                        if (oDetalleFactura.impuestoTotal > 0)
                        {
                            oFactura.impuesto = oFactura.impuesto - oDetalleFactura.impuestoTotal;
                        }

                        oFactura.subtotal = oFactura.subtotal - oDetalleFactura.subtotal;
                        oFactura.total = oFactura.total - oDetalleFactura.total;

                        db.facturaDetalle.Remove(oDetalleFactura);
                        db.SaveChanges();
                        ActualizaDatos();
                        IdCotizacionDetalle = null;
                    }
                }
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Contenedor_FacturaVenta oFactura = new Contenedor_FacturaVenta(idFacturacionDetalle);
            oFactura.ShowDialog();
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbProducto != null && cmbProducto.SelectedValue != null)
            {
                int valorCmb;
                if (int.TryParse(cmbProducto.SelectedValue.ToString(), out valorCmb))
                {
                    using (var db = new DATA())
                    {
                        productos oProductos = db.productos.FirstOrDefault(i => i.codigo == valorCmb.ToString());

                        txtCodigo.Text = oProductos.codigo;
                        txtPrecio.Text = oProductos.precio.ToString();
                        txtImpuesto.Text = oProductos.impuesto.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo convertir en int");
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            using (DATA db = new DATA())
            {
                facturas fact = db.facturas.FirstOrDefault(oc => oc.id == id);
                fact.estado = 1;
                fact.estadoPago = 1;

                productos oProductos = db.productos.FirstOrDefault();

                facturaDetalle facturaDetalle = db.facturaDetalle.FirstOrDefault(o => o.codigoProducto == oProductos.codigo);
                oProductos.cantidadExistencia = oProductos.cantidadExistencia-facturaDetalle.cantidad;
                db.SaveChanges();

                MessageBox.Show("Su factura se ha cerrado exitosamente");

                this.Close();
            }
        }
    }
}