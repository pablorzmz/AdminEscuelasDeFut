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
    public partial class Players : Form
    {
        private PlayerTrainnings playerTrainingsTool;
        private C_Players playerController;
        private String sexValue;
        public Players()
        {
            InitializeComponent();
            playerController = new C_Players();
            sexValue = "";
        }

        public void showPlayersTraingins()
        {
          playerTrainingsTool = new PlayerTrainnings();
          playerTrainingsTool.ShowDialog();
        }
        private void menuItemConsultarEntren_Click(object sender, EventArgs e)
        {
            showPlayersTraingins();
        }

        private void Players_Load(object sender, EventArgs e)
        {
            /* Fill combo box with user levels*/
            playerController.fillLevesComboBox(this.cboNiveles);
            playerController.fillPlayerDataGridView( dgtvPlayersInfo, null );            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedulaEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender,e,false);            
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txbPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txbSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txbNombreEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txbNumeroPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbPrimerApellidoEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txbTelefonoDEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> parameters = new List<String>();
            /*0*/
            parameters.Add(txbCedula.Text);
            /*1*/parameters.Add(txbNombre.Text);
            playerController.fillPlayerDataGridView(dgtvPlayersInfo, parameters);
        }

        private void rbtnHombre_CheckedChanged(object sender, EventArgs e)
        {
            this.sexValue = "m";
        }

        private void rbtnMujer_CheckedChanged(object sender, EventArgs e)
        {
            this.sexValue = "f";
        }

        private void lbTeléfono_Click(object sender, EventArgs e)
        {

        }

        private void dgtvPlayersInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgtvPlayersInfo.RowCount -1)
            {
                List<String> buffer = new List<string>();
                Utilities.readCurrentRowFromDataGridView(dgtvPlayersInfo, e.RowIndex, dgtvPlayersInfo.ColumnCount, buffer);
                DateTime t1;
                DateTime t2;
                String sex;
                int nivel = -1;
                txbCedula.Text = buffer[0];
                txbNombre.Text = buffer[1];
                txbPrimerApellidoJug.Text = buffer[2];
                txbSegundoApellidoJug.Text = buffer[3];
                sex = buffer[5];
                t1 = Convert.ToDateTime(buffer[6]);
                dtpFechaDeNacimiento.Value = t1;
                if (buffer[7] != "")
                {
                    t2 = Convert.ToDateTime(buffer[7]);
                    dtpFechaIngreso.Value = t2;
                }
                nivel = Convert.ToInt16(buffer[8]);
                txtCedulaEncargado.Text = buffer[9];
                txbNombreEncargado.Text = buffer[10];
                txbPrimerApellidoEncargado.Text = buffer[11];
                txbSegundoApellidoEncargado.Text = buffer[12];

                if (sex == "f")
                {
                    rbtnMujer.Checked = true;
                }
                else
                {
                    rbtnHombre.Checked = true;
                }

                cboNiveles.SelectedIndex = nivel;
            }
        }
    }
}

