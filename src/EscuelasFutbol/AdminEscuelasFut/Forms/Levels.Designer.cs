namespace AdminEscuelasFut
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
            this.lbNombreEscuela = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbEdadFin = new System.Windows.Forms.TextBox();
            this.txbEdadInicio = new System.Windows.Forms.TextBox();
            this.txbNivel = new System.Windows.Forms.TextBox();
            this.txbNombreEscuela = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menLevels.Size = new System.Drawing.Size(796, 24);
            this.menLevels.TabIndex = 4;
            this.menLevels.Text = "menuPays";
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
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
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
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Location = new System.Drawing.Point(201, 126);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(31, 13);
            this.lbNivel.TabIndex = 5;
            this.lbNivel.Text = "Nivel";
            // 
            // lbEdadFin
            // 
            this.lbEdadFin.AutoSize = true;
            this.lbEdadFin.Location = new System.Drawing.Point(369, 179);
            this.lbEdadFin.Name = "lbEdadFin";
            this.lbEdadFin.Size = new System.Drawing.Size(49, 13);
            this.lbEdadFin.TabIndex = 6;
            this.lbEdadFin.Text = "Edad Fin";
            // 
            // lbEdadInicio
            // 
            this.lbEdadInicio.AutoSize = true;
            this.lbEdadInicio.Location = new System.Drawing.Point(169, 179);
            this.lbEdadInicio.Name = "lbEdadInicio";
            this.lbEdadInicio.Size = new System.Drawing.Size(63, 13);
            this.lbEdadInicio.TabIndex = 7;
            this.lbEdadInicio.Text = "Edad  Inicio";
            // 
            // lbNombreEscuela
            // 
            this.lbNombreEscuela.AutoSize = true;
            this.lbNombreEscuela.Location = new System.Drawing.Point(132, 74);
            this.lbNombreEscuela.Name = "lbNombreEscuela";
            this.lbNombreEscuela.Size = new System.Drawing.Size(100, 13);
            this.lbNombreEscuela.TabIndex = 8;
            this.lbNombreEscuela.Text = "Nombre de Escuela";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 218);
            this.dataGridView1.TabIndex = 9;
            // 
            // txbEdadFin
            // 
            this.txbEdadFin.Location = new System.Drawing.Point(424, 172);
            this.txbEdadFin.Name = "txbEdadFin";
            this.txbEdadFin.Size = new System.Drawing.Size(100, 20);
            this.txbEdadFin.TabIndex = 10;
            // 
            // txbEdadInicio
            // 
            this.txbEdadInicio.Location = new System.Drawing.Point(238, 172);
            this.txbEdadInicio.Name = "txbEdadInicio";
            this.txbEdadInicio.Size = new System.Drawing.Size(100, 20);
            this.txbEdadInicio.TabIndex = 11;
            // 
            // txbNivel
            // 
            this.txbNivel.Location = new System.Drawing.Point(238, 119);
            this.txbNivel.Name = "txbNivel";
            this.txbNivel.Size = new System.Drawing.Size(100, 20);
            this.txbNivel.TabIndex = 12;
            // 
            // txbNombreEscuela
            // 
            this.txbNombreEscuela.Location = new System.Drawing.Point(238, 67);
            this.txbNombreEscuela.Name = "txbNombreEscuela";
            this.txbNombreEscuela.Size = new System.Drawing.Size(100, 20);
            this.txbNombreEscuela.TabIndex = 13;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConsultar.Location = new System.Drawing.Point(492, 230);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnActualizar.Location = new System.Drawing.Point(324, 230);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegistrar.Location = new System.Drawing.Point(157, 230);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscar.Location = new System.Drawing.Point(372, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 514);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txbNombreEscuela);
            this.Controls.Add(this.txbNivel);
            this.Controls.Add(this.txbEdadInicio);
            this.Controls.Add(this.txbEdadFin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbNombreEscuela);
            this.Controls.Add(this.lbEdadInicio);
            this.Controls.Add(this.lbEdadFin);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.menLevels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Niveles";
            this.Load += new System.EventHandler(this.Levels_Load);
            this.menLevels.ResumeLayout(false);
            this.menLevels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lbNombreEscuela;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbEdadFin;
        private System.Windows.Forms.TextBox txbEdadInicio;
        private System.Windows.Forms.TextBox txbNivel;
        private System.Windows.Forms.TextBox txbNombreEscuela;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
    }
}