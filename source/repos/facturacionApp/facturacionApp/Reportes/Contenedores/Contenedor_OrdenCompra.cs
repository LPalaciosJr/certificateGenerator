using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace facturacionApp.Reportes.Contenedores
{
    public partial class Contenedor_OrdenCompra : DevExpress.XtraEditors.XtraForm
    {
        public int? OC_Detalle;
        public Contenedor_OrdenCompra(int? OC_Detalle)
        {
            InitializeComponent();
            this.OC_Detalle = OC_Detalle;
        }

        private void Contenedor_OrdenCompra_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();

            try
            {
                this.ordenesCompraImpresionTableAdapter.Fill(dataSetOrdenesCompra.OrdenesCompraImpresion, OC_Detalle);
                this.reportViewer1.RefreshReport();

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.PageWidth;
            }
            catch (Exception)
            {
                MessageBox.Show("Se esta configurando esta seccion, cuando haya finalizado se le notificara.","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}