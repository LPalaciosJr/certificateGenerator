using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DagoApp_.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string Pass = txtPassword.Text;

            using (Models.DATA db = new Models.DATA())
            {
                var lst = from u in db.usuarios
                          where u.usuario == txtUsuario.Text && u.clave == Pass
                          select u;

                if (lst.Count() > 0)
                {
                    this.Hide();
                    Form1 Main = new Form1();
                    Main.FormClosed += (s, args) => this.Close();
                    Main.Show();
                }
                else
                {
                    MessageBox.Show("Este usuario no existe o se ha ingresado de forma incorrecta.","Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
        }
    }
}
