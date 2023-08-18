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

namespace DagoApp_.Forms
{
    public partial class DatosEmpresas : Form
    {
        DATA db = new DATA();

        public int? id;

        Empresas oempresa = null;

        public DatosEmpresas(int? id = null)
        {
            InitializeComponent();

            this.id = id;

            if (id != null)
                CargaDatosE();
        }

        private void CargaDatosE()
        {
                oempresa = db.Empresas.Find(id);
                txtNombreEmpresa.Text = oempresa.Nombre;
                txtDireccion.Text = oempresa.Direccion;

        }

        private void btnGuardarEmpresas_Click(object sender, EventArgs e)
        {
                if (id == null)

                    oempresa = new Empresas();
                oempresa.Nombre = txtNombreEmpresa.Text;
                oempresa.Direccion = txtDireccion.Text;
                

                if (id == null)

                    db.Empresas.Add(oempresa);
                else
                {
                    db.Entry(oempresa).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();

                MessageBox.Show("Datos Ingresados Satisfactoriamente.");

                this.Close();

            }
    }
}
