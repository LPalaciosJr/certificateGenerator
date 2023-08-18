using System;
using static facturacionApp.Clases.GridView;

namespace facturacionApp.Componentes
{
    public partial class FacturasCredito : DevExpress.XtraEditors.XtraForm
    {
        public FacturasCredito()
        {
            InitializeComponent();
        }

        private void FacturasCredito_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill("EXEC [Factura_X_Estado] 1");
            dgvDatos.DataSource = dt;
        }
    }
}