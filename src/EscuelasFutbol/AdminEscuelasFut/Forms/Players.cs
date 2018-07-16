using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdminEscuelasFut
{    
    public partial class Players : Form
    {
        private PlayerTrainnings playerTrainingsTool;
        private C_Players playerController;
        private String sexValue;
        private DataGridViewRow currentRow;
        public Players()
        {
            InitializeComponent();
            playerController = new C_Players();
            sexValue = "m";
            currentRow = null;
        }

        public void showPlayersTraingins()
        {
            playerTrainingsTool = new PlayerTrainnings();            
            playerTrainingsTool.setCurrentArgs(txbCedula.Text, cboEscuelas.SelectedItem.ToString());
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
            playerController.fillComboBoxCedulasEncargado(this.cboCedulasEncargado);
            playerController.fillPlayerDataGridView( dgtvPlayersInfo, null );

            dgtvPlayersInfo.Columns[6].Visible = false;
            dgtvPlayersInfo.Columns[7].Visible = false;
            dgtvPlayersInfo.Columns[10].Visible = false;
            dgtvPlayersInfo.Columns[11].Visible = false;
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
        private void cleanInput()
        {
            txbCedula.Text = "";
            txtCedulaEncargado.Text = "";
            txbNombre.Text = "";
            txbPrimerApellidoJug.Text = "";
            txbSegundoApellidoJug.Text = "";
            txbTelefonoJug1.Text = "";
            txbTelefonoJug2.Text = "";
            txbNombreEncargado.Text = "";
            txbPrimerApellidoEncargado.Text = "";
            txbSegundoApellidoEncargado.Text = "";
            txbSegundoApellidoEncargado.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /*Asumiento que ya el ususario confirmo que quiere actualizar la información*/
            /*Y se validó que todo sea del mismo tamaño que debería ser*/
            if (cboEscuelas.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar una escuela válida");
                cboEscuelas.Focus();
            }
            else if (cboNiveles.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar un nivel válido");
                cboNiveles.Focus();
            }
            else if (txbCedula.Text == "")
            {
                MessageBox.Show("Número de cédula Jugador inválido");
                txbCedula.Focus();
            }
            else if (txtCedulaEncargado.Text == "")
            {
                MessageBox.Show("Número de cédula de encargado inválido");
                txtCedulaEncargado.Focus();
            }            
            else if (dgtvPlayersInfo.Rows.Count == 0 || currentRow == null)
            {
                MessageBox.Show("Debe consultar al menos un dato del la tabla de registro para actualizar");
            }
            else
            {
                if (currentRow != null)
                {
                    /*Y que el nombre de la escuela no sea item 0 ni nivel item 0*/
                    List<String> args = new List<string>();
                    //"@NuevaCedJugador"
                    args.Add(txbCedula.Text);
                    //"@ViejaCedJugador"
                    args.Add(currentRow.Cells["N° Cédula"].Value.ToString());
                    //"@Edad"
                    DateTime currentTime = DateTime.Now;
                    int edad = currentTime.Year - dtpFechaDeNacimiento.Value.Year;
                    args.Add(edad.ToString());
                    //"@Sexo"
                    args.Add(sexValue);
                    //"@FechaNacimiento"
                    args.Add(dtpFechaDeNacimiento.Value.ToString("yyyy-MM-dd"));
                    //"@NuevaCedEncargado"
                    args.Add(txtCedulaEncargado.Text);
                    //"@ViejaCedEncargado"
                    // args.Add(currentRow.Cells["N° Cédula Encargado"].Value.ToString());
                    //"@FechaIngreso"
                    args.Add(dtpFechaIngreso.Value.ToString("yyyy-MM-dd"));
                    //"@NombreJug"
                    args.Add(txbNombre.Text);
                    //"@Apellido1Jug"
                    args.Add(txbPrimerApellidoJug.Text);
                    //"@Apellido2Jug"
                    args.Add(txbSegundoApellidoJug.Text);
                    //"@NombreEncargado"
                    args.Add(txbNombreEncargado.Text);
                    //"@Apellido1Encar"
                    args.Add(txbPrimerApellidoEncargado.Text);
                    //"@Apellido2Encar"
                    args.Add(txbSegundoApellidoEncargado.Text);
                    //"@NomEscuela"
                    args.Add(cboEscuelas.SelectedItem.ToString());
                    //"@Nivel"
                    args.Add(cboNiveles.SelectedItem.ToString());
                    //"@NuevoTelefono1Jugador"
                    args.Add(txbTelefonoJug1.Text);
                    //"@NuevoTelefono2Jugador"
                    args.Add(txbTelefonoJug2.Text);
                    int result = playerController.updatePlayerInformaction(args);
                    if (result == 0)
                    {
                        MessageBox.Show("Actualización Exitosa");
                        currentRow = null;
                        cleanInput();
                        playerController.fillPlayerDataGridView(dgtvPlayersInfo, null);
                    }
                    else
                    {
                        MessageBox.Show("Error número: " + result.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Para actualizar debe seleccionar una fila de tabla de jugadores");
                }
            }
        }

        private void dgtvPlayersInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cleanInput();
            if (e.RowIndex >= 0 && e.RowIndex < dgtvPlayersInfo.RowCount)
            {
                List<String> buffer = new List<string>();
                currentRow = dgtvPlayersInfo.Rows[e.RowIndex];
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
                cboCedulasEncargado.SelectedItem = txtCedulaEncargado.Text;
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

        private void cboCedulasEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCedulasEncargado.SelectedIndex != 0)
            {
                txtCedulaEncargado.Text = cboCedulasEncargado.SelectedItem.ToString();
                playerController.fillEncargadoInfo(txtCedulaEncargado.Text,txbNombreEncargado,txbPrimerApellidoEncargado,txbSegundoApellidoEncargado);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txbCedula.Text == "")
            {
                MessageBox.Show("El valor para la cédula del jugador es inválido");
                txbCedula.Focus();
            }
            else if (txbNombre.Text == "")
            {
                MessageBox.Show("El valor para el Nombre del jugador es inválido");
                txbNombre.Focus();
            }
            else if (txbPrimerApellidoJug.Text == "")
            {
                MessageBox.Show("El valor para el primer apellido del jugador es inválido");
                txbPrimerApellidoJug.Focus();
            }
            else if (txbSegundoApellidoJug.Text == "")
            {
                MessageBox.Show("El valor para el segundo apellido del jugador es inválido");
                txbSegundoApellidoJug.Focus();
            }
            else if (cboEscuelas.SelectedIndex == 0)
            {
                MessageBox.Show("El valor para la escuela del jugador es inválido");
                cboEscuelas.Focus();
            }
            else if (txtCedulaEncargado.Text == "")
            {
                MessageBox.Show("El valor para la cédula del encargado es inválido");
                txtCedulaEncargado.Focus();
            }
            else if (txbPrimerApellidoEncargado.Text == "")
            {
                MessageBox.Show("El valor para el primer apellido del encargado es inválido");
                txbPrimerApellidoEncargado.Focus();
            }
            else if (txbSegundoApellidoEncargado.Text == "")
            {
                MessageBox.Show("El valor para el segundo apellido del encargado es inválido");
                txbSegundoApellidoEncargado.Focus();
            }
            else
            {
                MessageBox.Show("Datos válidos");
                List<String> args = new List<string>();
                //@nombreJ
                args.Add(txbNombre.Text);
                //,@Apellido1J
                args.Add(txbPrimerApellidoJug.Text);
                //,@tel1J
                args.Add(txbTelefonoJug1.Text);
                //,@tel2J
                args.Add(txbTelefonoJug2.Text);
                //,@cedulaJ
                args.Add(txbCedula.Text);
                //,@Apellido2J
                args.Add(txbSegundoApellidoJug.Text);
                //,@fechaNac
                args.Add(dtpFechaDeNacimiento.Value.ToString("yyyy-MM-dd"));
                //,@sexo
                args.Add(sexValue);
                //,@escuela
                args.Add(cboEscuelas.SelectedItem.ToString());
                //,@nombreE
                args.Add(txbNombreEncargado.Text);
                //,@Apellido1E
                args.Add(txbPrimerApellidoEncargado.Text);
                //,@fechaIngreso
                args.Add(dtpFechaIngreso.Value.ToString("yyyy-MM-dd"));
                //,@cedulaE
                args.Add(txtCedulaEncargado.Text);
                //,@Apellido2E
                args.Add(txbSegundoApellidoEncargado.Text);

                int result = playerController.insertNewPlayer(args);

                if (result == 0)
                {
                    MessageBox.Show("Jugador registrado con éxito");
                    cleanInput();
                    playerController.fillPlayerDataGridView(dgtvPlayersInfo, null);
                }
                else
                {
                    MessageBox.Show("Error(" + result + ") al registrar el jugador");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txbCedula.Text == "")
            {
                MessageBox.Show("Valor para la cédula del jugador invalida");
            }
            else
            {
                List<String> args = new List<string>();
                args.Add(txbCedula.Text);
                int result = playerController.deletePlayer(args);
                if (result == 0)
                {
                    MessageBox.Show("Jugador borrado con éxito");
                    cleanInput();
                    playerController.fillPlayerDataGridView(dgtvPlayersInfo, null);
                }
                else
                {
                    MessageBox.Show("Error al borrar el jugador");
                }
            }
        }
    }
}

