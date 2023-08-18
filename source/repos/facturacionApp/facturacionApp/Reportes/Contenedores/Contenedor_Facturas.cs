using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacionApp.Reportes.Contenedores
{
    public partial class Contenedor_Facturas : Form
    {
        public Contenedor_Facturas()
        {
            InitializeComponent();
        }

        private void Contenedor_Facturas_Load(object sender, EventArgs e)
        {
            this.sP_FacturasTableAdapter.Fill(this.dataSetFacturas.SP_Facturas);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.sP_FacturasTableAdapter.Fill(this.dataSetFacturas.SP_Facturas);
            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

        }
    }
}
