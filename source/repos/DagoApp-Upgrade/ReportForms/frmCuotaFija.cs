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
    public partial class frmCuotaFija : Form
    {
        DATA db = new DATA();

        public frmCuotaFija()
        {
            InitializeComponent();
        }

        public int CLIENTE { get; set; }

        private void CargaClienteCuotaFija()
        {
                var listaClientes = (from cli in db.Clientes
                                     where cli.TipoCliente ==0
                                     select cli).ToList();


                cbClienteCuotaFija.DataSource = listaClientes;
                cbClienteCuotaFija.DisplayMember = "Nombre";
                cbClienteCuotaFija.ValueMember = "IdCliente";
 
        }

        private void frmCuotaFija_Load(object sender, EventArgs e)
        {
            CargaClienteCuotaFija();

            CLIENTE = Convert.ToInt32(cbClienteCuotaFija.SelectedValue.ToString());

            this.eSTADO_CUENTA_CUOTAFIJATableAdapter.Fill(dataSetCuotaFija.ESTADO_CUENTA_CUOTAFIJA, CLIENTE);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CLIENTE = Convert.ToInt32(cbClienteCuotaFija.SelectedValue.ToString());

            this.eSTADO_CUENTA_CUOTAFIJATableAdapter.Fill(dataSetCuotaFija.ESTADO_CUENTA_CUOTAFIJA, CLIENTE);

            this.reportViewer1.RefreshReport();
        }
    }
}
