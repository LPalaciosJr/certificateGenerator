using System;
using static facturacionApp.Clases.GridView;

namespace facturacionApp.Componentes
{
    public partial class ListadoEmpleados : DevExpress.XtraEditors.XtraForm
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void ListadoEmpleados_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
        }

        private void ActualizaDatos()
        {
            var dt = DgvFill("SELECT * FROM VIEWEMPLEADOS");
            dgvDatos.DataSource = dt;
        }
    }
}