namespace facturacionApp.Componentes
{
    partial class OrdenDeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenDeCompra));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOCDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtNumReferencia = new DevExpress.XtraEditors.TextEdit();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDatos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNumOC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDatos);
            this.splitContainer1.Size = new System.Drawing.Size(1444, 675);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNumOC);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.btnOCDetalle);
            this.groupControl1.Controls.Add(this.btnEliminar);
            this.groupControl1.Controls.Add(this.btnEditar);
            this.groupControl1.Controls.Add(this.btnGuardar);
            this.groupControl1.Controls.Add(this.txtNota);
            this.groupControl1.Controls.Add(this.txtNumReferencia);
            this.groupControl1.Controls.Add(this.cmbProveedor);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(492, 675);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Control de Ordenes de Compra";
            // 
            // btnOCDetalle
            // 
            this.btnOCDetalle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOCDetalle.Appearance.Options.UseFont = true;
            this.btnOCDetalle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOCDetalle.ImageOptions.Image")));
            this.btnOCDetalle.Location = new System.Drawing.Point(263, 558);
            this.btnOCDetalle.Name = "btnOCDetalle";
            this.btnOCDetalle.Size = new System.Drawing.Size(205, 38);
            this.btnOCDetalle.TabIndex = 14;
            this.btnOCDetalle.Text = "VER ORDEN DE COMPRA";
            this.btnOCDetalle.Click += new System.EventHandler(this.btnOCDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(24, 558);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(205, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR DATOS";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(24, 494);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(205, 38);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "EDITAR DATOS";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(263, 494);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(205, 38);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "GUARDAR DATOS";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNota.Location = new System.Drawing.Point(24, 293);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(444, 153);
            this.txtNota.TabIndex = 5;
            // 
            // txtNumReferencia
            // 
            this.txtNumReferencia.Location = new System.Drawing.Point(24, 202);
            this.txtNumReferencia.Name = "txtNumReferencia";
            this.txtNumReferencia.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNumReferencia.Properties.Appearance.Options.UseFont = true;
            this.txtNumReferencia.Size = new System.Drawing.Size(444, 22);
            this.txtNumReferencia.TabIndex = 4;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(24, 110);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(199, 24);
            this.cmbProveedor.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(24, 267);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nota o Comentario";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(24, 177);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(213, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Número de referencia de factura";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(24, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Proveedor";
            // 
            // dgvDatos
            // 
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MainView = this.gridView1;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(948, 675);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvDatos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // txtNumOC
            // 
            this.txtNumOC.Location = new System.Drawing.Point(255, 112);
            this.txtNumOC.Name = "txtNumOC";
            this.txtNumOC.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNumOC.Properties.Appearance.Options.UseFont = true;
            this.txtNumOC.Size = new System.Drawing.Size(213, 22);
            this.txtNumOC.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(255, 87);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(213, 16);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Número de Orden Compra";
            // 
            // OrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 675);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdenDeCompra";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenDeCompra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrdenDeCompra_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgvDatos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtNota;
        private DevExpress.XtraEditors.TextEdit txtNumReferencia;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnOCDetalle;
        private DevExpress.XtraEditors.TextEdit txtNumOC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}