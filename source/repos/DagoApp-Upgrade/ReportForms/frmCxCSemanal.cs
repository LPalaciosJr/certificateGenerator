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
using Microsoft.Reporting.WinForms;

namespace DagoApp_
{
    public partial class frmCxCSemanal : Form
    {
        DATA db = new DATA();

        public frmCxCSemanal()
        {
            InitializeComponent();
        }

        private void CargaCobrador()
        {

                var listaCobrador = (from cob in db.Cobradores
                                     select cob).ToList();

                cbCobradorRPT.DataSource = listaCobrador;
                cbCobradorRPT.DisplayMember = "Nombre";
                cbCobradorRPT.ValueMember = "IdCobrador";
           
        }

        public int COBRADOR { get; set; }

        private void frmCxCSemanal_Load(object sender, EventArgs e)
        {
            CargaCobrador();

            COBRADOR = Convert.ToInt32(cbCobradorRPT.SelectedValue.ToString());

            this.cOBRO_POR_COBRADOR_SEMANALTableAdapter.Fill(this.dataSetCxC.COBRO_POR_COBRADOR_SEMANAL, COBRADOR);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            COBRADOR = Convert.ToInt32(cbCobradorRPT.SelectedValue.ToString());

            this.cOBRO_POR_COBRADOR_SEMANALTableAdapter.Fill(this.dataSetCxC.COBRO_POR_COBRADOR_SEMANAL, COBRADOR);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
