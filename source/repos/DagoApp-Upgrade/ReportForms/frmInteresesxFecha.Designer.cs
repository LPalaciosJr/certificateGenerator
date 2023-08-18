namespace DagoApp_
{
    partial class frmInteresesxFecha
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
            this.iNTERESESRECIBIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInteresesxFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInteresesxFecha = new DagoApp_.DataSets.DataSetInteresesxFecha();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iNTERESESRECIBIDOSTableAdapter = new DagoApp_.DataSets.DataSetInteresesxFechaTableAdapters.INTERESESRECIBIDOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERESESRECIBIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInteresesxFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInteresesxFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iNTERESESRECIBIDOSBindingSource
            // 
            this.iNTERESESRECIBIDOSBindingSource.DataMember = "INTERESESRECIBIDOS";
            this.iNTERESESRECIBIDOSBindingSource.DataSource = this.dataSetInteresesxFechaBindingSource;
            // 
            // dataSetInteresesxFechaBindingSource
            // 
            this.dataSetInteresesxFechaBindingSource.DataSource = this.dataSetInteresesxFecha;
            this.dataSetInteresesxFechaBindingSource.Position = 0;
            // 
            // dataSetInteresesxFecha
            // 
            this.dataSetInteresesxFecha.DataSetName = "DataSetInteresesxFecha";
            this.dataSetInteresesxFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer1.Panel1.Controls.Add(this.dtpHasta);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDesde);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 603);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 2;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(501, 21);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(287, 23);
            this.dtpHasta.TabIndex = 9;
            this.dtpHasta.Value = new System.DateTime(2022, 7, 25, 23, 59, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(430, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "HASTA:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(818, 20);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(193, 24);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "GENERAR REPORTE";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(83, 21);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(287, 23);
            this.dtpDesde.TabIndex = 6;
            this.dtpDesde.Value = new System.DateTime(2022, 7, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESDE:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetInteresesxFecha";
            reportDataSource1.Value = this.iNTERESESRECIBIDOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.InteresesxFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1032, 540);
            this.reportViewer1.TabIndex = 1;
            // 
            // iNTERESESRECIBIDOSTableAdapter
            // 
            this.iNTERESESRECIBIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmInteresesxFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmInteresesxFecha";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intereses Recibidos";
            this.Load += new System.EventHandler(this.frmInteresesxFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNTERESESRECIBIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInteresesxFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInteresesxFecha)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetInteresesxFechaBindingSource;
        private DataSets.DataSetInteresesxFecha dataSetInteresesxFecha;
        private System.Windows.Forms.BindingSource iNTERESESRECIBIDOSBindingSource;
        private DataSets.DataSetInteresesxFechaTableAdapters.INTERESESRECIBIDOSTableAdapter iNTERESESRECIBIDOSTableAdapter;
    }
}