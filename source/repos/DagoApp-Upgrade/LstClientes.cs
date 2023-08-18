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
    public partial class LstClientes : Form
    {
        public LstClientes()
        {
            InitializeComponent();
        }

        private void LstClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetLstClientes.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dataSetLstClientes.DataTable1);

            this.reportViewer1.RefreshReport();
            //MODO IMPRESION POR DEFAULT
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            //FindForm MODO IMPRESION
        }
    }
}
