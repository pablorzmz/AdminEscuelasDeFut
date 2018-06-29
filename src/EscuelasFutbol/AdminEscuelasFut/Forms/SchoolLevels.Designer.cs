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
            this.menSchoolLeves.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menSchoolLeves.Size = new System.Drawing.Size(928, 28);
            this.menSchoolLeves.TabIndex = 4;
            this.menSchoolLeves.Text = "menuPrincipal";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre escuela";
            // 
            // btnDeleteSchoolLevel
            // 
            this.btnDeleteSchoolLevel.Location = new System.Drawing.Point(719, 204);
            this.btnDeleteSchoolLevel.Name = "btnDeleteSchoolLevel";
            this.btnDeleteSchoolLevel.Size = new System.Drawing.Size(90, 34);
            this.btnDeleteSchoolLevel.TabIndex = 22;
            this.btnDeleteSchoolLevel.Text = "Borrar";
            this.btnDeleteSchoolLevel.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSchoolLevel
            // 
            this.btnUpdateSchoolLevel.Location = new System.Drawing.Point(529, 204);
            this.btnUpdateSchoolLevel.Name = "btnUpdateSchoolLevel";
            this.btnUpdateSchoolLevel.Size = new System.Drawing.Size(90, 34);
            this.btnUpdateSchoolLevel.TabIndex = 21;
            this.btnUpdateSchoolLevel.Text = "Actualizar";
            this.btnUpdateSchoolLevel.UseVisualStyleBackColor = true;
            // 
            // btnSearchTrainingM
            // 
            this.btnSearchTrainingM.Location = new System.Drawing.Point(656, 44);
            this.btnSearchTrainingM.Name = "btnSearchTrainingM";
            this.btnSearchTrainingM.Size = new System.Drawing.Size(90, 34);
            this.btnSearchTrainingM.TabIndex = 20;
            this.btnSearchTrainingM.Text = "Buscar";
            this.btnSearchTrainingM.UseVisualStyleBackColor = true;
            // 
            // btnRegisterSchoolLevel
            // 
            this.btnRegisterSchoolLevel.Location = new System.Drawing.Point(114, 204);
            this.btnRegisterSchoolLevel.Name = "btnRegisterSchoolLevel";
            this.btnRegisterSchoolLevel.Size = new System.Drawing.Size(90, 34);
            this.btnRegisterSchoolLevel.TabIndex = 19;
            this.btnRegisterSchoolLevel.Text = "Registrar";
            this.btnRegisterSchoolLevel.UseVisualStyleBackColor = true;
            // 
            // dgvSchoolLevel
            // 
            this.dgvSchoolLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolLevel.Location = new System.Drawing.Point(59, 278);
            this.dgvSchoolLevel.Name = "dgvSchoolLevel";
            this.dgvSchoolLevel.RowTemplate.Height = 24;
            this.dgvSchoolLevel.Size = new System.Drawing.Size(820, 220);
            this.dgvSchoolLevel.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Edad fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Edad inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nivel";
            // 
            // txtSchoolNameSchoolLevel
            // 
            this.txtSchoolNameSchoolLevel.Location = new System.Drawing.Point(272, 50);
            this.txtSchoolNameSchoolLevel.Name = "txtSchoolNameSchoolLevel";
            this.txtSchoolNameSchoolLevel.Size = new System.Drawing.Size(347, 22);
            this.txtSchoolNameSchoolLevel.TabIndex = 26;
            // 
            // cmbSchoolLevel
            // 
            this.cmbSchoolLevel.FormattingEnabled = true;
            this.cmbSchoolLevel.Location = new System.Drawing.Point(272, 79);
            this.cmbSchoolLevel.Name = "cmbSchoolLevel";
            this.cmbSchoolLevel.Size = new System.Drawing.Size(100, 24);
            this.cmbSchoolLevel.TabIndex = 27;
            // 
            // txtMinimumAgeSchoolLevel
            // 
            this.txtMinimumAgeSchoolLevel.Location = new System.Drawing.Point(272, 110);
            this.txtMinimumAgeSchoolLevel.Name = "txtMinimumAgeSchoolLevel";
            this.txtMinimumAgeSchoolLevel.Size = new System.Drawing.Size(100, 22);
            this.txtMinimumAgeSchoolLevel.TabIndex = 28;
            // 
            // txtMaximumAgeSchoolLevel
            // 
            this.txtMaximumAgeSchoolLevel.Location = new System.Drawing.Point(272, 138);
            this.txtMaximumAgeSchoolLevel.Name = "txtMaximumAgeSchoolLevel";
            this.txtMaximumAgeSchoolLevel.Size = new System.Drawing.Size(100, 22);
            this.txtMaximumAgeSchoolLevel.TabIndex = 29;
            // 
            // btnConsultSchoolLevel
            // 
            this.btnConsultSchoolLevel.Location = new System.Drawing.Point(334, 204);
            this.btnConsultSchoolLevel.Name = "btnConsultSchoolLevel";
            this.btnConsultSchoolLevel.Size = new System.Drawing.Size(90, 34);
            this.btnConsultSchoolLevel.TabIndex = 30;
            this.btnConsultSchoolLevel.Text = "Consultar";
            this.btnConsultSchoolLevel.UseVisualStyleBackColor = true;
            // 
            // SchoolLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 510);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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