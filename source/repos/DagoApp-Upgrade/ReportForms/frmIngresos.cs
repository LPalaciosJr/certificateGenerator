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
    public partial class frmIngresos : Form
    {
        public frmIngresos()
        {
            InitializeComponent();
        }

        public DateTime FECHAINICIO { get; set; }
        public DateTime FECHAFINAL { get; set;}

        private void frmIngresos_Load(object sender, EventArgs e)
        {

            FECHAINICIO = dtpdesde.Value;
            FECHAFINAL = dtphasta.Value;

            this.iNGRESOSTableAdapter.Fill(this.dataSetIngresos.INGRESOS, FECHAINICIO, FECHAFINAL);

            this.reportViewer1.RefreshReport();
            
            //MODO IMPRESION POR DEFAULT
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout); 
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            //FindForm MODO IMPRESION
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            DateTime FECHAINICIO = dtpdesde.Value;
            DateTime FECHAFINAL = dtphasta.Value;

            this.iNGRESOSTableAdapter.Fill(this.dataSetIngresos.INGRESOS, FECHAINICIO, FECHAFINAL);

            this.reportViewer1.RefreshReport();

        }
    }
}
