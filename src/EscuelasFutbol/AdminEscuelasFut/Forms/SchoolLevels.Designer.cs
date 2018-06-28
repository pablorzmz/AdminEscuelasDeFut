namespace AdminEscuelasFut
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
            this.menSchoolLeves = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteSchoolLevel = new System.Windows.Forms.Button();
            this.btnUpdateSchoolLevel = new System.Windows.Forms.Button();
            this.btnSearchTrainingM = new System.Windows.Forms.Button();
            this.btnRegisterSchoolLevel = new System.Windows.Forms.Button();
            this.dgvSchoolLevel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSchoolNameSchoolLevel = new System.Windows.Forms.TextBox();
            this.cmbSchoolLevel = new System.Windows.Forms.ComboBox();
            this.txtMinimumAgeSchoolLevel = new System.Windows.Forms.TextBox();
            this.txtMaximumAgeSchoolLevel = new System.Windows.Forms.TextBox();
            this.btnConsultSchoolLevel = new System.Windows.Forms.Button();
            this.menSchoolLeves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolLevel)).BeginInit();
            this.SuspendLayout();
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
            this.menSchoolLeves.Size = new System.Drawing.Size(696, 24);
            this.menSchoolLeves.TabIndex = 4;
            this.menSchoolLeves.Text = "menuPrincipal";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre escuela";
            // 
            // btnDeleteSchoolLevel
            // 
            this.btnDeleteSchoolLevel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteSchoolLevel.Location = new System.Drawing.Point(539, 166);
            this.btnDeleteSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteSchoolLevel.Name = "btnDeleteSchoolLevel";
            this.btnDeleteSchoolLevel.Size = new System.Drawing.Size(68, 28);
            this.btnDeleteSchoolLevel.TabIndex = 22;
            this.btnDeleteSchoolLevel.Text = "Borrar";
            this.btnDeleteSchoolLevel.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSchoolLevel
            // 
            this.btnUpdateSchoolLevel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateSchoolLevel.Location = new System.Drawing.Point(397, 166);
            this.btnUpdateSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateSchoolLevel.Name = "btnUpdateSchoolLevel";
            this.btnUpdateSchoolLevel.Size = new System.Drawing.Size(68, 28);
            this.btnUpdateSchoolLevel.TabIndex = 21;
            this.btnUpdateSchoolLevel.Text = "Actualizar";
            this.btnUpdateSchoolLevel.UseVisualStyleBackColor = false;
            // 
            // btnSearchTrainingM
            // 
            this.btnSearchTrainingM.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearchTrainingM.Location = new System.Drawing.Point(492, 36);
            this.btnSearchTrainingM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchTrainingM.Name = "btnSearchTrainingM";
            this.btnSearchTrainingM.Size = new System.Drawing.Size(91, 28);
            this.btnSearchTrainingM.TabIndex = 20;
            this.btnSearchTrainingM.Text = "Buscar Escuela";
            this.btnSearchTrainingM.UseVisualStyleBackColor = false;
            // 
            // btnRegisterSchoolLevel
            // 
            this.btnRegisterSchoolLevel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegisterSchoolLevel.Location = new System.Drawing.Point(86, 166);
            this.btnRegisterSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegisterSchoolLevel.Name = "btnRegisterSchoolLevel";
            this.btnRegisterSchoolLevel.Size = new System.Drawing.Size(68, 28);
            this.btnRegisterSchoolLevel.TabIndex = 19;
            this.btnRegisterSchoolLevel.Text = "Registrar";
            this.btnRegisterSchoolLevel.UseVisualStyleBackColor = false;
            // 
            // dgvSchoolLevel
            // 
            this.dgvSchoolLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolLevel.Location = new System.Drawing.Point(44, 226);
            this.dgvSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSchoolLevel.Name = "dgvSchoolLevel";
            this.dgvSchoolLevel.RowTemplate.Height = 24;
            this.dgvSchoolLevel.Size = new System.Drawing.Size(615, 179);
            this.dgvSchoolLevel.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Edad fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Edad inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nivel";
            // 
            // txtSchoolNameSchoolLevel
            // 
            this.txtSchoolNameSchoolLevel.Location = new System.Drawing.Point(204, 41);
            this.txtSchoolNameSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSchoolNameSchoolLevel.Name = "txtSchoolNameSchoolLevel";
            this.txtSchoolNameSchoolLevel.Size = new System.Drawing.Size(261, 20);
            this.txtSchoolNameSchoolLevel.TabIndex = 26;
            // 
            // cmbSchoolLevel
            // 
            this.cmbSchoolLevel.FormattingEnabled = true;
            this.cmbSchoolLevel.Location = new System.Drawing.Point(204, 64);
            this.cmbSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSchoolLevel.Name = "cmbSchoolLevel";
            this.cmbSchoolLevel.Size = new System.Drawing.Size(76, 21);
            this.cmbSchoolLevel.TabIndex = 27;
            // 
            // txtMinimumAgeSchoolLevel
            // 
            this.txtMinimumAgeSchoolLevel.Location = new System.Drawing.Point(204, 89);
            this.txtMinimumAgeSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinimumAgeSchoolLevel.Name = "txtMinimumAgeSchoolLevel";
            this.txtMinimumAgeSchoolLevel.Size = new System.Drawing.Size(76, 20);
            this.txtMinimumAgeSchoolLevel.TabIndex = 28;
            // 
            // txtMaximumAgeSchoolLevel
            // 
            this.txtMaximumAgeSchoolLevel.Location = new System.Drawing.Point(204, 112);
            this.txtMaximumAgeSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaximumAgeSchoolLevel.Name = "txtMaximumAgeSchoolLevel";
            this.txtMaximumAgeSchoolLevel.Size = new System.Drawing.Size(76, 20);
            this.txtMaximumAgeSchoolLevel.TabIndex = 29;
            // 
            // btnConsultSchoolLevel
            // 
            this.btnConsultSchoolLevel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConsultSchoolLevel.Location = new System.Drawing.Point(250, 166);
            this.btnConsultSchoolLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultSchoolLevel.Name = "btnConsultSchoolLevel";
            this.btnConsultSchoolLevel.Size = new System.Drawing.Size(68, 28);
            this.btnConsultSchoolLevel.TabIndex = 30;
            this.btnConsultSchoolLevel.Text = "Consultar";
            this.btnConsultSchoolLevel.UseVisualStyleBackColor = false;
            // 
            // SchoolLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 414);
            this.Controls.Add(this.btnConsultSchoolLevel);
            this.Controls.Add(this.txtMaximumAgeSchoolLevel);
            this.Controls.Add(this.txtMinimumAgeSchoolLevel);
            this.Controls.Add(this.cmbSchoolLevel);
            this.Controls.Add(this.txtSchoolNameSchoolLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteSchoolLevel);
            this.Controls.Add(this.btnUpdateSchoolLevel);
            this.Controls.Add(this.btnSearchTrainingM);
            this.Controls.Add(this.btnRegisterSchoolLevel);
            this.Controls.Add(this.dgvSchoolLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menSchoolLeves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SchoolLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionar niveles de escuelas";
            this.Load += new System.EventHandler(this.SchoolLevels_Load);
            this.menSchoolLeves.ResumeLayout(false);
            this.menSchoolLeves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menSchoolLeves;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteSchoolLevel;
        private System.Windows.Forms.Button btnUpdateSchoolLevel;
        private System.Windows.Forms.Button btnSearchTrainingM;
        private System.Windows.Forms.Button btnRegisterSchoolLevel;
        private System.Windows.Forms.DataGridView dgvSchoolLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSchoolNameSchoolLevel;
        private System.Windows.Forms.ComboBox cmbSchoolLevel;
        private System.Windows.Forms.TextBox txtMinimumAgeSchoolLevel;
        private System.Windows.Forms.TextBox txtMaximumAgeSchoolLevel;
        private System.Windows.Forms.Button btnConsultSchoolLevel;
    }
}