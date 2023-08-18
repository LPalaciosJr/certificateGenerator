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
using DagoApp_.Diseño_Reportes;
using DagoApp_.ReportForms;

namespace DagoApp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        //    using (Models.DATA db = new DATA())
        //    {
        //        usuarios u = new usuarios();
        //        label1.Text = u.nombre;
        //    }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients frmClientes = new Clients();
            frmClientes.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Quiere cerrar la aplicación?","AVISO", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(resp == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresas empresas = new frmEmpresas();
            empresas.ShowDialog();
        }

        private void informaciónDeAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void cobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCobradores cobradores = new frmCobradores();
            cobradores.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos prestamos = new frmPrestamos();
            prestamos.ShowDialog();
        }

        private void empresasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rptEmpresas rptE = new rptEmpresas(); 
            rptE.ShowDialog();
        }

        private void cobradoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rptLstCobradores rptC  = new rptLstCobradores();
            rptC.ShowDialog(); 
        }

        private void cobroPorCobradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CxC cxc = new CxC();
            cxc.ShowDialog();
        }

        private void historialClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptHistorialClientes frmHC = new rptHistorialClientes();
            frmHC.ShowDialog();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesIngresos ingresos = new frmClientesIngresos();
            ingresos.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LstClientes frmrpt = new LstClientes();
            frmrpt.ShowDialog();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEgresos egresos = new frmEgresos();
            egresos.ShowDialog();
        }

        private void estadoDeCuentaCuotaFijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuotaFija CuotaFija = new frmCuotaFija();
            CuotaFija.ShowDialog();
        }

        private void reporteCobroSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCxCSemanal cxcsemnal = new frmCxCSemanal();
            cxcsemnal.ShowDialog();
        }

        private void pendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPendientes pendi = new frmPendientes();
            pendi.ShowDialog();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovientos mov = new frmMovientos();
            mov.ShowDialog();
        }

        private void reporteCobroGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCxCG cxCG = new frmCxCG();
            cxCG.ShowDialog();
        }

        private void interesesPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInteresesxFecha ixf = new frmInteresesxFecha();
            ixf.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios formUsuarios = new frmUsuarios();
            formUsuarios.ShowDialog();
        }

        private void abonoAInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptAbonoInteres AbonoInteres = new rptAbonoInteres();
            AbonoInteres.ShowDialog();
        }
    }
}
