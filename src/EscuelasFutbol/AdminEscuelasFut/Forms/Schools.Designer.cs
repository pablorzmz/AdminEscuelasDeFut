namespace AdminEscuelasFut
{
    partial class Schools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schools));
            this.menSchools = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdministrarInst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGestionarNiveles = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameSchoolM = new System.Windows.Forms.TextBox();
            this.txtTelephoneSchoolM = new System.Windows.Forms.TextBox();
            this.txtPlaceSchoolM = new System.Windows.Forms.TextBox();
            this.dgvSchoolM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDirrInstalacion = new System.Windows.Forms.ComboBox();
            this.txtTelephoneSchoo2M = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menSchools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menSchools
            // 
            this.menSchools.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menSchools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.heeraToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menSchools.Location = new System.Drawing.Point(0, 0);
            this.menSchools.Name = "menSchools";
            this.menSchools.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menSchools.Size = new System.Drawing.Size(676, 28);
            this.menSchools.TabIndex = 5;
            this.menSchools.Text = "menuPays";
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
            // heeraToolStripMenuItem
            // 
            this.heeraToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.heeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdministrarInst,
            this.menuItemGestionarNiveles});
            this.heeraToolStripMenuItem.Name = "heeraToolStripMenuItem";
            this.heeraToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.heeraToolStripMenuItem.Text = "Herramientas";
            // 
            // menuItemAdministrarInst
            // 
            this.menuItemAdministrarInst.BackColor = System.Drawing.Color.AliceBlue;
            this.menuItemAdministrarInst.Name = "menuItemAdministrarInst";
            this.menuItemAdministrarInst.Size = new System.Drawing.Size(250, 26);
            this.menuItemAdministrarInst.Text = "Administrar instalaciones";
            this.menuItemAdministrarInst.Click += new System.EventHandler(this.menuItemAdministrarInst_Click);
            // 
            // menuItemGestionarNiveles
            // 
            this.menuItemGestionarNiveles.BackColor = System.Drawing.Color.AliceBlue;
            this.menuItemGestionarNiveles.Name = "menuItemGestionarNiveles";
            this.menuItemGestionarNiveles.Size = new System.Drawing.Size(250, 26);
            this.menuItemGestionarNiveles.Text = "Gestionar niveles";
            this.menuItemGestionarNiveles.Click += new System.EventHandler(this.menuItemGestionarNiveles_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Télefono1";
            // 
            // txtNameSchoolM
            // 
            this.txtNameSchoolM.Location = new System.Drawing.Point(97, 32);
            this.txtNameSchoolM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameSchoolM.MaxLength = 30;
            this.txtNameSchoolM.Name = "txtNameSchoolM";
            this.txtNameSchoolM.Size = new System.Drawing.Size(539, 22);
            this.txtNameSchoolM.TabIndex = 11;
            this.txtNameSchoolM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameSchoolM_KeyPress);
            // 
            // txtTelephoneSchoolM
            // 
            this.txtTelephoneSchoolM.Location = new System.Drawing.Point(97, 129);
            this.txtTelephoneSchoolM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephoneSchoolM.MaxLength = 8;
            this.txtTelephoneSchoolM.Name = "txtTelephoneSchoolM";
            this.txtTelephoneSchoolM.Size = new System.Drawing.Size(539, 22);
            this.txtTelephoneSchoolM.TabIndex = 12;
            this.txtTelephoneSchoolM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephoneSchoolM_KeyPress);
            // 
            // txtPlaceSchoolM
            // 
            this.txtPlaceSchoolM.Location = new System.Drawing.Point(97, 65);
            this.txtPlaceSchoolM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlaceSchoolM.MaxLength = 30;
            this.txtPlaceSchoolM.Name = "txtPlaceSchoolM";
            this.txtPlaceSchoolM.Size = new System.Drawing.Size(539, 22);
            this.txtPlaceSchoolM.TabIndex = 15;
            this.txtPlaceSchoolM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaceSchoolM_KeyPress);
            // 
            // dgvSchoolM
            // 
            this.dgvSchoolM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchoolM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSchoolM.Location = new System.Drawing.Point(0, 306);
            this.dgvSchoolM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSchoolM.Name = "dgvSchoolM";
            this.dgvSchoolM.RowTemplate.Height = 24;
            this.dgvSchoolM.Size = new System.Drawing.Size(676, 327);
            this.dgvSchoolM.TabIndex = 18;
            this.dgvSchoolM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchoolM_CellDoubleClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lugar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDirrInstalacion);
            this.groupBox1.Controls.Add(this.txtTelephoneSchoo2M);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNameSchoolM);
            this.groupBox1.Controls.Add(this.txtTelephoneSchoolM);
            this.groupBox1.Controls.Add(this.txtPlaceSchoolM);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(649, 202);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de las escuelas";
            // 
            // cmbDirrInstalacion
            // 
            this.cmbDirrInstalacion.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbDirrInstalacion.FormattingEnabled = true;
            this.cmbDirrInstalacion.Location = new System.Drawing.Point(97, 95);
            this.cmbDirrInstalacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDirrInstalacion.Name = "cmbDirrInstalacion";
            this.cmbDirrInstalacion.Size = new System.Drawing.Size(539, 24);
            this.cmbDirrInstalacion.TabIndex = 40;
            // 
            // txtTelephoneSchoo2M
            // 
            this.txtTelephoneSchoo2M.Location = new System.Drawing.Point(97, 164);
            this.txtTelephoneSchoo2M.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephoneSchoo2M.MaxLength = 8;
            this.txtTelephoneSchoo2M.Name = "txtTelephoneSchoo2M";
            this.txtTelephoneSchoo2M.Size = new System.Drawing.Size(539, 22);
            this.txtTelephoneSchoo2M.TabIndex = 29;
            this.txtTelephoneSchoo2M.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConsultar_MouseClick);
            this.txtTelephoneSchoo2M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephoneSchoo2M_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Télefono2";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(448, 255);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 32;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConsultar_MouseClick);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gold;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(232, 255);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(340, 255);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(565, 255);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 31;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDescartar
            // 
            this.btnDescartar.BackColor = System.Drawing.Color.Gold;
            this.btnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescartar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDescartar.FlatAppearance.BorderSize = 0;
            this.btnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.Location = new System.Drawing.Point(39, 240);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(144, 28);
            this.btnDescartar.TabIndex = 33;
            this.btnDescartar.Text = "Descartar cambios";
            this.btnDescartar.UseVisualStyleBackColor = false;
            this.btnDescartar.Visible = false;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gold;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(3, 276);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(164, 28);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Schools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 633);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSchoolM);
            this.Controls.Add(this.menSchools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Schools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Escuelas";
            this.Load += new System.EventHandler(this.Schools_Load);
            this.menSchools.ResumeLayout(false);
            this.menSchools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menSchools;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemGestionarNiveles;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdministrarInst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameSchoolM;
        private System.Windows.Forms.TextBox txtTelephoneSchoolM;
        private System.Windows.Forms.TextBox txtPlaceSchoolM;
        private System.Windows.Forms.DataGridView dgvSchoolM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelephoneSchoo2M;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbDirrInstalacion;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnGuardar;
    }
}