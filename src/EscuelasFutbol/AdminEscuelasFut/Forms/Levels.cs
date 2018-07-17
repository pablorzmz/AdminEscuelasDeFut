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
    public partial class Levels : Form
    {
        private C_Levels levelController;
        private HelpForm help;
        private String dataTemp;

        String helpText = "\r\nEn este módulo se pueden manipular los niveles que se imparten en las escuelas de futbol," +
                            "donde no pueden existir niveles repetidos, además los rangos deberán ser excluyentes.";

        public Levels()
        {
            InitializeComponent();
            levelController = new C_Levels();
            help = new HelpForm("Manipulacion niveles", helpText);
        }

        private void Levels_Load(object sender, EventArgs e)
        {
            levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbEdadInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbEdadFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        /**
         * 
         * 
         **/
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> parameters = new List<String>();
            /*0*/parameters.Add(txbNivel.Text);
            /*1*/parameters.Add(txbEdadInicio.Text);
            /*2*/parameters.Add(txbEdadFin.Text);
            levelController.fillLevelsDataGridView(dgtvLevelInfo, parameters);
        }
        
       
        
        private void dgtvLevelInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cleanInput();
            if (e.RowIndex >= 0 && e.RowIndex < dgtvLevelInfo.RowCount - 1)
            {
                List<String> buffer = new List<string>();
                Utilities.readCurrentRowFromDataGridView(dgtvLevelInfo, e.RowIndex, dgtvLevelInfo.ColumnCount, buffer);
                txbNivel.Text = buffer[0];
                txbEdadInicio.Text = buffer[1];
                txbEdadFin.Text = buffer[2];

            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (allFieldsFilled())
            {
                int error = levelController.insertLevel(txbNivel.Text, txbEdadInicio.Text, txbEdadFin.Text);
                Console.WriteLine("Se retorna insert " + error);
                levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
            }
            else
            {
                //mensaje de advertencia para que llene los campos
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if( txbNivel.Text != "")
            {
                int error = levelController.deleteLevel(txbNivel.Text);
                Console.WriteLine("Se retorna delete " + error);
                levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
                cleanInput();
            }
            else
            {
                //mensaje de error
                //Diciendo que hacen falta los niveles
            }
        }

        /**
         * clean all text fields
         **/
        private void cleanInput()
        {
            txbNivel.Text = "";
            txbEdadInicio.Text = "";
            txbEdadFin.Text = "";
        }

        private bool allFieldsFilled()
        {
            if(txbNivel.Text != "" && txbEdadInicio.Text != "" && txbEdadFin.Text != "")
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
                dataTemp = txbNivel.Text;
                setVisibleBtn(false);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            levelController.updateLevel(dataTemp, txbNivel.Text, txbEdadInicio.Text, txbEdadFin.Text);
            levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
            setVisibleBtn(true);
        }

        public void setVisibleBtn(bool visible)
        {
            btnBorrar.Visible = visible;
            btnConsultar.Visible = visible;
            btnRegistrar.Visible = visible;
            btnActualizar.Visible = visible;

            dgtvLevelInfo.Enabled = visible;

            btnGuardar.Visible = !visible;
            btnDescartar.Visible = !visible;
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            setVisibleBtn(true);
            cleanInput();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.Show();
        }
    }
}
