namespace AdminEscuelasFut
{
    partial class PlayerTrainnings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerTrainnings));
            this.menEntrenJugadores = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIDPlayerTraining = new System.Windows.Forms.TextBox();
            this.dtpDatePlayerTraining = new System.Windows.Forms.DateTimePicker();
            this.btnDeletePlayerTraining = new System.Windows.Forms.Button();
            this.btnUpdatePlayerTraining = new System.Windows.Forms.Button();
            this.btnSearchPlayerTraining = new System.Windows.Forms.Button();
            this.btnRegisterPlayerTraining = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPlayerTraining = new System.Windows.Forms.DataGridView();
            this.menEntrenJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // menEntrenJugadores
            // 
            this.menEntrenJugadores.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menEntrenJugadores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menEntrenJugadores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menEntrenJugadores.Location = new System.Drawing.Point(0, 0);
            this.menEntrenJugadores.Name = "menEntrenJugadores";
            this.menEntrenJugadores.Size = new System.Drawing.Size(696, 24);
            this.menEntrenJugadores.TabIndex = 4;
            this.menEntrenJugadores.Text = "menuPrincipal";
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
            // txtIDPlayerTraining
            // 
            this.txtIDPlayerTraining.Location = new System.Drawing.Point(429, 84);
            this.txtIDPlayerTraining.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDPlayerTraining.Name = "txtIDPlayerTraining";
            this.txtIDPlayerTraining.Size = new System.Drawing.Size(93, 20);
            this.txtIDPlayerTraining.TabIndex = 39;
            // 
            // dtpDatePlayerTraining
            // 
            this.dtpDatePlayerTraining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePlayerTraining.Location = new System.Drawing.Point(209, 84);
            this.dtpDatePlayerTraining.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatePlayerTraining.Name = "dtpDatePlayerTraining";
            this.dtpDatePlayerTraining.Size = new System.Drawing.Size(112, 20);
            this.dtpDatePlayerTraining.TabIndex = 38;
            // 
            // btnDeletePlayerTraining
            // 
            this.btnDeletePlayerTraining.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeletePlayerTraining.Location = new System.Drawing.Point(265, 161);
            this.btnDeletePlayerTraining.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePlayerTraining.Name = "btnDeletePlayerTraining";
            this.btnDeletePlayerTraining.Size = new System.Drawing.Size(68, 28);
            this.btnDeletePlayerTraining.TabIndex = 37;
            this.btnDeletePlayerTraining.Text = "Borrar";
            this.btnDeletePlayerTraining.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePlayerTraining
            // 
            this.btnUpdatePlayerTraining.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdatePlayerTraining.Location = new System.Drawing.Point(176, 161);
            this.btnUpdatePlayerTraining.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePlayerTraining.Name = "btnUpdatePlayerTraining";
            this.btnUpdatePlayerTraining.Size = new System.Drawing.Size(68, 28);
            this.btnUpdatePlayerTraining.TabIndex = 36;
            this.btnUpdatePlayerTraining.Text = "Actualizar";
            this.btnUpdatePlayerTraining.UseVisualStyleBackColor = false;
            // 
            // btnSearchPlayerTraining
            // 
            this.btnSearchPlayerTraining.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearchPlayerTraining.Location = new System.Drawing.Point(429, 161);
            this.btnSearchPlayerTraining.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPlayerTraining.Name = "btnSearchPlayerTraining";
            this.btnSearchPlayerTraining.Size = new System.Drawing.Size(132, 28);
            this.btnSearchPlayerTraining.TabIndex = 35;
            this.btnSearchPlayerTraining.Text = "Buscar Entrenamientos";
            this.btnSearchPlayerTraining.UseVisualStyleBackColor = false;
            // 
            // btnRegisterPlayerTraining
            // 
            this.btnRegisterPlayerTraining.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegisterPlayerTraining.Location = new System.Drawing.Point(88, 161);
            this.btnRegisterPlayerTraining.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterPlayerTraining.Name = "btnRegisterPlayerTraining";
            this.btnRegisterPlayerTraining.Size = new System.Drawing.Size(68, 28);
            this.btnRegisterPlayerTraining.TabIndex = 34;
            this.btnRegisterPlayerTraining.Text = "Registrar";
            this.btnRegisterPlayerTraining.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(148, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(368, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cédula";
            // 
            // dgvPlayerTraining
            // 
            this.dgvPlayerTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerTraining.Location = new System.Drawing.Point(44, 226);
            this.dgvPlayerTraining.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlayerTraining.Name = "dgvPlayerTraining";
            this.dgvPlayerTraining.RowTemplate.Height = 24;
            this.dgvPlayerTraining.Size = new System.Drawing.Size(615, 179);
            this.dgvPlayerTraining.TabIndex = 31;
            // 
            // PlayerTrainnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 414);
            this.Controls.Add(this.txtIDPlayerTraining);
            this.Controls.Add(this.dtpDatePlayerTraining);
            this.Controls.Add(this.btnDeletePlayerTraining);
            this.Controls.Add(this.btnUpdatePlayerTraining);
            this.Controls.Add(this.btnSearchPlayerTraining);
            this.Controls.Add(this.btnRegisterPlayerTraining);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPlayerTraining);
            this.Controls.Add(this.menEntrenJugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerTrainnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrenamientos de jugadores";
            this.Load += new System.EventHandler(this.PlayerTrainnings_Load);
            this.menEntrenJugadores.ResumeLayout(false);
            this.menEntrenJugadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menEntrenJugadores;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIDPlayerTraining;
        private System.Windows.Forms.DateTimePicker dtpDatePlayerTraining;
        private System.Windows.Forms.Button btnDeletePlayerTraining;
        private System.Windows.Forms.Button btnUpdatePlayerTraining;
        private System.Windows.Forms.Button btnSearchPlayerTraining;
        private System.Windows.Forms.Button btnRegisterPlayerTraining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPlayerTraining;
    }
}