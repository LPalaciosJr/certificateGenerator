using System;
using static facturacionApp.Clases.GridView;

namespace facturacionApp.Componentes
{
    public partial class FacturasContado : DevExpress.XtraEditors.XtraForm
    {
        public FacturasContado()
        {
            InitializeComponent();
        }

        private void FacturasContado_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill("EXEC [Factura_X_Estado] 0");
            dgvDatos.DataSource = dt;
        }
    }
}