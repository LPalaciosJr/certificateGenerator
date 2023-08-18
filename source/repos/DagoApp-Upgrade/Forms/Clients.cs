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
using System.Data.Entity;
using static DagoApp_.Class.LLENAGRIDVIEW;

namespace DagoApp_.Forms
{
    public partial class Clients : Form
    {
        DATA db = new DATA();

        public int? id;

        Clientes oClientes = null;

        public Clients(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                CargaDatos();
             CargaEmpresas();
            CargaCobradores();
        }
        private void CargaDatos(int? id = null)
        {

                oClientes = db.Clientes.Find(id);

            this.id = id;

            txtNombre.Text = oClientes.Nombre;
                txtNumTarjeta.Text = oClientes.NOTarjeta;
                dtpFechaVT.Value = (DateTime)oClientes.FechaVencimientoTarjeta;
                txtPIN.Text = oClientes.Pin;
                txtTel.Text = oClientes.Telefono;
                txtCorreoE.Text = oClientes.CorreoElectronico;
               txtTasaInteres.Text = oClientes.tasainteres.ToString();
                txtDNI.Text = oClientes.dni;
                cbEmpresa.SelectedValue = (int?)oClientes.IdEmpresa;
                cbCobrador.SelectedValue = (int?) oClientes.IdCobrador;

                if(oClientes.TipoCliente == 0)
                {
                    rbTipoClienteCuotaFija.Checked = true;
                }
                else
                {
                    rbTipoClienteInteres.Checked = true;
                }

            if (oClientes.estado == 0)
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            var dt = DgvFill("EXEC LST_CLIENTES");
            dgvClientes.DataSource = dt;

            this.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private int? GetId()
        {
            try
            {
               return int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int? id = GetId();

                if (id != null)
                {
                    CargaDatos(id);

                    Actualizar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                   if (result == DialogResult.Yes)
                   {

                        int? id = GetId();
                        if (id != null)
                        {
                        var dt = DgvFill("EXEC VALIDA_PRESTAMOS_CLIENTE");

                        var Valida_Si_Existe_Prestamo = dt.Rows[0][0].ToString();

                            if (Valida_Si_Existe_Prestamo == 0.ToString())
                            {
                                Clientes oclientes = db.Clientes.Find(id);
                                db.Clientes.Remove(oclientes);
                                db.SaveChanges();
                                Actualizar();
                            }
                            else
                            {
                                MessageBox.Show("Este cliente tiene préstamo pendiente aún. \n Lo invitamos a que revise el modulo de préstamos.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    
                   
                   }
            }
        }

        private void CargaEmpresas()
        {

                if (id != null)
                {

                    var listaempresas1 = (from emp in db.Empresas
                                          select emp).ToList();

                    cbEmpresa.DataSource = listaempresas1;
                    cbEmpresa.DisplayMember = "Nombre";
                    cbEmpresa.ValueMember = "IdEmpresa";
                    cbEmpresa.SelectedValue = oClientes.IdEmpresa;
                }
                else
                {
                    var listaempresas = (from emp in db.Empresas
                                         select emp).ToList();

                    cbEmpresa.DataSource = listaempresas;
                    cbEmpresa.DisplayMember = "Nombre";
                    cbEmpresa.ValueMember = "IdEmpresa";
                }

            
        }

        private void CargaCobradores()
        {
                if (id != null)
                {

                    var listacobradores1 = (from cob in db.Cobradores
                                            select cob).ToList();

                    cbCobrador.DataSource = listacobradores1;
                    cbCobrador.DisplayMember = "Nombre";
                    cbCobrador.ValueMember = "IdCobrador";
                    cbCobrador.SelectedValue = oClientes.IdCobrador;
                }
                else
                {
                    var listacobradores = (from cob in db.Cobradores
                                         select cob).ToList();

                    cbCobrador.DataSource = listacobradores;
                    cbCobrador.DisplayMember = "Nombre";
                    cbCobrador.ValueMember = "IdCobrador";
                }
        }

        private void btnGuardarClientes_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtNumTarjeta.Text == "" || txtPIN.Text == "" || cbEmpresa.SelectedValue == null || dtpFechaVT.Text == "")
            {
                MessageBox.Show("Asegurese que todos los campos esten llenos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (id == null)

                oClientes = new Clientes();
                oClientes.Nombre = txtNombre.Text;
                oClientes.NOTarjeta = txtNumTarjeta.Text;
                oClientes.FechaVencimientoTarjeta = dtpFechaVT.Value;
                oClientes.Pin = txtPIN.Text;
                oClientes.Telefono = txtTel.Text;
                oClientes.CorreoElectronico = txtCorreoE.Text;
                oClientes.tasainteres = Convert.ToDecimal(txtTasaInteres.Text.ToString());
                oClientes.dni = txtDNI.Text;
                oClientes.IdEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue.ToString());
                oClientes.IdCobrador = Convert.ToInt32(cbCobrador.SelectedValue.ToString());
                oClientes.TipoCliente = Convert.ToInt32(rbTipoClienteInteres.Checked == true ? true : false);


                if (rbActivo.Checked == true)
                {
                  oClientes.estado = 0;
                }
                else if(rbInactivo.Checked == true)
                {
                    oClientes.estado = 1;
                }

                if (id == null)

                    db.Clientes.Add(oClientes);
                else
                {
                    db.Entry(oClientes).State = EntityState.Modified;
                    MessageBox.Show("Actualizado");
                    id = null;
                    txtNombre.Clear();
                    txtNumTarjeta.Clear();
                    txtPIN.Clear();
                    txtTel.Clear();
                    txtCorreoE.Clear();
                    dtpFechaVT.Refresh();
                    cbEmpresa.Refresh();
                    txtTasaInteres.Clear();
                    txtDNI.Clear();
                    rbTipoClienteCuotaFija.Refresh();
                    rbTipoClienteInteres.Refresh();
                }
                db.SaveChanges();

                Actualizar();
                    txtNombre.Clear();
                    txtNumTarjeta.Clear();
                    txtPIN.Clear();
                    txtTel.Clear();
                    txtCorreoE.Clear();
                    dtpFechaVT.Refresh();
                    cbEmpresa.Refresh();
                    txtTasaInteres.Clear();
                    txtDNI.Clear();
                    rbTipoClienteCuotaFija.Refresh();
                    rbTipoClienteInteres.Refresh();
                }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" && txtCorreoE.Text == "" && txtNumTarjeta.Text == "" && txtPIN.Text == "" && txtTel.Text == "" && txtTasaInteres.Text == "")
            {

                int? id = GetId();

                if (id != null)
                {
                    frmHistorialCliente HistorialCliente = new frmHistorialCliente(id);
                    HistorialCliente.ShowDialog();

                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Al parecer estabas registrando un cliente\nSi es asi te invitamos a terminar el proceso en caso contrario limpia las cajas de texto.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            var dt = DgvFill("EXEC LST_CLIENTES" +"'"+ txtBuscaCliente.Text+"'" + " ");
            dgvClientes.DataSource = dt;

            this.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCorreoE.Clear();
            txtNumTarjeta.Clear();
            txtPIN.Clear();
            txtTel.Clear();
            txtTasaInteres.Clear();
            dtpFechaVT.Value = DateTime.Now;
            cbCobrador.SelectedIndex = 0;
            cbEmpresa.SelectedIndex = 0;
            rbTipoClienteCuotaFija.Checked = false;
            rbTipoClienteInteres.Checked = false;
        }

        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}