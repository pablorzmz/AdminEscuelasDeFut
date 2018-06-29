namespace AdminEscuelasFut
{
    partial class Trainings
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
            this.menTrainings = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTrainingM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegisterTrainingM = new System.Windows.Forms.Button();
            this.btnSearchTrainingM = new System.Windows.Forms.Button();
            this.btnUpdateTrainingM = new System.Windows.Forms.Button();
            this.btnDeleteTrainingM = new System.Windows.Forms.Button();
            this.dtpDateTrainingM = new System.Windows.Forms.DateTimePicker();
            this.txtHourTrainingM = new System.Windows.Forms.TextBox();
            this.menTrainings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingM)).BeginInit();
            this.SuspendLayout();
            // 
            // menTrainings
            // 
            this.menTrainings.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menTrainings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menTrainings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menTrainings.Location = new System.Drawing.Point(0, 0);
            this.menTrainings.Name = "menTrainings";
            this.menTrainings.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menTrainings.Size = new System.Drawing.Size(1061, 28);
            this.menTrainings.TabIndex = 4;
            this.menTrainings.Text = "menuPrincipal";
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
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // dgvTrainingM
            // 
            this.dgvTrainingM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainingM.Location = new System.Drawing.Point(67, 371);
            this.dgvTrainingM.Name = "dgvTrainingM";
            this.dgvTrainingM.RowTemplate.Height = 24;
            this.dgvTrainingM.Size = new System.Drawing.Size(920, 240);
            this.dgvTrainingM.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(545, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(252, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // btnRegisterTrainingM
            // 
            this.btnRegisterTrainingM.Location = new System.Drawing.Point(181, 317);
            this.btnRegisterTrainingM.Name = "btnRegisterTrainingM";
            this.btnRegisterTrainingM.Size = new System.Drawing.Size(90, 34);
            this.btnRegisterTrainingM.TabIndex = 14;
            this.btnRegisterTrainingM.Text = "Registrar";
            this.btnRegisterTrainingM.UseVisualStyleBackColor = true;
            // 
            // btnSearchTrainingM
            // 
            this.btnSearchTrainingM.Location = new System.Drawing.Point(384, 317);
            this.btnSearchTrainingM.Name = "btnSearchTrainingM";
            this.btnSearchTrainingM.Size = new System.Drawing.Size(90, 34);
            this.btnSearchTrainingM.TabIndex = 15;
            this.btnSearchTrainingM.Text = "Buscar";
            this.btnSearchTrainingM.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTrainingM
            // 
            this.btnUpdateTrainingM.Location = new System.Drawing.Point(596, 317);
            this.btnUpdateTrainingM.Name = "btnUpdateTrainingM";
            this.btnUpdateTrainingM.Size = new System.Drawing.Size(90, 34);
            this.btnUpdateTrainingM.TabIndex = 16;
            this.btnUpdateTrainingM.Text = "Actualizar";
            this.btnUpdateTrainingM.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTrainingM
            // 
            this.btnDeleteTrainingM.Location = new System.Drawing.Point(786, 317);
            this.btnDeleteTrainingM.Name = "btnDeleteTrainingM";
            this.btnDeleteTrainingM.Size = new System.Drawing.Size(90, 34);
            this.btnDeleteTrainingM.TabIndex = 17;
            this.btnDeleteTrainingM.Text = "Borrar";
            this.btnDeleteTrainingM.UseVisualStyleBackColor = true;
            // 
            // dtpDateTrainingM
            // 
            this.dtpDateTrainingM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTrainingM.Location = new System.Drawing.Point(334, 137);
            this.dtpDateTrainingM.Name = "dtpDateTrainingM";
            this.dtpDateTrainingM.Size = new System.Drawing.Size(148, 22);
            this.dtpDateTrainingM.TabIndex = 18;
            // 
            // txtHourTrainingM
            // 
            this.txtHourTrainingM.Location = new System.Drawing.Point(627, 137);
            this.txtHourTrainingM.Name = "txtHourTrainingM";
            this.txtHourTrainingM.Size = new System.Drawing.Size(123, 22);
            this.txtHourTrainingM.TabIndex = 30;
            // 
            // Trainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 633);
            this.Controls.Add(this.txtHourTrainingM);
            this.Controls.Add(this.dtpDateTrainingM);
            this.Controls.Add(this.btnDeleteTrainingM);
            this.Controls.Add(this.btnUpdateTrainingM);
            this.Controls.Add(this.btnSearchTrainingM);
            this.Controls.Add(this.btnRegisterTrainingM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTrainingM);
            this.Controls.Add(this.menTrainings);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Trainings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de entrenamientos";
            this.Load += new System.EventHandler(this.Trainings_Load);
            this.menTrainings.ResumeLayout(false);
            this.menTrainings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menTrainings;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTrainingM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegisterTrainingM;
        private System.Windows.Forms.Button btnSearchTrainingM;
        private System.Windows.Forms.Button btnUpdateTrainingM;
        private System.Windows.Forms.Button btnDeleteTrainingM;
        private System.Windows.Forms.DateTimePicker dtpDateTrainingM;
        private System.Windows.Forms.TextBox txtHourTrainingM;
    }
}