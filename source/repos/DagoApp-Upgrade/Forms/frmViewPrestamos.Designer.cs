namespace DagoApp_.Forms
{
    partial class frmViewPrestamos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTasaInt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblModoPrestamo = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbonoInteres = new System.Windows.Forms.Button();
            this.btnADS = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbtipoOperacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtQtyITransaction = new System.Windows.Forms.TextBox();
            this.dptHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetallePrestamo = new System.Windows.Forms.DataGridView();
            this.btnImprimirHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTasaInt);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.lblModoPrestamo);
            this.splitContainer1.Panel1.Controls.Add(this.lblTipoCliente);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalActual);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetallePrestamo);
            this.splitContainer1.Size = new System.Drawing.Size(1663, 633);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblTasaInt
            // 
            this.lblTasaInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTasaInt.ForeColor = System.Drawing.Color.Red;
            this.lblTasaInt.Location = new System.Drawing.Point(476, 400);
            this.lblTasaInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTasaInt.Name = "lblTasaInt";
            this.lblTasaInt.Size = new System.Drawing.Size(124, 28);
            this.lblTasaInt.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(316, 400);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tasa Interés:";
            // 
            // lblModoPrestamo
            // 
            this.lblModoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblModoPrestamo.ForeColor = System.Drawing.Color.Red;
            this.lblModoPrestamo.Location = new System.Drawing.Point(240, 442);
            this.lblModoPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModoPrestamo.Name = "lblModoPrestamo";
            this.lblModoPrestamo.Size = new System.Drawing.Size(352, 28);
            this.lblModoPrestamo.TabIndex = 10;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoCliente.ForeColor = System.Drawing.Color.Red;
            this.lblTipoCliente.Location = new System.Drawing.Point(153, 400);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(119, 28);
            this.lblTipoCliente.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 442);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Modalidad Préstamo:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo Cliente:";
            // 
            // lblTotalActual
            // 
            this.lblTotalActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalActual.Location = new System.Drawing.Point(5, 470);
            this.lblTotalActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalActual.Name = "lblTotalActual";
            this.lblTotalActual.Size = new System.Drawing.Size(595, 151);
            this.lblTotalActual.TabIndex = 6;
            this.lblTotalActual.Text = "Total";
            this.lblTotalActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detalle de Préstamo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimirHistorial);
            this.groupBox1.Controls.Add(this.btnAbonoInteres);
            this.groupBox1.Controls.Add(this.btnADS);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.cbtipoOperacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtQtyITransaction);
            this.groupBox1.Controls.Add(this.dptHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(4, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(596, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Préstamo";
            // 
            // btnAbonoInteres
            // 
            this.btnAbonoInteres.BackColor = System.Drawing.Color.Blue;
            this.btnAbonoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonoInteres.Location = new System.Drawing.Point(208, 207);
            this.btnAbonoInteres.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbonoInteres.Name = "btnAbonoInteres";
            this.btnAbonoInteres.Size = new System.Drawing.Size(182, 46);
            this.btnAbonoInteres.TabIndex = 18;
            this.btnAbonoInteres.Text = "Abono a Interes";
            this.btnAbonoInteres.UseVisualStyleBackColor = false;
            this.btnAbonoInteres.Click += new System.EventHandler(this.btnAbonoInteres_Click);
            // 
            // btnADS
            // 
            this.btnADS.BackColor = System.Drawing.Color.Green;
            this.btnADS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADS.Location = new System.Drawing.Point(404, 207);
            this.btnADS.Margin = new System.Windows.Forms.Padding(4);
            this.btnADS.Name = "btnADS";
            this.btnADS.Size = new System.Drawing.Size(182, 46);
            this.btnADS.TabIndex = 17;
            this.btnADS.Text = "A D S";
            this.btnADS.UseVisualStyleBackColor = false;
            this.btnADS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(12, 287);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 46);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Blue;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(208, 288);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(182, 46);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbtipoOperacion
            // 
            this.cbtipoOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbtipoOperacion.FormattingEnabled = true;
            this.cbtipoOperacion.Location = new System.Drawing.Point(321, 65);
            this.cbtipoOperacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbtipoOperacion.Name = "cbtipoOperacion";
            this.cbtipoOperacion.Size = new System.Drawing.Size(265, 28);
            this.cbtipoOperacion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Operación";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Blue;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(404, 287);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 46);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Datos";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtQtyITransaction
            // 
            this.txtQtyITransaction.Location = new System.Drawing.Point(12, 65);
            this.txtQtyITransaction.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtyITransaction.Name = "txtQtyITransaction";
            this.txtQtyITransaction.Size = new System.Drawing.Size(255, 26);
            this.txtQtyITransaction.TabIndex = 4;
            this.txtQtyITransaction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyITransaction_KeyPress);
            // 
            // dptHasta
            // 
            this.dptHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptHasta.Location = new System.Drawing.Point(321, 146);
            this.dptHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dptHasta.Name = "dptHasta";
            this.dptHasta.Size = new System.Drawing.Size(267, 26);
            this.dptHasta.TabIndex = 4;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(12, 146);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(256, 26);
            this.dtpDesde.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad";
            // 
            // dgvDetallePrestamo
            // 
            this.dgvDetallePrestamo.AllowUserToAddRows = false;
            this.dgvDetallePrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetallePrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetallePrestamo.Location = new System.Drawing.Point(0, 0);
            this.dgvDetallePrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetallePrestamo.MultiSelect = false;
            this.dgvDetallePrestamo.Name = "dgvDetallePrestamo";
            this.dgvDetallePrestamo.ReadOnly = true;
            this.dgvDetallePrestamo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetallePrestamo.RowHeadersWidth = 51;
            this.dgvDetallePrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallePrestamo.Size = new System.Drawing.Size(1207, 633);
            this.dgvDetallePrestamo.TabIndex = 0;
            // 
            // btnImprimirHistorial
            // 
            this.btnImprimirHistorial.BackColor = System.Drawing.Color.Blue;
            this.btnImprimirHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirHistorial.Location = new System.Drawing.Point(10, 207);
            this.btnImprimirHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimirHistorial.Name = "btnImprimirHistorial";
            this.btnImprimirHistorial.Size = new System.Drawing.Size(182, 46);
            this.btnImprimirHistorial.TabIndex = 19;
            this.btnImprimirHistorial.Text = "Imprimir historial";
            this.btnImprimirHistorial.UseVisualStyleBackColor = false;
            this.btnImprimirHistorial.Click += new System.EventHandler(this.btnImprimirHistorial_Click);
            // 
            // frmViewPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1663, 633);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewPrestamos";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Préstamo";
            this.Load += new System.EventHandler(this.frmViewPrestamos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDetallePrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalActual;
        private System.Windows.Forms.Label lblModoPrestamo;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.ComboBox cbtipoOperacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtQtyITransaction;
        private System.Windows.Forms.DateTimePicker dptHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnADS;
        private System.Windows.Forms.Label lblTasaInt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAbonoInteres;
        private System.Windows.Forms.Button btnImprimirHistorial;
    }
}