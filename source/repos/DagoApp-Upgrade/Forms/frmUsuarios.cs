using DagoApp_.Models;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static DagoApp_.Class.LLENAGRIDVIEW;

namespace DagoApp_.Forms
{
    public partial class frmUsuarios : Form
    {
        DATA db = new DATA();

        public int? idRow;

        public frmUsuarios(int? id = null)
        {
            InitializeComponent();

            this.idRow = id;
            if (id != null)
                ActualizaGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //txtNombreUsuario.Text = idRow.ToString();

            //if (idRow == null)
            //{
                usuarios user = new usuarios();
                user.nombre = txtNombreUsuario.Text;
                user.apellido = txtApellidoUsuario.Text;
                user.usuario = txtUsuario.Text;
                user.nivelseguridad = 1;
                user.clave = txtClave.Text;

                db.usuarios.Add(user);
                db.SaveChanges();

                ActualizaGrid();

                MessageBox.Show("Sus datos se guardaron exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreUsuario.Text = string.Empty;
                txtApellidoUsuario.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;

                txtNombreUsuario.Focus();
            //}
            //else if (idRow != null)
            //{
            //    usuarios user = new usuarios();
            //    user.nombre = txtNombreUsuario.Text;
            //    user.apellido = txtApellidoUsuario.Text;
            //    user.usuario = txtUsuario.Text;
            //    user.nivelseguridad = 1;
            //    user.clave = txtClave.Text;

            //    db.SaveChanges();

            //    ActualizaGrid();

            //    MessageBox.Show("Se han actualizado los datos de " + user.nombre + " exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    txtNombreUsuario.Text = string.Empty;
            //    txtApellidoUsuario.Text = string.Empty;
            //    txtUsuario.Text = string.Empty;
            //    txtClave.Text = string.Empty;

            //    txtNombreUsuario.Focus();
            //}            
        }

        private void ActualizaGrid()
        {
            var dt = DgvFill("EXEC LST_USUARIOS");
            dgvUsuarios.DataSource = dt;
            this.dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private int? ObtieneIDFilaGrid()
        {
            try
            {
                return int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int? id = ObtieneIDFilaGrid();

                if (id != null)
                {
                    CargaDatos(id);

                    ActualizaGrid();
                }
            }
        }

        private void CargaDatos(int? id = null)
        {

            usuarios usuario = db.usuarios.Find(id);

            this.idRow = id;

            txtNombreUsuario.Text = usuario.nombre;
            txtApellidoUsuario.Text = usuario.apellido;
            txtUsuario.Text = usuario.usuario;
            txtClave.Text = usuario.clave;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = ObtieneIDFilaGrid();
            if (id != null)
            {

                    usuarios user = db.usuarios.Find(id);
                    db.usuarios.Remove(user);
                    db.SaveChanges();
                    ActualizaGrid();

                MessageBox.Show("El registro se elimino exitosamente","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
