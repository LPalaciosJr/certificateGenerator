using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using facturacionApp.Datos;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;
using DevExpress.XtraGrid.Views.Grid;

namespace facturacionApp.Componentes
{
    public partial class Facturacion : DevExpress.XtraEditors.XtraForm
    {
        public int? id;
        facturas oFactura = null;

        public Facturacion()
        {
            InitializeComponent();
        }
        private void Clientes()
        {
            try
            {
                using (var db = new DATA())
                {
                    var clientes = db.clientes.ToList();
                    cmbClientesFactura.DisplayMember = "nombre";
                    cmbClientesFactura.ValueMember = "id";
                    cmbClientesFactura.DataSource = clientes;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill("SELECT * FROM VIEWFACTURAS");
            dgvDatos.DataSource = dt;
        }
        private void MetodoPagos()
        {
            List<Valor> list = new List<Valor>();

            list.Add(new Valor() { Index = "Efectivo", Value = 1.ToString() });
            list.Add(new Valor() { Index = "Transferencia", Value = 2.ToString() });

            cmbMetodoPago.DataSource = list;
            cmbMetodoPago.DisplayMember = "Index";
            cmbMetodoPago.ValueMember = "Value";
        }
        public class Valor
        {
           public string Value { get; set; }
            public string Index { get; set; }
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
                oFactura = db.facturas.Find(id);
                this.id = id;

                var clientes = db.clientes.ToList();
                cmbClientesFactura.DisplayMember = "Company";
                cmbClientesFactura.ValueMember = "AccountNumber";
                cmbClientesFactura.DataSource = clientes;
                clientes clienteSeleccionado = clientes.FirstOrDefault(c => c.id == oFactura.codigoCliente);
                cmbClientesFactura.SelectedItem = clienteSeleccionado;

                if (oFactura.metodoPago == "Efectivo")
                {
                    int index = cmbMetodoPago.FindString("Efectivo");
                    if (index != -1)
                    {
                        cmbMetodoPago.SelectedIndex = index;
                    }
                }
                else
                {
                    int index = cmbMetodoPago.FindString("Transferencia");
                    if (index != -1)
                    {
                        cmbMetodoPago.SelectedIndex = index;
                    }
                }


                txtCAI.Text = oFactura.cai;
                txtNoFactura.Text = oFactura.numeroFactura;
                txtRangoAutorizado.Text = oFactura.rangoAutorizado;

                if (oFactura.estadoPago == 1)
                {
                    rbContado.Checked = true;
                }
                else
                {
                    rbCredito.Checked = true;
                }

                dtpFechaEmision.Value = Convert.ToDateTime(oFactura.fechaEmision);
                dtpFechaLimite.Value = Convert.ToDateTime(oFactura.fechaLimite);
                dtpFechaVence.Value = Convert.ToDateTime(oFactura.fechaVencimiento);
            }
        }
        private void Facturacion_Load(object sender, EventArgs e)
        {
            Clientes();
            ActualizaDatos();
            MetodoPagos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new DATA())
            {
                if (cmbClientesFactura.SelectedValue.ToString() != null)
                {
                    int ClienteSeleccionado = int.Parse(cmbClientesFactura.SelectedValue.ToString());
                    clientes oCustomer = db.clientes.FirstOrDefault(c => c.id == ClienteSeleccionado);

                    if (id == null)
                    oFactura = new facturas();
                    oFactura.numeroFactura = txtNoFactura.Text;
                    oFactura.cai = txtCAI.Text;
                    oFactura.rangoAutorizado = txtRangoAutorizado.Text;
                    oFactura.codigoCliente = int.Parse(cmbClientesFactura.SelectedValue.ToString());
                    oFactura.nombreCliente = oCustomer.nombre;
                    oFactura.rtn = oCustomer.rtn;
                    oFactura.fechaLimite = dtpFechaLimite.Value;
                    oFactura.fechaEmision= dtpFechaEmision.Value;
                    oFactura.fechaVencimiento = dtpFechaVence.Value;
                    oFactura.fechaVenta = DateTime.Now;
                    if (cmbMetodoPago.SelectedValue.ToString()=="1")
                    {
                        oFactura.metodoPago = "Efectivo";
                    }
                    else
                    {
                        oFactura.metodoPago = "Transferencia";
                    }

                    if (rbContado.Checked)
                    {
                        oFactura.estadoPago = 1;
                        oFactura.descripcionEstadoPago = "Contado";
                    }
                    else
                    {
                        oFactura.estadoPago = 0;
                        oFactura.descripcionEstadoPago = "Credito";
                    }

                    oFactura.subtotal = 0;
                    oFactura.impuesto = 0;
                    oFactura.total = 0;
                    oFactura.usuario = "Administrador";

                    if (id == null)
                        db.facturas.Add(oFactura);
                    else
                    {
                        db.Entry(oFactura).State = System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();

                    ActualizaDatos();
                    LimpiaControl(this);
                    id = null;
                }
                else
                {
                    XtraMessageBox.Show("Algo ha pasado viejo", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCotizacionDetalle_Click(object sender, EventArgs e)
        {
            GridView dataGridView1 = gridView1 as GridView;
            int[] SelectedRowHandles = dataGridView1.GetSelectedRows();

            if (SelectedRowHandles != null)
            {
                int? id = GetId();
                //int? idFactura = GetId();

                if (id != null)
                {
                    FacturacionDetalle oDetalleFactura = new FacturacionDetalle(id);
                    oDetalleFactura.idFacturacionDetalle = id;
                    oDetalleFactura.MdiParent = this.MdiParent;
                    oDetalleFactura.Show();

                    ActualizaDatos();
                }
            }
            else
            {
                MessageBox.Show("No haz seleccionado una fila valida ó asegurate de tener registros en la tabla!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        facturas oFacturacion = db.facturas.Find(id);

                        if (oFacturacion.subtotal == 0 && oFacturacion.total == 0)
                        {
                            db.facturas.Remove(oFacturacion);
                            db.SaveChanges();
                            ActualizaDatos();
                        }
                        else
                        {
                            MessageBox.Show("Ésta factura tiene productos, asegurese de que esté vacia para proceder a eliminarla.", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros para eliminar.", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
    }
}