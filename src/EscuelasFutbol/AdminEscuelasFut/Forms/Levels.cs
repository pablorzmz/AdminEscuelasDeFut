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
        

        /// <summary>
        /// Constructor
        /// </summary>
        public Levels()
        {
            InitializeComponent();
            levelController = new C_Levels();
            help = new HelpForm();
        }

        /// <summary>
        /// Event that is activated when the form is loaded, loads the data in the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Levels_Load(object sender, EventArgs e)
        {
            levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
        }

        /// <summary>
        /// event click exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool r = Utilities.showQuestionMessage("¿Desea salir del módulo de niveles?",
                          "Módulo de niveles");
            if (r)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Event that is activated when a key is pressed, validates that what is typed is correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        /// <summary>
        /// Event that is activated when a key is pressed, validates that what is typed is correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbEdadInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        /// <summary>
        /// Event that is activated when a key is pressed, validates that what is typed is correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbEdadFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        /// <summary>
        /// event click button Consultar. Search the database, according to the data in the text fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> parameters = new List<String>();
            /*0*/parameters.Add(txbNivel.Text);
            /*1*/parameters.Add(txbEdadInicio.Text);
            /*2*/parameters.Add(txbEdadFin.Text);
            levelController.fillLevelsDataGridView(dgtvLevelInfo, parameters);
        }


        /// <summary>
        /// event double click. Load the selected datagrid information to the text fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// event click save button. It is responsible for validating that everything is fine, then boorar the information of the database, 
        /// also controls the various errors, and according to the error shows an informative message to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    else if (result == 547)
                    {
                        Utilities.showErrorMessage("Solo se pueden eliminar niveles que no pertenecen a una escuela", "Error al eliminar nivel");
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

        

        /// <summary>
        /// clean all text fields
        /// </summary>
        private void cleanInput()
        {
            txbNivel.Text = "";
            txbEdadInicio.Text = "";
            txbEdadFin.Text = "";
        }

        /// <summary>
        /// Method that verifies that all the fields of the form are well, in case it is not notified to the user.
        /// </summary>
        /// <returns>Returns true if all is well.</returns>
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

        /// <summary>
        /// event click update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (allFieldsFilled())
            {
                dataTemp = txbNivel.Text;
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
                            Utilities.showErrorMessage("El nivel qu intenta ingresar ya se encuentra registrado en la base de datos", "Error al actualizar nivel");
                        }else
                        {
                            Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al actualizar nivel");
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

            dgtvLevelInfo.Enabled = visible;

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


        /// <summary>
        /// Closed form event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
