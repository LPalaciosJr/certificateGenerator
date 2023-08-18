using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using facturacionApp.Datos;
using System;
using System.Linq;
using System.Windows.Forms;
using static facturacionApp.Clases.GridView;

namespace facturacionApp.Componentes
{
    public partial class Cotizaciones : DevExpress.XtraEditors.XtraForm
    {
        DATA db = new DATA();
        public int? id;

        cotizaciones oCotizacion = null;
        public Cotizaciones(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }
        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            Clientes();
            ActualizaDatos();
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
        private void Clientes()
        {
            try
            {
                using (var db = new DATA())
                {
                    var clientes = db.clientes.ToList();
                    cmbCotizacion.DisplayMember = "nombre";
                    cmbCotizacion.ValueMember = "id";
                    cmbCotizacion.DataSource = clientes;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill("select * from ViewCotizaciones");
            dgvDatos.DataSource = dt;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int ClienteSeleccionado = int.Parse(cmbCotizacion.SelectedValue.ToString());

            clientes oCustomer = db.clientes.FirstOrDefault(c => c.id == ClienteSeleccionado);
            cotizaciones oCotizacion = new cotizaciones();
            oCotizacion.idCliente = int.Parse(cmbCotizacion.SelectedValue.ToString());
            oCotizacion.nombreCliente = oCustomer.nombre;
            oCotizacion.direccion = oCustomer.direccion;
            oCotizacion.rtn = oCustomer.rtn;
            oCotizacion.telefono = oCustomer.telefono;
            oCotizacion.correoE = oCustomer.correoE;
            oCotizacion.usuario = "Administrador";
            oCotizacion.fechaRegistro = DateTime.Now;
            oCotizacion.subtotal = 0;
            oCotizacion.impuesto = 0;
            oCotizacion.total = 0;

            db.cotizaciones.Add(oCotizacion);
            db.SaveChanges();

            XtraMessageBox.Show("Cotizacion creada exitosamente", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizaDatos();
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
                        cotizaciones oCotizaciones = db.cotizaciones.Find(id);

                        if (oCotizaciones.subtotal == 0 && oCotizaciones.total == 0)
                        {
                            db.cotizaciones.Remove(oCotizaciones);
                            db.SaveChanges();
                            ActualizaDatos();
                        }
                        else
                        {
                            MessageBox.Show("Ésta cotización tiene productos, asegurese de que esté vacia para proceder a eliminarla.", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay registros para eliminar.", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                //int? idCliente = GetIdCliente();

                if (id != null)
                {
                    CotizacionesDetalle oDetalleCotizacion = new CotizacionesDetalle(id, null);
                    //oDetalleCotizacion.idCliente = idCliente;
                    oDetalleCotizacion.MdiParent = this.MdiParent;
                    oDetalleCotizacion.Show();

                    ActualizaDatos();
                }
            }
            else
            {
                MessageBox.Show("No haz seleccionado una fila valida ó asegurate de tener registros en la tabla!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvDatos_Click(object sender, EventArgs e)
        {
            //ActualizaDatos();
        }
    }
}