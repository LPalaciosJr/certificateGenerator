namespace DagoApp_
{
    partial class frmCxCG
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
            this.cOBROPORCOBRADOR15NALGENERALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCxCG = new DagoApp_.DataSetCxCG();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbTipoModalidad = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetCxCGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOBRO_POR_COBRADOR_15NAL_GENERALTableAdapter = new DagoApp_.DataSetCxCGTableAdapters.COBRO_POR_COBRADOR_15NAL_GENERALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cOBROPORCOBRADOR15NALGENERALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxCGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cOBROPORCOBRADOR15NALGENERALBindingSource
            // 
            this.cOBROPORCOBRADOR15NALGENERALBindingSource.DataMember = "COBRO_POR_COBRADOR_15NAL_GENERAL";
            this.cOBROPORCOBRADOR15NALGENERALBindingSource.DataSource = this.dataSetCxCG;
            // 
            // dataSetCxCG
            // 
            this.dataSetCxCG.DataSetName = "DataSetCxCG";
            this.dataSetCxCG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer1.Panel1.Controls.Add(this.cbTipoModalidad);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 599);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "MODALIDAD PAGO:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(914, 8);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(174, 25);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "GENERAR REPORTE";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbTipoModalidad
            // 
            this.cbTipoModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbTipoModalidad.FormattingEnabled = true;
            this.cbTipoModalidad.Location = new System.Drawing.Point(174, 9);
            this.cbTipoModalidad.Name = "cbTipoModalidad";
            this.cbTipoModalidad.Size = new System.Drawing.Size(325, 24);
            this.cbTipoModalidad.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCxCG";
            reportDataSource1.Value = this.cOBROPORCOBRADOR15NALGENERALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.ReportCXCG.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1100, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetCxCGBindingSource
            // 
            this.dataSetCxCGBindingSource.DataSource = this.dataSetCxCG;
            this.dataSetCxCGBindingSource.Position = 0;
            // 
            // cOBRO_POR_COBRADOR_15NAL_GENERALTableAdapter
            // 
            this.cOBRO_POR_COBRADOR_15NAL_GENERALTableAdapter.ClearBeforeFill = true;
            // 
            // frmCxCG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 599);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCxCG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro Por Cobrador General";
            this.Load += new System.EventHandler(this.frmCxCG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOBROPORCOBRADOR15NALGENERALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxCG)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCxCGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbTipoModalidad;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cOBROPORCOBRADOR15NALGENERALBindingSource;
        private DataSetCxCG dataSetCxCG;
        private System.Windows.Forms.BindingSource dataSetCxCGBindingSource;
        private DataSetCxCGTableAdapters.COBRO_POR_COBRADOR_15NAL_GENERALTableAdapter cOBRO_POR_COBRADOR_15NAL_GENERALTableAdapter;
    }
}