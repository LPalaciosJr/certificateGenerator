using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DagoApp_.Diseño_Reportes
{
    public partial class rptEmpresas : Form
    {
        public rptEmpresas()
        {
            InitializeComponent();
        }

        private void rptEmpresas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lstEmpresas.Empresas' Puede moverla o quitarla según sea necesario.
            this.empresasTableAdapter.Fill(this.lstEmpresas.Empresas);

            this.reportViewer1.RefreshReport();
        }
    }
}
