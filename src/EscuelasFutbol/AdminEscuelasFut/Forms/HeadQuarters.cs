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
            if (txtAddressAdministerInstallation.Text != "")
            {
                int error = headQuartersController.insertHeadQuarter(txtAddressAdministerInstallation.Text, txtTelephoneAdministerInstallation.Text);
                Console.WriteLine("Se retorna insert " + error);
                headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
            }
            else
            {
                //Solo se debe de dar advertencia en el Caso de La direccion, el tel si puede estar vacio
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtAddressAdministerInstallation.Text != "")
            {
                int error = headQuartersController.deleteHeadQuarter(txtAddressAdministerInstallation.Text);
                Console.WriteLine("Se retorna delete " + error);
                headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
                cleanInput();
            }
            else
            {
                //mensaje de error
                //Diciendo que hacen falta los niveles
            }
        }

        private bool allFieldsFilled()
        {
            if (txtAddressAdministerInstallation.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
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
            headQuartersController.updateHeadQuarter(dataTemp, txtAddressAdministerInstallation.Text, txtTelephoneAdministerInstallation.Text);
            headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
            setVisibleBtn(true);
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
