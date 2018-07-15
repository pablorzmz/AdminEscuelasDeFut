using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_Players
    {
        private DataAccess dataAccess;

        public C_Players()
        {
            dataAccess = new DataAccess();
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
            DataTable dataTable = dataAccess.getTableFromQuery(queryTelephoneNumbers);

            if (dataTable.Rows.Count == 2)
            {
                tel1.Text = dataTable.Rows[0]["Telefono"].ToString();
                tel2.Text = dataTable.Rows[1]["Telefono"].ToString();
            }
            else if (dataTable.Rows.Count == 1)
            {
                tel1.Text = dataTable.Rows[0]["Telefono"].ToString();
            }

        }
        public int probarProcedimientoAlmacenado(String fecha)
        {
            DataAccess.storedProcData datos =new DataAccess.storedProcData();
            datos.storedProcParam = "@fecha";
            datos.storedProcParamType = SqlDbType.Date;
            datos.userParams = fecha;

            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            parameters.Add(datos);

            return dataAccess.executeStoreProcedure(parameters, "fechaNacimientoGeneral");      
        }
    }
}
