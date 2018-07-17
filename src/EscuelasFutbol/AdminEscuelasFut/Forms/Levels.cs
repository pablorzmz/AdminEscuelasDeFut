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
            bool r = Utilities.showQuestionMessage("¿Desea salir del módulo de niveles?",
                          "Módulo de niveles");
            if (r)
            {
                this.Close();
            }
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
                bool confirm = Utilities.showQuestionMessage("¿Desea registrar el nivel en la base de datos?", "Actualizar nivel");
                if (confirm)
                {
                    int result = levelController.insertLevel(txbNivel.Text, txbEdadInicio.Text, txbEdadFin.Text);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Nivel registrado con éxito", "Éxito al registrar");
                        cleanInput();
                        levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
                    }
                    else
                    {
                        if (result == Utilities.DUPLICATED_KEY)
                        {
                            Utilities.showErrorMessage("El nivel con dicha número ya se encuentra registrado en la base de datos", "Error al insertar nivel");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al insertar nivel");
                        }
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if( txbNivel.Text != "")
            {
                bool confirm = Utilities.showQuestionMessage("¿Desea eliminar al nivel con número " + txbNivel.Text + " de la base de datos?", "Borrar nivel");
                if (confirm)
                {
                    int result = levelController.deleteLevel(txbNivel.Text);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Operación de borrado exitosa", "Éxito al borrar");
                        cleanInput();
                        levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
                    }
                    else
                    {
                        Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al borrar nivel");
                    }
                }
            }
            else
            {
                Utilities.showErrorMessage("Campo para nivel invalido, no debe estar vacío", "Dato inválido");
                txbNivel.Focus();
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
            bool isOk = true;
            if(txbNivel.Text == ""  )
            {
                Utilities.showErrorMessage("El campo para el nivel es inválido", "Dato inválido");
                txbNivel.Focus();
                isOk = false;
            }else if(txbEdadInicio.Text == "")
            {
                Utilities.showErrorMessage("El campo para la edad mínima es inválido", "Dato inválido");
                txbEdadInicio.Focus();
                isOk = false;
            }
            else if(txbEdadFin.Text == "")
            {
                Utilities.showErrorMessage("El campo para la edad máxima es inválido", "Dato inválido");
                txbEdadFin.Focus();
                isOk = false;
            }else if(Convert.ToInt32( txbEdadInicio.Text) >= Convert.ToInt32( txbEdadFin.Text) )
            {
                Utilities.showErrorMessage("La edad minima no puede ser mayor o igual a la máxima", "Dato inválido");
                txbEdadInicio.Focus();
                isOk = false;
            }

            return isOk;
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
            if (allFieldsFilled())
            {
                bool confirm = Utilities.showQuestionMessage("¿Desea actualizar el nivel en la base de datos?", "Actualizar nivel");
                if (confirm)
                {
                    int result = levelController.updateLevel(dataTemp, txbNivel.Text, txbEdadInicio.Text, txbEdadFin.Text);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Nivel actualizado con éxito", "Éxito al actualizar");
                        cleanInput();
                        levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
                    }
                    else
                    {
                        if (result == Utilities.DUPLICATED_KEY)
                        {
                            Utilities.showErrorMessage("El nivel con dicha número ya se encuentra registrado en la base de datos", "Error al actualizar nivel");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al actualizar nivel");
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

        private void Levels_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool r = Utilities.showQuestionMessage("¿Desea salir del módulo de niveles?",
                          "Módulo de niveles");
            if (!r)
            {
                e.Cancel = true;
            }
        }
    }
}
