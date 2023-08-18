using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DagoApp_.Models;
using static DagoApp_.Class.LLENAGRIDVIEW;

namespace DagoApp_.Forms
{
    public partial class frmViewPrestamos : Form
    {
        DATA db = new DATA();
        Prestamos oprestamos = new Prestamos();

        public int? id;
        public int? idt;

        public int? idCliente;

        Transaction oTransaction = null;

        public frmViewPrestamos(int? id = null, int? idt = null)
        {
            InitializeComponent();

            this.id = id;

            this.idt = idt;


            if (idt != null)
                CargaDatosPrestamosEntry();
        }
    
        private void CargaDatosPrestamosEntry(int? idt = null)
    {
            Transaction oTransaction = db.Transaction.Find(idt);
                double d = Convert.ToDouble(oTransaction.Cantidad);
                int i = (int)Math.Round(d);

                txtQtyITransaction.Text = i.ToString();
    }

        private void frmViewPrestamos_Load(object sender, EventArgs e)
        {
            ActualizaViewPrestamos();
            CargaOperaciones();
        }

        private void CargaOperaciones()
        {
            if (idt != null)
            {
                cbtipoOperacion.SelectedValue = oTransaction.tipoOperacion;
            }
            else
            {
                var tipooperaciones1 = (from pres in db.TipoOperacion
                                        select pres).ToList();

                cbtipoOperacion.DataSource = tipooperaciones1;
                cbtipoOperacion.DisplayMember = "Descripcion";
                cbtipoOperacion.ValueMember = "Id";

            }
        }

