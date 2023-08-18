namespace DagoApp_.Diseño_Reportes
{
    partial class rptEmpresas
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
            this.empresasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lstEmpresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstEmpresas = new DagoApp_.DataSets.LstEmpresas();
            this.empresasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lstEmpresasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new DagoApp_.DataSets.LstEmpresasTableAdapters.EmpresasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmpresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmpresasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empresasBindingSource1
            // 
            this.empresasBindingSource1.DataMember = "Empresas";
            this.empresasBindingSource1.DataSource = this.lstEmpresasBindingSource;
            // 
            // lstEmpresasBindingSource
            // 
            this.lstEmpresasBindingSource.DataSource = this.lstEmpresas;
            this.lstEmpresasBindingSource.Position = 0;
            // 
            // lstEmpresas
            // 
            this.lstEmpresas.DataSetName = "LstEmpresas";
            this.lstEmpresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasBindingSource2
            // 
            this.empresasBindingSource2.DataMember = "Empresas";
            this.empresasBindingSource2.DataSource = this.lstEmpresasBindingSource;
            // 
            // lstEmpresasBindingSource1
            // 
            this.lstEmpresasBindingSource1.DataSource = this.lstEmpresas;
            this.lstEmpresasBindingSource1.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEmpresas1";
            reportDataSource1.Value = this.empresasBindingSource1;
            reportDataSource2.Name = "ObjDataSetEmpresas1";
            reportDataSource2.Value = this.empresasBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.Reports.rptEmpresas1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(757, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmpresasBindingSource
            // 
            this.EmpresasBindingSource.DataMember = "Empresas";
            this.EmpresasBindingSource.DataSource = this.lstEmpresas;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // rptEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptEmpresas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Empresas";
            this.Load += new System.EventHandler(this.rptEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmpresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmpresasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lstEmpresasBindingSource;
        private DataSets.LstEmpresas lstEmpresas;
        private System.Windows.Forms.BindingSource lstEmpresasBindingSource1;
        private System.Windows.Forms.BindingSource EmpresasBindingSource;
        private System.Windows.Forms.BindingSource empresasBindingSource1;
        private DataSets.LstEmpresasTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.BindingSource empresasBindingSource2;
    }
}