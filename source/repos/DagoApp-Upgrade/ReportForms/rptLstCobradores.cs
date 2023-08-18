using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DagoApp_.ReportForms
{
    public partial class rptLstCobradores : Form
    {
        public rptLstCobradores()
        {
            InitializeComponent();
        }

        private void rptLstCobradores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCobrador.Cobradores' Puede moverla o quitarla según sea necesario.
            this.cobradoresTableAdapter.Fill(this.dataSetCobrador.Cobradores);

            this.reportViewer1.RefreshReport();
        }
    }
}
