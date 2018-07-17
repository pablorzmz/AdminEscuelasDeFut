using AdminEscuelasFut.Classes;
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

        public HeadQuarters()
        {
            InitializeComponent();
            headQuartersController = new C_HeadQuarters();
        }

        private void HeadQuarters_Load(object sender, EventArgs e)
        {
            headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddressAdministerInstallation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> parameters = new List<String>();
            /*0*/parameters.Add(txtAddressAdministerInstallation.Text);
            /*1*/parameters.Add(txtTelephoneAdministerInstallation.Text);
            headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, parameters);
        }


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

        private void cleanInput()
        {
            txtAddressAdministerInstallation.Text = "";
            txtTelephoneAdministerInstallation.Text = "";
        }

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
                            Utilities.showErrorMessage("La instalación con dicha dirrección ya se encuentra registrada en la base de datos", "Error al insertar instalación");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al insertar instalación");
                        }
                    }
                }
                
            }
            
        }

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

        private bool allFieldsFilled()
        {
            bool isOk = true;
            if (txtAddressAdministerInstallation.Text != "")
            {
                Utilities.showErrorMessage("El campo para la direccción es inválido", "Dato inválido");
                txtAddressAdministerInstallation.Focus();
                isOk = false;
            }
            return isOk;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (allFieldsFilled())
            {
                dataTemp = txtAddressAdministerInstallation.Text;
                setVisibleBtn(false);
            }
        }

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

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            setVisibleBtn(true);
            cleanInput();
        }
    }
}
