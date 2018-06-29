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
            this.menSchools = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdministrarInst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGestionarNiveles = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameSchoolM = new System.Windows.Forms.TextBox();
            this.txtTelephoneSchoolM = new System.Windows.Forms.TextBox();
            this.txtInstallationNameSchoolM = new System.Windows.Forms.TextBox();
            this.txtAddressSchoolM = new System.Windows.Forms.TextBox();
            this.txtPlaceSchoolM = new System.Windows.Forms.TextBox();
            this.btnDeleteSchoolM = new System.Windows.Forms.Button();
            this.btnUpdateSchoolM = new System.Windows.Forms.Button();
            this.btnConsultSchoolM = new System.Windows.Forms.Button();
            this.btnRegisterSchoolM = new System.Windows.Forms.Button();
            this.dgvSchoolM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchSchoolM = new System.Windows.Forms.Button();
            this.menSchools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolM)).BeginInit();
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
            this.menSchools.Size = new System.Drawing.Size(1061, 28);
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
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // heeraToolStripMenuItem
            // 
            this.heeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdministrarInst,
            this.menuItemGestionarNiveles});
            this.heeraToolStripMenuItem.Name = "heeraToolStripMenuItem";
            this.heeraToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.heeraToolStripMenuItem.Text = "Herramientas";
            // 
            // menuItemAdministrarInst
            // 
            this.menuItemAdministrarInst.Name = "menuItemAdministrarInst";
            this.menuItemAdministrarInst.Size = new System.Drawing.Size(250, 26);
            this.menuItemAdministrarInst.Text = "Administrar instalaciones";
            this.menuItemAdministrarInst.Click += new System.EventHandler(this.menuItemAdministrarInst_Click);
            // 
            // menuItemGestionarNiveles
            // 
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre instalación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Télefono";
            // 
            // txtNameSchoolM
            // 
            this.txtNameSchoolM.Location = new System.Drawing.Point(326, 81);
            this.txtNameSchoolM.Name = "txtNameSchoolM";
            this.txtNameSchoolM.Size = new System.Drawing.Size(375, 22);
            this.txtNameSchoolM.TabIndex = 11;
            // 
            // txtTelephoneSchoolM
            // 
            this.txtTelephoneSchoolM.Location = new System.Drawing.Point(326, 252);
            this.txtTelephoneSchoolM.Name = "txtTelephoneSchoolM";
            this.txtTelephoneSchoolM.Size = new System.Drawing.Size(375, 22);
            this.txtTelephoneSchoolM.TabIndex = 12;
            // 
            // txtInstallationNameSchoolM
            // 
            this.txtInstallationNameSchoolM.Location = new System.Drawing.Point(326, 209);
            this.txtInstallationNameSchoolM.Name = "txtInstallationNameSchoolM";
            this.txtInstallationNameSchoolM.Size = new System.Drawing.Size(375, 22);
            this.txtInstallationNameSchoolM.TabIndex = 13;
            // 
            // txtAddressSchoolM
            // 
            this.txtAddressSchoolM.Location = new System.Drawing.Point(326, 166);
            this.txtAddressSchoolM.Name = "txtAddressSchoolM";
            this.txtAddressSchoolM.Size = new System.Drawing.Size(375, 22);
            this.txtAddressSchoolM.TabIndex = 14;
            // 
            // txtPlaceSchoolM
            // 
            this.txtPlaceSchoolM.Location = new System.Drawing.Point(326, 123);
            this.txtPlaceSchoolM.Name = "txtPlaceSchoolM";
            this.txtPlaceSchoolM.Size = new System.Drawing.Size(375, 22);
            this.txtPlaceSchoolM.TabIndex = 15;
            // 
            // btnDeleteSchoolM
            // 
            this.btnDeleteSchoolM.Location = new System.Drawing.Point(788, 327);
            this.btnDeleteSchoolM.Name = "btnDeleteSchoolM";
            this.btnDeleteSchoolM.Size = new System.Drawing.Size(90, 34);
            this.btnDeleteSchoolM.TabIndex = 22;
            this.btnDeleteSchoolM.Text = "Borrar";
            this.btnDeleteSchoolM.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSchoolM
            // 
            this.btnUpdateSchoolM.Location = new System.Drawing.Point(598, 327);
            this.btnUpdateSchoolM.Name = "btnUpdateSchoolM";
            this.btnUpdateSchoolM.Size = new System.Drawing.Size(90, 34);
            this.btnUpdateSchoolM.TabIndex = 21;
            this.btnUpdateSchoolM.Text = "Actualizar";
            this.btnUpdateSchoolM.UseVisualStyleBackColor = true;
            // 
            // btnConsultSchoolM
            // 
            this.btnConsultSchoolM.Location = new System.Drawing.Point(386, 327);
            this.btnConsultSchoolM.Name = "btnConsultSchoolM";
            this.btnConsultSchoolM.Size = new System.Drawing.Size(90, 34);
            this.btnConsultSchoolM.TabIndex = 20;
            this.btnConsultSchoolM.Text = "Consultar";
            this.btnConsultSchoolM.UseVisualStyleBackColor = true;
            // 
            // btnRegisterSchoolM
            // 
            this.btnRegisterSchoolM.Location = new System.Drawing.Point(183, 327);
            this.btnRegisterSchoolM.Name = "btnRegisterSchoolM";
            this.btnRegisterSchoolM.Size = new System.Drawing.Size(90, 34);
            this.btnRegisterSchoolM.TabIndex = 19;
            this.btnRegisterSchoolM.Text = "Registrar";
            this.btnRegisterSchoolM.UseVisualStyleBackColor = true;
            // 
            // dgvSchoolM
            // 
            this.dgvSchoolM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolM.Location = new System.Drawing.Point(69, 381);
            this.dgvSchoolM.Name = "dgvSchoolM";
            this.dgvSchoolM.RowTemplate.Height = 24;
            this.dgvSchoolM.Size = new System.Drawing.Size(920, 240);
            this.dgvSchoolM.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lugar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre escuela";
            // 
            // btnSearchSchoolM
            // 
            this.btnSearchSchoolM.Location = new System.Drawing.Point(724, 200);
            this.btnSearchSchoolM.Name = "btnSearchSchoolM";
            this.btnSearchSchoolM.Size = new System.Drawing.Size(90, 34);
            this.btnSearchSchoolM.TabIndex = 27;
            this.btnSearchSchoolM.Text = "Buscar";
            this.btnSearchSchoolM.UseVisualStyleBackColor = true;
            // 
            // Schools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 633);
            this.Controls.Add(this.btnSearchSchoolM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteSchoolM);
            this.Controls.Add(this.btnUpdateSchoolM);
            this.Controls.Add(this.btnConsultSchoolM);
            this.Controls.Add(this.btnRegisterSchoolM);
            this.Controls.Add(this.dgvSchoolM);
            this.Controls.Add(this.txtPlaceSchoolM);
            this.Controls.Add(this.txtAddressSchoolM);
            this.Controls.Add(this.txtInstallationNameSchoolM);
            this.Controls.Add(this.txtTelephoneSchoolM);
            this.Controls.Add(this.txtNameSchoolM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menSchools);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Schools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Escuelas";
            this.Load += new System.EventHandler(this.Schools_Load);
            this.menSchools.ResumeLayout(false);
            this.menSchools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolM)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameSchoolM;
        private System.Windows.Forms.TextBox txtTelephoneSchoolM;
        private System.Windows.Forms.TextBox txtInstallationNameSchoolM;
        private System.Windows.Forms.TextBox txtAddressSchoolM;
        private System.Windows.Forms.TextBox txtPlaceSchoolM;
        private System.Windows.Forms.Button btnDeleteSchoolM;
        private System.Windows.Forms.Button btnUpdateSchoolM;
        private System.Windows.Forms.Button btnConsultSchoolM;
        private System.Windows.Forms.Button btnRegisterSchoolM;
        private System.Windows.Forms.DataGridView dgvSchoolM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchSchoolM;
    }
}