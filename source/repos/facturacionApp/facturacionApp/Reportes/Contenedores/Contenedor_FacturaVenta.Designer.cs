namespace facturacionApp.Reportes.Contenedores
{
    partial class Contenedor_FacturaVenta
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
            this.facturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFacturaVenta = new facturacionApp.Reportes.Conjunto_de_Datos.DataSetFacturaVenta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturaVentaTableAdapter = new facturacionApp.Reportes.Conjunto_de_Datos.DataSetFacturaVentaTableAdapters.FacturaVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.facturaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // facturaVentaBindingSource
            // 
            this.facturaVentaBindingSource.DataMember = "FacturaVenta";
            this.facturaVentaBindingSource.DataSource = this.dataSetFacturaVenta;
            // 
            // dataSetFacturaVenta
            // 
            this.dataSetFacturaVenta.DataSetName = "DataSetFacturaVenta";
            this.dataSetFacturaVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFacturaVenta";
            reportDataSource1.Value = this.facturaVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "facturacionApp.Reportes.Informes.FacturaVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1695, 679);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturaVentaTableAdapter
            // 
            this.facturaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // Contenedor_FacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 679);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Contenedor_FacturaVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contenedor_FacturaVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Contenedor_FacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource facturaVentaBindingSource;
        private Conjunto_de_Datos.DataSetFacturaVenta dataSetFacturaVenta;
        private Conjunto_de_Datos.DataSetFacturaVentaTableAdapters.FacturaVentaTableAdapter facturaVentaTableAdapter;
    }
}