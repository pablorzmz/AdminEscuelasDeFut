namespace AdminEscuelasFut
{
    partial class Pays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pays));
            this.menPays = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCPagosGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvPagosJugador = new System.Windows.Forms.DataGridView();
            this.btnRegisterRPaymentPlayer = new System.Windows.Forms.Button();
            this.goBoxInfoPagosJugador = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinMensualidad = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicMensualidad = new System.Windows.Forms.DateTimePicker();
            this.txtIDRPaymentPlayer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameRPaymentPlayer = new System.Windows.Forms.TextBox();
            this.ckbxMonthlyRPaymentPlayer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbxAnnuityRPaymentPlayer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceiptNumberRPaymentPlayer = new System.Windows.Forms.TextBox();
            this.txtAmountRPaymentPlayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menPays.SuspendLayout();
            this.tabCPagosGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosJugador)).BeginInit();
            this.goBoxInfoPagosJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // menPays
            // 
            this.menPays.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menPays.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menPays.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.modificarPagoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menPays.Location = new System.Drawing.Point(0, 0);
            this.menPays.Name = "menPays";
            this.menPays.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menPays.Size = new System.Drawing.Size(1072, 28);
            this.menPays.TabIndex = 3;
            this.menPays.Text = "menuPays";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // modificarPagoToolStripMenuItem
            // 
            this.modificarPagoToolStripMenuItem.Name = "modificarPagoToolStripMenuItem";
            this.modificarPagoToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.modificarPagoToolStripMenuItem.Text = "Modificar pagos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tabCPagosGeneral
            // 
            this.tabCPagosGeneral.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabCPagosGeneral.Controls.Add(this.tabPage1);
            this.tabCPagosGeneral.Controls.Add(this.tabPage2);
            this.tabCPagosGeneral.Controls.Add(this.tabPage3);
            this.tabCPagosGeneral.Controls.Add(this.tabPage4);
            this.tabCPagosGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCPagosGeneral.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCPagosGeneral.ItemSize = new System.Drawing.Size(121, 150);
            this.tabCPagosGeneral.Location = new System.Drawing.Point(0, 28);
            this.tabCPagosGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.tabCPagosGeneral.Multiline = true;
            this.tabCPagosGeneral.Name = "tabCPagosGeneral";
            this.tabCPagosGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCPagosGeneral.SelectedIndex = 0;
            this.tabCPagosGeneral.Size = new System.Drawing.Size(1072, 605);
            this.tabCPagosGeneral.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCPagosGeneral.TabIndex = 4;
            this.tabCPagosGeneral.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabCPagosGeneral_DrawItem);
            this.tabCPagosGeneral.SelectedIndexChanged += new System.EventHandler(this.tabCPagosGeneral_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.dgvPagosJugador);
            this.tabPage1.Controls.Add(this.btnRegisterRPaymentPlayer);
            this.tabPage1.Controls.Add(this.goBoxInfoPagosJugador);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(914, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pagos jugadores";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(727, 234);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 28);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar pago";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // dgvPagosJugador
            // 
            this.dgvPagosJugador.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPagosJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosJugador.Location = new System.Drawing.Point(9, 268);
            this.dgvPagosJugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPagosJugador.Name = "dgvPagosJugador";
            this.dgvPagosJugador.RowTemplate.Height = 24;
            this.dgvPagosJugador.Size = new System.Drawing.Size(849, 396);
            this.dgvPagosJugador.TabIndex = 73;
            // 
            // btnRegisterRPaymentPlayer
            // 
            this.btnRegisterRPaymentPlayer.BackColor = System.Drawing.Color.Gold;
            this.btnRegisterRPaymentPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterRPaymentPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegisterRPaymentPlayer.FlatAppearance.BorderSize = 0;
            this.btnRegisterRPaymentPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegisterRPaymentPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterRPaymentPlayer.Location = new System.Drawing.Point(600, 234);
            this.btnRegisterRPaymentPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterRPaymentPlayer.Name = "btnRegisterRPaymentPlayer";
            this.btnRegisterRPaymentPlayer.Size = new System.Drawing.Size(119, 28);
            this.btnRegisterRPaymentPlayer.TabIndex = 11;
            this.btnRegisterRPaymentPlayer.Text = "Registrar pago";
            this.btnRegisterRPaymentPlayer.UseVisualStyleBackColor = false;
            // 
            // goBoxInfoPagosJugador
            // 
            this.goBoxInfoPagosJugador.Controls.Add(this.btnBuscar);
            this.goBoxInfoPagosJugador.Controls.Add(this.dtpFechaMatricula);
            this.goBoxInfoPagosJugador.Controls.Add(this.dtpFechaFinMensualidad);
            this.goBoxInfoPagosJugador.Controls.Add(this.dtpFechaInicMensualidad);
            this.goBoxInfoPagosJugador.Controls.Add(this.txtIDRPaymentPlayer);
            this.goBoxInfoPagosJugador.Controls.Add(this.label5);
            this.goBoxInfoPagosJugador.Controls.Add(this.txtNameRPaymentPlayer);
            this.goBoxInfoPagosJugador.Controls.Add(this.ckbxMonthlyRPaymentPlayer);
            this.goBoxInfoPagosJugador.Controls.Add(this.label1);
            this.goBoxInfoPagosJugador.Controls.Add(this.chbxAnnuityRPaymentPlayer);
            this.goBoxInfoPagosJugador.Controls.Add(this.label2);
            this.goBoxInfoPagosJugador.Controls.Add(this.label4);
            this.goBoxInfoPagosJugador.Controls.Add(this.txtReceiptNumberRPaymentPlayer);
            this.goBoxInfoPagosJugador.Controls.Add(this.txtAmountRPaymentPlayer);
            this.goBoxInfoPagosJugador.Controls.Add(this.label3);
            this.goBoxInfoPagosJugador.Location = new System.Drawing.Point(9, 18);
            this.goBoxInfoPagosJugador.Margin = new System.Windows.Forms.Padding(4);
            this.goBoxInfoPagosJugador.Name = "goBoxInfoPagosJugador";
            this.goBoxInfoPagosJugador.Padding = new System.Windows.Forms.Padding(4);
            this.goBoxInfoPagosJugador.Size = new System.Drawing.Size(841, 206);
            this.goBoxInfoPagosJugador.TabIndex = 67;
            this.goBoxInfoPagosJugador.TabStop = false;
            this.goBoxInfoPagosJugador.Text = "Datos del pago";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(700, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(135, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Consultar cédula";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Enabled = false;
            this.dtpFechaMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMatricula.Location = new System.Drawing.Point(129, 146);
            this.dtpFechaMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(123, 22);
            this.dtpFechaMatricula.TabIndex = 10;
            // 
            // dtpFechaFinMensualidad
            // 
            this.dtpFechaFinMensualidad.Enabled = false;
            this.dtpFechaFinMensualidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinMensualidad.Location = new System.Drawing.Point(321, 108);
            this.dtpFechaFinMensualidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFinMensualidad.Name = "dtpFechaFinMensualidad";
            this.dtpFechaFinMensualidad.Size = new System.Drawing.Size(127, 22);
            this.dtpFechaFinMensualidad.TabIndex = 8;
            // 
            // dtpFechaInicMensualidad
            // 
            this.dtpFechaInicMensualidad.Enabled = false;
            this.dtpFechaInicMensualidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicMensualidad.Location = new System.Drawing.Point(129, 108);
            this.dtpFechaInicMensualidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicMensualidad.Name = "dtpFechaInicMensualidad";
            this.dtpFechaInicMensualidad.Size = new System.Drawing.Size(123, 22);
            this.dtpFechaInicMensualidad.TabIndex = 7;
            // 
            // txtIDRPaymentPlayer
            // 
            this.txtIDRPaymentPlayer.Location = new System.Drawing.Point(525, 30);
            this.txtIDRPaymentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDRPaymentPlayer.MaxLength = 9;
            this.txtIDRPaymentPlayer.Name = "txtIDRPaymentPlayer";
            this.txtIDRPaymentPlayer.Size = new System.Drawing.Size(167, 22);
            this.txtIDRPaymentPlayer.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "hasta";
            // 
            // txtNameRPaymentPlayer
            // 
            this.txtNameRPaymentPlayer.Location = new System.Drawing.Point(91, 27);
            this.txtNameRPaymentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameRPaymentPlayer.Name = "txtNameRPaymentPlayer";
            this.txtNameRPaymentPlayer.Size = new System.Drawing.Size(357, 22);
            this.txtNameRPaymentPlayer.TabIndex = 1;
            this.txtNameRPaymentPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameRPaymentPlayer_KeyPress);
            // 
            // ckbxMonthlyRPaymentPlayer
            // 
            this.ckbxMonthlyRPaymentPlayer.AutoSize = true;
            this.ckbxMonthlyRPaymentPlayer.Location = new System.Drawing.Point(11, 112);
            this.ckbxMonthlyRPaymentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbxMonthlyRPaymentPlayer.Name = "ckbxMonthlyRPaymentPlayer";
            this.ckbxMonthlyRPaymentPlayer.Size = new System.Drawing.Size(110, 21);
            this.ckbxMonthlyRPaymentPlayer.TabIndex = 6;
            this.ckbxMonthlyRPaymentPlayer.Text = "Mensualidad";
            this.ckbxMonthlyRPaymentPlayer.UseVisualStyleBackColor = true;
            this.ckbxMonthlyRPaymentPlayer.CheckedChanged += new System.EventHandler(this.ckbxMonthlyRPaymentPlayer_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cédula";
            // 
            // chbxAnnuityRPaymentPlayer
            // 
            this.chbxAnnuityRPaymentPlayer.AutoSize = true;
            this.chbxAnnuityRPaymentPlayer.Location = new System.Drawing.Point(11, 150);
            this.chbxAnnuityRPaymentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxAnnuityRPaymentPlayer.Name = "chbxAnnuityRPaymentPlayer";
            this.chbxAnnuityRPaymentPlayer.Size = new System.Drawing.Size(87, 21);
            this.chbxAnnuityRPaymentPlayer.TabIndex = 9;
            this.chbxAnnuityRPaymentPlayer.Text = "Matrícula";
            this.chbxAnnuityRPaymentPlayer.UseVisualStyleBackColor = true;
            this.chbxAnnuityRPaymentPlayer.CheckedChanged += new System.EventHandler(this.chbxAnnuityRPaymentPlayer_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Monto";
            // 
            // txtReceiptNumberRPaymentPlayer
            // 
            this.txtReceiptNumberRPaymentPlayer.Location = new System.Drawing.Point(91, 68);
            this.txtReceiptNumberRPaymentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReceiptNumberRPaymentPlayer.MaxLength = 5;
            this.txtReceiptNumberRPaymentPlayer.Name = "txtReceiptNumberRPaymentPlayer";
            this.txtReceiptNumberRPaymentPlayer.Size = new System.Drawing.Size(357, 22);
            this.txtReceiptNumberRPaymentPlayer.TabIndex = 4;
            this.txtReceiptNumberRPaymentPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceiptNumberRPaymentPlayer_KeyPress);
            // 
            // txtAmountRPaymentPlayer
            // 
            this.txtAmountRPaymentPlayer.Location = new System.Drawing.Point(525, 68);
            this.txtAmountRPaymentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmountRPaymentPlayer.Name = "txtAmountRPaymentPlayer";
            this.txtAmountRPaymentPlayer.Size = new System.Drawing.Size(167, 22);
            this.txtAmountRPaymentPlayer.TabIndex = 5;
            this.txtAmountRPaymentPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountRPaymentPlayer_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "N°  Recibo";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(914, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pagos instalaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(914, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagos entrenadores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(914, 597);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pagos equipamientos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Pays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 633);
            this.Controls.Add(this.tabCPagosGeneral);
            this.Controls.Add(this.menPays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Pagos";
            this.Load += new System.EventHandler(this.Pays_Load);
            this.menPays.ResumeLayout(false);
            this.menPays.PerformLayout();
            this.tabCPagosGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosJugador)).EndInit();
            this.goBoxInfoPagosJugador.ResumeLayout(false);
            this.goBoxInfoPagosJugador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menPays;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPagoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCPagosGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox goBoxInfoPagosJugador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.DateTimePicker dtpFechaFinMensualidad;
        private System.Windows.Forms.DateTimePicker dtpFechaInicMensualidad;
        private System.Windows.Forms.TextBox txtIDRPaymentPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameRPaymentPlayer;
        private System.Windows.Forms.CheckBox ckbxMonthlyRPaymentPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbxAnnuityRPaymentPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceiptNumberRPaymentPlayer;
        private System.Windows.Forms.TextBox txtAmountRPaymentPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegisterRPaymentPlayer;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvPagosJugador;
    }
}