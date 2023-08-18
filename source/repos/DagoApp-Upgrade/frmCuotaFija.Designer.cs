namespace DagoApp_
{
    partial class frmCuotaFija
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.eSTADOCUENTACUOTAFIJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCuotaFija = new DagoApp_.DataSetCuotaFija();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbClienteCuotaFija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eSTADO_CUENTA_CUOTAFIJATableAdapter = new DagoApp_.DataSetCuotaFijaTableAdapters.ESTADO_CUENTA_CUOTAFIJATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOCUENTACUOTAFIJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuotaFija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eSTADOCUENTACUOTAFIJABindingSource
            // 
            this.eSTADOCUENTACUOTAFIJABindingSource.DataMember = "ESTADO_CUENTA_CUOTAFIJA";
            this.eSTADOCUENTACUOTAFIJABindingSource.DataSource = this.dataSetCuotaFija;
            // 
            // dataSetCuotaFija
            // 
            this.dataSetCuotaFija.DataSetName = "DataSetCuotaFija";
            this.dataSetCuotaFija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel1.Controls.Add(this.cbClienteCuotaFija);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1188, 566);
            this.splitContainer1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(1002, 13);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(174, 28);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "GENERAR REPORTE";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbClienteCuotaFija
            // 
            this.cbClienteCuotaFija.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClienteCuotaFija.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClienteCuotaFija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbClienteCuotaFija.FormattingEnabled = true;
            this.cbClienteCuotaFija.Location = new System.Drawing.Point(100, 16);
            this.cbClienteCuotaFija.Name = "cbClienteCuotaFija";
            this.cbClienteCuotaFija.Size = new System.Drawing.Size(323, 24);
            this.cbClienteCuotaFija.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCuotaFija";
            reportDataSource1.Value = this.eSTADOCUENTACUOTAFIJABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.ReportCuotaFija.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1188, 512);
            this.reportViewer1.TabIndex = 0;
            // 
            // eSTADO_CUENTA_CUOTAFIJATableAdapter
            // 
            this.eSTADO_CUENTA_CUOTAFIJATableAdapter.ClearBeforeFill = true;
            // 
            // frmCuotaFija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1188, 566);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCuotaFija";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Cuota Fija";
            this.Load += new System.EventHandler(this.frmCuotaFija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOCUENTACUOTAFIJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuotaFija)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbClienteCuotaFija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource eSTADOCUENTACUOTAFIJABindingSource;
        private DataSetCuotaFija dataSetCuotaFija;
        private DataSetCuotaFijaTableAdapters.ESTADO_CUENTA_CUOTAFIJATableAdapter eSTADO_CUENTA_CUOTAFIJATableAdapter;
    }
}