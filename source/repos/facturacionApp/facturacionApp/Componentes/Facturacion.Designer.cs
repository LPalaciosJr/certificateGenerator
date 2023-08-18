namespace facturacionApp.Componentes
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNoFactura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCAI = new DevExpress.XtraEditors.TextEdit();
            this.txtRangoAutorizado = new DevExpress.XtraEditors.TextEdit();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbContado = new System.Windows.Forms.RadioButton();
            this.dtpFechaVence = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbClientesFactura = new System.Windows.Forms.ComboBox();
            this.btnCotizacionDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDatos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangoAutorizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.splitContainer1.Size = new System.Drawing.Size(1642, 684);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNoFactura);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.btnEditar);
            this.groupControl1.Controls.Add(this.txtCAI);
            this.groupControl1.Controls.Add(this.txtRangoAutorizado);
            this.groupControl1.Controls.Add(this.rbCredito);
            this.groupControl1.Controls.Add(this.rbContado);
            this.groupControl1.Controls.Add(this.dtpFechaVence);
            this.groupControl1.Controls.Add(this.dtpFechaEmision);
            this.groupControl1.Controls.Add(this.dtpFechaLimite);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cmbMetodoPago);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cmbClientesFactura);
            this.groupControl1.Controls.Add(this.btnCotizacionDetalle);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnEliminar);
            this.groupControl1.Controls.Add(this.btnGuardar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1638, 208);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Panel de Facturación";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(33, 173);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.txtNoFactura.Properties.Appearance.Options.UseFont = true;
            this.txtNoFactura.Size = new System.Drawing.Size(199, 24);
            this.txtNoFactura.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(33, 149);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(199, 23);
            this.labelControl9.TabIndex = 58;
            this.labelControl9.Text = "NO. FACTURA";
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(1458, 50);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(174, 54);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "EDITAR FACTURA";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(310, 115);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCAI.Properties.Appearance.Options.UseFont = true;
            this.txtCAI.Size = new System.Drawing.Size(221, 24);
            this.txtCAI.TabIndex = 5;
            // 
            // txtRangoAutorizado
            // 
            this.txtRangoAutorizado.Location = new System.Drawing.Point(33, 115);
            this.txtRangoAutorizado.Name = "txtRangoAutorizado";
            this.txtRangoAutorizado.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.txtRangoAutorizado.Properties.Appearance.Options.UseFont = true;
            this.txtRangoAutorizado.Size = new System.Drawing.Size(199, 24);
            this.txtRangoAutorizado.TabIndex = 4;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.rbCredito.Location = new System.Drawing.Point(456, 174);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(98, 22);
            this.rbCredito.TabIndex = 9;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "CRÉDITO";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbContado
            // 
            this.rbContado.AutoSize = true;
            this.rbContado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.rbContado.Location = new System.Drawing.Point(310, 174);
            this.rbContado.Name = "rbContado";
            this.rbContado.Size = new System.Drawing.Size(104, 22);
            this.rbContado.TabIndex = 8;
            this.rbContado.TabStop = true;
            this.rbContado.Text = "CONTADO";
            this.rbContado.UseVisualStyleBackColor = true;
            // 
            // dtpFechaVence
            // 
            this.dtpFechaVence.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpFechaVence.Location = new System.Drawing.Point(617, 171);
            this.dtpFechaVence.Name = "dtpFechaVence";
            this.dtpFechaVence.Size = new System.Drawing.Size(316, 25);
            this.dtpFechaVence.TabIndex = 10;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpFechaEmision.Location = new System.Drawing.Point(617, 118);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(316, 25);
            this.dtpFechaEmision.TabIndex = 6;
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpFechaLimite.Location = new System.Drawing.Point(617, 57);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(316, 25);
            this.dtpFechaLimite.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(617, 149);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(316, 23);
            this.labelControl8.TabIndex = 56;
            this.labelControl8.Text = "FECHA VENCIMIENTO";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(617, 93);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(316, 23);
            this.labelControl7.TabIndex = 55;
            this.labelControl7.Text = "FECHA EMISIÓN";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(617, 36);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(316, 23);
            this.labelControl6.TabIndex = 54;
            this.labelControl6.Text = "FECHA LIMITE";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(310, 149);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(221, 23);
            this.labelControl5.TabIndex = 53;
            this.labelControl5.Text = "ESTADO DE PAGO";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(310, 56);
            this.cmbMetodoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(221, 26);
            this.cmbMetodoPago.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(310, 36);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(221, 23);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "MÉTODO DE PAGO";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(310, 91);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(221, 23);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "CAI";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(33, 91);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(199, 23);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "RANGO AUTORIZADO";
            // 
            // cmbClientesFactura
            // 
            this.cmbClientesFactura.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbClientesFactura.FormattingEnabled = true;
            this.cmbClientesFactura.Location = new System.Drawing.Point(33, 58);
            this.cmbClientesFactura.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientesFactura.Name = "cmbClientesFactura";
            this.cmbClientesFactura.Size = new System.Drawing.Size(199, 26);
            this.cmbClientesFactura.TabIndex = 1;
            // 
            // btnCotizacionDetalle
            // 
            this.btnCotizacionDetalle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCotizacionDetalle.Appearance.Options.UseFont = true;
            this.btnCotizacionDetalle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCotizacionDetalle.ImageOptions.Image")));
            this.btnCotizacionDetalle.Location = new System.Drawing.Point(1279, 129);
            this.btnCotizacionDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCotizacionDetalle.Name = "btnCotizacionDetalle";
            this.btnCotizacionDetalle.Size = new System.Drawing.Size(171, 54);
            this.btnCotizacionDetalle.TabIndex = 13;
            this.btnCotizacionDetalle.Text = "VER FACTURA";
            this.btnCotizacionDetalle.Click += new System.EventHandler(this.btnCotizacionDetalle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(33, 36);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(199, 23);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "CLIENTE";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(1458, 129);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 54);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR FACTURA";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(1279, 50);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 54);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "CREAR FACTURA";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MainView = this.gridView1;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(1638, 464);
            this.dgvDatos.TabIndex = 0;
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
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 684);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangoAutorizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbClientesFactura;
        private DevExpress.XtraEditors.SimpleButton btnCotizacionDetalle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraGrid.GridControl dgvDatos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.TextEdit txtCAI;
        private DevExpress.XtraEditors.TextEdit txtRangoAutorizado;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbContado;
        private System.Windows.Forms.DateTimePicker dtpFechaVence;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNoFactura;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}