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

        public Schools()
        {
            InitializeComponent();
            schoolController = new C_Schools();
            dataTemp = new List<string>();
        }

        public void showHeadQuaderModule()
        {
            headQuatersModule = new HeadQuarters();
            headQuatersModule.ShowDialog();
        }
        private void menuItemAdministrarInst_Click(object sender, EventArgs e)
        {
            showHeadQuaderModule();
        }

        public void showSchooLevels()
        {
            schoolLevesManagement = new SchoolLevels();
            schoolLevesManagement.ShowDialog();
        }

        private void menuItemGestionarNiveles_Click(object sender, EventArgs e)
        {
            showSchooLevels();
        }

        private void Schools_Load(object sender, EventArgs e)
        {
            schoolController.fillSchoolsDataGridView(dgvSchoolM, null);
            schoolController.fillDirrInstalacionComboBox(cmbDirrInstalacion);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool salir = Utilities.showQuestionMessage("¿Desea salir del módulo Escuelas?",
                          "Módulo Escuelas");
            if (salir)
            {
                this.Close();
            }
        }

        private void txtNameSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txtPlaceSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txtAddressSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void TxtInstallationNameSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void cleanInput()
        {
            txtNameSchoolM.Text = "";
            txtPlaceSchoolM.Text = "";
            cmbDirrInstalacion.SelectedItem = 0;
            txtTelephoneSchoolM.Text = "";
            txtTelephoneSchoo2M.Text = "";
        }

        private void btnConsultar_MouseClick(object sender, MouseEventArgs e)
        {
            List<String> parameters = new List<String>();
            parameters.Add(txtNameSchoolM.Text);
            schoolController.fillSchoolsDataGridView(dgvSchoolM, parameters);
        }

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

        private void txtTelephoneSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txtTelephoneSchoo2M_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

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

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            cleanInput();
            setVisibleBtn(true);
            dataTemp.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
}
