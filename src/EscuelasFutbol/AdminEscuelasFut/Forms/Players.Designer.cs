﻿namespace AdminEscuelasFut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Players));
            this.menPlayers = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConsultarEntren = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDatosEncargado = new System.Windows.Forms.GroupBox();
            this.txbSegundoApellidoEncargado = new System.Windows.Forms.TextBox();
            this.btnConsultarCedEncar = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txbPrimerApellidoEncargado = new System.Windows.Forms.TextBox();
            this.lbFechaIngreso = new System.Windows.Forms.Label();
            this.lbSegundoApellidoDEncargado = new System.Windows.Forms.Label();
            this.txtCedulaEncargado = new System.Windows.Forms.TextBox();
            this.txbNombreEncargado = new System.Windows.Forms.TextBox();
            this.lbPrimerApellidoDEncargado = new System.Windows.Forms.Label();
            this.lbTelefonoDEncargado = new System.Windows.Forms.Label();
            this.txbTelefonoDEncargado = new System.Windows.Forms.TextBox();
            this.lbNombreDEncargado = new System.Windows.Forms.Label();
            this.lbCedulaDEncargado = new System.Windows.Forms.Label();
            this.grbDatosJugador = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txbNumeroPoliza = new System.Windows.Forms.TextBox();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.lbNumeroPoliza = new System.Windows.Forms.Label();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.lbTeléfono = new System.Windows.Forms.Label();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbNivel = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txbSegundoApellido = new System.Windows.Forms.TextBox();
            this.txbPrimerApellido = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbPrimerApellido = new System.Windows.Forms.Label();
            this.lbFechaDeNacimiento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
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
            this.menPlayers.Size = new System.Drawing.Size(691, 24);
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConsultarEntren});
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
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // grbDatosEncargado
            // 
            this.grbDatosEncargado.Controls.Add(this.txbSegundoApellidoEncargado);
            this.grbDatosEncargado.Controls.Add(this.btnConsultarCedEncar);
            this.grbDatosEncargado.Controls.Add(this.dtpFechaIngreso);
            this.grbDatosEncargado.Controls.Add(this.txbPrimerApellidoEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbFechaIngreso);
            this.grbDatosEncargado.Controls.Add(this.lbSegundoApellidoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.txtCedulaEncargado);
            this.grbDatosEncargado.Controls.Add(this.txbNombreEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbPrimerApellidoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbTelefonoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.txbTelefonoDEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbNombreDEncargado);
            this.grbDatosEncargado.Controls.Add(this.lbCedulaDEncargado);
            this.grbDatosEncargado.Location = new System.Drawing.Point(14, 223);
            this.grbDatosEncargado.Name = "grbDatosEncargado";
            this.grbDatosEncargado.Size = new System.Drawing.Size(671, 114);
            this.grbDatosEncargado.TabIndex = 4;
            this.grbDatosEncargado.TabStop = false;
            this.grbDatosEncargado.Text = "Datos del encargado";
            // 
            // txbSegundoApellidoEncargado
            // 
            this.txbSegundoApellidoEncargado.Location = new System.Drawing.Point(64, 77);
            this.txbSegundoApellidoEncargado.Name = "txbSegundoApellidoEncargado";
            this.txbSegundoApellidoEncargado.Size = new System.Drawing.Size(284, 20);
            this.txbSegundoApellidoEncargado.TabIndex = 21;
            this.txbSegundoApellidoEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConsultarCedEncar
            // 
            this.btnConsultarCedEncar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultarCedEncar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarCedEncar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultarCedEncar.FlatAppearance.BorderSize = 0;
            this.btnConsultarCedEncar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultarCedEncar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCedEncar.Location = new System.Drawing.Point(559, 18);
            this.btnConsultarCedEncar.Name = "btnConsultarCedEncar";
            this.btnConsultarCedEncar.Size = new System.Drawing.Size(104, 20);
            this.btnConsultarCedEncar.TabIndex = 18;
            this.btnConsultarCedEncar.Text = "Buscar cédula";
            this.btnConsultarCedEncar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(464, 76);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(201, 20);
            this.dtpFechaIngreso.TabIndex = 17;
            // 
            // txbPrimerApellidoEncargado
            // 
            this.txbPrimerApellidoEncargado.Location = new System.Drawing.Point(89, 51);
            this.txbPrimerApellidoEncargado.Name = "txbPrimerApellidoEncargado";
            this.txbPrimerApellidoEncargado.Size = new System.Drawing.Size(259, 20);
            this.txbPrimerApellidoEncargado.TabIndex = 22;
            this.txbPrimerApellidoEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbFechaIngreso
            // 
            this.lbFechaIngreso.AutoSize = true;
            this.lbFechaIngreso.Location = new System.Drawing.Point(368, 77);
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
            this.txtCedulaEncargado.Location = new System.Drawing.Point(409, 18);
            this.txtCedulaEncargado.Name = "txtCedulaEncargado";
            this.txtCedulaEncargado.Size = new System.Drawing.Size(144, 20);
            this.txtCedulaEncargado.TabIndex = 14;
            this.txtCedulaEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCedulaEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaEncargado_KeyPress);
            // 
            // txbNombreEncargado
            // 
            this.txbNombreEncargado.Location = new System.Drawing.Point(64, 22);
            this.txbNombreEncargado.Name = "txbNombreEncargado";
            this.txbNombreEncargado.Size = new System.Drawing.Size(284, 20);
            this.txbNombreEncargado.TabIndex = 15;
            this.txbNombreEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // lbTelefonoDEncargado
            // 
            this.lbTelefonoDEncargado.AutoSize = true;
            this.lbTelefonoDEncargado.Location = new System.Drawing.Point(14, 82);
            this.lbTelefonoDEncargado.Name = "lbTelefonoDEncargado";
            this.lbTelefonoDEncargado.Size = new System.Drawing.Size(49, 13);
            this.lbTelefonoDEncargado.TabIndex = 10;
            this.lbTelefonoDEncargado.Text = "Teléfono";
            // 
            // txbTelefonoDEncargado
            // 
            this.txbTelefonoDEncargado.Location = new System.Drawing.Point(461, 47);
            this.txbTelefonoDEncargado.Name = "txbTelefonoDEncargado";
            this.txbTelefonoDEncargado.Size = new System.Drawing.Size(204, 20);
            this.txbTelefonoDEncargado.TabIndex = 16;
            this.txbTelefonoDEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.lbCedulaDEncargado.Location = new System.Drawing.Point(368, 21);
            this.lbCedulaDEncargado.Name = "lbCedulaDEncargado";
            this.lbCedulaDEncargado.Size = new System.Drawing.Size(40, 13);
            this.lbCedulaDEncargado.TabIndex = 1;
            this.lbCedulaDEncargado.Text = "Cédula";
            // 
            // grbDatosJugador
            // 
            this.grbDatosJugador.AutoSize = true;
            this.grbDatosJugador.Controls.Add(this.comboBox1);
            this.grbDatosJugador.Controls.Add(this.dtpFechaDeNacimiento);
            this.grbDatosJugador.Controls.Add(this.txbNumeroPoliza);
            this.grbDatosJugador.Controls.Add(this.rbtnHombre);
            this.grbDatosJugador.Controls.Add(this.lbNumeroPoliza);
            this.grbDatosJugador.Controls.Add(this.rbtnMujer);
            this.grbDatosJugador.Controls.Add(this.lbTeléfono);
            this.grbDatosJugador.Controls.Add(this.txbCedula);
            this.grbDatosJugador.Controls.Add(this.txbNombre);
            this.grbDatosJugador.Controls.Add(this.lbNivel);
            this.grbDatosJugador.Controls.Add(this.lbCedula);
            this.grbDatosJugador.Controls.Add(this.txbTelefono);
            this.grbDatosJugador.Controls.Add(this.lbNombre);
            this.grbDatosJugador.Controls.Add(this.txbSegundoApellido);
            this.grbDatosJugador.Controls.Add(this.txbPrimerApellido);
            this.grbDatosJugador.Controls.Add(this.lbSexo);
            this.grbDatosJugador.Controls.Add(this.lbPrimerApellido);
            this.grbDatosJugador.Controls.Add(this.lbFechaDeNacimiento);
            this.grbDatosJugador.Controls.Add(this.label2);
            this.grbDatosJugador.Location = new System.Drawing.Point(12, 36);
            this.grbDatosJugador.Name = "grbDatosJugador";
            this.grbDatosJugador.Size = new System.Drawing.Size(673, 188);
            this.grbDatosJugador.TabIndex = 0;
            this.grbDatosJugador.TabStop = false;
            this.grbDatosJugador.Text = "Datos personales del jugador";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(480, 83);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(185, 20);
            this.dtpFechaDeNacimiento.TabIndex = 15;
            // 
            // txbNumeroPoliza
            // 
            this.txbNumeroPoliza.Location = new System.Drawing.Point(449, 115);
            this.txbNumeroPoliza.Name = "txbNumeroPoliza";
            this.txbNumeroPoliza.Size = new System.Drawing.Size(216, 20);
            this.txbNumeroPoliza.TabIndex = 17;
            this.txbNumeroPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Location = new System.Drawing.Point(54, 152);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnHombre.TabIndex = 14;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // lbNumeroPoliza
            // 
            this.lbNumeroPoliza.AutoSize = true;
            this.lbNumeroPoliza.Location = new System.Drawing.Point(368, 122);
            this.lbNumeroPoliza.Name = "lbNumeroPoliza";
            this.lbNumeroPoliza.Size = new System.Drawing.Size(74, 13);
            this.lbNumeroPoliza.TabIndex = 15;
            this.lbNumeroPoliza.Text = "Número póliza";
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Location = new System.Drawing.Point(122, 151);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtnMujer.TabIndex = 13;
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            // 
            // lbTeléfono
            // 
            this.lbTeléfono.AutoSize = true;
            this.lbTeléfono.Location = new System.Drawing.Point(14, 90);
            this.lbTeléfono.Name = "lbTeléfono";
            this.lbTeléfono.Size = new System.Drawing.Size(49, 13);
            this.lbTeléfono.TabIndex = 9;
            this.lbTeléfono.Text = "Teléfono";
            // 
            // txbCedula
            // 
            this.txbCedula.Location = new System.Drawing.Point(409, 31);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(256, 20);
            this.txbCedula.TabIndex = 12;
            this.txbCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(64, 31);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(284, 20);
            this.txbNombre.TabIndex = 13;
            this.txbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Location = new System.Drawing.Point(14, 118);
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
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(64, 83);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(284, 20);
            this.txbTelefono.TabIndex = 9;
            this.txbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txbSegundoApellido
            // 
            this.txbSegundoApellido.Location = new System.Drawing.Point(461, 57);
            this.txbSegundoApellido.Name = "txbSegundoApellido";
            this.txbSegundoApellido.Size = new System.Drawing.Size(204, 20);
            this.txbSegundoApellido.TabIndex = 10;
            this.txbSegundoApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbPrimerApellido
            // 
            this.txbPrimerApellido.Location = new System.Drawing.Point(89, 57);
            this.txbPrimerApellido.Name = "txbPrimerApellido";
            this.txbPrimerApellido.Size = new System.Drawing.Size(259, 20);
            this.txbPrimerApellido.TabIndex = 11;
            this.txbPrimerApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(17, 156);
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
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gold;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(359, 342);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(441, 342);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(608, 342);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 143);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(525, 342);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(691, 514);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.Label lbCedulaDEncargado;
        private System.Windows.Forms.TextBox txtCedulaEncargado;
        private System.Windows.Forms.TextBox txbNombreEncargado;
        private System.Windows.Forms.TextBox txbTelefonoDEncargado;
        private System.Windows.Forms.Label lbTelefonoDEncargado;
        private System.Windows.Forms.Label lbNombreDEncargado;
        private System.Windows.Forms.Label lbFechaIngreso;
        private System.Windows.Forms.Label lbNumeroPoliza;
        private System.Windows.Forms.TextBox txbNumeroPoliza;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbSegundoApellidoEncargado;
        private System.Windows.Forms.Button btnConsultarCedEncar;
        private System.Windows.Forms.TextBox txbPrimerApellidoEncargado;
        private System.Windows.Forms.Label lbSegundoApellidoDEncargado;
        private System.Windows.Forms.Label lbPrimerApellidoDEncargado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConsultar;
    }
}