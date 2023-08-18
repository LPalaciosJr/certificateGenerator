using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DagoApp_.Models;
using static DagoApp_.Class.LLENAGRIDVIEW;

namespace DagoApp_.Forms
{
    public partial class frmCobradores : Form
    {
        DATA db = new DATA();
        public frmCobradores()
        {
            InitializeComponent();
        }

        private void frmCobradores_Load(object sender, EventArgs e)
        {
            ActualizaCobradores();
        }

        private void ActualizaCobradores()
        {
                var lstCobradores = from c in db.Cobradores
                                    select c;


                dgvCobradores.DataSource = lstCobradores.ToList();

        
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DatosCobradores cobradores = new DatosCobradores();
            cobradores.ShowDialog();

            ActualizaCobradores();
        }

        private int? GetIdCob()
        {
            try
            {
                return int.Parse(dgvCobradores.Rows[dgvCobradores.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnEditarCobrador_Click(object sender, EventArgs e)
        {
            int? id = GetIdCob();

            if (id != null)
            {
                DatosCobradores oDatosCobradores = new DatosCobradores(id);
                oDatosCobradores.ShowDialog();

                ActualizaCobradores();
            }
        }

        private void btnEliminarCobrador_Click(object sender, EventArgs e)
        {

            if (dgvCobradores.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                        int? id = GetIdCob();
                        if (id != null)
                        {

                        var dtClientesBajoCobrador = DgvFill("EXEC VALIDA_CLIENTES_POR_COBRADOR " + id + " ");
                        var QtyClientesxCobrador = dtClientesBajoCobrador.Rows[0][0].ToString();

                            if (QtyClientesxCobrador == 0.ToString())
                            {
                                Cobradores ocobradores = db.Cobradores.Find(id);
                                db.Cobradores.Remove(ocobradores);
                                db.SaveChanges();
                                ActualizaCobradores();
                            }
                            else
                            {
                                MessageBox.Show("Este cobrador aun tiene clientes asignados. \n Lo invitamos a que revise el modulo de clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                }
            }
        }
    }
}