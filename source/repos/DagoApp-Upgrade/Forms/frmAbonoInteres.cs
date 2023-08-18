using DagoApp_.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using static DagoApp_.Class.LLENAGRIDVIEW;

namespace DagoApp_.Forms
{
    public partial class frmAbonoInteres : Form
    {
        DATA db = new DATA();

        public int? id;

        public frmAbonoInteres(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)

            ActualizaGrid();
        }

        private void ActualizaGrid()
        {
                var dt = DgvFill("EXEC LST_ABONO_INTERES " + id + " ");
                dgvAbonoInteres.DataSource = dt;
        }

        private void actualizaSaldo()
        {
            var DT_PENDIENTES_POR_TRANSACCION = DgvFill("EXEC PENDIENTES_POR_TRANSACCION " + id + " ");
            lblSaldo.Text = DT_PENDIENTES_POR_TRANSACCION.Rows[0][8].ToString().Replace("-", "");

            if(Convert.ToDecimal(lblSaldo.Text) <= 0)
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }

            if (dgvAbonoInteres.CurrentRow == null)
            {
                btnEliminar.Enabled = false;
            }
        }

        private void frmAbonoInteres_Load(object sender, EventArgs e)
        {
            actualizaSaldo();
        }

        private int? ObtieneIDFilaGrid()
        {
            try
            {
                return int.Parse(dgvAbonoInteres.Rows[dgvAbonoInteres.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var DT_PENDIENTES_POR_TRANSACCION = DgvFill("EXEC PENDIENTES_POR_TRANSACCION " + id + " ");
            decimal saldoPendiente = Convert.ToDecimal(DT_PENDIENTES_POR_TRANSACCION.Rows[0][8].ToString().Replace("-", ""));

            int? idAbonoInteres = ObtieneIDFilaGrid();
            if (idAbonoInteres != null)
            {

                abonoInteres abonoI = db.abonoInteres.Find(idAbonoInteres);
                db.abonoInteres.Remove(abonoI);

                Transaction transaction = db.Transaction.Where(i => i.IdTransaction == id).FirstOrDefault();
                transaction.Cantidad = transaction.Cantidad - abonoI.cantidadAbonada;
                transaction.diferencia = transaction.cantidadesperada - transaction.Cantidad;

                if (transaction.diferencia > 0)
                {
                    transaction.estado = "Faltante";
                }
                else if (transaction.diferencia == 0)
                {
                    transaction.estado = "-";
                }
                else
                {
                    transaction.estado = "Sobrante";
                }
                transaction.fechamodificacion = DateTime.Now;

                db.SaveChanges();

                MessageBox.Show("Sus datos se eliminaron exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ActualizaGrid();
            actualizaSaldo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var DT_PENDIENTES_POR_TRANSACCION = DgvFill("EXEC PENDIENTES_POR_TRANSACCION " + id + " ");
            decimal saldoPendiente = Convert.ToDecimal(DT_PENDIENTES_POR_TRANSACCION.Rows[0][8].ToString().Replace("-", ""));

            if (saldoPendiente < Convert.ToInt32(txtCantidadAbonoInteres.Text) || Convert.ToInt32(txtCantidadAbonoInteres.Text) <= 0)
            {
                MessageBox.Show("Esta intentando insertar un valor mas alto que el saldo o inferior a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                abonoInteres abonoI = new abonoInteres();
                abonoI.cantidadAbonada = Convert.ToDecimal(txtCantidadAbonoInteres.Text);
                abonoI.fecha = dtpFechaAbonoInteres.Value;
                abonoI.idtransaction = id;

                db.abonoInteres.Add(abonoI);

                Transaction transaction = db.Transaction.Where(i => i.IdTransaction == id).FirstOrDefault();
                transaction.Cantidad = transaction.Cantidad + abonoI.cantidadAbonada;
                transaction.diferencia = transaction.cantidadesperada - transaction.Cantidad;

                if (transaction.diferencia > 0)
                {
                    transaction.estado = "Faltante";
                }
                else if (transaction.diferencia == 0)
                {
                    transaction.estado = "-";
                }
                else
                {
                    transaction.estado = "Sobrante";
                }
                transaction.fechamodificacion = DateTime.Now;

                db.SaveChanges();

                txtCantidadAbonoInteres.Text = string.Empty;
                txtCantidadAbonoInteres.Focus();

                ActualizaGrid();
                actualizaSaldo();

                MessageBox.Show("Sus datos se guardaron exitosamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
