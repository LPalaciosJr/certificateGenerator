using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace facturacionApp.Reportes.Contenedores
{
    public partial class Contenedor_FacturaVenta : Form
    {
        public int? id;
        public Contenedor_FacturaVenta(int? id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Contenedor_FacturaVenta_Load(object sender, EventArgs e)
        {
            this.facturaVentaTableAdapter.Fill(dataSetFacturaVenta.FacturaVenta, id);
            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{
        //    this.facturaVentaTableAdapter.Fill(dataSetFacturaVenta.FacturaVenta, id);

        //    this.reportViewer1.RefreshReport();

        //    reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        //    reportViewer1.ZoomMode = ZoomMode.PageWidth;

        //}
    }
}
