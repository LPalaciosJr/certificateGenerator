using DevExpress.XtraGrid.Views.Grid;
using facturacionApp.Datos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;


namespace facturacionApp.Componentes
{
    public partial class Usuarios : DevExpress.XtraEditors.XtraForm
    {
        DATA db = new DATA();
        usuarios oUser = null;

        public int? id;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
            LlenarComboBox();
            btnEliminar.Enabled = false;
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill("select * from viewUsuarios");
            dgvDatos.DataSource = dt;
        }
        public class ComboBoxItem
        {
            public int Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void LlenarComboBox()
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>
    {
        new ComboBoxItem { Value = 7, Text = "Administrador" },
        new ComboBoxItem { Value = 1, Text = "Usuario" }
    };
            cmbRol.DataSource = items;
            cmbRol.DisplayMember = "Text";
            cmbRol.ValueMember = "Value";

            cmbRol.SelectedIndex = 1;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id == null)

                oUser = new usuarios();
            oUser.nombres = txtNombres.Text;
            oUser.apellidos = txtApellidos.Text;
            oUser.correoE = txtEmail.Text;
            oUser.telefono = txtTelefono.Text;

            if (rbActivo.Checked)
            {
                oUser.inactive = 0;
            }
            else
            {
                oUser.inactive = 1;
            }

            oUser.usuario = txtUsuario.Text;
            oUser.clave = txtClave.Text;

            if (cmbRol.SelectedValue.ToString() == "1")
            {
                oUser.nivelSeguridad = 1;
            }
            else
            {
                oUser.nivelSeguridad = 7;
            }
            oUser.fechaRegistro = DateTime.Now;

            if (id == null)
                db.usuarios.Add(oUser);
            else
            {
                db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();

            ActualizaDatos();
            LimpiaControl(this);
            id = null;
        }

        private void CargaDatos(int? id = null)
        {
            oUser = db.usuarios.Find(id);
            this.id = id;
            txtNombres.Text = oUser.nombres;
            txtApellidos.Text = oUser.apellidos;
            txtEmail.Text = oUser.correoE;
            txtTelefono.Text = oUser.telefono;

            if (oUser.inactive == 0)
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }

            txtUsuario.Text = oUser.usuario;
            txtClave.Text = oUser.clave;
            cmbRol.SelectedValue = oUser.nivelSeguridad;
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int? id = GetId();

                if (id != null)
                {
                    usuarios oUser = db.usuarios.Find(id);
                    db.usuarios.Remove(oUser);
                    db.SaveChanges();
                    ActualizaDatos();
                }
                else
                {
                    MessageBox.Show("No se eliminó", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                CargaDatos(id);
                ActualizaDatos();
                gridView1.FocusedRowHandle = (int)id - 1;
            }
        }
    }
}