using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace DagoApp_
{
    public partial class frmPendientes : Form
    {
        public frmPendientes()
        {
            InitializeComponent();
        }

        public DateTime FECHAINICIO { get; set; }
        public DateTime FECHAFINAL { get; set; }

        private void frmPendientes_Load(object sender, EventArgs e)
        {
            FECHAINICIO = dtpDesde.Value;
            FECHAFINAL = dtpHasta.Value;

            this.tRANSACCIONES_PENDIENTESTableAdapter.Fill(this.dataSetPendientes.TRANSACCIONES_PENDIENTES, FECHAINICIO, FECHAFINAL);
            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FECHAINICIO = dtpDesde.Value;
            FECHAFINAL = dtpHasta.Value;

            this.tRANSACCIONES_PENDIENTESTableAdapter.Fill(this.dataSetPendientes.TRANSACCIONES_PENDIENTES, FECHAINICIO, FECHAFINAL);
            this.reportViewer1.RefreshReport();
        }
    }
}
