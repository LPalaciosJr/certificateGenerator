namespace DagoApp_
{
    partial class frmIngresos
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
            this.iNGRESOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIngresos = new DagoApp_.DataSets.DataSetIngresos();
            this.iNGRESOS1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.btnenviar = new System.Windows.Forms.Button();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iNGRESOS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtIngresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNGRESOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNGRESOSTableAdapter = new DagoApp_.DataSets.DataSetIngresosTableAdapters.INGRESOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOS1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIngresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iNGRESOSBindingSource1
            // 
            this.iNGRESOSBindingSource1.DataMember = "INGRESOS";
            this.iNGRESOSBindingSource1.DataSource = this.dataSetIngresos;
            // 
            // dataSetIngresos
            // 
            this.dataSetIngresos.DataSetName = "DataSetIngresos";
            this.dataSetIngresos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtphasta);
            this.splitContainer1.Panel1.Controls.Add(this.btnenviar);
            this.splitContainer1.Panel1.Controls.Add(this.dtpdesde);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 755);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(310, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // dtphasta
            // 
            this.dtphasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dtphasta.Location = new System.Drawing.Point(371, 17);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(200, 20);
            this.dtphasta.TabIndex = 4;
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.Blue;
            this.btnenviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnenviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnenviar.Location = new System.Drawing.Point(601, 14);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(139, 25);
            this.btnenviar.TabIndex = 2;
            this.btnenviar.Text = "Generar Reporte";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // dtpdesde
            // 
            this.dtpdesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dtpdesde.Location = new System.Drawing.Point(77, 17);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(200, 20);
            this.dtpdesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetIngresos";
            reportDataSource1.Value = this.iNGRESOSBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DagoApp_.rptIngresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1050, 696);
            this.reportViewer1.TabIndex = 0;
            // 
            // iNGRESOSTableAdapter
            // 
            this.iNGRESOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1050, 755);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Ingresados";
            this.Load += new System.EventHandler(this.frmIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOS1BindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIngresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGRESOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource iNGRESOSBindingSource;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource iNGRESOS1BindingSource;
        private System.Windows.Forms.BindingSource dtIngresosBindingSource;
        private System.Windows.Forms.BindingSource iNGRESOS1BindingSource1;
        private System.Windows.Forms.BindingSource iNGRESOSBindingSource1;
        private DataSets.DataSetIngresos dataSetIngresos;
        private DataSets.DataSetIngresosTableAdapters.INGRESOSTableAdapter iNGRESOSTableAdapter;
    }
}