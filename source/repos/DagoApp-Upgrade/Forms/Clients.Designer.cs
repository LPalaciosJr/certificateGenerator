
namespace DagoApp_.Forms
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTipoClienteCuotaFija = new System.Windows.Forms.RadioButton();
            this.rbTipoClienteInteres = new System.Windows.Forms.RadioButton();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCobrador = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.dtpFechaVT = new System.Windows.Forms.DateTimePicker();
            this.txtCorreoE = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnGuardarClientes);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1945, 657);
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(395, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(517, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Historial";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTasaInteres);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbCobrador);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbEmpresa);
            this.groupBox1.Controls.Add(this.dtpFechaVT);
            this.groupBox1.Controls.Add(this.txtCorreoE);
            this.groupBox1.Controls.Add(this.txtPIN);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtNumTarjeta);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(4, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(653, 492);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbInactivo);
            this.groupBox3.Controls.Add(this.rbActivo);
            this.groupBox3.Location = new System.Drawing.Point(381, 334);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(255, 57);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESTADO CLIENTE";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.ForeColor = System.Drawing.Color.Black;
            this.rbInactivo.Location = new System.Drawing.Point(116, 26);
            this.rbInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(100, 21);
            this.rbInactivo.TabIndex = 21;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "INACTIVO";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.ForeColor = System.Drawing.Color.Black;
            this.rbActivo.Location = new System.Drawing.Point(3, 26);
            this.rbActivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(85, 21);
            this.rbActivo.TabIndex = 20;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "ACTIVO";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(12, 455);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ingrese un valor entero.";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtDNI.Location = new System.Drawing.Point(380, 284);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.MaxLength = 40;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(251, 26);
            this.txtDNI.TabIndex = 9;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 265);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Identidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTipoClienteCuotaFija);
            this.groupBox2.Controls.Add(this.rbTipoClienteInteres);
            this.groupBox2.Location = new System.Drawing.Point(381, 402);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(255, 57);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TIPO CLIENTE";
            // 
            // rbTipoClienteCuotaFija
            // 
            this.rbTipoClienteCuotaFija.AutoSize = true;
            this.rbTipoClienteCuotaFija.ForeColor = System.Drawing.Color.Black;
            this.rbTipoClienteCuotaFija.Location = new System.Drawing.Point(116, 26);
            this.rbTipoClienteCuotaFija.Margin = new System.Windows.Forms.Padding(4);
            this.rbTipoClienteCuotaFija.Name = "rbTipoClienteCuotaFija";
            this.rbTipoClienteCuotaFija.Size = new System.Drawing.Size(118, 21);
            this.rbTipoClienteCuotaFija.TabIndex = 21;
            this.rbTipoClienteCuotaFija.TabStop = true;
            this.rbTipoClienteCuotaFija.Text = "CUOTA FIJA";
            this.rbTipoClienteCuotaFija.UseVisualStyleBackColor = true;
            // 
            // rbTipoClienteInteres
            // 
            this.rbTipoClienteInteres.AutoSize = true;
            this.rbTipoClienteInteres.ForeColor = System.Drawing.Color.Black;
            this.rbTipoClienteInteres.Location = new System.Drawing.Point(3, 26);
            this.rbTipoClienteInteres.Margin = new System.Windows.Forms.Padding(4);
            this.rbTipoClienteInteres.Name = "rbTipoClienteInteres";
            this.rbTipoClienteInteres.Size = new System.Drawing.Size(95, 21);
            this.rbTipoClienteInteres.TabIndex = 20;
            this.rbTipoClienteInteres.TabStop = true;
            this.rbTipoClienteInteres.Text = "INTERÉS";
            this.rbTipoClienteInteres.UseVisualStyleBackColor = true;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTasaInteres.Location = new System.Drawing.Point(12, 423);
            this.txtTasaInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtTasaInteres.MaxLength = 40;
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(289, 26);
            this.txtTasaInteres.TabIndex = 10;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteres_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 404);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tasa Interés";
            // 
            // cbCobrador
            // 
            this.cbCobrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbCobrador.FormattingEnabled = true;
            this.cbCobrador.Location = new System.Drawing.Point(12, 354);
            this.cbCobrador.Margin = new System.Windows.Forms.Padding(4);
            this.cbCobrador.Name = "cbCobrador";
            this.cbCobrador.Size = new System.Drawing.Size(289, 28);
            this.cbCobrador.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 334);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cobrador";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.ItemHeight = 20;
            this.cbEmpresa.Location = new System.Drawing.Point(381, 205);
            this.cbEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(251, 28);
            this.cbEmpresa.TabIndex = 7;
            // 
            // dtpFechaVT
            // 
            this.dtpFechaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dtpFechaVT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVT.Location = new System.Drawing.Point(12, 284);
            this.dtpFechaVT.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaVT.Name = "dtpFechaVT";
            this.dtpFechaVT.Size = new System.Drawing.Size(289, 26);
            this.dtpFechaVT.TabIndex = 6;
            // 
            // txtCorreoE
            // 
            this.txtCorreoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtCorreoE.Location = new System.Drawing.Point(126, 207);
            this.txtCorreoE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoE.MaxLength = 40;
            this.txtCorreoE.Name = "txtCorreoE";
            this.txtCorreoE.Size = new System.Drawing.Size(177, 26);
            this.txtCorreoE.TabIndex = 5;
            // 
            // txtPIN
            // 
            this.txtPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtPIN.Location = new System.Drawing.Point(12, 207);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtPIN.MaxLength = 40;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(86, 26);
            this.txtPIN.TabIndex = 4;
            this.txtPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIN_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTel.Location = new System.Drawing.Point(381, 133);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.MaxLength = 40;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(251, 26);
            this.txtTel.TabIndex = 3;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtNumTarjeta.Location = new System.Drawing.Point(12, 133);
            this.txtNumTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumTarjeta.MaxLength = 40;
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(291, 26);
            this.txtNumTarjeta.TabIndex = 2;
            this.txtNumTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTarjeta_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(12, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(620, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Correo Electrónico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de Vencimiento Tarjeta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "PIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número de Tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Completo";
            // 
            // btnGuardarClientes
            // 
            this.btnGuardarClientes.BackColor = System.Drawing.Color.Blue;
            this.btnGuardarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGuardarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarClientes.Location = new System.Drawing.Point(272, 598);
            this.btnGuardarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarClientes.Name = "btnGuardarClientes";
            this.btnGuardarClientes.Size = new System.Drawing.Size(115, 38);
            this.btnGuardarClientes.TabIndex = 12;
            this.btnGuardarClientes.Text = "Guardar";
            this.btnGuardarClientes.UseVisualStyleBackColor = false;
            this.btnGuardarClientes.Click += new System.EventHandler(this.btnGuardarClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(188, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos de Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(149, 598);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 38);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gray;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(27, 598);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 38);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.txtBuscaCliente);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvClientes);
            this.splitContainer2.Size = new System.Drawing.Size(1438, 657);
            this.splitContainer2.SplitterDistance = 67;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(17, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Buscar Cliente:";
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBuscaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCliente.Location = new System.Drawing.Point(195, 27);
            this.txtBuscaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaCliente.MaxLength = 40;
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(1064, 23);
            this.txtBuscaCliente.TabIndex = 17;
            this.txtBuscaCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaCliente_KeyUp);
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1438, 585);
            this.dgvClientes.TabIndex = 18;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1945, 657);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clients";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.DateTimePicker dtpFechaVT;
        private System.Windows.Forms.TextBox txtCorreoE;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarClientes;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.ComboBox cbCobrador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTipoClienteCuotaFija;
        private System.Windows.Forms.RadioButton rbTipoClienteInteres;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
    }
}