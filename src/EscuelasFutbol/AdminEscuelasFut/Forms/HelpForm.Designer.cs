namespace AdminEscuelasFut.Forms
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.txtHelpText = new System.Windows.Forms.TextBox();
            this.txtHelpTitleText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHelpText
            // 
            this.txtHelpText.AcceptsReturn = true;
            this.txtHelpText.AcceptsTab = true;
            this.txtHelpText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHelpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelpText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHelpText.Location = new System.Drawing.Point(32, 86);
            this.txtHelpText.Multiline = true;
            this.txtHelpText.Name = "txtHelpText";
            this.txtHelpText.ReadOnly = true;
            this.txtHelpText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHelpText.Size = new System.Drawing.Size(832, 452);
            this.txtHelpText.TabIndex = 4;
            // 
            // txtHelpTitleText
            // 
            this.txtHelpTitleText.AcceptsReturn = true;
            this.txtHelpTitleText.AcceptsTab = true;
            this.txtHelpTitleText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHelpTitleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelpTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelpTitleText.ForeColor = System.Drawing.Color.Blue;
            this.txtHelpTitleText.Location = new System.Drawing.Point(2, 21);
            this.txtHelpTitleText.Multiline = true;
            this.txtHelpTitleText.Name = "txtHelpTitleText";
            this.txtHelpTitleText.ReadOnly = true;
            this.txtHelpTitleText.Size = new System.Drawing.Size(862, 45);
            this.txtHelpTitleText.TabIndex = 5;
            this.txtHelpTitleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(193, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(536, 73);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            this.textBox3.AcceptsTab = true;
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Blue;
            this.textBox3.Location = new System.Drawing.Point(2, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(862, 69);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(865, 538);
            this.Controls.Add(this.txtHelpTitleText);
            this.Controls.Add(this.txtHelpText);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHelpText;
        private System.Windows.Forms.TextBox txtHelpTitleText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}