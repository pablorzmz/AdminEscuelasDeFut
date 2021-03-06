﻿using AdminEscuelasFut.Forms;
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
    public partial class LegalManager : Form
    {
        private C_LegalManager legalManagerController;
        private List<String> dataTemp;
        private HelpForm help;

        /// <summary>
        /// Default class constructor
        /// </summary>
        public LegalManager()
        {
            InitializeComponent();
            legalManagerController = new C_LegalManager();
            dataTemp = new List<string>();
            help = new HelpForm();
        }
        /// <summary>
        /// Load method for this form. Do the first load in DataGridViewComponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LegalManager_Load(object sender, EventArgs e)
        {
            legalManagerController.filldtgvEncarcado(this.dtgvEncargados,null);
        }
        /// <summary>
        ///  Key press event action for sql injection control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender,e);
        }
        /// <summary>
        ///  Key press event action for sql injection control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }
        /// <summary>
        ///  Key press event action for sql injection control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }
        /// <summary>
        ///  Key press event action for sql injection control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }
        /// <summary>
        ///  Cell mouse double click event for loading data into other component from a DataGridView component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvEncargados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<String> buffer = new List<string>();
            Utilities.readCurrentRowFromDataGridView(dtgvEncargados, e.RowIndex, dtgvEncargados.ColumnCount, buffer);
            txtCedula.Text = buffer[0];
            txtNombre.Text = buffer[1];
            txtApellido1.Text = buffer[2];
            txtApellido2.Text = buffer[3];
        }
        /// <summary>
        /// Method that ask user to close this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Click event of button that calls the controller to insert a new legal manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {            
            if (txtCedula.Text == "")
            {
                Utilities.showErrorMessage("El campo para la cédula es inválido", "Dato inválido");
                txtCedula.Focus();
            }
            else if (txtNombre.Text == "")
            {
                Utilities.showErrorMessage("El campo para el nombre del encargado es inválido", "Dato inválido");
                txtNombre.Focus();
            }
            else if (txtApellido1.Text == "")
            {
                Utilities.showErrorMessage("El campo para el primer apellido del encargado es inválido", "Dato inválido");
                txtApellido1.Focus();
            }
            else if (txtApellido2.Text == "")
            {
                Utilities.showErrorMessage("El campo para el segundo apellido del encargado es inválido", "Dato inválido");
                txtApellido2.Focus();
            }
            else
            {
                List<String> args = new List<string>();
                //@Cedula char(9),
                args.Add(txtCedula.Text);
                //@Nombre varchar(30),
                args.Add(txtNombre.Text);
                //@Apellido1 varchar(15),
                args.Add(txtApellido1.Text);
                //@Apellido2 varchar(15)
                args.Add(txtApellido2.Text);

                bool confirm = Utilities.showQuestionMessage("¿Desea registrar al nuevo encargado en la base?", "Registrar nuevo encargado");
                if (confirm)
                {
                    int result = legalManagerController.insertNewEncargado(args);

                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Encargado registrado con éxito", "Éxito al registrar");
                        cleanInput();
                        legalManagerController.filldtgvEncarcado(dtgvEncargados, null);
                    }
                    else
                    {
                        if (result == Utilities.DUPLICATED_KEY)
                        {
                            Utilities.showErrorMessage("El encargado ya se encuentra registrado en la base de datos", "Error al registrar encargado");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Excepción no controlada número (" + result+ ")", "Error al registrar encargado");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Clean all textbox files in this form
        /// </summary>
        private void cleanInput()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
        }
        /// <summary>
        /// Click event of button that calls the controller to delete a legal manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                Utilities.showErrorMessage("El campo para la cédula es inválido", "Dato inválido");
                txtCedula.Focus();
            }
            else
            {
                List<String> args = new List<string>();
                //@Cedula
                args.Add(txtCedula.Text);
                bool confirm = Utilities.showQuestionMessage("¿Desea eliminar al encargado con cédula " + txtCedula.Text + " de la base de datos?", "Borrar encargado");
                if (confirm)
                {                    
                    int result = legalManagerController.deleteEncargado(args);
                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Operación de borrado exitosa", "Éxito al borrar");
                        Utilities.showWarningMessage("Solo se borrarán los encargados con ningún jugador asociado. Puede que no se hayan realizado cambios", "Borrado de encargado");
                        cleanInput();
                        legalManagerController.filldtgvEncarcado(dtgvEncargados, null);
                    }
                    else
                    {
                        Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al borrar encargado");                        
                    }
                }
            }
        }
        /// <summary>
        /// Click event of button that calls the controller to update a legal manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if ( isOk()) {
                dataTemp.Clear();
                //@NCedula char(9),
                dataTemp.Add(txtCedula.Text);
                //@NNombre varchar(30),	
                dataTemp.Add(txtNombre.Text);
                //@NApellido1 varchar(15),
                dataTemp.Add(txtApellido1.Text);
                //@NApellido2 varchar(15),
                dataTemp.Add(txtApellido2.Text);

                setVisibleBtn(false);
            }
        }
        /// <summary>
        /// Click event of button that calls the controller to show a query of legal managers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> args = new List<string>();
            args.Add(txtCedula.Text);
            args.Add(txtNombre.Text);
            legalManagerController.filldtgvEncarcado(dtgvEncargados, args);
        }
        /// <summary>
        ///  Valida input data
        /// </summary>
        /// <returns></returns>
        private bool isOk()
        {
            bool isOk = true;
            if (txtCedula.Text == "")
            {
                Utilities.showErrorMessage("El campo para la cédula es inválido", "Dato inválido");
                txtCedula.Focus();
                isOk = false;
            }
            else if (txtNombre.Text == "")
            {
                Utilities.showErrorMessage("El campo para el nombre del encargado es inválido", "Dato inválido");
                txtNombre.Focus();
                isOk = false;
            }
            else if (txtApellido1.Text == "")
            {
                Utilities.showErrorMessage("El campo para el primer apellido del encargado es inválido", "Dato inválido");
                txtApellido1.Focus();
                isOk = false;
            }
            else if (txtApellido2.Text == "")
            {
                Utilities.showErrorMessage("El campo para el segundo apellido del encargado es inválido", "Dato inválido");
                txtApellido2.Focus();
                isOk = false;
            }
            return isOk;
        }
        /// <summary>
        /// Click event of button that calls the controller to save updated info of legal managers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (isOk())
            {
                //@NCedula char(9),
                dataTemp.Add(txtCedula.Text);
                //@NNombre varchar(30),	
                dataTemp.Add(txtNombre.Text);
                //@NApellido1 varchar(15),
                dataTemp.Add(txtApellido1.Text);
                //@NApellido2 varchar(15),
                dataTemp.Add(txtApellido2.Text);

                bool confirm = Utilities.showQuestionMessage("¿Desea actualizar al encargado en la base de datos?", "Registrar nuevo encargado");
                if (confirm)
                {
                    int result = legalManagerController.updateEncargado(dataTemp);

                    if (result == 0)
                    {
                        Utilities.showInformationMessage("Encargado actualizado con éxito", "Éxito al actualizar");
                        cleanInput();
                        legalManagerController.filldtgvEncarcado(dtgvEncargados, null);
                    }
                    else
                    {
                        if (result == Utilities.DUPLICATED_KEY)
                        {
                            Utilities.showErrorMessage("El encargado con dicha nueva cédula ya se encuentra registrado en la base de datos", "Error al registrar encargado");
                        }
                        else
                        {
                            Utilities.showErrorMessage("Excepción no controlada número (" + result + ")", "Error al registrar encargado");
                        }
                    }
                    setVisibleBtn(true);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            cleanInput();
            setVisibleBtn(true);
        }
        /// <summary>
        /// Method that show hidden button for update action
        /// </summary>
        /// <param name="visible"> Boolean value to show or hide buttons</param>
        public void setVisibleBtn(bool visible)
        {
            btnBorrar.Visible = visible;
            btnConsultar.Visible = visible;
            btnRegistrar.Visible = visible;
            btnActualizar.Visible = visible;

            dtgvEncargados.Enabled = visible;

            btnGuardar.Visible = !visible;
            btnDescartar.Visible = !visible;
        }
        /// <summary>
        ///  Show help form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.Show();
        }
    }
}
