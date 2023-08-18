namespace DagoApp_
{
    partial class frmClientesIngresos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.iNGRESOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIngresos = new DagoApp_.DataSetIngresos();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iNGRESOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNGRESOSTableAdapter = new DagoApp_.DataSetIngresosTableAdapters.INGRESOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iNGRESOSBindingSource1
            // 
            this.iNGRESOSBindingSource1.DataMember = "INGRESOS";
            this.iNGRESOSBindingSource1.DataSource = this.dataSetIngresos;
            // 
            // dataSetIngresos
            // 
            this.dataSetIngresos.DataSetName = "DataSetIngresos";
            this.dataSetIngresos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.dtpHasta);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDesde);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 559);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(501, 14);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(287, 23);
            this.dtpHasta.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(430, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "HASTA:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(900, 13);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(193, 24);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "GENERAR REPORTE";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(83, 14);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(287, 23);
            this.dtpDesde.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESDE:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetIngresos";
            reportDataSource2.Value = this.iNGRESOSBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.rptIngresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1105, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // iNGRESOSBindingSource
            // 
            this.iNGRESOSBindingSource.DataMember = "INGRESOS";
            this.iNGRESOSBindingSource.DataSource = this.dataSetIngresos;
            // 
            // iNGRESOSTableAdapter
            // 
            this.iNGRESOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmClientesIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 559);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "frmClientesIngresos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Clientes Ingresados";
            this.Load += new System.EventHandler(this.frmClientesIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIngresos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource iNGRESOSBindingSource;
        private DataSetIngresos dataSetIngresos;
        private DataSetIngresosTableAdapters.INGRESOSTableAdapter iNGRESOSTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource iNGRESOSBindingSource1;
    }
}