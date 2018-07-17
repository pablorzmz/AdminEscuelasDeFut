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

        public SchoolLevels()
        {
            InitializeComponent();
            schoolLevelsController = new C_SchoolLevels();
            dataTemp = new List<string>();
        }

        private void SchoolLevels_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = new Size(this.Width + 100, this.Height + 100);
            schoolLevelsController.fillLevesComboBox(this.cmbSchoolLevel);
            schoolLevelsController.fillSchoolsComboBox(this.cmbSchoolName);
            schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool salir = Utilities.showQuestionMessage("¿Desea salir de las herramientas Niveles de Escuelas?",
                          "Niveles de Escuelas");
            if (salir)
            {
                this.Close();
            }
        }

        private void txtMinimumAgeSchoolLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txtMaximumAgeSchoolLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void cleanInput()
        {
            cmbSchoolName.SelectedItem = 0;
            cmbSchoolLevel.SelectedItem = 0;
        }

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

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            cleanInput();
            setVisibleBtn(true);
            dataTemp.Clear();
        }

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

        
    }
}
