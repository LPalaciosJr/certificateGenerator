using facturacionApp.Reportes.Conjunto_de_Datos;
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
//using facturacionApp.Reportes.Conjunto_de_Datos;

namespace facturacionApp.Reportes.Contenedores
{
    public partial class Contenedor_Cotizaciones : Form
    {
        public Contenedor_Cotizaciones()
        {
            InitializeComponent();
        }

        private void Contenedor_Cotizaciones_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

         

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Crear una instancia del dataset
            DataSetCotizaciones dataset = new DataSetCotizaciones(); // Reemplaza 'DataSetCotizaciones' con el nombre real de tu dataset

            // Cargar los datos en el dataset (aquí puedes realizar tus consultas y llenar el dataset con los datos correspondientes)

            // Crear una instancia del origen de datos y asignar el dataset
            ReportDataSource rds = new ReportDataSource("DataSetCotizaciones", dataset.Tables[0]); // Reemplaza 'DataSetCotizaciones' con el nombre real de tu dataset

            // Asignar el origen de datos al Report Viewer
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Refrescar el Report Viewer
            reportViewer1.RefreshReport();
        }

        //private DataTable ObtenerDatos()
        //{
        //    // Aquí debes implementar la lógica para obtener los datos que deseas mostrar en el informe
        //    // Puedes usar una base de datos, una lista de objetos, etc.

        //    DataTable dataTable = new DataTable("DS_Cotizacion");
        //    // Agregar las columnas necesarias a la DataTable
        //    // Rellenar la DataTable con los datos

        //    return dataTable;
        //}
    }
}
