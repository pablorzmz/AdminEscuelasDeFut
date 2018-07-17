namespace AdminEscuelasFut
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menPrincp = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escuelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemJugadores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNiveles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menPrincp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menPrincp
            // 
            this.menPrincp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menPrincp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menPrincp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.módulosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menPrincp.Location = new System.Drawing.Point(0, 0);
            this.menPrincp.Name = "menPrincp";
            this.menPrincp.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menPrincp.Size = new System.Drawing.Size(1383, 28);
            this.menPrincp.TabIndex = 2;
            this.menPrincp.Text = "menuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // módulosToolStripMenuItem
            // 
            this.módulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradoresToolStripMenuItem,
            this.entrenadoresToolStripMenuItem,
            this.entrenamientosToolStripMenuItem,
            this.escuelasToolStripMenuItem,
            this.menuItemJugadores,
            this.menuItemNiveles,
            this.menuItemPagos});
            this.módulosToolStripMenuItem.Name = "módulosToolStripMenuItem";
            this.módulosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.módulosToolStripMenuItem.Text = "Módulos";
            // 
            // administradoresToolStripMenuItem
            // 
            this.administradoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.administradoresToolStripMenuItem.Enabled = false;
            this.administradoresToolStripMenuItem.Name = "administradoresToolStripMenuItem";
            this.administradoresToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.administradoresToolStripMenuItem.Text = "Administradores";
            // 
            // entrenadoresToolStripMenuItem
            // 
            this.entrenadoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.entrenadoresToolStripMenuItem.Enabled = false;
            this.entrenadoresToolStripMenuItem.Name = "entrenadoresToolStripMenuItem";
            this.entrenadoresToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.entrenadoresToolStripMenuItem.Text = "Entrenadores";
            // 
            // entrenamientosToolStripMenuItem
            // 
            this.entrenamientosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.entrenamientosToolStripMenuItem.Name = "entrenamientosToolStripMenuItem";
            this.entrenamientosToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.entrenamientosToolStripMenuItem.Text = "Entrenamientos";
            this.entrenamientosToolStripMenuItem.Click += new System.EventHandler(this.entrenamientosToolStripMenuItem_Click);
            // 
            // escuelasToolStripMenuItem
            // 
            this.escuelasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.escuelasToolStripMenuItem.Name = "escuelasToolStripMenuItem";
            this.escuelasToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.escuelasToolStripMenuItem.Text = "Escuelas";
            this.escuelasToolStripMenuItem.Click += new System.EventHandler(this.escuelasToolStripMenuItem_Click);
            // 
            // menuItemJugadores
            // 
            this.menuItemJugadores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuItemJugadores.Name = "menuItemJugadores";
            this.menuItemJugadores.Size = new System.Drawing.Size(193, 26);
            this.menuItemJugadores.Text = "Jugadores";
            this.menuItemJugadores.Click += new System.EventHandler(this.menuItemJugadores_Click);
            // 
            // menuItemNiveles
            // 
            this.menuItemNiveles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuItemNiveles.Name = "menuItemNiveles";
            this.menuItemNiveles.Size = new System.Drawing.Size(193, 26);
            this.menuItemNiveles.Text = "Niveles";
            this.menuItemNiveles.Click += new System.EventHandler(this.menuItemNiveles_Click);
            // 
            // menuItemPagos
            // 
            this.menuItemPagos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuItemPagos.Name = "menuItemPagos";
            this.menuItemPagos.Size = new System.Drawing.Size(193, 26);
            this.menuItemPagos.Text = "Pagos";
            this.menuItemPagos.Click += new System.EventHandler(this.menuItemPagos_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::AdminEscuelasFut.Properties.Resources.estadioFondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1383, 676);
            this.Controls.Add(this.menPrincp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de escuelas de fútbol 2018";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menPrincp.ResumeLayout(false);
            this.menPrincp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menPrincp;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenamientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escuelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemJugadores;
        private System.Windows.Forms.ToolStripMenuItem menuItemPagos;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNiveles;
    }
}