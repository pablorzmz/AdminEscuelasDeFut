﻿namespace AdminEscuelasFut
{
    partial class SchoolLevels
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menSchoolLeves = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSchoolName = new System.Windows.Forms.ComboBox();
            this.cmbSchoolLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvSchoolLevels = new System.Windows.Forms.DataGridView();
            this.menSchoolLeves.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolLevels)).BeginInit();
            this.SuspendLayout();
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // menSchoolLeves
            // 
            this.menSchoolLeves.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menSchoolLeves.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menSchoolLeves.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menSchoolLeves.Location = new System.Drawing.Point(0, 0);
            this.menSchoolLeves.Name = "menSchoolLeves";
            this.menSchoolLeves.Size = new System.Drawing.Size(508, 24);
            this.menSchoolLeves.TabIndex = 4;
            this.menSchoolLeves.Text = "menuPrincipal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSchoolName);
            this.groupBox1.Controls.Add(this.cmbSchoolLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 80);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Niveles por escuela";
            // 
            // cmbSchoolName
            // 
            this.cmbSchoolName.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbSchoolName.FormattingEnabled = true;
            this.cmbSchoolName.Location = new System.Drawing.Point(102, 25);
            this.cmbSchoolName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSchoolName.Name = "cmbSchoolName";
            this.cmbSchoolName.Size = new System.Drawing.Size(375, 21);
            this.cmbSchoolName.TabIndex = 39;
            // 
            // cmbSchoolLevel
            // 
            this.cmbSchoolLevel.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbSchoolLevel.FormattingEnabled = true;
            this.cmbSchoolLevel.Location = new System.Drawing.Point(102, 51);
            this.cmbSchoolLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSchoolLevel.Name = "cmbSchoolLevel";
            this.cmbSchoolLevel.Size = new System.Drawing.Size(374, 21);
            this.cmbSchoolLevel.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nivel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre escuela";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(329, 117);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 55;
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
            this.btnRegistrar.Location = new System.Drawing.Point(167, 117);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 52;
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
            this.btnActualizar.Location = new System.Drawing.Point(248, 117);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 53;
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
            this.btnBorrar.Location = new System.Drawing.Point(415, 117);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 54;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvSchoolLevels
            // 
            this.dgvSchoolLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolLevels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSchoolLevels.Location = new System.Drawing.Point(0, 158);
            this.dgvSchoolLevels.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSchoolLevels.Name = "dgvSchoolLevels";
            this.dgvSchoolLevels.RowTemplate.Height = 24;
            this.dgvSchoolLevels.Size = new System.Drawing.Size(508, 190);
            this.dgvSchoolLevels.TabIndex = 56;
            this.dgvSchoolLevels.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSchoolLevels_CellMouseDoubleClick);
            // 
            // SchoolLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 348);
            this.Controls.Add(this.dgvSchoolLevels);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menSchoolLeves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SchoolLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionar niveles de escuelas";
            this.Load += new System.EventHandler(this.SchoolLevels_Load);
            this.menSchoolLeves.ResumeLayout(false);
            this.menSchoolLeves.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolLevels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menSchoolLeves;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSchoolName;
        private System.Windows.Forms.ComboBox cmbSchoolLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dgvSchoolLevels;
    }
}