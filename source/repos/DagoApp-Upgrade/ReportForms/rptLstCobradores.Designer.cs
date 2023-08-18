namespace DagoApp_.ReportForms
{
    partial class rptLstCobradores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cobradoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCobradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCobrador = new DagoApp_.DataSetCobrador();
            this.CobradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetCobradorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cobradoresTableAdapter = new DagoApp_.DataSetCobradorTableAdapters.CobradoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCobradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCobrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCobradorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cobradoresBindingSource1
            // 
            this.cobradoresBindingSource1.DataMember = "Cobradores";
            this.cobradoresBindingSource1.DataSource = this.dataSetCobradorBindingSource;
            // 
            // dataSetCobradorBindingSource
            // 
            this.dataSetCobradorBindingSource.DataSource = this.dataSetCobrador;
            this.dataSetCobradorBindingSource.Position = 0;
            // 
            // dataSetCobrador
            // 
            this.dataSetCobrador.DataSetName = "DataSetCobrador";
            this.dataSetCobrador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CobradoresBindingSource
            // 
            this.CobradoresBindingSource.DataMember = "Cobradores";
            this.CobradoresBindingSource.DataSource = this.dataSetCobrador;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCobrador";
            reportDataSource1.Value = this.cobradoresBindingSource1;
            reportDataSource2.Name = "ObjDataSetCobrador";
            reportDataSource2.Value = this.CobradoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetCobradorBindingSource1
            // 
            this.dataSetCobradorBindingSource1.DataSource = this.dataSetCobrador;
            this.dataSetCobradorBindingSource1.Position = 0;
            // 
            // cobradoresTableAdapter
            // 
            this.cobradoresTableAdapter.ClearBeforeFill = true;
            // 
            // rptLstCobradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptLstCobradores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Cobradores";
            this.Load += new System.EventHandler(this.rptLstCobradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCobradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCobrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCobradorBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetCobradorBindingSource;
        private DataSetCobrador dataSetCobrador;
        private System.Windows.Forms.BindingSource dataSetCobradorBindingSource1;
        private System.Windows.Forms.BindingSource CobradoresBindingSource;
        private System.Windows.Forms.BindingSource cobradoresBindingSource1;
        private DataSetCobradorTableAdapters.CobradoresTableAdapter cobradoresTableAdapter;
    }
}