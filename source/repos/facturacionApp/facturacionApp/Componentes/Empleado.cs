using DevExpress.XtraGrid.Views.Grid;
using facturacionApp.Datos;
using System;
using System.Windows.Forms;
using static facturacionApp.Clases.GridView;
using static facturacionApp.Clases.LimpiaControles;

namespace facturacionApp.Componentes
{
    public partial class Empleado : DevExpress.XtraEditors.XtraForm
    {
        //TA db = new DATA();
        public int? id;
        empleados oTablaEmpleados = null;
        public Empleado(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                CargaDatos();
        }
        private void ActualizaDatos()
        {
            var dt = DgvFill("SELECT * FROM VIEWEMPLEADOS");
            dgvDatos.DataSource = dt;
        }
        private int? GetId()
        {
            try
            {
                GridView dataGridView1 = gridView1 as GridView;
                int[] SelectedRowHandles = dataGridView1.GetSelectedRows();
                string Valor = dataGridView1.GetRowCellValue(SelectedRowHandles[0], dataGridView1.Columns[0]).ToString();
                return int.Parse(Valor.ToString());
            }
            catch
            {
                return null;
            }
        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            ActualizaDatos();
            rbActivo.Checked = true;
        }
        private void CargaDatos(int? id = null)
        {
            using (DATA db = new DATA())
            {
                oTablaEmpleados = db.empleados.Find(id);
                this.id = id;
                txtNombres.Text = oTablaEmpleados.nombres;
                txtApellidos.Text = oTablaEmpleados.apellidos;
                txtIdentidad.Text = oTablaEmpleados.identidad;
                txtTelefono.Text = oTablaEmpleados.telefono;
                txtPuesto.Text = oTablaEmpleados.puesto;
                txtSueldo.Text = oTablaEmpleados.sueldo.ToString();
                dtpFechaNac.Value = Convert.ToDateTime(oTablaEmpleados.fechanac);

                if (oTablaEmpleados.inactive == 0)
                {
                    rbActivo.Checked = true;
                }
                else
                {
                    rbInactivo.Checked = true;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DATA db = new DATA())
            {
                if (id == null)

                    oTablaEmpleados = new empleados();
                oTablaEmpleados.nombres = txtNombres.Text;
                oTablaEmpleados.apellidos = txtApellidos.Text;
                oTablaEmpleados.identidad = txtIdentidad.Text;
                oTablaEmpleados.puesto = txtPuesto.Text;
                oTablaEmpleados.telefono = txtTelefono.Text;
                oTablaEmpleados.sueldo = Convert.ToDecimal(txtSueldo.Text);
                oTablaEmpleados.fechanac = dtpFechaNac.Value;
                oTablaEmpleados.fechaActualizacion = DateTime.Now;
                oTablaEmpleados.usuario = "Administrador";

                if (rbActivo.Checked)
                {
                    oTablaEmpleados.inactive = 0;
                }
                else if (rbInactivo.Checked)
                {
                    oTablaEmpleados.inactive = 1;
                }

                if (id == null)
                {
                    oTablaEmpleados.fechaIngreso = DateTime.Now;
                }


                if (id == null)

                    db.empleados.Add(oTablaEmpleados);
                else
                {
                    db.Entry(oTablaEmpleados).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                ActualizaDatos();

                if (id != null)
                {
                    gridView1.FocusedRowHandle = (int)id - 1;
                }
                else
                {
                    gridView1.FocusedRowHandle = 0;
                }

                LimpiaControl(this);
                id = null;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (DATA db = new DATA())
            {
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    int? id = GetId();

                    if (id != null)
                    {
                        empleados oempleados = db.empleados.Find(id);
                        db.empleados.Remove(oempleados);
                        db.SaveChanges();
                        ActualizaDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (DATA db = new DATA())
            {
                try
                {
                    int? id = GetId();
                    if (id != null)
                    {
                        CargaDatos(id);
                        ActualizaDatos();
                        gridView1.FocusedRowHandle = (int)id - 1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se editó", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}