﻿namespace AdminEscuelasFut
{
    partial class Levels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Levels));
            this.menLevels = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNivel = new System.Windows.Forms.Label();
            this.lbEdadFin = new System.Windows.Forms.Label();
            this.lbEdadInicio = new System.Windows.Forms.Label();
            this.dgtvLevelInfo = new System.Windows.Forms.DataGridView();
            this.txbEdadFin = new System.Windows.Forms.TextBox();
            this.txbEdadInicio = new System.Windows.Forms.TextBox();
            this.txbNivel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.menLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvLevelInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menLevels
            // 
            this.menLevels.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menLevels.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menLevels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menLevels.Location = new System.Drawing.Point(0, 0);
            this.menLevels.Name = "menLevels";
            this.menLevels.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menLevels.Size = new System.Drawing.Size(751, 28);
            this.menLevels.TabIndex = 4;
            this.menLevels.Text = "menuPays";
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
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Location = new System.Drawing.Point(13, 36);
            this.lbNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(39, 17);
            this.lbNivel.TabIndex = 5;
            this.lbNivel.Text = "Nivel";
            // 
            // lbEdadFin
            // 
            this.lbEdadFin.AutoSize = true;
            this.lbEdadFin.Location = new System.Drawing.Point(13, 123);
            this.lbEdadFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEdadFin.Name = "lbEdadFin";
            this.lbEdadFin.Size = new System.Drawing.Size(64, 17);
            this.lbEdadFin.TabIndex = 6;
            this.lbEdadFin.Text = "Edad Fin";
            // 
            // lbEdadInicio
            // 
            this.lbEdadInicio.AutoSize = true;
            this.lbEdadInicio.Location = new System.Drawing.Point(13, 81);
            this.lbEdadInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEdadInicio.Name = "lbEdadInicio";
            this.lbEdadInicio.Size = new System.Drawing.Size(81, 17);
            this.lbEdadInicio.TabIndex = 7;
            this.lbEdadInicio.Text = "Edad  Inicio";
            // 
            // dgtvLevelInfo
            // 
            this.dgtvLevelInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtvLevelInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvLevelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgtvLevelInfo.Location = new System.Drawing.Point(0, 274);
            this.dgtvLevelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgtvLevelInfo.Name = "dgtvLevelInfo";
            this.dgtvLevelInfo.Size = new System.Drawing.Size(751, 359);
            this.dgtvLevelInfo.TabIndex = 9;
            this.dgtvLevelInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgtvLevelInfo_CellMouseDoubleClick);
            // 
            // txbEdadFin
            // 
            this.txbEdadFin.Location = new System.Drawing.Point(105, 119);
            this.txbEdadFin.Margin = new System.Windows.Forms.Padding(4);
            this.txbEdadFin.MaxLength = 2;
            this.txbEdadFin.Name = "txbEdadFin";
            this.txbEdadFin.Size = new System.Drawing.Size(611, 22);
            this.txbEdadFin.TabIndex = 3;
            this.txbEdadFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEdadFin_KeyPress);
            // 
            // txbEdadInicio
            // 
            this.txbEdadInicio.Location = new System.Drawing.Point(105, 76);
            this.txbEdadInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txbEdadInicio.MaxLength = 2;
            this.txbEdadInicio.Name = "txbEdadInicio";
            this.txbEdadInicio.Size = new System.Drawing.Size(611, 22);
            this.txbEdadInicio.TabIndex = 2;
            this.txbEdadInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEdadInicio_KeyPress);
            // 
            // txbNivel
            // 
            this.txbNivel.Location = new System.Drawing.Point(105, 32);
            this.txbNivel.Margin = new System.Windows.Forms.Padding(4);
            this.txbNivel.MaxLength = 2;
            this.txbNivel.Name = "txbNivel";
            this.txbNivel.Size = new System.Drawing.Size(611, 22);
            this.txbNivel.TabIndex = 1;
            this.txbNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNivel_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbEdadInicio);
            this.groupBox1.Controls.Add(this.lbNivel);
            this.groupBox1.Controls.Add(this.lbEdadFin);
            this.groupBox1.Controls.Add(this.lbEdadInicio);
            this.groupBox1.Controls.Add(this.txbEdadFin);
            this.groupBox1.Controls.Add(this.txbNivel);
            this.groupBox1.Location = new System.Drawing.Point(17, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(734, 166);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de los niveles";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(320, 228);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 34);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar cambios";
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
            this.btnConsultar.Image = global::AdminEscuelasFut.Properties.Resources.icons_find;
            this.btnConsultar.Location = new System.Drawing.Point(592, 220);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(60, 50);
            this.btnConsultar.TabIndex = 6;
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
            this.btnRegistrar.Image = global::AdminEscuelasFut.Properties.Resources.icons_insert;
            this.btnRegistrar.Location = new System.Drawing.Point(454, 220);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(60, 50);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnActualizar.Image = global::AdminEscuelasFut.Properties.Resources.icons_edit;
            this.btnActualizar.Location = new System.Drawing.Point(522, 223);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(60, 50);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Image = global::AdminEscuelasFut.Properties.Resources.icons_delete;
            this.btnBorrar.Location = new System.Drawing.Point(660, 220);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(60, 50);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDescartar
            // 
            this.btnDescartar.BackColor = System.Drawing.Color.White;
            this.btnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescartar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDescartar.FlatAppearance.BorderSize = 0;
            this.btnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.Location = new System.Drawing.Point(155, 228);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(141, 34);
            this.btnDescartar.TabIndex = 20;
            this.btnDescartar.Text = "Descartar cambios";
            this.btnDescartar.UseVisualStyleBackColor = false;
            this.btnDescartar.Visible = false;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 633);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgtvLevelInfo);
            this.Controls.Add(this.menLevels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Niveles";
            this.Load += new System.EventHandler(this.Levels_Load);
            this.menLevels.ResumeLayout(false);
            this.menLevels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvLevelInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menLevels;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Label lbEdadFin;
        private System.Windows.Forms.Label lbEdadInicio;
        private System.Windows.Forms.DataGridView dgtvLevelInfo;
        private System.Windows.Forms.TextBox txbEdadFin;
        private System.Windows.Forms.TextBox txbEdadInicio;
        private System.Windows.Forms.TextBox txbNivel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDescartar;
    }
}