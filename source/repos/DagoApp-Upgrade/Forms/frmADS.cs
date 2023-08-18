using System;
using System.Drawing;
using System.Windows.Forms;
using DagoApp_.Models;
using static DagoApp_.Class.LLENAGRIDVIEW;

namespace DagoApp_.Forms
{
    public partial class frmADS : Form
    {
        DATA db = new DATA();

        Prestamos oprestamos = new Prestamos();

        adelantosalario oADS = null;

        public int? id;

        public int? idADS;

        public frmADS(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)

                CargaGrid();
        }

        private void CargaGrid()
        {

            var dt = DgvFill("EXEC LST_ADS " + id + " ");
            dgvAds.DataSource = dt;

                dgvAds.RowHeadersVisible = false;
                dgvAds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.dgvAds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvAds.ForeColor = Color.Black;
                dgvAds.EnableHeadersVisualStyles = false;
                dgvAds.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvAds.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idADS == null)

                oADS = new adelantosalario();
                oADS.cantidad = Convert.ToDecimal(txtCantidad.Text);
                oADS.comentario = txtDescription.Text;
                
                oADS.fechai = Convert.ToDateTime(dtpDesde.Text);
                oADS.fechaf = Convert.ToDateTime(dptHasta.Text);           
                oADS.estado = rbDebe.Checked == true ? true : false;
                oADS.IdPrestamo = id;

                if (idADS == null)
                    db.adelantosalario.Add(oADS);
                else
            {
                db.Entry(oADS).State = System.Data.Entity.EntityState.Modified;
                    txtCantidad.Clear();
                    txtDescription.Clear();
                    idADS = null;
                }

                db.SaveChanges();
                txtCantidad.Clear();
                txtDescription.Clear();
                idADS = null;

                CargaGrid();
        }

        private void frmADS_Load(object sender, EventArgs e)
        {
            rbDebe.Checked = true;
            lblPrestamo.Text = id.ToString();
            txtDescription.Text = "ADS";
        }

        private void CargaDatos(int? idADS = null)
        {
                oADS = db.adelantosalario.Find(idADS);
                this.idADS = idADS;

                txtCantidad.Text = oADS.cantidad.ToString();
                txtDescription.Text = oADS.comentario;
                dtpDesde.Value = Convert.ToDateTime(oADS.fechai.ToString());
                dptHasta.Value = Convert.ToDateTime(oADS.fechaf.ToString());

                txtCantidad.Enabled = false;
                dtpDesde.Enabled = false;
                txtDescription.Text = DateTime.Now.ToString();
                txtDescription.Enabled = false;

                if (Convert.ToInt32(oADS.estado) == 1)
                {
                    rbDebe.Checked = true;
                }
                else
                {
                    rbPago.Checked = true;
                }     
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvAds.Rows[dgvAds.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                if (dgvAds.CurrentRow == null)
                {
                    MessageBox.Show("No hay datos para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int? idADS = GetId();

                    if (idADS != null)
                    {
                        CargaDatos(idADS);
                    }
                }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvAds.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int? idADS = GetId();

                if (idADS != null)
                {
                    adelantosalario oAds = db.adelantosalario.Find(idADS);
                    db.adelantosalario.Remove(oAds);
                    db.SaveChanges();
                    CargaGrid();
                }
            }
        }
    }
}