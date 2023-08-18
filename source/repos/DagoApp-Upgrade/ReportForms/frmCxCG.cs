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
    public partial class frmCxCG : Form
    {
        DATA db = new DATA();
        public frmCxCG()
        {
            InitializeComponent();
        }

        private void CargaCobrador()
        {
                List<Valor> list = new List<Valor>();

                list.Add(new Valor() { Index = "Semanal", Value = 0.ToString() });
                list.Add(new Valor() { Index = "Quincenal", Value = 1.ToString() });
                list.Add(new Valor() { Index = "Mensual", Value = 2.ToString() });

                cbTipoModalidad.DataSource = list;
                cbTipoModalidad.DisplayMember = "Index";
                cbTipoModalidad.ValueMember = "Value";
        }

        public class Valor
        {
            public string Value { get; set; }
            public string Index { get; set; }
        }

        public int TIPO { get; set; }

        private void frmCxCG_Load(object sender, EventArgs e)
        {

            CargaCobrador();

            TIPO = Convert.ToInt32(cbTipoModalidad.SelectedValue.ToString());

            this.cOBRO_POR_COBRADOR_15NAL_GENERALTableAdapter.Fill(this.dataSetCxCG.COBRO_POR_COBRADOR_15NAL_GENERAL, TIPO);

            this.reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            TIPO = Convert.ToInt32(cbTipoModalidad.SelectedValue.ToString());

            this.cOBRO_POR_COBRADOR_15NAL_GENERALTableAdapter.Fill(this.dataSetCxCG.COBRO_POR_COBRADOR_15NAL_GENERAL, TIPO);

            this.reportViewer1.RefreshReport();
        }
    }
}
