namespace AdminEscuelasFut
{
    partial class PlayerPaysRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerPaysRegister));
            this.menPlayerPays = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameRPaymentPlayer = new System.Windows.Forms.TextBox();
            this.txtIDRPaymentPlayer = new System.Windows.Forms.TextBox();
            this.dgvRPaymentPlayer = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceiptNumberRPaymentPlayer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountRPaymentPlayer = new System.Windows.Forms.TextBox();
            this.chbxAnnuityRPaymentPlayer = new System.Windows.Forms.CheckBox();
            this.ckbxMonthlyRPaymentPlayer = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaInicMensualidad = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinMensualidad = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegisterRPaymentPlayer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menPlayerPays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRPaymentPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menPlayerPays
            // 
            this.menPlayerPays.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menPlayerPays.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menPlayerPays.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menPlayerPays.Location = new System.Drawing.Point(0, 0);
            this.menPlayerPays.Name = "menPlayerPays";
            this.menPlayerPays.Size = new System.Drawing.Size(694, 24);
            this.menPlayerPays.TabIndex = 5;
            this.menPlayerPays.Text = "menuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cédula";
            // 
            // txtNameRPaymentPlayer
            // 
            this.txtNameRPaymentPlayer.Location = new System.Drawing.Point(53, 22);
            this.txtNameRPaymentPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameRPaymentPlayer.Name = "txtNameRPaymentPlayer";
            this.txtNameRPaymentPlayer.Size = new System.Drawing.Size(284, 20);
            this.txtNameRPaymentPlayer.TabIndex = 51;
            // 
            // txtIDRPaymentPlayer
            // 
            this.txtIDRPaymentPlayer.Location = new System.Drawing.Point(394, 24);
            this.txtIDRPaymentPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDRPaymentPlayer.Name = "txtIDRPaymentPlayer";
            this.txtIDRPaymentPlayer.Size = new System.Drawing.Size(192, 20);
            this.txtIDRPaymentPlayer.TabIndex = 50;
            // 
            // dgvRPaymentPlayer
            // 
            this.dgvRPaymentPlayer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvRPaymentPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRPaymentPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRPaymentPlayer.Location = new System.Drawing.Point(0, 217);
            this.dgvRPaymentPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRPaymentPlayer.Name = "dgvRPaymentPlayer";
            this.dgvRPaymentPlayer.RowTemplate.Height = 24;
            this.dgvRPaymentPlayer.Size = new System.Drawing.Size(694, 179);
            this.dgvRPaymentPlayer.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "N°  Recibo";
            // 
            // txtReceiptNumberRPaymentPlayer
            // 
            this.txtReceiptNumberRPaymentPlayer.Location = new System.Drawing.Point(68, 55);
            this.txtReceiptNumberRPaymentPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiptNumberRPaymentPlayer.Name = "txtReceiptNumberRPaymentPlayer";
            this.txtReceiptNumberRPaymentPlayer.Size = new System.Drawing.Size(269, 20);
            this.txtReceiptNumberRPaymentPlayer.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Monto";
            // 
            // txtAmountRPaymentPlayer
            // 
            this.txtAmountRPaymentPlayer.Location = new System.Drawing.Point(394, 55);
            this.txtAmountRPaymentPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountRPaymentPlayer.Name = "txtAmountRPaymentPlayer";
            this.txtAmountRPaymentPlayer.Size = new System.Drawing.Size(274, 20);
            this.txtAmountRPaymentPlayer.TabIndex = 56;
            // 
            // chbxAnnuityRPaymentPlayer
            // 
            this.chbxAnnuityRPaymentPlayer.AutoSize = true;
            this.chbxAnnuityRPaymentPlayer.Location = new System.Drawing.Point(8, 122);
            this.chbxAnnuityRPaymentPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.chbxAnnuityRPaymentPlayer.Name = "chbxAnnuityRPaymentPlayer";
            this.chbxAnnuityRPaymentPlayer.Size = new System.Drawing.Size(71, 17);
            this.chbxAnnuityRPaymentPlayer.TabIndex = 58;
            this.chbxAnnuityRPaymentPlayer.Text = "Matrícula";
            this.chbxAnnuityRPaymentPlayer.UseVisualStyleBackColor = true;
            // 
            // ckbxMonthlyRPaymentPlayer
            // 
            this.ckbxMonthlyRPaymentPlayer.AutoSize = true;
            this.ckbxMonthlyRPaymentPlayer.Location = new System.Drawing.Point(8, 91);
            this.ckbxMonthlyRPaymentPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxMonthlyRPaymentPlayer.Name = "ckbxMonthlyRPaymentPlayer";
            this.ckbxMonthlyRPaymentPlayer.Size = new System.Drawing.Size(86, 17);
            this.ckbxMonthlyRPaymentPlayer.TabIndex = 59;
            this.ckbxMonthlyRPaymentPlayer.Text = "Mensualidad";
            this.ckbxMonthlyRPaymentPlayer.UseVisualStyleBackColor = true;
            this.ckbxMonthlyRPaymentPlayer.CheckedChanged += new System.EventHandler(this.ckbxMonthlyRPaymentPlayer_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "hasta";
            // 
            // dtpFechaInicMensualidad
            // 
            this.dtpFechaInicMensualidad.Enabled = false;
            this.dtpFechaInicMensualidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicMensualidad.Location = new System.Drawing.Point(97, 88);
            this.dtpFechaInicMensualidad.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicMensualidad.Name = "dtpFechaInicMensualidad";
            this.dtpFechaInicMensualidad.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaInicMensualidad.TabIndex = 63;
            // 
            // dtpFechaFinMensualidad
            // 
            this.dtpFechaFinMensualidad.Enabled = false;
            this.dtpFechaFinMensualidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinMensualidad.Location = new System.Drawing.Point(241, 88);
            this.dtpFechaFinMensualidad.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFinMensualidad.Name = "dtpFechaFinMensualidad";
            this.dtpFechaFinMensualidad.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFinMensualidad.TabIndex = 64;
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Enabled = false;
            this.dtpFechaMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMatricula.Location = new System.Drawing.Point(97, 119);
            this.dtpFechaMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaMatricula.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtpFechaMatricula);
            this.groupBox1.Controls.Add(this.dtpFechaFinMensualidad);
            this.groupBox1.Controls.Add(this.dtpFechaInicMensualidad);
            this.groupBox1.Controls.Add(this.txtIDRPaymentPlayer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNameRPaymentPlayer);
            this.groupBox1.Controls.Add(this.ckbxMonthlyRPaymentPlayer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chbxAnnuityRPaymentPlayer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReceiptNumberRPaymentPlayer);
            this.groupBox1.Controls.Add(this.txtAmountRPaymentPlayer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 148);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos para el registro del pago";
            // 
            // btnRegisterRPaymentPlayer
            // 
            this.btnRegisterRPaymentPlayer.BackColor = System.Drawing.Color.Gold;
            this.btnRegisterRPaymentPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterRPaymentPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegisterRPaymentPlayer.FlatAppearance.BorderSize = 0;
            this.btnRegisterRPaymentPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegisterRPaymentPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterRPaymentPlayer.Location = new System.Drawing.Point(588, 185);
            this.btnRegisterRPaymentPlayer.Name = "btnRegisterRPaymentPlayer";
            this.btnRegisterRPaymentPlayer.Size = new System.Drawing.Size(89, 23);
            this.btnRegisterRPaymentPlayer.TabIndex = 71;
            this.btnRegisterRPaymentPlayer.Text = "Registrar pago";
            this.btnRegisterRPaymentPlayer.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(604, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 20);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // PlayerPaysRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 396);
            this.Controls.Add(this.btnRegisterRPaymentPlayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRPaymentPlayer);
            this.Controls.Add(this.menPlayerPays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerPaysRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar pagos de jugadores";
            this.Load += new System.EventHandler(this.PlayerPaysRegister_Load);
            this.menPlayerPays.ResumeLayout(false);
            this.menPlayerPays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRPaymentPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menPlayerPays;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameRPaymentPlayer;
        private System.Windows.Forms.TextBox txtIDRPaymentPlayer;
        private System.Windows.Forms.DataGridView dgvRPaymentPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceiptNumberRPaymentPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmountRPaymentPlayer;
        private System.Windows.Forms.CheckBox chbxAnnuityRPaymentPlayer;
        private System.Windows.Forms.CheckBox ckbxMonthlyRPaymentPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaInicMensualidad;
        private System.Windows.Forms.DateTimePicker dtpFechaFinMensualidad;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegisterRPaymentPlayer;
    }
}