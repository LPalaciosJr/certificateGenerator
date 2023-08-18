namespace facturacionApp.Reportes.Contenedores
{
    partial class Contenedor_Facturas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetFacturas = new facturacionApp.Reportes.Conjunto_de_Datos.DataSetFacturas();
            this.sPFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_FacturasTableAdapter = new facturacionApp.Reportes.Conjunto_de_Datos.DataSetFacturasTableAdapters.SP_FacturasTableAdapter();
            this.dataSetFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPFacturasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFacturas";
            reportDataSource1.Value = this.sPFacturasBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "facturacionApp.Reportes.Informes.Facturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSetFacturas
            // 
            this.dataSetFacturas.DataSetName = "DataSetFacturas";
            this.dataSetFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPFacturasBindingSource
            // 
            this.sPFacturasBindingSource.DataMember = "SP_Facturas";
            this.sPFacturasBindingSource.DataSource = this.dataSetFacturas;
            // 
            // sP_FacturasTableAdapter
            // 
            this.sP_FacturasTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetFacturasBindingSource
            // 
            this.dataSetFacturasBindingSource.DataSource = this.dataSetFacturas;
            this.dataSetFacturasBindingSource.Position = 0;
            // 
            // sPFacturasBindingSource1
            // 
            this.sPFacturasBindingSource1.DataMember = "SP_Facturas";
            this.sPFacturasBindingSource1.DataSource = this.dataSetFacturasBindingSource;
            // 
            // Contenedor_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Contenedor_Facturas";
            this.Text = "Contenedor_Facturas";
            this.Load += new System.EventHandler(this.Contenedor_Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Conjunto_de_Datos.DataSetFacturas dataSetFacturas;
        private System.Windows.Forms.BindingSource sPFacturasBindingSource;
        private Conjunto_de_Datos.DataSetFacturasTableAdapters.SP_FacturasTableAdapter sP_FacturasTableAdapter;
        private System.Windows.Forms.BindingSource dataSetFacturasBindingSource;
        private System.Windows.Forms.BindingSource sPFacturasBindingSource1;
    }
}