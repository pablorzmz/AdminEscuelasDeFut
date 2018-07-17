namespace AdminEscuelasFut
{
    partial class HeadQuarters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadQuarters));
            this.menAdminInstalaciones = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAdministerInstallation = new System.Windows.Forms.DataGridView();
            this.txtAddressAdministerInstallation = new System.Windows.Forms.TextBox();
            this.txtTelephoneAdministerInstallation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.menAdminInstalaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministerInstallation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menAdminInstalaciones
            // 
            this.menAdminInstalaciones.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menAdminInstalaciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menAdminInstalaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menAdminInstalaciones.Location = new System.Drawing.Point(0, 0);
            this.menAdminInstalaciones.Name = "menAdminInstalaciones";
            this.menAdminInstalaciones.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menAdminInstalaciones.Size = new System.Drawing.Size(631, 28);
            this.menAdminInstalaciones.TabIndex = 5;
            this.menAdminInstalaciones.Text = "menuPrincipal";
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // dgvAdministerInstallation
            // 
            this.dgvAdministerInstallation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdministerInstallation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministerInstallation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdministerInstallation.Location = new System.Drawing.Point(0, 213);
            this.dgvAdministerInstallation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdministerInstallation.Name = "dgvAdministerInstallation";
            this.dgvAdministerInstallation.RowTemplate.Height = 24;
            this.dgvAdministerInstallation.Size = new System.Drawing.Size(631, 215);
            this.dgvAdministerInstallation.TabIndex = 7;
            this.dgvAdministerInstallation.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAdministerInstallation_CellMouseDoubleClick);
            // 
            // txtAddressAdministerInstallation
            // 
            this.txtAddressAdministerInstallation.Location = new System.Drawing.Point(99, 27);
            this.txtAddressAdministerInstallation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressAdministerInstallation.MaxLength = 30;
            this.txtAddressAdministerInstallation.Name = "txtAddressAdministerInstallation";
            this.txtAddressAdministerInstallation.Size = new System.Drawing.Size(511, 22);
            this.txtAddressAdministerInstallation.TabIndex = 1;
            this.txtAddressAdministerInstallation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddressAdministerInstallation_KeyPress);
            // 
            // txtTelephoneAdministerInstallation
            // 
            this.txtTelephoneAdministerInstallation.Location = new System.Drawing.Point(99, 63);
            this.txtTelephoneAdministerInstallation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephoneAdministerInstallation.MaxLength = 8;
            this.txtTelephoneAdministerInstallation.Name = "txtTelephoneAdministerInstallation";
            this.txtTelephoneAdministerInstallation.Size = new System.Drawing.Size(511, 22);
            this.txtTelephoneAdministerInstallation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Dirrección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Teléfono";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelephoneAdministerInstallation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddressAdministerInstallation);
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(627, 107);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de las intalaciones";
            // 
            // btnDescartar
            // 
            this.btnDescartar.BackColor = System.Drawing.Color.Transparent;
            this.btnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescartar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDescartar.FlatAppearance.BorderSize = 0;
            this.btnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.Image = global::AdminEscuelasFut.Properties.Resources.icons_discard;
            this.btnDescartar.Location = new System.Drawing.Point(380, 173);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(111, 34);
            this.btnDescartar.TabIndex = 49;
            this.btnDescartar.UseVisualStyleBackColor = false;
            this.btnDescartar.Visible = false;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::AdminEscuelasFut.Properties.Resources.icon_save;
            this.btnGuardar.Location = new System.Drawing.Point(261, 173);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 34);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = global::AdminEscuelasFut.Properties.Resources.icon_find;
            this.btnConsultar.Location = new System.Drawing.Point(380, 173);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 34);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Image = global::AdminEscuelasFut.Properties.Resources.icon_add;
            this.btnRegistrar.Location = new System.Drawing.Point(142, 173);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 34);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = global::AdminEscuelasFut.Properties.Resources.icon_edit;
            this.btnActualizar.Location = new System.Drawing.Point(261, 173);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 34);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Image = global::AdminEscuelasFut.Properties.Resources.icon_delete;
            this.btnBorrar.Location = new System.Drawing.Point(499, 173);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 34);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // HeadQuarters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 428);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAdministerInstallation);
            this.Controls.Add(this.menAdminInstalaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HeadQuarters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar instalaciones";
            this.Load += new System.EventHandler(this.HeadQuarters_Load);
            this.menAdminInstalaciones.ResumeLayout(false);
            this.menAdminInstalaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministerInstallation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menAdminInstalaciones;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAdministerInstallation;
        private System.Windows.Forms.TextBox txtAddressAdministerInstallation;
        private System.Windows.Forms.TextBox txtTelephoneAdministerInstallation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDescartar;
    }
}