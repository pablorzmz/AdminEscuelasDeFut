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
            playerController.fillSchoolsComboBox(this.cboEscuelas);
            playerController.fillPlayerDataGridView( dgtvPlayersInfo, null );

            dgtvPlayersInfo.Columns[6].Visible = false;
            dgtvPlayersInfo.Columns[7].Visible = false;
            dgtvPlayersInfo.Columns[12].Visible = false;
            dgtvPlayersInfo.Columns[13].Visible = false;
            
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
            /*0*/parameters.Add(txbCedula.Text);
            /*1*/parameters.Add(txbNombre.Text);
            /*2*/parameters.Add(cboEscuelas.SelectedItem.ToString());
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
            cleanInput();
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
                cboEscuelas.SelectedItem = buffer[8];
                nivel = Convert.ToInt16(buffer[9]);
                txtCedulaEncargado.Text = buffer[10];
                txbNombreEncargado.Text = buffer[11];
                txbPrimerApellidoEncargado.Text = buffer[12];
                txbSegundoApellidoEncargado.Text = buffer[13];

                if (sex == "f")
                {
                    rbtnMujer.Checked = true;
                }
                else
                {
                    rbtnHombre.Checked = true;
                }

                cboNiveles.SelectedIndex = nivel;
                playerController.fillPlayerTelephoneInfo(buffer[0], txbTelefonoJug1, txbTelefonoJug2);
            }
        }

        private void txbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbTelefonoJug1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbTelefonoJug2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbSegundoApellidoEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void pruebaProcAlmacenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerController.probarProcedimientoAlmacenado( dtpFechaIngreso.Value.ToString("yyyy-MM-dd") );
            playerController.fillPlayerDataGridView(dgtvPlayersInfo, null);
        }
        private void cleanInput()
        {
            txtCedulaEncargado.Text = "";
            txbNombre.Text = "";
            txbPrimerApellidoJug.Text = "";
            txbSegundoApellidoJug.Text = "";
            txbTelefonoJug1.Text = "";
            txbTelefonoJug2.Text = "";
            txbNombreEncargado.Text = "";
            txbPrimerApellidoEncargado.Text = "";
            txbSegundoApellidoEncargado.Text = "";
            txbTelefonoDEncargado.Text = "";
        }
    }
}

