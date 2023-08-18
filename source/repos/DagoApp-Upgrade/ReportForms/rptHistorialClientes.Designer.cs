namespace DagoApp_.ReportForms
{
    partial class rptHistorialClientes
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
            this.hISTORIALCLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetHC = new DagoApp_.DataSetHC();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hISTORIAL_CLIENTESTableAdapter = new DagoApp_.DataSetHCTableAdapters.HISTORIAL_CLIENTESTableAdapter();
            this.cbClienteRPT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIALCLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hISTORIALCLIENTESBindingSource
            // 
            this.hISTORIALCLIENTESBindingSource.DataMember = "HISTORIAL_CLIENTES";
            this.hISTORIALCLIENTESBindingSource.DataSource = this.dataSetHC;
            // 
            // dataSetHC
            // 
            this.dataSetHC.DataSetName = "DataSetHC";
            this.dataSetHC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer1.Panel1.Controls.Add(this.cbClienteRPT);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(996, 542);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÓDIGO CLIENTE:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(829, 8);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(155, 28);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Generar Reporte";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetHC";
            reportDataSource2.Value = this.hISTORIALCLIENTESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.ReportHistorialClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(996, 492);
            this.reportViewer1.TabIndex = 3;
            // 
            // hISTORIAL_CLIENTESTableAdapter
            // 
            this.hISTORIAL_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // cbClienteRPT
            // 
            this.cbClienteRPT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClienteRPT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClienteRPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbClienteRPT.FormattingEnabled = true;
            this.cbClienteRPT.Location = new System.Drawing.Point(151, 13);
            this.cbClienteRPT.Name = "cbClienteRPT";
            this.cbClienteRPT.Size = new System.Drawing.Size(203, 24);
            this.cbClienteRPT.TabIndex = 3;
            // 
            // rptHistorialClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 542);
            this.Controls.Add(this.splitContainer1);
            this.Name = "rptHistorialClientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Clientes";
            this.Load += new System.EventHandler(this.rptHistorialClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIALCLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHC)).EndInit();
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
        private System.Windows.Forms.BindingSource hISTORIALCLIENTESBindingSource;
        private DataSetHC dataSetHC;
        private DataSetHCTableAdapters.HISTORIAL_CLIENTESTableAdapter hISTORIAL_CLIENTESTableAdapter;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClienteRPT;
    }
}