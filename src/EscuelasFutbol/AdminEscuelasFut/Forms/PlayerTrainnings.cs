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
    public partial class PlayerTrainnings : Form
    {
        private C_PlayerTrainnings playerTrainingController;
        private String cedula;
        private String escuela;
        private DataGridViewRow currentRow;
        private HelpForm help;
        /// <summary>
        /// Default class constructor
        /// </summary>
        public PlayerTrainnings()
        {
            InitializeComponent();
            playerTrainingController = new C_PlayerTrainnings();
            this.cedula = "-1";
            this.escuela = "Elija una Escuela";
            currentRow = null;
            help = new HelpForm();
        }
        /// <summary>
        /// Set loaded values of Cedula and Escuelas as selected in this form.
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="escuela"></param>
        public void setCurrentArgs(String cedula, String escuela)
        {
            this.cedula = cedula;
            this.escuela = escuela;
        }
        /// <summary>
        /// Default load method of this form. Initialize and show all  first-look info from data base in this context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerTrainnings_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = new Size(this.Width + 100, this.Height + 100);
            playerTrainingController.fillComboBoxEscuelas(this.cboEscuelas);
            playerTrainingController.fillComboBoxFechasEntren(cboFechasEntrenamientos);
            playerTrainingController.fillComboBoxCedula(this.cboCedulas);
            this.txtIDPlayerTraining.Text = this.cedula;
            this.cboEscuelas.SelectedItem = this.escuela;
            for (int index = 1; index < cboFechasEntrenamientos.Items.Count; ++ index )
            {
                cboFechasEntrenamientos.Items[index] =
                    Convert.ToDateTime(cboFechasEntrenamientos.Items[index]).ToString("dd/MM/yyyy");
            }
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
        /// <summary>
        /// Control and ask to user to close this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Click action that calls controller to execute stored proc for executing a query of a player training record from data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Clone a valid id number from comboBox to the specific player id number textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCedulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCedulas.SelectedIndex != 0)
            {
                txtIDPlayerTraining.Text = cboCedulas.SelectedItem.ToString();
            }
        }
        /// <summary>
        /// Displays and fills files with a selected row from datagridview. Double click action event of the datagridview component.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPlayerTraining_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<String> buffer = new List<string>();
            currentRow = dgvPlayerTraining.Rows[e.RowIndex];
            Utilities.readCurrentRowFromDataGridView(dgvPlayerTraining, e.RowIndex, dgvPlayerTraining.ColumnCount, buffer);
            this.cboEscuelas.SelectedItem = buffer[0];
            this.cboCedulas.SelectedItem = buffer[1];
            this.txtIDPlayerTraining.Text = buffer[1];
            DateTime t = Convert.ToDateTime(buffer[4]);
            this.cboFechasEntrenamientos.SelectedItem = t.ToString("dd/MM/yyyy");
        }
        /// <summary>
        /// Click action that calls controller to execute stored proc for updating a player training record from data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDPlayerTraining.Text == "")
            {
                Utilities.showErrorMessage("Se debe degitar una cédula válida","Campo inválido");
                txtIDPlayerTraining.Focus();
            }
            else if (cboFechasEntrenamientos.SelectedIndex == 0)
            {
                Utilities.showErrorMessage("Se debe seleccionar una fecha de entrenamiento válida","Campo inválido");
                cboFechasEntrenamientos.Focus();
            }
            else if (currentRow == null)
            {
                Utilities.showErrorMessage("Para actualizar un valor, debe haberse seleccionado" +
                    " de la tabla de entrenamientos","Seleccione un valod con doble clic en la tabla inferior");
                dgvPlayerTraining.Focus();
            }
            else
            {
                List<String> args = new List<string>();
                args.Add(txtIDPlayerTraining.Text);
                args.Add(cboFechasEntrenamientos.SelectedItem.ToString());
                args.Add(currentRow.Cells["Fecha"].Value.ToString());

                int result = playerTrainingController.updatePlayerTrainingInfo(args);

                if (result == 0)
                {
                    Utilities.showInformationMessage("Entrenamiento actualizado con éxito","Actualización exitosa");
                    playerTrainingController.fillPlayerDataGridView(dgvPlayerTraining, null);
                    currentRow = null;
                    cleanInput();
                }
                else
                {
                    Utilities.showErrorMessage("Execepción no controlada número(" + result + ")", "Excepción sql");
                }
            }
        }
        /// <summary>
        /// Clear all data input
        /// </summary>
        private void cleanInput()
        {
            txtIDPlayerTraining.Text = "";
            cboCedulas.SelectedIndex = 0;
            cboEscuelas.SelectedIndex = 0;
            cboFechasEntrenamientos.SelectedIndex = 0;
        }
        /// <summary>
        /// Click action that calls controller to execute stored proc for inserting a player training record into data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIDPlayerTraining.Text == "")
            {
                Utilities.showErrorMessage("Se debe degitar una cédula válida","Campo cédula inválido");
                txtIDPlayerTraining.Focus();
            }
            else if (cboFechasEntrenamientos.SelectedIndex == 0)
            {
                Utilities.showErrorMessage("Se debe seleccionar una fecha de entrenamiento válida","Campo fecha entrenamientos inválido");
                cboFechasEntrenamientos.Focus();
            }
            else
            {
                List<String> args = new List<string>();
                args.Add(txtIDPlayerTraining.Text);
                args.Add(cboFechasEntrenamientos.SelectedItem.ToString());

                int result = playerTrainingController.addNewPlayerTraining(args);

                if (result == 0)
                {
                    Utilities.showInformationMessage("Entrenamiento registrado con éxito","Registro correcto en la base de datos");
                    playerTrainingController.fillPlayerDataGridView(dgvPlayerTraining, null);
                    cleanInput();
                }
                else
                {
                    if (result == Utilities.DUPLICATED_KEY)
                    {
                        Utilities.showErrorMessage("El valor que intenta registrar ya se encuentra en la base de datos", "Valor duplicado");
                    }
                    else
                    {
                        Utilities.showErrorMessage("Excepción no controlada número: (" + result + ")","Excepción SQL");
                    }
                }
            }
        }
        /// <summary>
        /// Click action that calls controller to execute stored proc for deleting a player training record from data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtIDPlayerTraining.Text == "")
            {
                Utilities.showErrorMessage("Se debe degitar una cédula válida","Campo inválido");
                txtIDPlayerTraining.Focus();
            }
            else if (cboFechasEntrenamientos.SelectedIndex == 0)
            {
                Utilities.showErrorMessage("Se debe seleccionar una fecha de entrenamiento válida","Campo inválido");
                cboFechasEntrenamientos.Focus();
            }
            else
            {
                List<String> args = new List<string>();
                args.Add(txtIDPlayerTraining.Text);
                args.Add(cboFechasEntrenamientos.SelectedItem.ToString());

                int result = playerTrainingController.deletePlayerTraining(args);

                if (result == 0)
                {
                    Utilities.showInformationMessage("Entrenamiento borrado con éxito","Borrado exitoso");
                    playerTrainingController.fillPlayerDataGridView(dgvPlayerTraining, null);
                    cleanInput();
                }
                else
                {
                    Utilities.showErrorMessage("Error al borrar entrenamiento de jugador. Excepción número(" + result + ")","Excepción SQL");
                }
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.Show();
        }
    }
}
