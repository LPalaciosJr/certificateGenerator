namespace facturacionApp.Componentes
{
    partial class OrdenDeCompraDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenDeCompraDetalle));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPrintQuedan = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintOC = new DevExpress.XtraEditors.SimpleButton();
            this.btnCerrarOC = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.txtImpuesto = new DevExpress.XtraEditors.TextEdit();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDatos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDatos);
            this.splitContainer1.Size = new System.Drawing.Size(1554, 778);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPrintQuedan);
            this.groupControl1.Controls.Add(this.btnPrintOC);
            this.groupControl1.Controls.Add(this.btnCerrarOC);
            this.groupControl1.Controls.Add(this.btnEliminar);
            this.groupControl1.Controls.Add(this.btnEditar);
            this.groupControl1.Controls.Add(this.btnGuardar);
            this.groupControl1.Controls.Add(this.txtCantidad);
            this.groupControl1.Controls.Add(this.txtImpuesto);
            this.groupControl1.Controls.Add(this.txtCosto);
            this.groupControl1.Controls.Add(this.txtCodigo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cmbProducto);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(489, 778);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Detalle de Orden de Compra";
            // 
            // btnPrintQuedan
            // 
            this.btnPrintQuedan.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintQuedan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrintQuedan.Appearance.Options.UseBackColor = true;
            this.btnPrintQuedan.Appearance.Options.UseFont = true;
            this.btnPrintQuedan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintQuedan.ImageOptions.Image")));
            this.btnPrintQuedan.Location = new System.Drawing.Point(29, 574);
            this.btnPrintQuedan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintQuedan.Name = "btnPrintQuedan";
            this.btnPrintQuedan.Size = new System.Drawing.Size(518, 47);
            this.btnPrintQuedan.TabIndex = 10;
            this.btnPrintQuedan.Text = "IMPRIMIR QUEDAN";
            // 
            // btnPrintOC
            // 
            this.btnPrintOC.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrintOC.Appearance.Options.UseFont = true;
            this.btnPrintOC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintOC.ImageOptions.Image")));
            this.btnPrintOC.Location = new System.Drawing.Point(308, 455);
            this.btnPrintOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintOC.Name = "btnPrintOC";
            this.btnPrintOC.Size = new System.Drawing.Size(239, 47);
            this.btnPrintOC.TabIndex = 9;
            this.btnPrintOC.Text = "IMPRIMIR O/C";
            this.btnPrintOC.Click += new System.EventHandler(this.btnPrintOC_Click);
            // 
            // btnCerrarOC
            // 
            this.btnCerrarOC.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnCerrarOC.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrarOC.Appearance.Options.UseBackColor = true;
            this.btnCerrarOC.Appearance.Options.UseFont = true;
            this.btnCerrarOC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarOC.ImageOptions.Image")));
            this.btnCerrarOC.Location = new System.Drawing.Point(29, 662);
            this.btnCerrarOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarOC.Name = "btnCerrarOC";
            this.btnCerrarOC.Size = new System.Drawing.Size(518, 47);
            this.btnCerrarOC.TabIndex = 11;
            this.btnCerrarOC.Text = "RECIBIDA";
            this.btnCerrarOC.Click += new System.EventHandler(this.btnCerrarOC_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(29, 455);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(239, 47);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR DATOS";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(29, 377);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(239, 47);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "EDITAR DATOS";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(308, 377);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(239, 47);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR DATOS";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(414, 262);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCantidad.Properties.Appearance.Options.UseFont = true;
            this.txtCantidad.Size = new System.Drawing.Size(133, 26);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(223, 262);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtImpuesto.Properties.Appearance.Options.UseFont = true;
            this.txtImpuesto.Size = new System.Drawing.Size(130, 26);
            this.txtImpuesto.TabIndex = 4;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(29, 262);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCosto.Properties.Appearance.Options.UseFont = true;
            this.txtCosto.Size = new System.Drawing.Size(130, 26);
            this.txtCosto.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(331, 159);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(216, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(414, 235);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 20);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Cantidad";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(223, 235);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 20);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Impuesto";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(29, 235);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 20);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Costo";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(331, 130);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 20);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Código";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(29, 159);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(231, 27);
            this.cmbProducto.TabIndex = 1;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(29, 130);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 20);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Producto";
            // 
            // dgvDatos
            // 
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MainView = this.gridView1;
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(1060, 778);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.dgvDatos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // OrdenDeCompraDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 778);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrdenDeCompraDetalle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenDeCompraDetalle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrdenDeCompraDetalle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgvDatos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbProducto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.TextEdit txtImpuesto;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.SimpleButton btnCerrarOC;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnPrintQuedan;
        private DevExpress.XtraEditors.SimpleButton btnPrintOC;
    }
}