namespace facturacionApp.Reportes.Contenedores
{
    partial class Contenedor_OrdenCompra
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
            this.dataSetOrdenesCompra = new facturacionApp.Reportes.Conjunto_de_Datos.DataSetOrdenesCompra();
            this.ordenesCompraImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesCompraImpresionTableAdapter = new facturacionApp.Reportes.Conjunto_de_Datos.DataSetOrdenesCompraTableAdapters.OrdenesCompraImpresionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrdenesCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesCompraImpresionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetOrdenesCompra";
            reportDataSource1.Value = this.ordenesCompraImpresionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "facturacionApp.Reportes.Informes.OrdenesCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1709, 772);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetOrdenesCompra
            // 
            this.dataSetOrdenesCompra.DataSetName = "DataSetOrdenesCompra";
            this.dataSetOrdenesCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenesCompraImpresionBindingSource
            // 
            this.ordenesCompraImpresionBindingSource.DataMember = "OrdenesCompraImpresion";
            this.ordenesCompraImpresionBindingSource.DataSource = this.dataSetOrdenesCompra;
            // 
            // ordenesCompraImpresionTableAdapter
            // 
            this.ordenesCompraImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // Contenedor_OrdenCompra
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 772);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Contenedor_OrdenCompra";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contenedor_OrdenCompra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Contenedor_OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrdenesCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesCompraImpresionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ordenesCompraImpresionBindingSource;
        private Conjunto_de_Datos.DataSetOrdenesCompra dataSetOrdenesCompra;
        private Conjunto_de_Datos.DataSetOrdenesCompraTableAdapters.OrdenesCompraImpresionTableAdapter ordenesCompraImpresionTableAdapter;
    }
}