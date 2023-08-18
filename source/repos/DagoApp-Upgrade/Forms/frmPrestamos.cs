using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using static DagoApp_.Class.LLENAGRIDVIEW;
using System.Windows.Forms;
using DagoApp_.Models;
using System.Data.SqlClient;

namespace DagoApp_.Forms
{
    public partial class frmPrestamos : Form
    {
        SqlConnection conexion = new SqlConnection(@"data source=.;initial catalog=DBIR;persist security info=True;user id=sa;password=admin2022.;MultipleActiveResultSets=True;App=EntityFramework");
        DATA db = new DATA();
        public int? id;
        Prestamos oprestamos = null;

        string tasacli = string.Empty;

        string ValuecmbFilter = "1";

        public frmPrestamos(int? id = null)
        {
            InitializeComponent();
            CargaComboboxs();

            ValuecmbFilter = cbFiltroGRID.SelectedValue.ToString();

            this.id = id;
            if (id != null)
                CargaPrestamos();
            CargaComboboxs();
        }

        private void CargaComboboxs()
        {

                List<Valor> list = new List<Valor>();

                list.Add(new Valor() { Index = "Semanal" , Value = 0.ToString() });
                list.Add(new Valor() { Index = "Quincenal" , Value = 1.ToString() });
                list.Add(new Valor() { Index = "Mensual" , Value = 2.ToString() });

                cbTipoCliente.DataSource = list;
                cbTipoCliente.DisplayMember = "Index";
                cbTipoCliente.ValueMember = "Value";


                //COMBOBOX DE FILTRO
                List<Valor> listFiltro = new List<Valor>();

                listFiltro.Add(new Valor() { Index = "Activos", Value = 1.ToString() });
                listFiltro.Add(new Valor() { Index = "Pagados", Value = 2.ToString() });

                cbFiltroGRID.DataSource = listFiltro;
                cbFiltroGRID.DisplayMember = "Index";
                cbFiltroGRID.ValueMember = "Value";
                //FINCOOMBOBOX

                var listaClientes = (from cli in db.Clientes
                                     select cli).ToList();

                cbCliente.DataSource = listaClientes;
                cbCliente.DisplayMember = "Nombre";
                cbCliente.ValueMember = "IdCliente";

        }

        public class Valor
        {
            public string Value { get; set; }
            public string Index { get; set; }
        }

        public string TasaCliente(string cliente)
        {

            string query = "Select tasainteres from clientes WHERE IdCliente = @param";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@param", cliente);

                conexion.Open();

                object userNameObj = cmd.ExecuteScalar();

                if (userNameObj != null)
                    tasacli = userNameObj.ToString();

            }
            catch (Exception)
            {

            }
            finally
            {
                conexion.Close();
            }

            return tasacli;
        }

        public string ClienteExist(string cliente)
        {
            string cli = string.Empty;

            string query = "Select IDCliente from Prestamos WHERE IDCliente = @param and status=1";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@param", cliente);

                conexion.Open();

                object userNameObj = cmd.ExecuteScalar();

                if (userNameObj != null)
                    cli = userNameObj.ToString();

            }
            catch (Exception)
            {

            }
            finally
            {
                conexion.Close();
            }

            return cli;
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            ActualizaPrestamos();

