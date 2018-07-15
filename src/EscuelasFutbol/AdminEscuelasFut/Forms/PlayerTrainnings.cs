using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    public partial class PlayerTrainnings : Form
    {
        private C_PlayerTrainnings playerTrainingController;
        private String cedula;
        private String escuela;
        public PlayerTrainnings()
        {
            InitializeComponent();
            playerTrainingController = new C_PlayerTrainnings();
            this.cedula = "-1";
            this.escuela = "Elija una Escuela";
        }


        public void setCurrentArgs(String cedula, String escuela)
        {
            this.cedula = cedula;
            this.escuela = escuela;
        }

        private void PlayerTrainnings_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = new Size(this.Width + 100, this.Height + 100);            
            playerTrainingController.fillComboBoxEscuelas(this.cboEscuelas);
            playerTrainingController.fillComboBoxFechasEntren(cboFechasEntrenamientos);
            this.txtIDPlayerTraining.Text = this.cedula;
            this.cboEscuelas.SelectedItem = this.escuela;
            if (this.escuela == "Elija una Escuela")
            {
                playerTrainingController.fillPlayerDataGridView(this.dgvPlayerTraining, null);
            }
            else
            {
                List<String> parameters = new List<string>();
                parameters.Add(this.cedula);
                parameters.Add("9876-12-12");
                parameters.Add(this.escuela);
                playerTrainingController.fillPlayerDataGridView(this.dgvPlayerTraining, parameters);
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboFechasEntrenamientos.SelectedIndex != 0)
            {
                List<String> parameters = new List<string>();
                if (txtIDPlayerTraining.Text == "")
                {
                    parameters.Add("-1");
                    parameters.Add("");
                    parameters.Add("");
                    playerTrainingController.fillPlayerDataGridView(dgvPlayerTraining, null);
                }                
                else
                {
                    parameters.Add(txtIDPlayerTraining.Text);
                    DateTime t1 = Convert.ToDateTime(cboFechasEntrenamientos.SelectedItem.ToString());
                    parameters.Add(t1.ToString("yyyy-MM-dd"));
                    parameters.Add(cboEscuelas.SelectedItem.ToString());
                    playerTrainingController.fillPlayerDataGridView(dgvPlayerTraining, parameters);

                }                
            }            
        }
    }
}
