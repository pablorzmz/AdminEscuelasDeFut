using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_Players
    {
        private DataAccess dataAccess;
        private DataTable dataTableTelephones;

        /// <summary>
        /// Default classs constructor
        /// </summary>
        public C_Players()
        {
            dataAccess = new DataAccess();
            dataTableTelephones = null;
        }
        /// <summary>
        ///  Method that fill ComboBox with level´s number from database
        /// </summary>
        /// <param name="cboNiveles">ComboBox objecto to fill</param>
        public void fillLevesComboBox( ComboBox cboNiveles )
        {
            dataAccess.fillComboBox(cboNiveles, "SELECT Numero FROM Nivel", "Elija un nivel");
        }
        /// <summary>
        /// Method that fill ComboBox with schoool´s name from database
        /// </summary>
        /// <param name="cboEscuelas">ComboBox object to fill</param>
        public void fillSchoolsComboBox( ComboBox cboEscuelas )
        {
            dataAccess.fillComboBox(cboEscuelas, "SELECT Nombre FROM Escuela", "Elija una Escuela");
        }
        /// <summary>
        /// Method that fill ComboBox with  legal manager id´s number from database
        /// </summary>
        /// <param name="cboCedulasEncar">ComboBox objecto to fill</param>
        public void fillComboBoxCedulasEncargado(ComboBox cboCedulasEncar)
        {
            dataAccess.fillComboBox(cboCedulasEncar, "SELECT CedEncargado FROM Encargado", "Buscar encargado");
        }
        /// <summary>
        ///     Method that fills a DataGridView component with View content from database
        /// </summary>
        /// <param name="dtgvPlayers">DataGridView component to fill</param>
        /// <param name="parameters">List of parameter for filtering on the database query</param>
        public void fillPlayerDataGridView( DataGridView dtgvPlayers, List<String> parameters )
        {
            const String loadDefaultQuery = "SELECT TOP 100 * FROM VistaInformacionJugador";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery = 
                "SELECT * FROM VistaInformacionJugador WHERE " +
                    "('N° Cédula' like '%" + parameters[0] + "%' OR " +
                    "Nombre like '%" + parameters[1] + "%') AND " +
                    "Escuela = '" + parameters[2] + "'" +
                    "";            
            }            
            DataTable dataTable = null;
            if (parameters == null)
            {
                dataTable = dataAccess.getTableFromQuery(loadDefaultQuery);                
            }
            else
            {
                dataTable = dataAccess.getTableFromQuery( filterQuery );
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dtgvPlayers.DataSource = bindingSource;
            dtgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvPlayers.ReadOnly = true;
            dtgvPlayers.AutoResizeColumns();
            dtgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Method to fill Textbox files with players telephone numbers
        /// </summary>
        /// <param name="cedJugador">Value od the player´s id to query telephone numbers</param>
        /// <param name="tel1">Textbox component to fill with telephone number 1</param>
        /// <param name="tel2">Textbox component to fill with telephone number 2</param>
        public void fillPlayerTelephoneInfo( String cedJugador, TextBox tel1, TextBox tel2 )
        {
            String queryTelephoneNumbers = 
                "SELECT " +
                "   Telefono " +
                "FROM " +
                "   TelefonoP " +
                "WHERE Cedula = '" + cedJugador  +"';";
            dataTableTelephones = dataAccess.getTableFromQuery(queryTelephoneNumbers);

            if (dataTableTelephones.Rows.Count == 2)
            {
                tel1.Text = dataTableTelephones.Rows[0]["Telefono"].ToString();
                tel2.Text = dataTableTelephones.Rows[1]["Telefono"].ToString();
            }
            else if (dataTableTelephones.Rows.Count == 1)
            {
                tel1.Text = dataTableTelephones.Rows[0]["Telefono"].ToString();
            }        
        }
        /// <summary>
        /// Method that returns dataTable with telephone numbers information
        /// </summary>
        /// <returns>A datatable with read telephone number from database</returns>
        public DataTable telephoneTable()
        {
            return this.dataTableTelephones;
        }
        /// <summary>
        /// Method that get from database the information of the legal manager of the current players
        /// </summary>
        /// <param name="cedEncargado">Legal manager id for the query filter</param>
        /// <param name="Nombre">Textbox component to fill with legal manager name</param>
        /// <param name="Apellido1">Textbox component to fill with legal manager last name 1</param>
        /// <param name="Apellido2">Textbox component to fill with legal manager last name 2</param>
        public void fillEncargadoInfo(String cedEncargado, TextBox Nombre, TextBox Apellido1, TextBox Apellido2 )
        {
            String queryEncargado =
            "SELECT " +
            "   *" +
            "FROM " +
            "   verInforEncargado " +
            "WHERE " +
            "   Cedula = '" + cedEncargado + "';";
            DataTable result = dataAccess.getTableFromQuery(queryEncargado);
            Nombre.Text = result.Rows[0]["Nombre"].ToString();
            Apellido1.Text = result.Rows[0]["Apellido1"].ToString();
            Apellido2.Text = result.Rows[0]["Apellido2"].ToString();
        }/// <summary>
        /// Method that update player information. New information is given in the list of strings 'args'
        /// </summary>
        /// <param name="args">List of strings that constains new player information</param>
        /// <returns>Return int value with the result of the query from database</returns>
        public int updatePlayerInformaction(List<String> args)
        {            
            DataAccess.storedProcData param;
            String[] procParams =
              {
              "@ViejaCedJugador"
              ,"@ViejoTelefono1Jugador"
              ,"@ViejoTelefono2Jugador"
              ,"@NuevaCedJugador"
              ,"@Edad"
              ,"@Sexo"
              ,"@FechaNacimiento"
              ,"@NuevaCedEncargado"
              ,"@FechaIngreso"
              ,"@NombreJug"
              ,"@Apellido1Jug"
              ,"@Apellido2Jug"
              ,"@NombreEncargado"
              ,"@Apellido1Encar"
              ,"@Apellido2Encar"
              ,"@NomEscuela"
              ,"@Nivel"
              ,"@NuevoTelefono1Jugador"
              ,"@NuevoTelefono2Jugador"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.Char
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.Char
                ,SqlDbType.TinyInt
                ,SqlDbType.Char
                ,SqlDbType.Date
                ,SqlDbType.Char
                ,SqlDbType.Date
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.TinyInt
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
            };
            /*Se declara la estructura para los parámetros*/
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData paramStruct;
            /*Se llena la estrucutra con los parámetros*/
            for (int index = 0; index < args.Count; ++index)
            {
                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[index];
                paramStruct.storedProcParamType = dataTypes[index];
                paramStruct.userParams = args[index];
                //MessageBox.Show("Parametro proc: " + procParams[index] +  ", Tipo: " + dataTypes[index].ToString() + ", Valor otorgado: " + args[index]);
                parameters.Add(paramStruct);
            }
            return dataAccess.executeStoreProcedure(parameters, "actualizarJugador");
        }
        /// <summary>
        /// Method that inserts a new player in the database.
        /// </summary>
        /// <param name="args">List of strings that contains information to insert a new player into database</param>
        /// <returns>Return int value with the result of the query from database</returns>
        public int insertNewPlayer(List<String> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData paramStruct;
            String[] procParams =
            {
               "@nombreJ"
              ,"@Apellido1J"
              ,"@tel1J"
              ,"@tel2J"
              ,"@cedulaJ"
              ,"@Apellido2J"
              ,"@fechaNac"
              ,"@sexo"
              ,"@escuela"
              ,"@nombreE"
              ,"@Apellido1E"
              ,"@fechaIngreso"
              ,"@cedulaE"
              ,"@Apellido2E"
            };
            SqlDbType[] dataTypes =
            {
                SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NChar
                ,SqlDbType.NVarChar
                ,SqlDbType.Date
                ,SqlDbType.NChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.Date
                ,SqlDbType.NChar
                ,SqlDbType.NVarChar
            };
            for (int index = 0; index < args.Count; ++index)
            {
                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[index];
                paramStruct.storedProcParamType = dataTypes[index];
                paramStruct.userParams = args[index];                
                parameters.Add(paramStruct);
            }
            return dataAccess.executeStoreProcedure(parameters, "insertarJugador");
        }
        /// <summary>
        ///  Method that execute a delete action of a player from database
        /// </summary>
        /// <param name="args">List of strings that contains the values for deleting a players</param>
        /// <returns>Return int value with the result of the query from database</returns>
        public int deletePlayer(List<string> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData param = new DataAccess.storedProcData();
            param.storedProcParam = "@Cedula";
            param.storedProcParamType = SqlDbType.NChar;
            param.userParams = args[0];
            parameters.Add(param);                     
            return dataAccess.executeStoreProcedure(parameters, "Eliminar_Jugador"); ;
        }
    }
}