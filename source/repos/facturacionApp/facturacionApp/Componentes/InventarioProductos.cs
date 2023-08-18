using System;
using static facturacionApp.Clases.GridView;

namespace facturacionApp.Componentes
{
    public partial class InventarioProductos : DevExpress.XtraEditors.XtraForm
    {
        public InventarioProductos()
        {
            InitializeComponent();
        }

        private void InventarioProductos_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
        }

        private void ActualizaDatos()
        {
            var dt = DgvFill("SELECT * FROM ViewExistenciaProductos");
            dgvDatos.DataSource = dt;
        }
    }
}