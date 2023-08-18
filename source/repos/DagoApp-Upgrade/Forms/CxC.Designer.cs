namespace DagoApp_
{
    partial class CxC
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cOBROPORCOBRADORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCxC = new DagoApp_.DataSetCxC();
            this.cOBROPORCOBRADORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCxCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOBRO_POR_COBRADORTableAdapter = new DagoApp_.DataSetCxCTableAdapters.COBRO_POR_COBRADORTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbCobradorRPT = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOBROPORCOBRADORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBROPORCOBRADORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cOBROPORCOBRADORBindingSource1
            // 
            this.cOBROPORCOBRADORBindingSource1.DataMember = "COBRO_POR_COBRADOR";
            this.cOBROPORCOBRADORBindingSource1.DataSource = this.dataSetCxC;
            // 
            // dataSetCxC
            // 
            this.dataSetCxC.DataSetName = "DataSetCxC";
            this.dataSetCxC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOBROPORCOBRADORBindingSource
            // 
            this.cOBROPORCOBRADORBindingSource.DataMember = "COBRO_POR_COBRADOR";
            this.cOBROPORCOBRADORBindingSource.DataSource = this.dataSetCxCBindingSource;
            // 
            // dataSetCxCBindingSource
            // 
            this.dataSetCxCBindingSource.DataSource = this.dataSetCxC;
            this.dataSetCxCBindingSource.Position = 0;
            // 
            // cOBRO_POR_COBRADORTableAdapter
            // 
            this.cOBRO_POR_COBRADORTableAdapter.ClearBeforeFill = true;
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
            this.splitContainer1.Size = new System.Drawing.Size(1098, 541);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSetCxC";
            reportDataSource5.Value = this.cOBROPORCOBRADORBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.ReportCxC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1098, 495);
            this.reportViewer1.TabIndex = 1;
            // 
            // cbCobradorRPT
            // 
            this.cbCobradorRPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbCobradorRPT.FormattingEnabled = true;
            this.cbCobradorRPT.Location = new System.Drawing.Point(118, 6);
            this.cbCobradorRPT.Name = "cbCobradorRPT";
            this.cbCobradorRPT.Size = new System.Drawing.Size(325, 24);
            this.cbCobradorRPT.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(912, 9);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(174, 25);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "GENERAR REPORTE";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "COBRADOR:";
            // 
            // CxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 541);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CxC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros Quincenales por Cobrador";
            this.Load += new System.EventHandler(this.CxC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOBROPORCOBRADORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBROPORCOBRADORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxCBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetCxC dataSetCxC;
        private System.Windows.Forms.BindingSource dataSetCxCBindingSource;
        private System.Windows.Forms.BindingSource cOBROPORCOBRADORBindingSource;
        private DataSetCxCTableAdapters.COBRO_POR_COBRADORTableAdapter cOBRO_POR_COBRADORTableAdapter;
        private System.Windows.Forms.BindingSource cOBROPORCOBRADORBindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbCobradorRPT;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
    }
}