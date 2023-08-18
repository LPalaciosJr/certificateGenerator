using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using facturacionApp.Datos;

namespace facturacionApp.Componentes
{
    public partial class InicioSesion : DevExpress.XtraEditors.XtraForm
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string Pass = txtPassword.Text;

            using (DATA db = new DATA())
            {
                var lst = from u in db.usuarios
                          where u.usuario == txtUsuario.Text && u.clave == Pass
                          select u;

                if (lst.Count() > 0)
                {
                    this.Hide();
                    Main oMain = new Main();
                    oMain.FormClosed += (s, args) => this.Close();
                    oMain.Show();
                }
                else
                {
                    MessageBox.Show("Este usuario no existe o se ha ingresado de forma incorrecta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
        }
    }
}