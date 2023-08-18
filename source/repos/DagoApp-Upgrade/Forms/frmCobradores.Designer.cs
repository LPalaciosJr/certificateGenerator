namespace DagoApp_.Forms
{
    partial class frmCobradores
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
            this.btnEliminarCobrador = new System.Windows.Forms.Button();
            this.btnEditarCobrador = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvCobradores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobradores)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminarCobrador);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditarCobrador);
            this.splitContainer1.Panel1.Controls.Add(this.btnNuevo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCobradores);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnEliminarCobrador
            // 
            this.btnEliminarCobrador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarCobrador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCobrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCobrador.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCobrador.Location = new System.Drawing.Point(624, 15);
            this.btnEliminarCobrador.Name = "btnEliminarCobrador";
            this.btnEliminarCobrador.Size = new System.Drawing.Size(164, 38);
            this.btnEliminarCobrador.TabIndex = 6;
            this.btnEliminarCobrador.Text = "Eliminar";
            this.btnEliminarCobrador.UseVisualStyleBackColor = false;
            this.btnEliminarCobrador.Click += new System.EventHandler(this.btnEliminarCobrador_Click);
            // 
            // btnEditarCobrador
            // 
            this.btnEditarCobrador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCobrador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCobrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCobrador.ForeColor = System.Drawing.Color.White;
            this.btnEditarCobrador.Location = new System.Drawing.Point(309, 15);
            this.btnEditarCobrador.Name = "btnEditarCobrador";
            this.btnEditarCobrador.Size = new System.Drawing.Size(184, 38);
            this.btnEditarCobrador.TabIndex = 5;
            this.btnEditarCobrador.Text = "Editar";
            this.btnEditarCobrador.UseVisualStyleBackColor = false;
            this.btnEditarCobrador.Click += new System.EventHandler(this.btnEditarCobrador_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(12, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(163, 38);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvCobradores
            // 
            this.dgvCobradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobradores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCobradores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCobradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCobradores.Location = new System.Drawing.Point(0, 0);
            this.dgvCobradores.MultiSelect = false;
            this.dgvCobradores.Name = "dgvCobradores";
            this.dgvCobradores.ReadOnly = true;
            this.dgvCobradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobradores.Size = new System.Drawing.Size(800, 378);
            this.dgvCobradores.TabIndex = 0;
            this.dgvCobradores.TabStop = false;
            // 
            // frmCobradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCobradores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobradores";
            this.Load += new System.EventHandler(this.frmCobradores_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCobradores;
        private System.Windows.Forms.Button btnEliminarCobrador;
        private System.Windows.Forms.Button btnEditarCobrador;
        private System.Windows.Forms.Button btnNuevo;
    }
}