using AdminEscuelasFut.Forms;
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
    public partial class Trainings : Form
    {
        private C_Trainings trainingsController;
        private DataGridViewRow currentRow;
        private String dataTemp;
        private HelpForm help;

        /// <summary>
        /// 
        /// </summary>
        public Trainings()
        {
            InitializeComponent();
            trainingsController = new C_Trainings();
            currentRow = null;
            help = new HelpForm();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Trainings_Load(object sender, EventArgs e)
        {
            trainingsController.filldataGridViewTrainings(this.dgvTrainingM,null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTrainingM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTrainingM.RowCount)
            {
                currentRow = dgvTrainingM.Rows[e.RowIndex];
                List<String> buffer = new List<string>();
                Utilities.readCurrentRowFromDataGridView(dgvTrainingM, e.RowIndex, dgvTrainingM.ColumnCount, buffer);
                this.dtpDateTrainingM.Value = Convert.ToDateTime(buffer[0]);
                this.txtHourTrainingM.Text = buffer[1];
            }            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {

            List<String> args = new List<string>();
            args.Add(dtpDateTrainingM.Value.ToString("yyyy-MM-dd"));
            args.Add(txtHourTrainingM.Text);
            if (args[1] == "  :  :")
            {
                trainingsController.filldataGridViewTrainings(dgvTrainingM, null);
            }
            else
            {
                trainingsController.filldataGridViewTrainings(dgvTrainingM, args);
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TimeSpan time;          
            if (txtHourTrainingM.Text == "  :  :" || txtHourTrainingM.Text.Contains(" ") || !TimeSpan.TryParse(txtHourTrainingM.Text, out time))
            {
                MessageBox.Show("Debe elegir una hora válida para el entrenamiento");
                txtHourTrainingM.Focus();
            }
            else if (currentRow == null)
            {
                MessageBox.Show("Debe elegir un campos para actualizar desde la tabla de entrenamientos");
            }
            else
            {
                dataTemp = dtpDateTrainingM.Value.ToString("yyyy-MM-dd");
                setVisibleBtn(false);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TimeSpan time;
            if (txtHourTrainingM.Text == "  :  :" || txtHourTrainingM.Text.Contains(" ") || !TimeSpan.TryParse(txtHourTrainingM.Text, out time))
            {
                MessageBox.Show("Debe elegir una hora válida para el entrenamiento");
                txtHourTrainingM.Focus();
            }
            else
            {
                List<String> args = new List<string>();
                args.Add(dtpDateTrainingM.Value.ToString("yyyy-MM-dd"));
                args.Add(txtHourTrainingM.Text);
                int result = trainingsController.insertNewTraining(args);
                if (result == 0)
                {
                    MessageBox.Show("Entrenamiento registrado con éxito");
                    this.txtHourTrainingM.Text = "  :  :";
                    trainingsController.filldataGridViewTrainings(dgvTrainingM, null);
                }
                else
                {
                    MessageBox.Show("Error al registrar entrenamiento");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            List<String> args = new List<string>();
            args.Add(dtpDateTrainingM.Value.ToString("yyyy-MM-dd"));

            int result = trainingsController.deleteTraining(args);
            if (result == 0)
            {
                MessageBox.Show("Entrenamiento borrado con éxito");
                this.txtHourTrainingM.Text = "  :  :";
                trainingsController.filldataGridViewTrainings(dgvTrainingM, null);
            }
            else
            {
                MessageBox.Show("Error al borrar entrenamiento");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<String> args = new List<string>();
            args.Add(dataTemp);
            args.Add(dtpDateTrainingM.Value.ToString("yyyy-MM-dd"));
            args.Add(txtHourTrainingM.Text);
            int result = trainingsController.updateTraining(args);
            if (result == 0)
            {
                MessageBox.Show("Entrenamiento actualizado con éxito");
                trainingsController.filldataGridViewTrainings(dgvTrainingM, null);
                setVisibleBtn(true);
                cleanInput();

            }
            else
            {
                MessageBox.Show("Error al actualizar entrenamiento");
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="visible"></param>
        public void setVisibleBtn(bool visible)
        {
            btnBorrar.Visible = visible;
            btnConsultar.Visible = visible;
            btnRegistrar.Visible = visible;
            btnActualizar.Visible = visible;
            dgvTrainingM.Enabled = visible;

            btnGuardar.Visible = !visible;
            btnDescartar.Visible = !visible;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            cleanInput();
            setVisibleBtn(true);
        }
        /// <summary>
        /// 
        /// </summary>
        private void cleanInput()
        {
            this.txtHourTrainingM.Text = "  :  :";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.Show();
        }
    }
}
