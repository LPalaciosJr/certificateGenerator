using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DagoApp_.Models;
using DagoApp_.Forms;
using System.Data.SqlClient;
using static DagoApp_.Class.LLENAGRIDVIEW;
using DagoApp_.Class;

namespace DagoApp_.Forms
{
    public partial class frmEmpresas : Form
    {
       DATA db = new DATA();
        public frmEmpresas()
        {
            InitializeComponent();
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            ActualizaEmpresa();
        }

        private void ActualizaEmpresa()
        {
           var dt = DgvFill("select * from empresas");
            dgvEmpresas.DataSource = dt;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DatosEmpresas empresas = new DatosEmpresas();
            empresas.ShowDialog();

            ActualizaEmpresa();
        }

        private int? GetIdEmp()
        {
            try
            {
                return int.Parse(dgvEmpresas.Rows[dgvEmpresas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetIdEmp();

            if (id != null)
            {
                DatosEmpresas oDatosEmpresas = new DatosEmpresas(id);
                oDatosEmpresas.ShowDialog();

                ActualizaEmpresa();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvEmpresas.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {


                        int? id = GetIdEmp();
                        if (id != null)
                        {
                    
                        var dtClientesBajoEmpresa = DgvFill("EXEC VALIDA_CLIENTES_POR_EMPRESA " + id + " ");
                        var QtyClientesxEmpresa = dtClientesBajoEmpresa.Rows[0][0].ToString();

                        if (QtyClientesxEmpresa == 0.ToString())
                            {
                                Empresas oempresas = db.Empresas.Find(id);
                                db.Empresas.Remove(oempresas);
                                db.SaveChanges();
                                ActualizaEmpresa();
                            }
                            else
                            {
                                MessageBox.Show("Este empresa aun tiene clientes asignados. \n Lo invitamos a que revise el modulo de clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    
                }
            }
        }
    }
}
