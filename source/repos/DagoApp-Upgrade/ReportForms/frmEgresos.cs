using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using DagoApp_.DataSets;

namespace DagoApp_
{
    public partial class frmEgresos : Form
    {
        public frmEgresos()
        {
            InitializeComponent();
        }

        public DateTime FECHAINICIO { get; set; }
        public DateTime FECHAFINAL { get; set; }

        private void frmEgresos_Load(object sender, EventArgs e)
        {
            FECHAINICIO = dtpDesde.Value;
            FECHAFINAL = dtpHasta.Value;
           
            

            this.egresosTableAdapter1.Fill(this.dataSetEgresos.EGRESOS, FECHAINICIO, FECHAFINAL);

            //this.eGRESOSTableAdapter.Fill(this.dataSetEgresos.EGRESOS, FECHAINICIO, FECHAFINAL);
            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FECHAINICIO = dtpDesde.Value;
            FECHAFINAL = dtpHasta.Value;

            this.egresosTableAdapter1.Fill(this.dataSetEgresos.EGRESOS, FECHAINICIO, FECHAFINAL);
            this.reportViewer1.RefreshReport();
        }
    }
}
