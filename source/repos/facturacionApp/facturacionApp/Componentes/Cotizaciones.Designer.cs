namespace facturacionApp.Componentes
{
    partial class Cotizaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizaciones));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            this.btnCotizacionDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDatos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelContainer4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.panelContainer3 = new DevExpress.XtraBars.Docking.DockPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDatos);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 489);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbCotizacion);
            this.groupControl1.Controls.Add(this.btnCotizacionDetalle);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnEliminar);
            this.groupControl1.Controls.Add(this.btnGuardar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1075, 96);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Módulo de Cotizaciones";
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(26, 51);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(252, 21);
            this.cmbCotizacion.TabIndex = 43;
            // 
            // btnCotizacionDetalle
            // 
            this.btnCotizacionDetalle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCotizacionDetalle.Appearance.Options.UseFont = true;
            this.btnCotizacionDetalle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCotizacionDetalle.ImageOptions.Image")));
            this.btnCotizacionDetalle.Location = new System.Drawing.Point(666, 34);
            this.btnCotizacionDetalle.Name = "btnCotizacionDetalle";
            this.btnCotizacionDetalle.Size = new System.Drawing.Size(174, 38);
            this.btnCotizacionDetalle.TabIndex = 42;
            this.btnCotizacionDetalle.Text = "VER COTIZACIÓN";
            this.btnCotizacionDetalle.Click += new System.EventHandler(this.btnCotizacionDetalle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(26, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 19);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Cliente";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(306, 34);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 38);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "ELIMINAR COTIZACIÓN";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(486, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 38);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "CREAR COTIZACIÓN";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MainView = this.gridView1;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(1075, 389);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvDatos.Click += new System.EventHandler(this.dgvDatos_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvDatos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // panelContainer4
            // 
            this.panelContainer4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.panelContainer4.ID = new System.Guid("eee6585f-d085-47f0-9710-9f670731b5be");
            this.panelContainer4.Location = new System.Drawing.Point(0, 24);
            this.panelContainer4.Name = "panelContainer4";
            this.panelContainer4.OriginalSize = new System.Drawing.Size(200, 196);
            this.panelContainer4.Size = new System.Drawing.Size(679, 200);
            this.panelContainer4.Text = "panelContainer4";
            // 
            // panelContainer1
            // 
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.panelContainer1.ID = new System.Guid("804b6dec-1634-4add-9639-b74b855d6649");
            this.panelContainer1.Location = new System.Drawing.Point(0, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.panelContainer1.SavedIndex = 0;
            this.panelContainer1.Size = new System.Drawing.Size(375, 396);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // panelContainer3
            // 
            this.panelContainer3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.panelContainer3.ID = new System.Guid("bbf6cd78-2529-4a0b-b43c-6bcc14e1960a");
            this.panelContainer3.Location = new System.Drawing.Point(1, 24);
            this.panelContainer3.Name = "panelContainer3";
            this.panelContainer3.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer3.Size = new System.Drawing.Size(374, 147);
            this.panelContainer3.Text = "panelContainer3";
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 489);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cotizaciones";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cotizaciones_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgvDatos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCotizacionDetalle;
        private System.Windows.Forms.ComboBox cmbCotizacion;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer4;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer3;
    }
}