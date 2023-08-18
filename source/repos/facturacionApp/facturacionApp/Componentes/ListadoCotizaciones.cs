using System;
using static facturacionApp.Clases.GridView;

namespace facturacionApp.Componentes
{
    public partial class ListadoCotizaciones : DevExpress.XtraEditors.XtraForm
    {
        public ListadoCotizaciones()
        {
            InitializeComponent();
        }

        private void ListadoCotizaciones_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
        }

        private void ActualizaDatos()
        {
            var dt = DgvFill("select * from ViewCotizaciones");
            dgvDatos.DataSource = dt;
        }
    }
}