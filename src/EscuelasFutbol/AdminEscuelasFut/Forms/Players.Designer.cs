namespace AdminEscuelasFut
{
    partial class Players
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Players));
            this.menPlayers = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultarEntren = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEncargadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDatosEncargado = new System.Windows.Forms.GroupBox();
            this.cboCedulasEncargado = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txbPrimerApellidoEncargado = new System.Windows.Forms.TextBox();
            this.lbFechaIngreso = new System.Windows.Forms.Label();
            this.lbSegundoApellidoDEncargado = new System.Windows.Forms.Label();
            this.txtCedulaEncargado = new System.Windows.Forms.TextBox();
            this.txbNombreEncargado = new System.Windows.Forms.TextBox();
            this.lbPrimerApellidoDEncargado = new System.Windows.Forms.Label();
            this.txbSegundoApellidoEncargado = new System.Windows.Forms.TextBox();
            this.lbNombreDEncargado = new System.Windows.Forms.Label();
            this.lbCedulaDEncargado = new System.Windows.Forms.Label();
            this.grbDatosJugador = new System.Windows.Forms.GroupBox();
            this.cboEscuelas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTelefonoJug2 = new System.Windows.Forms.TextBox();
            this.cboNiveles = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.lbTeléfono = new System.Windows.Forms.Label();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbNivel = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.txbTelefonoJug1 = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txbSegundoApellidoJug = new System.Windows.Forms.TextBox();
            this.txbPrimerApellidoJug = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbPrimerApellido = new System.Windows.Forms.Label();
            this.lbFechaDeNacimiento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgtvPlayersInfo = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.menPlayers.SuspendLayout();
            this.grbDatosEncargado.SuspendLayout();
            this.grbDatosJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvPlayersInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menPlayers
            // 
            this.menPlayers.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menPlayers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menPlayers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menPlayers.Location = new System.Drawing.Point(0, 0);
            this.menPlayers.Name = "menPlayers";
            this.menPlayers.Size = new System.Drawing.Size(690, 24);
            this.menPlayers.TabIndex = 3;
            this.menPlayers.Text = "menuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConsultarEntren,
            this.consultarEncargadosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // menuItemConsultarEntren
            // 
            this.menuItemConsultarEntren.BackColor = System.Drawing.Color.AliceBlue;
            this.menuItemConsultarEntren.Name = "menuItemConsultarEntren";
            this.menuItemConsultarEntren.Size = new System.Drawing.Size(211, 22);
            this.menuItemConsultarEntren.Text = "Consultar entrenamientos";
            this.menuItemConsultarEntren.Click += new System.EventHandler(this.menuItemConsultarEntren_Click);
            // 
            // consultarEncargadosToolStripMenuItem
            // 
            this.consultarEncargadosToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.consultarEncargadosToolStripMenuItem.Name = "consultarEncargadosToolStripMenuItem";
            this.consultarEncargadosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.consultarEncargadosToolStripMenuItem.Text = "Consultar encargados";
            this.consultarEncargadosToolStripMenuItem.Click += new System.EventHandler(this.consultarEncargadosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // grbDatosEncargado
            // 
            this.grbDatosEncargado.Controls.Add(this.cboCedulasEncargado);
            this.grbDatosEncargado.Controls.Add(this.dtpFechaIngreso);
            this.grbDatosEncargado.Controls.Add(this.txbPrimerApellidoEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbFechaIngreso);
            this.grbDatosEncargado.Controls.Add(this.lbSegundoApellidoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.txtCedulaEncargado);
            this.grbDatosEncargado.Controls.Add(this.txbNombreEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbPrimerApellidoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.txbSegundoApellidoEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbNombreDEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbCedulaDEncargado);
            this.grbDatosEncargado.Location = new System.Drawing.Point(14, 223);
            this.grbDatosEncargado.Name = "grbDatosEncargado";
            this.grbDatosEncargado.Size = new System.Drawing.Size(671, 114);
            this.grbDatosEncargado.TabIndex = 4;
            this.grbDatosEncargado.TabStop = false;
            this.grbDatosEncargado.Text = "Datos del encargado";
            // 
            // cboCedulasEncargado
            // 
            this.cboCedulasEncargado.BackColor = System.Drawing.Color.AliceBlue;
            this.cboCedulasEncargado.FormattingEnabled = true;
            this.cboCedulasEncargado.Location = new System.Drawing.Point(541, 18);
            this.cboCedulasEncargado.Name = "cboCedulasEncargado";
            this.cboCedulasEncargado.Size = new System.Drawing.Size(122, 21);
            this.cboCedulasEncargado.TabIndex = 24;
            this.cboCedulasEncargado.SelectedIndexChanged += new System.EventHandler(this.cboCedulasEncargado_SelectedIndexChanged);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(110, 80);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(238, 20);
            this.dtpFechaIngreso.TabIndex = 16;
            // 
            // txbPrimerApellidoEncargado
            // 
            this.txbPrimerApellidoEncargado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbPrimerApellidoEncargado.Location = new System.Drawing.Point(89, 51);
            this.txbPrimerApellidoEncargado.MaxLength = 15;
            this.txbPrimerApellidoEncargado.Name = "txbPrimerApellidoEncargado";
            this.txbPrimerApellidoEncargado.ReadOnly = true;
            this.txbPrimerApellidoEncargado.Size = new System.Drawing.Size(259, 20);
            this.txbPrimerApellidoEncargado.TabIndex = 14;
            this.txbPrimerApellidoEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerApellidoEncargado_KeyPress);
            // 
            // lbFechaIngreso
            // 
            this.lbFechaIngreso.AutoSize = true;
            this.lbFechaIngreso.Location = new System.Drawing.Point(14, 84);
            this.lbFechaIngreso.Name = "lbFechaIngreso";
            this.lbFechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lbFechaIngreso.TabIndex = 14;
            this.lbFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lbSegundoApellidoDEncargado
            // 
            this.lbSegundoApellidoDEncargado.AutoSize = true;
            this.lbSegundoApellidoDEncargado.Location = new System.Drawing.Point(365, 50);
            this.lbSegundoApellidoDEncargado.Name = "lbSegundoApellidoDEncargado";
            this.lbSegundoApellidoDEncargado.Size = new System.Drawing.Size(90, 13);
            this.lbSegundoApellidoDEncargado.TabIndex = 19;
            this.lbSegundoApellidoDEncargado.Text = "Segundo Apellido";
            // 
            // txtCedulaEncargado
            // 
            this.txtCedulaEncargado.BackColor = System.Drawing.Color.White;
            this.txtCedulaEncargado.Location = new System.Drawing.Point(406, 19);
            this.txtCedulaEncargado.MaxLength = 9;
            this.txtCedulaEncargado.Name = "txtCedulaEncargado";
            this.txtCedulaEncargado.ReadOnly = true;
            this.txtCedulaEncargado.Size = new System.Drawing.Size(131, 20);
            this.txtCedulaEncargado.TabIndex = 13;
            this.txtCedulaEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaEncargado_KeyPress);
            // 
            // txbNombreEncargado
            // 
            this.txbNombreEncargado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbNombreEncargado.Location = new System.Drawing.Point(89, 22);
            this.txbNombreEncargado.MaxLength = 30;
            this.txbNombreEncargado.Name = "txbNombreEncargado";
            this.txbNombreEncargado.ReadOnly = true;
            this.txbNombreEncargado.Size = new System.Drawing.Size(258, 20);
            this.txbNombreEncargado.TabIndex = 12;
            this.txbNombreEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombreEncargado_KeyPress);
            // 
            // lbPrimerApellidoDEncargado
            // 
            this.lbPrimerApellidoDEncargado.AutoSize = true;
            this.lbPrimerApellidoDEncargado.Location = new System.Drawing.Point(14, 54);
            this.lbPrimerApellidoDEncargado.Name = "lbPrimerApellidoDEncargado";
            this.lbPrimerApellidoDEncargado.Size = new System.Drawing.Size(76, 13);
            this.lbPrimerApellidoDEncargado.TabIndex = 20;
            this.lbPrimerApellidoDEncargado.Text = "Primer Apellido";
            // 
            // txbSegundoApellidoEncargado
            // 
            this.txbSegundoApellidoEncargado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbSegundoApellidoEncargado.Location = new System.Drawing.Point(461, 47);
            this.txbSegundoApellidoEncargado.MaxLength = 15;
            this.txbSegundoApellidoEncargado.Name = "txbSegundoApellidoEncargado";
            this.txbSegundoApellidoEncargado.ReadOnly = true;
            this.txbSegundoApellidoEncargado.Size = new System.Drawing.Size(201, 20);
            this.txbSegundoApellidoEncargado.TabIndex = 15;
            this.txbSegundoApellidoEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelefonoDEncargado_KeyPress);
            // 
            // lbNombreDEncargado
            // 
            this.lbNombreDEncargado.AutoSize = true;
            this.lbNombreDEncargado.Location = new System.Drawing.Point(14, 25);
            this.lbNombreDEncargado.Name = "lbNombreDEncargado";
            this.lbNombreDEncargado.Size = new System.Drawing.Size(44, 13);
            this.lbNombreDEncargado.TabIndex = 4;
            this.lbNombreDEncargado.Text = "Nombre";
            // 
            // lbCedulaDEncargado
            // 
            this.lbCedulaDEncargado.AutoSize = true;
            this.lbCedulaDEncargado.Location = new System.Drawing.Point(366, 21);
            this.lbCedulaDEncargado.Name = "lbCedulaDEncargado";
            this.lbCedulaDEncargado.Size = new System.Drawing.Size(40, 13);
            this.lbCedulaDEncargado.TabIndex = 1;
            this.lbCedulaDEncargado.Text = "Cédula";
            // 
            // grbDatosJugador
            // 
            this.grbDatosJugador.AutoSize = true;
            this.grbDatosJugador.Controls.Add(this.cboEscuelas);
            this.grbDatosJugador.Controls.Add(this.label3);
            this.grbDatosJugador.Controls.Add(this.label1);
            this.grbDatosJugador.Controls.Add(this.txbTelefonoJug2);
            this.grbDatosJugador.Controls.Add(this.cboNiveles);
            this.grbDatosJugador.Controls.Add(this.dtpFechaDeNacimiento);
            this.grbDatosJugador.Controls.Add(this.rbtnHombre);
            this.grbDatosJugador.Controls.Add(this.rbtnMujer);
            this.grbDatosJugador.Controls.Add(this.lbTeléfono);
            this.grbDatosJugador.Controls.Add(this.txbCedula);
            this.grbDatosJugador.Controls.Add(this.txbNombre);
            this.grbDatosJugador.Controls.Add(this.lbNivel);
            this.grbDatosJugador.Controls.Add(this.lbCedula);
            this.grbDatosJugador.Controls.Add(this.txbTelefonoJug1);
            this.grbDatosJugador.Controls.Add(this.lbNombre);
            this.grbDatosJugador.Controls.Add(this.txbSegundoApellidoJug);
            this.grbDatosJugador.Controls.Add(this.txbPrimerApellidoJug);
            this.grbDatosJugador.Controls.Add(this.lbSexo);
            this.grbDatosJugador.Controls.Add(this.lbPrimerApellido);
            this.grbDatosJugador.Controls.Add(this.lbFechaDeNacimiento);
            this.grbDatosJugador.Controls.Add(this.label2);
            this.grbDatosJugador.Location = new System.Drawing.Point(12, 36);
            this.grbDatosJugador.Name = "grbDatosJugador";
            this.grbDatosJugador.Size = new System.Drawing.Size(674, 188);
            this.grbDatosJugador.TabIndex = 0;
            this.grbDatosJugador.TabStop = false;
            this.grbDatosJugador.Text = "Datos personales del jugador";
            // 
            // cboEscuelas
            // 
            this.cboEscuelas.BackColor = System.Drawing.Color.AliceBlue;
            this.cboEscuelas.FormattingEnabled = true;
            this.cboEscuelas.Location = new System.Drawing.Point(480, 140);
            this.cboEscuelas.Name = "cboEscuelas";
            this.cboEscuelas.Size = new System.Drawing.Size(185, 21);
            this.cboEscuelas.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Escuela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Teléfono 2";
            // 
            // txbTelefonoJug2
            // 
            this.txbTelefonoJug2.Location = new System.Drawing.Point(92, 109);
            this.txbTelefonoJug2.MaxLength = 8;
            this.txbTelefonoJug2.Name = "txbTelefonoJug2";
            this.txbTelefonoJug2.Size = new System.Drawing.Size(256, 20);
            this.txbTelefonoJug2.TabIndex = 7;
            this.txbTelefonoJug2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelefonoJug2_KeyPress);
            // 
            // cboNiveles
            // 
            this.cboNiveles.BackColor = System.Drawing.Color.AliceBlue;
            this.cboNiveles.FormattingEnabled = true;
            this.cboNiveles.Location = new System.Drawing.Point(92, 140);
            this.cboNiveles.Name = "cboNiveles";
            this.cboNiveles.Size = new System.Drawing.Size(258, 21);
            this.cboNiveles.TabIndex = 10;
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(480, 83);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(185, 20);
            this.dtpFechaDeNacimiento.TabIndex = 6;
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Checked = true;
            this.rbtnHombre.Location = new System.Drawing.Point(480, 116);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnHombre.TabIndex = 8;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            this.rbtnHombre.CheckedChanged += new System.EventHandler(this.rbtnHombre_CheckedChanged);
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Location = new System.Drawing.Point(548, 116);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtnMujer.TabIndex = 9;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.CheckedChanged += new System.EventHandler(this.rbtnMujer_CheckedChanged);
            // 
            // lbTeléfono
            // 
            this.lbTeléfono.AutoSize = true;
            this.lbTeléfono.Location = new System.Drawing.Point(14, 87);
            this.lbTeléfono.Name = "lbTeléfono";
            this.lbTeléfono.Size = new System.Drawing.Size(58, 13);
            this.lbTeléfono.TabIndex = 9;
            this.lbTeléfono.Text = "Teléfono 1";
            // 
            // txbCedula
            // 
            this.txbCedula.Location = new System.Drawing.Point(480, 31);
            this.txbCedula.MaxLength = 9;
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(185, 20);
            this.txbCedula.TabIndex = 2;
            this.txbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCedula_KeyPress);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(92, 31);
            this.txbNombre.MaxLength = 30;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(256, 20);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombre_KeyPress);
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Location = new System.Drawing.Point(16, 143);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(31, 13);
            this.lbNivel.TabIndex = 10;
            this.lbNivel.Text = "Nivel";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Location = new System.Drawing.Point(368, 34);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(40, 13);
            this.lbCedula.TabIndex = 4;
            this.lbCedula.Text = "Cédula";
            // 
            // txbTelefonoJug1
            // 
            this.txbTelefonoJug1.Location = new System.Drawing.Point(92, 83);
            this.txbTelefonoJug1.MaxLength = 8;
            this.txbTelefonoJug1.Name = "txbTelefonoJug1";
            this.txbTelefonoJug1.Size = new System.Drawing.Size(256, 20);
            this.txbTelefonoJug1.TabIndex = 5;
            this.txbTelefonoJug1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelefonoJug1_KeyPress);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(14, 34);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // txbSegundoApellidoJug
            // 
            this.txbSegundoApellidoJug.Location = new System.Drawing.Point(480, 57);
            this.txbSegundoApellidoJug.MaxLength = 15;
            this.txbSegundoApellidoJug.Name = "txbSegundoApellidoJug";
            this.txbSegundoApellidoJug.Size = new System.Drawing.Size(185, 20);
            this.txbSegundoApellidoJug.TabIndex = 4;
            this.txbSegundoApellidoJug.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSegundoApellido_KeyPress);
            // 
            // txbPrimerApellidoJug
            // 
            this.txbPrimerApellidoJug.Location = new System.Drawing.Point(92, 57);
            this.txbPrimerApellidoJug.MaxLength = 15;
            this.txbPrimerApellidoJug.Name = "txbPrimerApellidoJug";
            this.txbPrimerApellidoJug.Size = new System.Drawing.Size(257, 20);
            this.txbPrimerApellidoJug.TabIndex = 3;
            this.txbPrimerApellidoJug.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerApellido_KeyPress);
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(370, 116);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(31, 13);
            this.lbSexo.TabIndex = 11;
            this.lbSexo.Text = "Sexo";
            // 
            // lbPrimerApellido
            // 
            this.lbPrimerApellido.AutoSize = true;
            this.lbPrimerApellido.Location = new System.Drawing.Point(14, 61);
            this.lbPrimerApellido.Name = "lbPrimerApellido";
            this.lbPrimerApellido.Size = new System.Drawing.Size(76, 13);
            this.lbPrimerApellido.TabIndex = 0;
            this.lbPrimerApellido.Text = "Primer Apellido";
            // 
            // lbFechaDeNacimiento
            // 
            this.lbFechaDeNacimiento.AutoSize = true;
            this.lbFechaDeNacimiento.Location = new System.Drawing.Point(365, 90);
            this.lbFechaDeNacimiento.Name = "lbFechaDeNacimiento";
            this.lbFechaDeNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lbFechaDeNacimiento.TabIndex = 2;
            this.lbFechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Apellido";
            // 
            // dgtvPlayersInfo
            // 
            this.dgtvPlayersInfo.AllowUserToAddRows = false;
            this.dgtvPlayersInfo.AllowUserToDeleteRows = false;
            this.dgtvPlayersInfo.AllowUserToResizeColumns = false;
            this.dgtvPlayersInfo.AllowUserToResizeRows = false;
            this.dgtvPlayersInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgtvPlayersInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtvPlayersInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgtvPlayersInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgtvPlayersInfo.Location = new System.Drawing.Point(0, 371);
            this.dgtvPlayersInfo.Name = "dgtvPlayersInfo";
            this.dgtvPlayersInfo.Size = new System.Drawing.Size(690, 199);
            this.dgtvPlayersInfo.TabIndex = 18;
            this.dgtvPlayersInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgtvPlayersInfo_CellMouseDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::AdminEscuelasFut.Properties.Resources.icon_save;
            this.btnGuardar.Location = new System.Drawing.Point(414, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 28);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDescartar
            // 
            this.btnDescartar.BackColor = System.Drawing.Color.Transparent;
            this.btnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescartar.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnDescartar.FlatAppearance.BorderSize = 0;
            this.btnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.Image = global::AdminEscuelasFut.Properties.Resources.icons_discard;
            this.btnDescartar.Location = new System.Drawing.Point(503, 337);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(83, 28);
            this.btnDescartar.TabIndex = 19;
            this.btnDescartar.UseVisualStyleBackColor = false;
            this.btnDescartar.Visible = false;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = global::AdminEscuelasFut.Properties.Resources.icon_find;
            this.btnConsultar.Location = new System.Drawing.Point(503, 337);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 28);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Image = global::AdminEscuelasFut.Properties.Resources.icon_add;
            this.btnRegistrar.Location = new System.Drawing.Point(325, 337);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(83, 28);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = global::AdminEscuelasFut.Properties.Resources.icon_edit;
            this.btnActualizar.Location = new System.Drawing.Point(414, 338);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(83, 28);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Image = global::AdminEscuelasFut.Properties.Resources.icon_delete;
            this.btnBorrar.Location = new System.Drawing.Point(592, 337);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(83, 28);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(690, 570);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgtvPlayersInfo);
            this.Controls.Add(this.grbDatosJugador);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.grbDatosEncargado);
            this.Controls.Add(this.menPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Jugadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Players_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Players_FormClosed);
            this.Load += new System.EventHandler(this.Players_Load);
            this.menPlayers.ResumeLayout(false);
            this.menPlayers.PerformLayout();
            this.grbDatosEncargado.ResumeLayout(false);
            this.grbDatosEncargado.PerformLayout();
            this.grbDatosJugador.ResumeLayout(false);
            this.grbDatosJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvPlayersInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menPlayers;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemConsultarEntren;
        private System.Windows.Forms.GroupBox grbDatosEncargado;
        private System.Windows.Forms.GroupBox grbDatosJugador;
        private System.Windows.Forms.Label lbPrimerApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFechaDeNacimiento;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.Label lbTeléfono;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.TextBox txbTelefonoJug1;
        private System.Windows.Forms.TextBox txbSegundoApellidoJug;
        private System.Windows.Forms.TextBox txbPrimerApellidoJug;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbCedulaDEncargado;
        private System.Windows.Forms.TextBox txtCedulaEncargado;
        private System.Windows.Forms.TextBox txbNombreEncargado;
        private System.Windows.Forms.TextBox txbSegundoApellidoEncargado;
        private System.Windows.Forms.Label lbNombreDEncargado;
        private System.Windows.Forms.Label lbFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DataGridView dgtvPlayersInfo;
        private System.Windows.Forms.TextBox txbPrimerApellidoEncargado;
        private System.Windows.Forms.Label lbSegundoApellidoDEncargado;
        private System.Windows.Forms.Label lbPrimerApellidoDEncargado;
        private System.Windows.Forms.ComboBox cboNiveles;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTelefonoJug2;
        private System.Windows.Forms.ComboBox cboEscuelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCedulasEncargado;
        private System.Windows.Forms.ToolStripMenuItem consultarEncargadosToolStripMenuItem;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnGuardar;
    }
}