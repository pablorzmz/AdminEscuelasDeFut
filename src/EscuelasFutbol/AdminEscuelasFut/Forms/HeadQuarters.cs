using AdminEscuelasFut.Classes;
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
    public partial class HeadQuarters : Form
    {
        private C_HeadQuarters headQuartersController;
        String dataTemp;
        private HelpForm help;

        /// <summary>
        /// Constructor
        /// </summary>
        public HeadQuarters()
        {
            InitializeComponent();
            headQuartersController = new C_HeadQuarters();
            help = new HelpForm();
        }

        /// <summary>
        /// Event that is activated when the form is loaded, loads the data in the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeadQuarters_Load(object sender, EventArgs e)
        {
            headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
        }

        /// <summary>
        /// event click exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Event that is activated when a key is pressed, validates that what is typed is correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddressAdministerInstallation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        /// <summary>
        /// event click button Consultar. Search the database, according to the data in the text fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> parameters = new List<String>();
            /*0*/parameters.Add(txtAddressAdministerInstallation.Text);
            /*1*/parameters.Add(txtTelephoneAdministerInstallation.Text);
            headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, parameters);
        }

        /// <summary>
        /// event double click. Load the selected datagrid information to the text fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdministerInstallation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cleanInput();
            if (e.RowIndex >= 0 && e.RowIndex < dgvAdministerInstallation.RowCount - 1)
            {
                List<String> buffer = new List<string>();
                Utilities.readCurrentRowFromDataGridView(dgvAdministerInstallation, e.RowIndex, dgvAdministerInstallation.ColumnCount, buffer);
                txtAddressAdministerInstallation.Text = buffer[0];
                txtTelephoneAdministerInstallation.Text = buffer[1];

            }
        }

        /// <summary>
        /// clean all text fields
        /// </summary>
        private void cleanInput()
        {
            txtAddressAdministerInstallation.Text = "";
            txtTelephoneAdministerInstallation.Text = "";
        }


        /// <summary>
        /// event click register button. It is responsible for validating that everything is fine, then inserting the information in the database, 
        /// it also controls the different errors, and according to the error, it shows an informative message to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (allFieldsFilled())
            {
                bool confirm = Utilities.showQuestionMessage("¿Desea registrar la instalación en la base de datos?", "Registrar instalación");
                if (confirm)
                {
                    int result = headQuartersController.insertHeadQuarter(txtAddressAdministerInstallation.Text, txtTelephoneAdministerInstallation.Text);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Instalación registrada con éxito", "Éxito al registrar");
                        cleanInput();
                        headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
                    }
                    else
                    {
                        if (result == Utilities.DUPLICATED_KEY)
                        {
                            Utilities.showErrorMessage("La instalación con dicha dirección ya se encuentra registrada en la base de datos", "Error al insertar instalación");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al insertar instalación");
                        }
                    }
                }
                
            }
            
        }


        /// <summary>
        /// event click save button. It is responsible for validating that everything is fine, then save the information in the database, 
        /// also controls the various errors, and according to the error shows an informative message to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtAddressAdministerInstallation.Text != "")
            {
                bool confirm = Utilities.showQuestionMessage("¿Desea eliminar la instalación con dirección " + txtAddressAdministerInstallation.Text + " de la base de datos?", "Borrar instalación");
                if (confirm)
                {
                    int result = headQuartersController.deleteHeadQuarter(txtAddressAdministerInstallation.Text);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Operación de borrado exitosa", "Éxito al borrar");
                        cleanInput();
                        headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
                    }
                    else
                    {
                        Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al borrar instalación");
                    }
                }
            }
            else
            {
                Utilities.showErrorMessage("El campo para la direccción es inválido, no puede estar vacío", "Dato inválido");
                txtAddressAdministerInstallation.Focus();
            }
        }


        /// <summary>
        /// Method that verifies that all the fields of the form are well, in case it is not notified to the user.
        /// </summary>
        /// <returns>Returns true if all is well.</returns>
        private bool allFieldsFilled()
        {
            bool isOk = true;
            if (txtAddressAdministerInstallation.Text == "")
            {
                Utilities.showErrorMessage("El campo para la direccción es inválido", "Dato inválido");
                txtAddressAdministerInstallation.Focus();
                isOk = false;
            }
            return isOk;
        }

        /// <summary>
        /// event click update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (allFieldsFilled())
            {
                dataTemp = txtAddressAdministerInstallation.Text;
                setVisibleBtn(false);
            }
        }

        /// <summary>
        /// event click save button. It is responsible for validating that everything is fine, then save the information in the database, 
        /// also controls the various errors, and according to the error shows an informative message to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (allFieldsFilled())
            {
                bool confirm = Utilities.showQuestionMessage("¿Desea actualizar la instalación en la base de datos?", "Actualizar instalación");
                if (confirm)
                {
                    int result = headQuartersController.updateHeadQuarter(dataTemp, txtAddressAdministerInstallation.Text, txtTelephoneAdministerInstallation.Text);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Instalación actualizado con éxito", "Éxito al actualizar");
                        cleanInput();
                        headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
                    }
                    else
                    {
                        if (result == Utilities.DUPLICATED_KEY)
                        {
                            Utilities.showErrorMessage("La instalación con dicha dirección ya se encuentra registrada en la base de datos", "Error al actualizar instalación");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al actualizar instalación");
                        }
                    }
                    setVisibleBtn(true);
                }
            }
        }


        /// <summary>
        /// Method that is responsible for manipulating the visibility of buttons
        /// </summary>
        /// <param name="visible">Boolean indicating the visibility of the button.</param>
        public void setVisibleBtn(bool visible)
        {
            btnBorrar.Visible = visible;
            btnConsultar.Visible = visible;
            btnRegistrar.Visible = visible;
            btnActualizar.Visible = visible;

            dgvAdministerInstallation.Enabled = visible;

            btnGuardar.Visible = !visible;
            btnDescartar.Visible = !visible;
        }

        /// <summary>
        /// event click button descartar. Discard the changes that were made when modifying.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            setVisibleBtn(true);
            cleanInput();
        }

        /// <summary>
        /// event click button help, show the help to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.Show();
        }
    }
}
