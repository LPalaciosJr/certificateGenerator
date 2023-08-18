using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DagoApp_.Forms;
using DagoApp_.Models;
using System.Data.SqlClient;


namespace DagoApp_.Forms
{
    public partial class frmEditsDetailPrestamos : Form
    {
        DATA db = new DATA();
        Prestamos oprestamos = new Prestamos();
        public int? idt;    
        Transaction oTransaction = new Transaction();

        public frmEditsDetailPrestamos(int? idt = null)
        {
            InitializeComponent();

            this.idt = idt;

            if (idt != null)
                CargaDatosTransaccion();
            CargaOperaciones();
        }

        private void CargaDatosTransaccion()
        {
                oTransaction = db.Transaction.Find(idt);
                txtEditQty.Text = Convert.ToInt32(oTransaction.Cantidad).ToString();
                cbTOEdit.SelectedValue = oTransaction.tipoOperacion.ToString();
                dtpDesdeEdit.Value = (DateTime)oTransaction.Desde;
                dptHastaEdit.Value = (DateTime)oTransaction.Hasta; 
        }

        private void CargaOperaciones()
        {
                    var tipooperaciones1 = (from pres in db.TipoOperacion
                                            select pres).ToList();

                cbTOEdit.DataSource = tipooperaciones1;
                cbTOEdit.DisplayMember = "Descripcion";
                cbTOEdit.ValueMember = "Id";
                cbTOEdit.SelectedValue = oTransaction.tipoOperacion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                oTransaction = db.Transaction.FirstOrDefault(i=> i.IdTransaction == idt);
                oTransaction.Cantidad = Convert.ToInt32(txtEditQty.Text.ToString());
                oTransaction.Desde = Convert.ToDateTime(dtpDesdeEdit.Value.ToString());
                oTransaction.Hasta = Convert.ToDateTime(dptHastaEdit.Value.ToString());
                oTransaction.tipoOperacion = Convert.ToInt32(cbTOEdit.SelectedValue.ToString());
            if (oTransaction.tipoOperacion == 1)
            {
                oTransaction.cantidadesperada = oTransaction.cantidadesperada;
                oTransaction.diferencia = oTransaction.Cantidad - oTransaction.cantidadesperada;
            }
            else
            {
                oTransaction.cantidadesperada = oTransaction.Cantidad;
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
            oTransaction.fechamodificacion = DateTime.Now;


                    db.SaveChanges();
                    MessageBox.Show("La Transacción se ha actualizado exitosamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
        }

        private void txtEditQty_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}