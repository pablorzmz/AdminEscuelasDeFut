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

            dtgvPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dtgvPlayers.DataSource = bindingSource;
            dtgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvPlayers.ReadOnly = true;
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
        public int updatePlayerInformaction(List<String> args)
        {
            if (dataTableTelephones.Rows.Count == 2)
            {
                //"@ViejoTelefono1Jugador"
                args.Add(dataTableTelephones.Rows[0]["Telefono"].ToString());
                //"@ViejoTelefono2Jugador"
                args.Add(dataTableTelephones.Rows[1]["Telefono"].ToString());

            }
            else if (dataTableTelephones.Rows.Count == 1)
            {
                //"@ViejoTelefono1Jugador"
                args.Add(dataTableTelephones.Rows[0]["Telefono"].ToString());
                //"@ViejoTelefono2Jugador"
                args.Add("");
            }
            else
            {
                //Se estan agregando nuevos telefonos, hay que insertarlos con un 
                //procedimiento almacenado
            }

            String[] procParams =
              {
              "@NuevaCedJugador"
              ,"@ViejaCedJugador"
              ,"@Edad"
              ,"@Sexo"
              ,"@FechaNacimiento"
              ,"@NuevaCedEncargado"
              ,"@ViejaCedEncargado"
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
              ,"@ViejoTelefono1Jugador"
              ,"@ViejoTelefono2Jugador"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.Char
                ,SqlDbType.Char
                ,SqlDbType.TinyInt
                ,SqlDbType.Char
                ,SqlDbType.Date
                ,SqlDbType.Char
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
    }
}
