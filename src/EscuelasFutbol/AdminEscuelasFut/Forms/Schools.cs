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
    public partial class Schools : Form
    {
        private HeadQuarters headQuatersModule;
        private SchoolLevels schoolLevesManagement;
        private C_Schools schoolController;
        private List<String> dataTemp;
        private HelpForm help;

        /// <summary>
        /// Builder of the interface school
        /// </summary>
        public Schools()
        {
            InitializeComponent();
            schoolController = new C_Schools();
            dataTemp = new List<string>();
            help = new HelpForm();
        }

        /// <summary>
        /// Show interface to manage headquarters
        /// </summary>
        public void showHeadQuaderModule()
        {
            headQuatersModule = new HeadQuarters();
            headQuatersModule.ShowDialog();
        }

        /// <summary>
        /// Activates the interface to manage the headquarters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemAdministrarInst_Click(object sender, EventArgs e)
        {
            showHeadQuaderModule();
        }

        /// <summary>
        /// Shows interface to manage the school levels
        /// </summary>
        public void showSchooLevels()
        {
            schoolLevesManagement = new SchoolLevels();
            schoolLevesManagement.ShowDialog();
        }

        /// <summary>
        /// Activates the interface to manage the school levels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemGestionarNiveles_Click(object sender, EventArgs e)
        {
            showSchooLevels();
        }

        /// <summary>
        /// Load the data that is necessary for this interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Schools_Load(object sender, EventArgs e)
        {
            schoolController.fillSchoolsDataGridView(dgvSchoolM, null);
            schoolController.fillDirrInstalacionComboBox(cmbDirrInstalacion);
        }

        /// <summary>
        /// Exit the interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Control the injection in the txtNameSchoolM 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNameSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        /// <summary>
        /// Control the injection in the txtPlaceSchoolM 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPlaceSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        /// <summary>
        /// Control the injection in the txtAddressSchoolM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddressSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        /// <summary>
        /// Control the injection in the TxtInstallationNameSchoolM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtInstallationNameSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        /// <summary>
        /// Clean all spaces in the interface
        /// </summary>
        private void cleanInput()
        {
            txtNameSchoolM.Text = "";
            txtPlaceSchoolM.Text = "";
            cmbDirrInstalacion.SelectedItem = 0;
            txtTelephoneSchoolM.Text = "";
            txtTelephoneSchoo2M.Text = "";
        }

        /// <summary>
        /// Activates the action of consulting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_MouseClick(object sender, MouseEventArgs e)
        {
            //cleanInput();
            if (txtNameSchoolM.Text == "")
            {
                Utilities.showWarningMessage("El nombre de la escuela es " +
                    "inválido.", "Datos de entrada inválidos para el nombre de la Escuela");
                txtNameSchoolM.Focus();
            }
            else
            {
                List<String> parameters = new List<String>();
                parameters.Add(txtNameSchoolM.Text);
                schoolController.fillSchoolsDataGridView(dgvSchoolM, parameters);
            }
        }

        /// <summary>
        /// Activates the action of loading selected data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSchoolM_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cleanInput();
            if (e.RowIndex >= 0 && e.RowIndex < dgvSchoolM.RowCount - 1)
            {
                List<String> buffer = new List<string>();
                Utilities.readCurrentRowFromDataGridView(dgvSchoolM, e.RowIndex, dgvSchoolM.ColumnCount, buffer);
                txtNameSchoolM.Text = buffer[0];
                txtPlaceSchoolM.Text = buffer[1];
                cmbDirrInstalacion.SelectedItem = buffer[2];
                schoolController.fillSchoolTelephoneInfo(buffer[0], txtTelephoneSchoolM, txtTelephoneSchoo2M);
            }
        }

        /// <summary>
        /// Control the injection in the txtTelephoneSchoolM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelephoneSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        /// <summary>
        /// Control the injection in the txtTelephoneSchoo2M
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelephoneSchoo2M_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        /// <summary>
        /// Activates the action of updating data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (txtNameSchoolM.Text == "")
            {
                Utilities.showWarningMessage("El nombre de la escuela es " +
                    "inválido.", "Datos de entrada inválidos para el nombre de la Escuela");
                txtNameSchoolM.Focus();
                error = true;
            }
            if (txtPlaceSchoolM.Text == "")
            {
                Utilities.showWarningMessage("El nombre del Lugar es" +
                    "inválido.", "Datos de entrada inválidos para el nombre del Lugar");
                txtPlaceSchoolM.Focus();
                error = true;
            }
            if (!error)
            {
                dataTemp.Add(txtNameSchoolM.Text);
                dataTemp.Add(txtTelephoneSchoolM.Text);
                dataTemp.Add(txtTelephoneSchoo2M.Text);
                setVisibleBtn(false);
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
            if (txtNameSchoolM.Text == "")
            {
                Utilities.showWarningMessage("El nombre de la escuela es " +
                    "inválido.", "Datos de entrada inválidos para el nombre de la Escuela");
                txtNameSchoolM.Focus();
                error = true;
            }
            if (txtPlaceSchoolM.Text == "")
            {
                Utilities.showWarningMessage("El nombre del Lugar es" +
                    "inválido.", "Datos de entrada inválidos para el nombre del Lugar");
                txtNameSchoolM.Focus();
                error = true;
            }
            if (!error)
            {
                bool seguir = Utilities.showQuestionMessage("¿Desea insertar la nueva escuela: " +
                    "Nombre: " + txtNameSchoolM.Text + ", Lugar: " + txtPlaceSchoolM.Text + " en la base de datos?", "Insertar nueva Escuela");
                if (seguir)
                {
                    List<String> args = new List<string>();
                    args.Add(txtNameSchoolM.Text.ToString());
                    args.Add(txtPlaceSchoolM.Text.ToString());
                    if (cmbDirrInstalacion.SelectedIndex == 0)
                    {
                        args.Add("");
                    }
                    else
                    {
                        args.Add(cmbDirrInstalacion.SelectedItem.ToString());
                    }
                    args.Add(txtTelephoneSchoolM.Text.ToString());
                    args.Add(txtTelephoneSchoo2M.Text.ToString());
                    int result = schoolController.insertSchool(args);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("La escuela fue registrada con éxito", "Éxito al registrar");
                        cleanInput();
                        schoolController.fillSchoolsDataGridView(dgvSchoolM, null);
                    }
                    else
                    {
                        if (result == Utilities.DUPLICATED_KEY)
                        {
                            Utilities.showErrorMessage("El nombre de la escuela que desea insertar ya se encuentra en la base de datos", "No se pudo registrar la escuela");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Error(" + result + ") al registrar la escuela.", "Excepción al registrar escuela");
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
            if (txtNameSchoolM.Text == "")
            {
                Utilities.showWarningMessage("El nombre de la escuela es " +
                    "inválido.", "Datos de entrada inválidos para el nombre de la Escuela");
                txtNameSchoolM.Focus();
            }
            else
            {
                bool seguir = Utilities.showQuestionMessage("¿Desea borrar la escuela: " +
                    "Nombre: " + txtNameSchoolM.Text + " en la base de datos?", "Borrar una Escuela");
                if (seguir)
                {
                    List<String> args = new List<string>();
                    args.Add(txtNameSchoolM.Text.ToString());
                    int result = schoolController.deleteSchool(args);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("La escuela fue borrada con éxito", "Éxito al borrar");
                        cleanInput();
                        schoolController.fillSchoolsDataGridView(dgvSchoolM, null);
                    }
                    else
                    {
                        Utilities.showErrorMessage("Error(" + result + ") al borrar la escuela.", "Excepción al borrar escuela");
                    }
                }
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

            dgvSchoolM.Enabled = visible;

            btnGuardar.Visible = !visible;
            btnDescartar.Visible = !visible;
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
            if (txtNameSchoolM.Text == "")
            {
                Utilities.showWarningMessage("El nombre de la escuela es " +
                    "inválido.", "Datos de entrada inválidos para el nombre de la Escuela");
                txtNameSchoolM.Focus();
                error = true;
            }
            if (txtPlaceSchoolM.Text == "")
            {
                Utilities.showWarningMessage("El nombre del Lugar es" +
                    "inválido.", "Datos de entrada inválidos para el nombre del Lugar");
                txtPlaceSchoolM.Focus();
                error = true;
            }
            if (!error)
            {
                dataTemp.Add(txtNameSchoolM.Text);
                dataTemp.Add(txtPlaceSchoolM.Text);
                dataTemp.Add(cmbDirrInstalacion.SelectedItem.ToString());
                dataTemp.Add(txtTelephoneSchoolM.Text);
                dataTemp.Add(txtTelephoneSchoo2M.Text);
                schoolController.updateSchoolInfo(dataTemp);

                setVisibleBtn(true);
                dataTemp.Clear();
                schoolController.fillSchoolsDataGridView(dgvSchoolM, null);
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
        private void Schools_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool salir = Utilities.showQuestionMessage("¿Desea salir del módulo Escuelas?",
                          "Módulo Escuelas");
            if (!salir)
            {
                e.Cancel = true;
            }
        }
    }
}
