namespace DagoApp_
{
    partial class frmCxCSemanal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetCxC = new DagoApp_.DataSetCxC();
            this.cOBROPORCOBRADORSEMANALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOBRO_POR_COBRADOR_SEMANALTableAdapter = new DagoApp_.DataSetCxCTableAdapters.COBRO_POR_COBRADOR_SEMANALTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbCobradorRPT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBROPORCOBRADORSEMANALBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel1.Controls.Add(this.cbCobradorRPT);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1096, 564);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetCxCS";
            reportDataSource3.Value = this.cOBROPORCOBRADORSEMANALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.ReportCxCSemanal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1096, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetCxC
            // 
            this.dataSetCxC.DataSetName = "DataSetCxC";
            this.dataSetCxC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOBROPORCOBRADORSEMANALBindingSource
            // 
            this.cOBROPORCOBRADORSEMANALBindingSource.DataMember = "COBRO_POR_COBRADOR_SEMANAL";
            this.cOBROPORCOBRADORSEMANALBindingSource.DataSource = this.dataSetCxC;
            // 
            // cOBRO_POR_COBRADOR_SEMANALTableAdapter
            // 
            this.cOBRO_POR_COBRADOR_SEMANALTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "COBRADOR:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(910, 11);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(174, 25);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "GENERAR REPORTE";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbCobradorRPT
            // 
            this.cbCobradorRPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbCobradorRPT.FormattingEnabled = true;
            this.cbCobradorRPT.Location = new System.Drawing.Point(119, 12);
            this.cbCobradorRPT.Name = "cbCobradorRPT";
            this.cbCobradorRPT.Size = new System.Drawing.Size(325, 24);
            this.cbCobradorRPT.TabIndex = 3;
            // 
            // frmCxCSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 564);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCxCSemanal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros Semanales por Cobrador";
            this.Load += new System.EventHandler(this.frmCxCSemanal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBROPORCOBRADORSEMANALBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cOBROPORCOBRADORSEMANALBindingSource;
        private DataSetCxC dataSetCxC;
        private DataSetCxCTableAdapters.COBRO_POR_COBRADOR_SEMANALTableAdapter cOBRO_POR_COBRADOR_SEMANALTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbCobradorRPT;
    }
}