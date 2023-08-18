using DevExpress.XtraBars;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using facturacionApp.Componentes;
using static facturacionApp.Clases.GridView;

namespace facturacionApp
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is Facturacion);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                Facturacion oPuntoDeVenta = new Facturacion();
                oPuntoDeVenta.MdiParent = this;
                oPuntoDeVenta.Show();
            }
        }
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Quiere cerrar la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is Empleado);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                Empleado oEmpleados = new Empleado();
                oEmpleados.MdiParent = this;
                oEmpleados.Show();
            }
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is ListadoEmpleados);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                ListadoEmpleados oLstEmpleados = new ListadoEmpleados();
                oLstEmpleados.MdiParent = this;
                oLstEmpleados.Show();
            }
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is Cotizaciones);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                Cotizaciones oCotizaciones = new Cotizaciones();
                oCotizaciones.MdiParent = this;
                oCotizaciones.Show();
            }
        }
        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is Clientes);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                Clientes oClientes = new Clientes();
                oClientes.MdiParent = this;
                oClientes.Show();
            }
        }
        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is Proveedores);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                Proveedores oProveedores = new Proveedores();
                oProveedores.MdiParent = this;
                oProveedores.Show();
            }
        }
        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is Productos);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                Productos oProductos = new Productos();
                oProductos.MdiParent = this;
                oProductos.Show();
            }
        }
        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is OrdenDeCompra);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                OrdenDeCompra OC = new OrdenDeCompra();
                OC.MdiParent = this;
                OC.Show();
            }
        }
        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is NotaDeSalida);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                NotaDeSalida NS = new NotaDeSalida();
                NS.MdiParent = this;
                NS.Show();
            }
        }
        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is BonificacionesYRegalias);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                BonificacionesYRegalias BYR = new BonificacionesYRegalias();
                BYR.MdiParent = this;
                BYR.Show();
            }
        }
        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Contenedor_Facturas ReporteFacturas = new Contenedor_Facturas();
            //ReporteFacturas.ShowDialog();
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is Usuarios);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                Usuarios oUsuarios = new Usuarios();
                oUsuarios.MdiParent = this;
                oUsuarios.Show();
            }
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is ListadoCotizaciones);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                ListadoCotizaciones oCotizaciones = new ListadoCotizaciones();
                oCotizaciones.MdiParent = this;
                oCotizaciones.Show();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            NotaSalida.Enabled = false;
            Regalias.Enabled = false;
            barButtonItem3.Enabled = false;

            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is InventarioProductos);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                InventarioProductos OnHand = new InventarioProductos();
                OnHand.MdiParent = this;
                OnHand.Show();
            }
        }

        private void barButtonItem22_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is InventarioProductos);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                InventarioProductos OnHand = new InventarioProductos();
                OnHand.MdiParent = this;
                OnHand.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is AcercaDe);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                AcercaDe oAbout = new AcercaDe();
                oAbout.MdiParent = this;
                oAbout.Show();
            }
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(i => i is InfoFiscal);

            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                InfoFiscal oInfo = new InfoFiscal();
                oInfo.MdiParent = this;
                oInfo.Show();
            }
        }
    }
}