            cbCliente.ResetText();
            cbTipoCliente.ResetText();
        }

        public void ActualizaPrestamos()
        {
            var dt = DgvFill("EXEC LST_GRID_PRESTAMOS " + 1 + " ");
            dgvPrestamos.DataSource = dt;

            this.dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPrestamos.AllowUserToAddRows = false;

            dgvPrestamos.Rows[dgvPrestamos.Rows.Count - 1].Selected = true;
            dgvPrestamos.FirstDisplayedScrollingRowIndex = dgvPrestamos.Rows.Count - 1;
        }

        private int? GetIdPresta()
        {
            try
            {
                return int.Parse(dgvPrestamos.Rows[dgvPrestamos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        private int? GetIdCliente()
        {
            try
            {
                return int.Parse(dgvPrestamos.Rows[dgvPrestamos.CurrentRow.Index].Cells[1].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnGuardaPrestamos_Click_1(object sender, EventArgs e)
        {

                if (txtQty.Text == string.Empty || txtTasa.Text == string.Empty || cbCliente.SelectedValue == null)
                {
                    MessageBox.Show("Verifica, haz hecho algo de forma incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                        if (id == null)

                            oprestamos = new Prestamos();

                    if (id == null)
                    {
                        oprestamos.IDCliente = Convert.ToInt32(cbCliente.SelectedValue.ToString());
                    }

                        oprestamos.Tipo = Convert.ToInt32(cbTipoCliente.SelectedValue.ToString());
                        oprestamos.Cantidad = Convert.ToInt32(txtQty.Text.ToString());
                        oprestamos.Desde = dtpFechaTransaccion.Value;
                        oprestamos.Tasa = float.Parse(txtTasa.Text.ToString());
                        oprestamos.Tipo = Convert.ToInt32(cbTipoCliente.SelectedValue.ToString());
                        oprestamos.status = 1;


                        if (cbTipoCliente.SelectedValue.ToString() == "0")
                        {
                            oprestamos.Descripcion = "Semanal";
                        }
                        else if (cbTipoCliente.SelectedValue.ToString() == "1")
                        {
                            oprestamos.Descripcion = "Quincenal";
                        }
                        else
                        {
                            oprestamos.Descripcion = "Mensual";
                        }


                        if (id == null)

                    if (ClienteExist(cbCliente.SelectedValue.ToString()) != "")
                    {
                        MessageBox.Show("Vaya, al parecer intentas crearle un prestamos a alguien que ya tiene uno.\n Te invito a darle click en el botón 'Transacciones' y optes por el 'Refinanciamiento.'", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        db.Prestamos.Add(oprestamos);
                    }
                else if (id != null)
                {
                    db.Entry(oprestamos).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("El registro se ha actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                db.SaveChanges();

                }   
                        ActualizaPrestamos();

                        txtQty.Clear();
                        txtTasa.Clear();
                        cbCliente.ResetText();
                        cbTipoCliente.ResetText();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (cbFiltroGRID.SelectedValue.ToString() == 1.ToString())
            {
                var dt = DgvFill("EXEC LST_GRID_PRESTAMOS " + 1 +","+ "'" + txtBuscaCliente.Text + "'" + " ");
                dgvPrestamos.DataSource = dt;
            }
            else
            {
                var dt = DgvFill("EXEC LST_GRID_PRESTAMOS " + 2 +","+ "'" + txtBuscaCliente.Text + "'" + " ");
                dgvPrestamos.DataSource = dt;
            }

            this.dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow != null)
            {
                int? id = GetIdPresta();
                int? idCliente = GetIdCliente();

                if (id != null)
                {
                    frmViewPrestamos viewprestamos = new frmViewPrestamos(id);
                    viewprestamos.idCliente = idCliente;
                    viewprestamos.ShowDialog();

                    ActualizaPrestamos();
                }
            }
            else
            {
                MessageBox.Show("No haz seleccionado una fila valida ó asegurate de tener registros en el GRID!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                        int? id = GetIdPresta();
                        if (id != null)
                        {

                        var dtPrestamos = DgvFill("EXEC PRESTAMOS_POR_ID " + id + " ");
                        var PrestamosPorId = dtPrestamos.Rows[0][0].ToString();

                            if (PrestamosPorId == 0.ToString())
                            {
                                Prestamos oprestamos = db.Prestamos.Find(id);
                                db.Prestamos.Remove(oprestamos);
                                db.SaveChanges();
                                ActualizaPrestamos();
                            }
                            else
                            {
                                MessageBox.Show("Este cliente tiene préstamo pendiente aún. \n Este registro solo se eliminara si Cantidad Préstamo es 0.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                
            }
        }

        private void CargaPrestamos(int? id = null)
        {
                CargaComboboxs();

                oprestamos = db.Prestamos.Find(id);
                this.id = id;
                txtTasa.Text = oprestamos.Tasa.ToString();
                txtQty.Text = oprestamos.Cantidad.ToString();
                dtpFechaTransaccion.Value = (DateTime)oprestamos.Desde;
                cbCliente.SelectedValue = (int?)oprestamos.IDCliente;
                cbTipoCliente.SelectedValue= oprestamos.Tipo.ToString(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int? id = GetIdPresta();

                if (id != null)
                {
                    CargaPrestamos(id);

                    ActualizaPrestamos();
                }
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TasaCliente(cbCliente.SelectedValue.ToString()) != string.Empty)
            {
                txtTasa.Text = tasacli.ToString();
            }
            else
            {
                txtTasa.Text = string.Empty;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbFiltroGRID_SelectedValueChanged(object sender, EventArgs e)
        {
                if (cbFiltroGRID.SelectedValue.ToString() == 1.ToString())
                {

                var dt = DgvFill("EXEC LST_GRID_PRESTAMOS " + 1 + " ");
                dgvPrestamos.DataSource = dt;

                this.dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardaPrestamos.Enabled = true;

                }
                else
                {

                var dt = DgvFill("EXEC LST_GRID_PRESTAMOS " + 2 + " ");
                dgvPrestamos.DataSource = dt;

                this.dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardaPrestamos.Enabled = false;
                }
            }
    }
}