        private int? GetIdTransaction()
        {
            try
            {
                return int.Parse(dgvDetallePrestamo.Rows[dgvDetallePrestamo.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        public class Valor
        {
            public string Value { get; set; }
            public string Index { get; set; }
        }

        private void ActualizaViewPrestamos()
        {
            var dt = DgvFill("EXEC TRANSACCIONES_POR_PRESTAMO " + id + " ");
            dgvDetallePrestamo.DataSource = dt;

                dgvDetallePrestamo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetallePrestamo.ScrollBars = ScrollBars.Both;

            dgvDetallePrestamo.ForeColor = Color.Blue;
            dgvDetallePrestamo.EnableHeadersVisualStyles = false;

            dgvDetallePrestamo.AllowUserToAddRows = false;

            if (dgvDetallePrestamo.CurrentRow != null)
            {
                dgvDetallePrestamo.Rows[dgvDetallePrestamo.Rows.Count - 1].Selected = true;
                dgvDetallePrestamo.FirstDisplayedScrollingRowIndex = dgvDetallePrestamo.Rows.Count-1;
            }
           
            int c = dgvDetallePrestamo.Rows.Count;

            for (int i = 0; i < c; i++)
            {
                if (dgvDetallePrestamo.Rows[i].Cells[5].Value.ToString() == "Faltante" )
                {
                    dgvDetallePrestamo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (dgvDetallePrestamo.Rows[i].Cells[5].Value.ToString() == "Sobrante")
                {
                    dgvDetallePrestamo.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                }
                else
                {
                    dgvDetallePrestamo.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                }
            }

            var dtCaratulaPrestamo = DgvFill("EXEC CARATULA_PRESTAMO " + id + " ");

                label1.Text = dtCaratulaPrestamo.Rows[0][1].ToString();
                lblTotalActual.Text = dtCaratulaPrestamo.Rows[0][3].ToString();
                lblModoPrestamo.Text = dtCaratulaPrestamo.Rows[0][5].ToString();
                lblTipoCliente.Text = dtCaratulaPrestamo.Rows[0][6].ToString();
                lblTasaInt.Text = dtCaratulaPrestamo.Rows[0][7].ToString()+"%";

                double d = Convert.ToDouble(dtCaratulaPrestamo.Rows[0][4]);
                decimal decimalQty = (decimal)Math.Round(d);
                txtQtyITransaction.Text = decimalQty.ToString();

                if (dtCaratulaPrestamo.Rows[0][3].ToString() == "0.00")
                {
                Prestamos prestamo = db.Prestamos.Where(i=> i.IdPrestamo == id).FirstOrDefault();
                prestamo.status = 2;

                db.SaveChanges();

                txtQtyITransaction.Enabled = false;
                    txtQtyITransaction.Text = "0.00";
                    cbtipoOperacion.Enabled = false;
                    dtpDesde.Enabled = false;
                    dptHasta.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnADS.Enabled = false;
                    btnEliminar.Enabled = false;
                btnAbonoInteres.Enabled = false;
                    btnAgregar.Text = "PAGADO";
                    btnAgregar.BackColor = Color.Red;
                    btnEditar.Text = "PAGADO";
                    btnEditar.BackColor = Color.Red;
                    btnEliminar.Text = "PAGADO";
                    btnEliminar.BackColor = Color.Red;
                    btnADS.Text = "PAGADO";
                    btnADS.BackColor = Color.Red;
                btnAbonoInteres.Text = "PAGADO";
                btnAbonoInteres.BackColor = Color.Red;

                btnImprimirHistorial.Enabled = true;
                }    
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtQtyITransaction.Text == "" || cbtipoOperacion.SelectedValue == null)
            {
                MessageBox.Show("Al parecer dejaste una caja de texto vacia!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var dtDeudaActual = DgvFill("EXEC CARATULA_PRESTAMO " + id + " ");
            var DeudaActual = dtDeudaActual.Rows[0][3].ToString();
            var InteresEsperado = dtDeudaActual.Rows[0][4].ToString();

            if (DeudaActual == 0.ToString() && Convert.ToInt32(cbtipoOperacion.SelectedValue.ToString()) != 3 || Convert.ToDouble(txtQtyITransaction.Text) == 0 || txtQtyITransaction.Text.ToString() == "")
            {
                MessageBox.Show("Por el momento solo puede refinanciar\nSiempre y cuando el valor sea mayor a cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (idt is null)

            oTransaction = new Transaction();
                            oTransaction.Cantidad = Convert.ToDecimal(txtQtyITransaction.Text);
                            oTransaction.tipoOperacion = Convert.ToInt32(cbtipoOperacion.SelectedValue);
                            oTransaction.Desde = dtpDesde.Value;
                            oTransaction.Hasta = dptHasta.Value;
                            oTransaction.IDPrestamo = id;

                    var dtTipoClientePorPrestamo = DgvFill("EXEC TIPO_CLIENTE_POR_PRESTAMO " + id + " ");
                    var TipoCliente = dtTipoClientePorPrestamo.Rows[0][0].ToString();

                    if (TipoCliente.Equals("0"))
            {
                    oTransaction.cantidadesperada = Convert.ToDecimal(txtQtyITransaction.Text);
                    oTransaction.diferencia = 0;
                    oTransaction.estado = "-";
                    }
            else
            {
                if (oTransaction.tipoOperacion == 1)
                {
                    oTransaction.cantidadesperada = Convert.ToDecimal(InteresEsperado);
                    oTransaction.diferencia = oTransaction.Cantidad - Convert.ToDecimal(InteresEsperado);
                }
                else
                {
                    oTransaction.cantidadesperada = Convert.ToDecimal(txtQtyITransaction.Text);
                    oTransaction.diferencia = 0;
                }
                if (oTransaction.diferencia < 0)
                {
                    oTransaction.estado = "Faltante";
                }
                else if (oTransaction.diferencia > 0)
                {
                    oTransaction.estado = "Sobrante";
                }
                else
                {
                    oTransaction.estado = "-";
                }
            }
                        if (idt is null)
                                db.Transaction.Add(oTransaction);

                            if (idt != null)
                            {
                                db.Entry(oTransaction).State = System.Data.Entity.EntityState.Modified;
                                MessageBox.Show("El registro se ha actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            db.SaveChanges();

                            ActualizaViewPrestamos();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? idt = GetIdTransaction();
            if (idt != null)
            {
                try
                {
                    var codigoCliente = id;

                    frmEditsDetailPrestamos EditDetail = new frmEditsDetailPrestamos(idt);
                    EditDetail.label1.Text = codigoCliente.ToString();
                    EditDetail.label7.Text = idt.ToString();
                    EditDetail.ShowDialog();
                }
                catch (Exception)
                {
                    return;
                }
                ActualizaViewPrestamos();
            }
        }

        private void txtQtyITransaction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetallePrestamo.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                        int? id = GetIdTransaction();
                        if (id != null)
                        {

                        var dtValidaTipoTransaccion = DgvFill("EXEC VALIDA_TIPO_TRANSACCION " + id + " ");

                            if (dtValidaTipoTransaccion.Rows[0][0].ToString() == 0.ToString())
                            {
                                Transaction oTransaction = db.Transaction.Find(id);
                                db.Transaction.Remove(oTransaction);
                                db.SaveChanges();
                                ActualizaViewPrestamos();
                            }
                            else
                            {
                                MessageBox.Show("Los Intereses no se pueden ELIMINAR, pero puede MODIFICAR.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    frmADS ads = new frmADS(id);
                    ads.ShowDialog();
        }

        private void btnAbonoInteres_Click(object sender, EventArgs e)
        {
            int? id = GetIdTransaction();
            if (id != null)
            {
                try
                {
                    var idTransaction = id;

                    frmAbonoInteres AbonoI = new frmAbonoInteres(id);
                    AbonoI.lblTransaccion.Text = idTransaction.ToString();
                    AbonoI.ShowDialog();
                }
                catch (Exception)
                {
                    return;
                }
                ActualizaViewPrestamos();
            }
        }

        private void btnImprimirHistorial_Click(object sender, EventArgs e)
        {
            oprestamos = db.Prestamos.Where(i => i.IdPrestamo == id).FirstOrDefault();

            if(oprestamos.status == 2)
            {
                MessageBox.Show("Estimado usuario, actualmente está en proceso de actualización la funcionalidad de este módulo,\n agradecemos su comprensión.","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (idCliente != null)
                {
                    frmHistorialCliente HistorialCliente = new frmHistorialCliente(idCliente);
                    HistorialCliente.ShowDialog();

                    ActualizaViewPrestamos();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}