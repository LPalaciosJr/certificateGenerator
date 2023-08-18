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
    public partial class DatosCobradores : Form
    {
        DATA db = new DATA();

        public int? id;

        Cobradores ocobrador = null;

        public DatosCobradores(int? id = null)
        {
            InitializeComponent();

            this.id = id;

            if (id != null)
                CargaDatosCobrador();
        }

        private void CargaDatosCobrador()
        {

                ocobrador = db.Cobradores.Find(id);
                txtNombreCobrador.Text = ocobrador.Nombre;
            
        }

        private void btnGuardaCobrador_Click(object sender, EventArgs e)
        {
                if (id == null)

                    ocobrador = new Cobradores();
                ocobrador.Nombre = txtNombreCobrador.Text;

                if (id == null)

                    db.Cobradores.Add(ocobrador);
                else
                {
                    db.Entry(ocobrador).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();

                MessageBox.Show("Datos Ingresados Satisfactoriamente.");

                this.Close();
            
        }
    }
}
