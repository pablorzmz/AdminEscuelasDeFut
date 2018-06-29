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
            this.menPlayers = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultarEntren = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDatosEncargado = new System.Windows.Forms.GroupBox();
            this.txbCedulaEncargado = new System.Windows.Forms.TextBox();
            this.txbNombreEncargado = new System.Windows.Forms.TextBox();
            this.txbTelefonoDEncargado = new System.Windows.Forms.TextBox();
            this.txbPrimerApellidoEncargado = new System.Windows.Forms.TextBox();
            this.lbTelefonoDEncargado = new System.Windows.Forms.Label();
            this.txbSegundoApellidoEncargado = new System.Windows.Forms.TextBox();
            this.lbNombreDEncargado = new System.Windows.Forms.Label();
            this.lbPrimerApellidoDEncargado = new System.Windows.Forms.Label();
            this.lbSegundoApellidoDEncargado = new System.Windows.Forms.Label();
            this.lbCedulaDEncargado = new System.Windows.Forms.Label();
            this.grbDatosJugador = new System.Windows.Forms.GroupBox();
            this.txbNivel = new System.Windows.Forms.TextBox();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.lbTeléfono = new System.Windows.Forms.Label();
            this.lbNivel = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbSegundoApellido = new System.Windows.Forms.TextBox();
            this.txbPrimerApellido = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbPrimerApellido = new System.Windows.Forms.Label();
            this.lbFechaDeNacimiento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbFechaIngreso = new System.Windows.Forms.Label();
            this.lbNumeroPoliza = new System.Windows.Forms.Label();
            this.txbNumeroPoliza = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menPlayers.SuspendLayout();
            this.grbDatosEncargado.SuspendLayout();
            this.grbDatosJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menPlayers.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menPlayers.Size = new System.Drawing.Size(1061, 28);
            this.menPlayers.TabIndex = 3;
            this.menPlayers.Text = "menuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConsultarEntren});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // menuItemConsultarEntren
            // 
            this.menuItemConsultarEntren.Name = "menuItemConsultarEntren";
            this.menuItemConsultarEntren.Size = new System.Drawing.Size(253, 26);
            this.menuItemConsultarEntren.Text = "Consultar entrenamientos";
            this.menuItemConsultarEntren.Click += new System.EventHandler(this.menuItemConsultarEntren_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // grbDatosEncargado
            // 
            this.grbDatosEncargado.Controls.Add(this.txbCedulaEncargado);
            this.grbDatosEncargado.Controls.Add(this.txbNombreEncargado);
            this.grbDatosEncargado.Controls.Add(this.txbTelefonoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.txbPrimerApellidoEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbTelefonoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.txbSegundoApellidoEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbNombreDEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbPrimerApellidoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbSegundoApellidoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbCedulaDEncargado);
            this.grbDatosEncargado.Location = new System.Drawing.Point(41, 255);
            this.grbDatosEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosEncargado.Name = "grbDatosEncargado";
            this.grbDatosEncargado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosEncargado.Size = new System.Drawing.Size(895, 110);
            this.grbDatosEncargado.TabIndex = 4;
            this.grbDatosEncargado.TabStop = false;
            this.grbDatosEncargado.Text = "Datos Encargado";
            // 
            // txbCedulaEncargado
            // 
            this.txbCedulaEncargado.Location = new System.Drawing.Point(691, 36);
            this.txbCedulaEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCedulaEncargado.Name = "txbCedulaEncargado";
            this.txbCedulaEncargado.Size = new System.Drawing.Size(132, 22);
            this.txbCedulaEncargado.TabIndex = 14;
            // 
            // txbNombreEncargado
            // 
            this.txbNombreEncargado.Location = new System.Drawing.Point(136, 71);
            this.txbNombreEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNombreEncargado.Name = "txbNombreEncargado";
            this.txbNombreEncargado.Size = new System.Drawing.Size(132, 22);
            this.txbNombreEncargado.TabIndex = 15;
            // 
            // txbTelefonoDEncargado
            // 
            this.txbTelefonoDEncargado.Location = new System.Drawing.Point(444, 71);
            this.txbTelefonoDEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTelefonoDEncargado.Name = "txbTelefonoDEncargado";
            this.txbTelefonoDEncargado.Size = new System.Drawing.Size(132, 22);
            this.txbTelefonoDEncargado.TabIndex = 16;
            // 
            // txbPrimerApellidoEncargado
            // 
            this.txbPrimerApellidoEncargado.Location = new System.Drawing.Point(136, 31);
            this.txbPrimerApellidoEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPrimerApellidoEncargado.Name = "txbPrimerApellidoEncargado";
            this.txbPrimerApellidoEncargado.Size = new System.Drawing.Size(132, 22);
            this.txbPrimerApellidoEncargado.TabIndex = 17;
            // 
            // lbTelefonoDEncargado
            // 
            this.lbTelefonoDEncargado.AutoSize = true;
            this.lbTelefonoDEncargado.Location = new System.Drawing.Point(303, 80);
            this.lbTelefonoDEncargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefonoDEncargado.Name = "lbTelefonoDEncargado";
            this.lbTelefonoDEncargado.Size = new System.Drawing.Size(64, 17);
            this.lbTelefonoDEncargado.TabIndex = 10;
            this.lbTelefonoDEncargado.Text = "Teléfono";
            // 
            // txbSegundoApellidoEncargado
            // 
            this.txbSegundoApellidoEncargado.Location = new System.Drawing.Point(444, 36);
            this.txbSegundoApellidoEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSegundoApellidoEncargado.Name = "txbSegundoApellidoEncargado";
            this.txbSegundoApellidoEncargado.Size = new System.Drawing.Size(132, 22);
            this.txbSegundoApellidoEncargado.TabIndex = 11;
            // 
            // lbNombreDEncargado
            // 
            this.lbNombreDEncargado.AutoSize = true;
            this.lbNombreDEncargado.Location = new System.Drawing.Point(19, 80);
            this.lbNombreDEncargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreDEncargado.Name = "lbNombreDEncargado";
            this.lbNombreDEncargado.Size = new System.Drawing.Size(58, 17);
            this.lbNombreDEncargado.TabIndex = 4;
            this.lbNombreDEncargado.Text = "Nombre";
            // 
            // lbPrimerApellidoDEncargado
            // 
            this.lbPrimerApellidoDEncargado.AutoSize = true;
            this.lbPrimerApellidoDEncargado.Location = new System.Drawing.Point(12, 39);
            this.lbPrimerApellidoDEncargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrimerApellidoDEncargado.Name = "lbPrimerApellidoDEncargado";
            this.lbPrimerApellidoDEncargado.Size = new System.Drawing.Size(103, 17);
            this.lbPrimerApellidoDEncargado.TabIndex = 3;
            this.lbPrimerApellidoDEncargado.Text = "Primer Apellido";
            // 
            // lbSegundoApellidoDEncargado
            // 
            this.lbSegundoApellidoDEncargado.AutoSize = true;
            this.lbSegundoApellidoDEncargado.Location = new System.Drawing.Point(303, 39);
            this.lbSegundoApellidoDEncargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSegundoApellidoDEncargado.Name = "lbSegundoApellidoDEncargado";
            this.lbSegundoApellidoDEncargado.Size = new System.Drawing.Size(119, 17);
            this.lbSegundoApellidoDEncargado.TabIndex = 2;
            this.lbSegundoApellidoDEncargado.Text = "Segundo Apellido";
            // 
            // lbCedulaDEncargado
            // 
            this.lbCedulaDEncargado.AutoSize = true;
            this.lbCedulaDEncargado.Location = new System.Drawing.Point(617, 39);
            this.lbCedulaDEncargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCedulaDEncargado.Name = "lbCedulaDEncargado";
            this.lbCedulaDEncargado.Size = new System.Drawing.Size(52, 17);
            this.lbCedulaDEncargado.TabIndex = 1;
            this.lbCedulaDEncargado.Text = "Cédula";
            // 
            // grbDatosJugador
            // 
            this.grbDatosJugador.Controls.Add(this.txbNivel);
            this.grbDatosJugador.Controls.Add(this.dtpFechaDeNacimiento);
            this.grbDatosJugador.Controls.Add(this.rbtnHombre);
            this.grbDatosJugador.Controls.Add(this.rbtnMujer);
            this.grbDatosJugador.Controls.Add(this.lbTeléfono);
            this.grbDatosJugador.Controls.Add(this.lbNivel);
            this.grbDatosJugador.Controls.Add(this.txbTelefono);
            this.grbDatosJugador.Controls.Add(this.txbSegundoApellido);
            this.grbDatosJugador.Controls.Add(this.txbPrimerApellido);
            this.grbDatosJugador.Controls.Add(this.lbSexo);
            this.grbDatosJugador.Controls.Add(this.lbPrimerApellido);
            this.grbDatosJugador.Controls.Add(this.lbFechaDeNacimiento);
            this.grbDatosJugador.Controls.Add(this.label2);
            this.grbDatosJugador.Location = new System.Drawing.Point(41, 98);
            this.grbDatosJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosJugador.Name = "grbDatosJugador";
            this.grbDatosJugador.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosJugador.Size = new System.Drawing.Size(895, 149);
            this.grbDatosJugador.TabIndex = 0;
            this.grbDatosJugador.TabStop = false;
            this.grbDatosJugador.Text = "Datos Jugador";
            // 
            // txbNivel
            // 
            this.txbNivel.Location = new System.Drawing.Point(136, 111);
            this.txbNivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNivel.Name = "txbNivel";
            this.txbNivel.Size = new System.Drawing.Size(132, 22);
            this.txbNivel.TabIndex = 16;
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(452, 74);
            this.dtpFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(127, 22);
            this.dtpFechaDeNacimiento.TabIndex = 15;
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Location = new System.Drawing.Point(699, 31);
            this.rbtnHombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(79, 21);
            this.rbtnHombre.TabIndex = 14;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Location = new System.Drawing.Point(699, 59);
            this.rbtnMujer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(64, 21);
            this.rbtnMujer.TabIndex = 13;
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            // 
            // lbTeléfono
            // 
            this.lbTeléfono.AutoSize = true;
            this.lbTeléfono.Location = new System.Drawing.Point(12, 79);
            this.lbTeléfono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeléfono.Name = "lbTeléfono";
            this.lbTeléfono.Size = new System.Drawing.Size(64, 17);
            this.lbTeléfono.TabIndex = 9;
            this.lbTeléfono.Text = "Teléfono";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Location = new System.Drawing.Point(12, 119);
            this.lbNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(39, 17);
            this.lbNivel.TabIndex = 10;
            this.lbNivel.Text = "Nivel";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(136, 70);
            this.txbTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(132, 22);
            this.txbTelefono.TabIndex = 9;
            // 
            // txbSegundoApellido
            // 
            this.txbSegundoApellido.Location = new System.Drawing.Point(444, 27);
            this.txbSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSegundoApellido.Name = "txbSegundoApellido";
            this.txbSegundoApellido.Size = new System.Drawing.Size(132, 22);
            this.txbSegundoApellido.TabIndex = 10;
            // 
            // txbPrimerApellido
            // 
            this.txbPrimerApellido.Location = new System.Drawing.Point(136, 32);
            this.txbPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPrimerApellido.Name = "txbPrimerApellido";
            this.txbPrimerApellido.Size = new System.Drawing.Size(132, 22);
            this.txbPrimerApellido.TabIndex = 11;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(649, 36);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(39, 17);
            this.lbSexo.TabIndex = 11;
            this.lbSexo.Text = "Sexo";
            // 
            // lbPrimerApellido
            // 
            this.lbPrimerApellido.AutoSize = true;
            this.lbPrimerApellido.Location = new System.Drawing.Point(12, 36);
            this.lbPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrimerApellido.Name = "lbPrimerApellido";
            this.lbPrimerApellido.Size = new System.Drawing.Size(103, 17);
            this.lbPrimerApellido.TabIndex = 0;
            this.lbPrimerApellido.Text = "Primer Apellido";
            // 
            // lbFechaDeNacimiento
            // 
            this.lbFechaDeNacimiento.AutoSize = true;
            this.lbFechaDeNacimiento.Location = new System.Drawing.Point(303, 79);
            this.lbFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaDeNacimiento.Name = "lbFechaDeNacimiento";
            this.lbFechaDeNacimiento.Size = new System.Drawing.Size(139, 17);
            this.lbFechaDeNacimiento.TabIndex = 2;
            this.lbFechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(96, 64);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Location = new System.Drawing.Point(411, 63);
            this.lbCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(52, 17);
            this.lbCedula.TabIndex = 4;
            this.lbCedula.Text = "Cédula";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gold;
            this.btnRegistrar.Location = new System.Drawing.Point(211, 438);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(364, 438);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBorrar.Location = new System.Drawing.Point(513, 438);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Location = new System.Drawing.Point(732, 52);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // txbCedula
            // 
            this.txbCedula.Location = new System.Drawing.Point(485, 55);
            this.txbCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(132, 22);
            this.txbCedula.TabIndex = 12;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(177, 54);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(132, 22);
            this.txbNombre.TabIndex = 13;
            // 
            // lbFechaIngreso
            // 
            this.lbFechaIngreso.AutoSize = true;
            this.lbFechaIngreso.Location = new System.Drawing.Point(344, 396);
            this.lbFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaIngreso.Name = "lbFechaIngreso";
            this.lbFechaIngreso.Size = new System.Drawing.Size(118, 17);
            this.lbFechaIngreso.TabIndex = 14;
            this.lbFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lbNumeroPoliza
            // 
            this.lbNumeroPoliza.AutoSize = true;
            this.lbNumeroPoliza.Location = new System.Drawing.Point(53, 396);
            this.lbNumeroPoliza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumeroPoliza.Name = "lbNumeroPoliza";
            this.lbNumeroPoliza.Size = new System.Drawing.Size(99, 17);
            this.lbNumeroPoliza.TabIndex = 15;
            this.lbNumeroPoliza.Text = "Número póliza";
            // 
            // txbNumeroPoliza
            // 
            this.txbNumeroPoliza.Location = new System.Drawing.Point(177, 388);
            this.txbNumeroPoliza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNumeroPoliza.Name = "txbNumeroPoliza";
            this.txbNumeroPoliza.Size = new System.Drawing.Size(132, 22);
            this.txbNumeroPoliza.TabIndex = 17;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(485, 389);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(127, 22);
            this.dtpFechaIngreso.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 480);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 138);
            this.dataGridView1.TabIndex = 18;
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 633);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txbNumeroPoliza);
            this.Controls.Add(this.lbNumeroPoliza);
            this.Controls.Add(this.lbFechaIngreso);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCedula);
            this.Controls.Add(this.grbDatosJugador);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grbDatosEncargado);
            this.Controls.Add(this.menPlayers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de jugadores";
            this.Load += new System.EventHandler(this.Players_Load);
            this.menPlayers.ResumeLayout(false);
            this.menPlayers.PerformLayout();
            this.grbDatosEncargado.ResumeLayout(false);
            this.grbDatosEncargado.PerformLayout();
            this.grbDatosJugador.ResumeLayout(false);
            this.grbDatosJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.Label lbTeléfono;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbSegundoApellido;
        private System.Windows.Forms.TextBox txbPrimerApellido;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbNivel;
        private System.Windows.Forms.Label lbCedulaDEncargado;
        private System.Windows.Forms.TextBox txbCedulaEncargado;
        private System.Windows.Forms.TextBox txbNombreEncargado;
        private System.Windows.Forms.TextBox txbTelefonoDEncargado;
        private System.Windows.Forms.TextBox txbPrimerApellidoEncargado;
        private System.Windows.Forms.Label lbTelefonoDEncargado;
        private System.Windows.Forms.TextBox txbSegundoApellidoEncargado;
        private System.Windows.Forms.Label lbNombreDEncargado;
        private System.Windows.Forms.Label lbPrimerApellidoDEncargado;
        private System.Windows.Forms.Label lbSegundoApellidoDEncargado;
        private System.Windows.Forms.Label lbFechaIngreso;
        private System.Windows.Forms.Label lbNumeroPoliza;
        private System.Windows.Forms.TextBox txbNumeroPoliza;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}