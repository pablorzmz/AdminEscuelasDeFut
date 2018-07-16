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
        public C_Players()
        {
            dataAccess = new DataAccess();
            dataTableTelephones = null;
        }
        public void fillLevesComboBox( ComboBox cboNiveles )
        {
            dataAccess.fillComboBox(cboNiveles, "SELECT Numero FROM Nivel", "Elija un nivel");
        }
        public void fillSchoolsComboBox( ComboBox cboEscuelas )
        {
            dataAccess.fillComboBox(cboEscuelas, "SELECT Nombre FROM Escuela", "Elija una Escuela");
        }
        public void fillComboBoxCedulasEncargado(ComboBox cboCedulasEncar)
        {
            dataAccess.fillComboBox(cboCedulasEncar, "SELECT CedEncargado FROM Encargado", "Buscar encargado");
        }
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
        public DataTable telephoneTable()
        {
            return this.dataTableTelephones;
        }
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
        }
        public int updatePlayerInformaction(List<String> args)
        {
            List<DataAccess.storedProcData> newTelephones = new List<DataAccess.storedProcData>();
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