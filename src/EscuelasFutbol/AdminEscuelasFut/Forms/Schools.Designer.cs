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
            this.menSchools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menSchools
            // 
            this.menSchools.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.heeraToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menSchools.Location = new System.Drawing.Point(0, 0);
            this.menSchools.Name = "menSchools";
            this.menSchools.Size = new System.Drawing.Size(796, 24);
            this.menSchools.TabIndex = 5;
            this.menSchools.Text = "menuPays";
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
            // 
            // heeraToolStripMenuItem
            // 
            this.heeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdministrarInst,
            this.menuItemGestionarNiveles});
            this.heeraToolStripMenuItem.Name = "heeraToolStripMenuItem";
            this.heeraToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.heeraToolStripMenuItem.Text = "Herramientas";
            // 
            // menuItemAdministrarInst
            // 
            this.menuItemAdministrarInst.Name = "menuItemAdministrarInst";
            this.menuItemAdministrarInst.Size = new System.Drawing.Size(207, 22);
            this.menuItemAdministrarInst.Text = "Administrar instalaciones";
            this.menuItemAdministrarInst.Click += new System.EventHandler(this.menuItemAdministrarInst_Click);
            // 
            // menuItemGestionarNiveles
            // 
            this.menuItemGestionarNiveles.Name = "menuItemGestionarNiveles";
            this.menuItemGestionarNiveles.Size = new System.Drawing.Size(207, 22);
            this.menuItemGestionarNiveles.Text = "Gestionar niveles";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Schools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 514);
            this.Controls.Add(this.menSchools);
            this.Name = "Schools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Escuelas";
            this.menSchools.ResumeLayout(false);
            this.menSchools.PerformLayout();
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
    }
}