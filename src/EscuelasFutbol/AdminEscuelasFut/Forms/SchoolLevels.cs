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
    public partial class SchoolLevels : Form
    {
        private C_SchoolLevels schoolLevelsController;
        private List<String> dataTemp;
        private HelpForm help;

        /// <summary>
        /// Builder of the interface schoolLevels
        /// </summary>
        public SchoolLevels()
        {
            InitializeComponent();
            schoolLevelsController = new C_SchoolLevels();
            dataTemp = new List<string>();
            help = new HelpForm();
        }

        /// <summary>
        /// Load the data that is necessary for this interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SchoolLevels_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = new Size(this.Width + 100, this.Height + 100);
            schoolLevelsController.fillLevesComboBox(this.cmbSchoolLevel);
            schoolLevelsController.fillSchoolsComboBox(this.cmbSchoolName);
            schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
        }

        /// <summary>
        /// Exit the interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool salir = Utilities.showQuestionMessage("¿Desea salir de las herramientas Niveles de Escuelas?",
                          "Niveles de Escuelas");
            if (salir)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Control the injection in the txtMinimumAgeSchoolLevel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMinimumAgeSchoolLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        /// <summary>
        /// Control the injection in the txtMaximumAgeSchoolLevel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMaximumAgeSchoolLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        /// <summary>
        /// Clean all spaces in the interface
        /// </summary>
        private void cleanInput()
        {
            cmbSchoolName.SelectedItem = 0;
            cmbSchoolLevel.SelectedItem = 0;
        }

        /// <summary>
        /// Activates the action of consulting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_MouseClick(object sender, MouseEventArgs e)
        {
            cleanInput();
            if (cmbSchoolName.SelectedIndex == 0)
            {
                Utilities.showWarningMessage("Debe Seleccionar una Escuela válida.", "Datos de entrada inválidos para el nombre de la Escuela");
                cmbSchoolName.Focus();
            }
            else
            {
                List<String> parameters = new List<String>();
                parameters.Add(cmbSchoolName.SelectedItem.ToString());
                schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, parameters);
            }
        }

        /// <summary>
        /// Activates the action of loading selected data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSchoolLevels_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cleanInput();
            if (e.RowIndex >= 0 && e.RowIndex < dgvSchoolLevels.RowCount - 1)
            {
                List<String> buffer = new List<string>();
                Utilities.readCurrentRowFromDataGridView(dgvSchoolLevels, e.RowIndex, dgvSchoolLevels.ColumnCount, buffer);
                cmbSchoolName.SelectedItem = buffer[0];
                int levelNumber = int.Parse(buffer[1]);
                cmbSchoolLevel.SelectedIndex = levelNumber;
            }
        }

        /// <summary>
        /// Activates the action of inserting data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (cmbSchoolName.SelectedIndex == 0)
            {
                Utilities.showWarningMessage("Debe Seleccionar una Escuela válida.", "Datos de entrada inválidos para el nombre de la Escuela");
                cmbSchoolName.Focus();
                error = true;
            }
            if (cmbSchoolLevel.SelectedIndex == 0)
            {
                Utilities.showWarningMessage("Debe Seleccionar un Nivel válido.", "Datos de entrada inválidos para el numero de Nivel");
                cmbSchoolLevel.Focus();
                error = true;
            }
            if (!error)
            {
                bool seguir = Utilities.showQuestionMessage("¿Desea insertar el nivel: " + cmbSchoolLevel.SelectedItem + ", a la escuela: " + cmbSchoolName.SelectedItem + " ?", "Insertar nuevo Nivel a Escuela");
                if (seguir)
                {
                    List<String> args = new List<string>();
                    args.Add(cmbSchoolName.SelectedItem.ToString());
                    args.Add(cmbSchoolLevel.SelectedItem.ToString());
                    int result = schoolLevelsController.insertSchoolLevels(args);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Exito al insertar el nivel en la escuela", "Éxito al registrar");
                        cleanInput();
                        schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
                    }
                    else
                    {
                        if (result == Utilities.DUPLICATED_KEY)
                        {
                            Utilities.showErrorMessage("La escuela ya tienen ese nivel", "No se pudo registrar");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Error(" + result + ") al registrar.", "Excepción al registrar");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Activates the action of deleting data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (cmbSchoolName.SelectedIndex == 0)
            {
                Utilities.showWarningMessage("Debe Seleccionar una Escuela válida.", "Datos de entrada inválidos para el nombre de la Escuela");
                cmbSchoolName.Focus();
                error = true;
            }
            if (cmbSchoolLevel.SelectedIndex == 0)
            {
                Utilities.showWarningMessage("Debe Seleccionar un Nivel válido.", "Datos de entrada inválidos para el numero de Nivel");
                cmbSchoolLevel.Focus();
                error = true;
            }
            if (!error)
            {
                bool seguir = Utilities.showQuestionMessage("¿Desea borrar el nivel: " + cmbSchoolLevel.SelectedItem + ", de la escuela: " + cmbSchoolName.SelectedItem + " ?", "Borrar Nivel de Escuela");
                if (seguir)
                {
                    List<String> args = new List<string>();
                    args.Add(cmbSchoolName.SelectedItem.ToString());
                    args.Add(cmbSchoolLevel.SelectedItem.ToString());
                    int result = schoolLevelsController.deleteSchoolLevels(args);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Exito al borrar el nivel de la escuela", "Éxito al borrar");
                        cleanInput();
                        schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
                    }
                    else
                    {
                        Utilities.showErrorMessage("Error(" + result + ") al borrar el nivel de la escuela.", "Excepción al borrar");
                    }
                }
            }
        }

        /// <summary>
        /// Activates the action of updating data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cmbSchoolLevel.SelectedIndex == 0)
            {
                Utilities.showWarningMessage("Debe Seleccionar un Nivel válido.", "Datos de entrada inválidos para el numero de Nivel");
                cmbSchoolLevel.Focus();
            }
            else
            {
                setVisibleBtn(false);
                dataTemp.Add(cmbSchoolLevel.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// Enable and disable buttons
        /// </summary>
        /// <param name="visible"></param>
        public void setVisibleBtn(bool visible)
        {
            btnBorrar.Visible = visible;
            btnConsultar.Visible = visible;
            btnRegistrar.Visible = visible;
            btnActualizar.Visible = visible;
            dgvSchoolLevels.Enabled = visible;

            btnGuardar.Visible = !visible;
            btnDescartar.Visible = !visible;
            cmbSchoolName.Enabled = visible;
        }

        /// <summary>
        /// Activate the action to discard changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            cleanInput();
            setVisibleBtn(true);
            dataTemp.Clear();
        }

        /// <summary>
        /// Activate the action to save changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (cmbSchoolName.SelectedIndex == 0)
            {
                Utilities.showWarningMessage("Debe Seleccionar una Escuela válida.", "Datos de entrada inválidos para el nombre de la Escuela");
                cmbSchoolName.Focus();
                error = true;
            }
            if (cmbSchoolLevel.SelectedIndex == 0)
            {
                Utilities.showWarningMessage("Debe Seleccionar un Nivel válido.", "Datos de entrada inválidos para el numero de Nivel");
                cmbSchoolLevel.Focus();
                error = true;
            }
            if (!error)
            {
                bool seguir = Utilities.showQuestionMessage("¿Desea actualizar el nivel: " + cmbSchoolLevel.SelectedItem + ", de la escuela: " + cmbSchoolName.SelectedItem + " ?", "Actualizar Nivel de Escuela");
                if (seguir)
                {
                    dataTemp.Add(cmbSchoolLevel.SelectedItem.ToString());
                    dataTemp.Add(cmbSchoolName.SelectedItem.ToString());
                    schoolLevelsController.updateSchoolLevelsInfo(dataTemp);
                    schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
                    dataTemp.Clear();
                    setVisibleBtn(true);
                }
            }
        }

        /// <summary>
        /// Show help window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.Show();
        }

        /// <summary>
        /// Verify if you want to leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SchoolLevels_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool salir = Utilities.showQuestionMessage("¿Desea salir de las herramientas Niveles de Escuelas?",
                          "Niveles de Escuelas");
            if (!salir)
            {
                e.Cancel = true;
            }
        }
    }
}
