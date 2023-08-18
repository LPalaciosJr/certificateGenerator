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

namespace DagoApp_.ReportForms
{

    public partial class rptHistorialClientes : Form
    {
        DATA db = new DATA();
        public int? id;

        Clientes oclientes = null;
        public rptHistorialClientes(int? id = null)
        {
            InitializeComponent();

            this.id = id;

            if (id != null)
                CargaDatosClientes();
        }

        private void CargaDatosClientes()
        {
                oclientes = db.Clientes.Find(id);
                cbClienteRPT.SelectedValue = oclientes.IdCliente.ToString();
        }

        public int CLIENTE { get; set; }

        private void CargaClientes()
        {
                var listaClientes = (from cli in db.Clientes
                                     select cli).ToList();

                if (id != null)
                {
                    cbClienteRPT.DataSource = listaClientes;
                    cbClienteRPT.DisplayMember = "Nombre";
                    cbClienteRPT.ValueMember = "IdCliente";
                    cbClienteRPT.SelectedValue = id.ToString();
                }
                else
                {
                    cbClienteRPT.DataSource = listaClientes;
                    cbClienteRPT.DisplayMember = "Nombre";
                    cbClienteRPT.ValueMember = "IdCliente";
                }
          
        }

        private void rptHistorialClientes_Load(object sender, EventArgs e)
        {
            CargaClientes();

            if (id != null)
            {
                CLIENTE = Convert.ToInt32(id.ToString());


                cbClienteRPT.Visible = false;
                btnEnviar.Visible = false;
                label1.Visible = false;
                splitContainer1.Panel1.BackColor = Color.Blue;
                splitContainer1.Panel1MinSize = 0;

            }
            else
            {
                try
                {
                    CLIENTE = Convert.ToInt32(cbClienteRPT.SelectedValue.ToString());
                }
                catch
                {
                    return;
                }
                
            }

            this.hISTORIAL_CLIENTESTableAdapter.Fill(dataSetHC.HISTORIAL_CLIENTES, CLIENTE);

            this.reportViewer1.RefreshReport();
                                    
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            CLIENTE = Convert.ToInt32(cbClienteRPT.SelectedValue.ToString());


            this.hISTORIAL_CLIENTESTableAdapter.Fill(dataSetHC.HISTORIAL_CLIENTES, CLIENTE);
            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
