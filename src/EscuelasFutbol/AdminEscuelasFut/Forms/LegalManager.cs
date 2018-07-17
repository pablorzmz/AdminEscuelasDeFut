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
        public LegalManager()
        {
            InitializeComponent();
            legalManagerController = new C_LegalManager();
        }

        private void LegalManager_Load(object sender, EventArgs e)
        {
            legalManagerController.filldtgvEncarcado(this.dtgvEncargados,null);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender,e);
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void dtgvEncargados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<String> buffer = new List<string>();
            Utilities.readCurrentRowFromDataGridView(dtgvEncargados, e.RowIndex, dtgvEncargados.ColumnCount, buffer);
            txtCedula.Text = buffer[0];
            txtNombre.Text = buffer[1];
            txtApellido1.Text = buffer[2];
            txtApellido2.Text = buffer[3];
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        private void cleanInput()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
        }

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

        private void btnActualizar_Click(object sender, EventArgs e)
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
                //@NCedula char(9),
                args.Add(txtCedula.Text);
                //@NNombre varchar(30),	
                args.Add(txtNombre.Text);
                //@NApellido1 varchar(15),
                args.Add(txtApellido1.Text);
                //@NApellido2 varchar(15),
                args.Add(txtApellido2.Text);

                /*Gerald estos valores que empiezan con V son los viejos*/
                //@VCedula char(9),
                //@VNombre varchar(30),
                //@VApellido1 varchar(15),
                //@VApellido2 varchar(15)

                bool confirm = Utilities.showQuestionMessage("¿Desea actualizar al encargado en la base de datos?", "Registrar nuevo encargado");
                if (confirm)
                {
                    int result = legalManagerController.updateEncargado(args);

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
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> args = new List<string>();
            args.Add(txtCedula.Text);
            args.Add(txtNombre.Text);
            legalManagerController.filldtgvEncarcado(dtgvEncargados, args);
        }
    }
}
