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

namespace DagoApp_
{
    public partial class frmInteresesxFecha : Form
    {
        public frmInteresesxFecha()
        {
            InitializeComponent();
        }

        public DateTime FECHAINICIO { get; set; }
        public DateTime FECHAFINAL { get; set; }

        private void frmInteresesxFecha_Load(object sender, EventArgs e)
        {

            FECHAINICIO = dtpDesde.Value;
            FECHAFINAL = dtpHasta.Value;

            this.iNTERESESRECIBIDOSTableAdapter.Fill(this.dataSetInteresesxFecha.INTERESESRECIBIDOS, FECHAINICIO, FECHAFINAL);
            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            this.reportViewer1.RefreshReport();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FECHAINICIO = dtpDesde.Value;
            FECHAFINAL = dtpHasta.Value;

            this.iNTERESESRECIBIDOSTableAdapter.Fill(this.dataSetInteresesxFecha.INTERESESRECIBIDOS, FECHAINICIO, FECHAFINAL);
            this.reportViewer1.RefreshReport();
        }
    }
}
