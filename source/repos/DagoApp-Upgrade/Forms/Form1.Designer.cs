
namespace DagoApp_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cobradoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroPorCobradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeCuentaCuotaFijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCobroSemanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCobroGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesesPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonoAInteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.cobradoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.reporteriaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.informaciónDeAplicaciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empresasToolStripMenuItem.Image")));
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // cobradoresToolStripMenuItem
            // 
            this.cobradoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cobradoresToolStripMenuItem.Image")));
            this.cobradoresToolStripMenuItem.Name = "cobradoresToolStripMenuItem";
            this.cobradoresToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.cobradoresToolStripMenuItem.Text = "Cobradores";
            this.cobradoresToolStripMenuItem.Click += new System.EventHandler(this.cobradoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.reportesToolStripMenuItem.Text = "Prestamos";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // reporteriaToolStripMenuItem
            // 
            this.reporteriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egresosToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.empresasToolStripMenuItem1,
            this.cobradoresToolStripMenuItem1,
            this.cobroPorCobradorToolStripMenuItem,
            this.historialClientesToolStripMenuItem,
            this.estadoDeCuentaCuotaFijaToolStripMenuItem,
            this.reporteCobroSemanalToolStripMenuItem,
            this.pendientesToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.reporteCobroGeneralToolStripMenuItem,
            this.interesesPorFechaToolStripMenuItem,
            this.abonoAInteresToolStripMenuItem});
            this.reporteriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteriaToolStripMenuItem.Image")));
            this.reporteriaToolStripMenuItem.Name = "reporteriaToolStripMenuItem";
            this.reporteriaToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.reporteriaToolStripMenuItem.Text = "Reporteria";
            // 
            // egresosToolStripMenuItem
            // 
            this.egresosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.egresosToolStripMenuItem.Name = "egresosToolStripMenuItem";
            this.egresosToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.egresosToolStripMenuItem.Text = "Egresos";
            this.egresosToolStripMenuItem.Click += new System.EventHandler(this.egresosToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(315, 30);
            this.clientesToolStripMenuItem1.Text = "Listado Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // empresasToolStripMenuItem1
            // 
            this.empresasToolStripMenuItem1.Name = "empresasToolStripMenuItem1";
            this.empresasToolStripMenuItem1.Size = new System.Drawing.Size(315, 30);
            this.empresasToolStripMenuItem1.Text = "Listado Empresas";
            this.empresasToolStripMenuItem1.Click += new System.EventHandler(this.empresasToolStripMenuItem1_Click);
            // 
            // cobradoresToolStripMenuItem1
            // 
            this.cobradoresToolStripMenuItem1.Name = "cobradoresToolStripMenuItem1";
            this.cobradoresToolStripMenuItem1.Size = new System.Drawing.Size(315, 30);
            this.cobradoresToolStripMenuItem1.Text = "Listado Cobradores";
            this.cobradoresToolStripMenuItem1.Click += new System.EventHandler(this.cobradoresToolStripMenuItem1_Click);
            // 
            // cobroPorCobradorToolStripMenuItem
            // 
            this.cobroPorCobradorToolStripMenuItem.Name = "cobroPorCobradorToolStripMenuItem";
            this.cobroPorCobradorToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.cobroPorCobradorToolStripMenuItem.Text = "Reporte Cobro Quincenal";
            this.cobroPorCobradorToolStripMenuItem.Click += new System.EventHandler(this.cobroPorCobradorToolStripMenuItem_Click);
            // 
            // historialClientesToolStripMenuItem
            // 
            this.historialClientesToolStripMenuItem.Name = "historialClientesToolStripMenuItem";
            this.historialClientesToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.historialClientesToolStripMenuItem.Text = "Historial Clientes";
            this.historialClientesToolStripMenuItem.Click += new System.EventHandler(this.historialClientesToolStripMenuItem_Click);
            // 
            // estadoDeCuentaCuotaFijaToolStripMenuItem
            // 
            this.estadoDeCuentaCuotaFijaToolStripMenuItem.Name = "estadoDeCuentaCuotaFijaToolStripMenuItem";
            this.estadoDeCuentaCuotaFijaToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.estadoDeCuentaCuotaFijaToolStripMenuItem.Text = "Estado Cuenta(Cuota Fija)";
            this.estadoDeCuentaCuotaFijaToolStripMenuItem.Click += new System.EventHandler(this.estadoDeCuentaCuotaFijaToolStripMenuItem_Click);
            // 
            // reporteCobroSemanalToolStripMenuItem
            // 
            this.reporteCobroSemanalToolStripMenuItem.Name = "reporteCobroSemanalToolStripMenuItem";
            this.reporteCobroSemanalToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.reporteCobroSemanalToolStripMenuItem.Text = "Reporte Cobro Semanal";
            this.reporteCobroSemanalToolStripMenuItem.Click += new System.EventHandler(this.reporteCobroSemanalToolStripMenuItem_Click);
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.pendientesToolStripMenuItem.Text = "Clientes Con Saldo";
            this.pendientesToolStripMenuItem.Click += new System.EventHandler(this.pendientesToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // reporteCobroGeneralToolStripMenuItem
            // 
            this.reporteCobroGeneralToolStripMenuItem.Name = "reporteCobroGeneralToolStripMenuItem";
            this.reporteCobroGeneralToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.reporteCobroGeneralToolStripMenuItem.Text = "Reporte Cobro General";
            this.reporteCobroGeneralToolStripMenuItem.Click += new System.EventHandler(this.reporteCobroGeneralToolStripMenuItem_Click);
            // 
            // interesesPorFechaToolStripMenuItem
            // 
            this.interesesPorFechaToolStripMenuItem.Name = "interesesPorFechaToolStripMenuItem";
            this.interesesPorFechaToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.interesesPorFechaToolStripMenuItem.Text = "Intereses Por Fecha";
            this.interesesPorFechaToolStripMenuItem.Click += new System.EventHandler(this.interesesPorFechaToolStripMenuItem_Click);
            // 
            // abonoAInteresToolStripMenuItem
            // 
            this.abonoAInteresToolStripMenuItem.Name = "abonoAInteresToolStripMenuItem";
            this.abonoAInteresToolStripMenuItem.Size = new System.Drawing.Size(315, 30);
            this.abonoAInteresToolStripMenuItem.Text = "Abono a Interes";
            this.abonoAInteresToolStripMenuItem.Click += new System.EventHandler(this.abonoAInteresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // informaciónDeAplicaciónToolStripMenuItem
            // 
            this.informaciónDeAplicaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaciónDeAplicaciónToolStripMenuItem.Image")));
            this.informaciónDeAplicaciónToolStripMenuItem.Name = "informaciónDeAplicaciónToolStripMenuItem";
            this.informaciónDeAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.informaciónDeAplicaciónToolStripMenuItem.Text = "Información";
            this.informaciónDeAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónDeAplicaciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 849);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PRESTAPP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDeAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cobradoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cobroPorCobradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeCuentaCuotaFijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCobroSemanalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCobroGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interesesPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonoAInteresToolStripMenuItem;
    }
}

