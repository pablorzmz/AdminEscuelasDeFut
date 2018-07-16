using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_PlayerTrainnings
    {
        private DataAccess dataAccess;

        public C_PlayerTrainnings()
        {
            dataAccess = new DataAccess();
        }

        public void fillPlayerDataGridView(DataGridView dtgvTrainings, List<String> parameters)
        {
            const String loadDefaultQuery =
                "SELECT TOP 100 * FROM VerEntrenamientosJugador ORDER BY [Fecha] DESC";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery =
                "SELECT * FROM VerEntrenamientosJugador WHERE " +
                    "([Cédula] like '%" + parameters[0] + "%' AND " +
                    "[Fecha] like '%" + parameters[1] + "%') AND " +
                    "[Escuela] like '%" + parameters[2] + "%'" +
                    "";
            }
            DataTable dataTable = null;
            if (parameters == null)
            {
                dataTable = dataAccess.getTableFromQuery(loadDefaultQuery);
            }
            else
            {
                dataTable = dataAccess.getTableFromQuery(filterQuery);
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
              
            dtgvTrainings.DataSource = bindingSource;
            dtgvTrainings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTrainings.ReadOnly = true;
            dtgvTrainings.AutoResizeColumns();            
            dtgvTrainings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void fillComboBoxEscuelas( ComboBox cboEscuelas )
        {
            dataAccess.fillComboBox(cboEscuelas, "SELECT Nombre FROM Escuela", "Elija una Escuela");
        }
        public void fillComboBoxFechasEntren(ComboBox cboFechasEntren)
        {
            dataAccess.fillComboBox(cboFechasEntren, "SELECT Fecha FROM Entrenamiento ORDER BY Fecha DESC", "Elija una Fecha");
        }
        public void fillComboBoxCedula( ComboBox cboCedulas )
        {
            dataAccess.fillComboBox(cboCedulas, "SELECT CedJugador From Jugador", "Buscar cédula");
        }
        public int updatePlayerTrainingInfo(List<String> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData param;
            String[] storedProcParamNames = 
                {
                    "@CedJugador"
                    ,"@NuevoFecha"
                    ,"@ViejaFecha"
                };
            SqlDbType[] paramDataTypes =
                {
                    SqlDbType.NChar,
                    SqlDbType.Date,
                    SqlDbType.Date
                };
            for (int index = 0; index < args.Count; ++index)
            {
                param = new DataAccess.storedProcData();
                param.storedProcParam = storedProcParamNames[index];
                param.storedProcParamType = paramDataTypes[index];
                param.userParams = args[index];
                parameters.Add(param);
            }
            return dataAccess.executeStoreProcedure(parameters, "actualizarEntrenamientoJugador");
        }
        public int addNewPlayerTraining(List<String> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData param;

            param = new DataAccess.storedProcData();
            param.storedProcParam = "@CedJugador";
            param.storedProcParamType = SqlDbType.NChar;
            param.userParams = args[0];
            parameters.Add(param);

            param = new DataAccess.storedProcData();
            param.storedProcParam = "@Fecha";
            param.storedProcParamType = SqlDbType.Date;
            param.userParams = args[1];
            parameters.Add(param);

            return dataAccess.executeStoreProcedure(parameters, "registrarEntrenamientoJugador");
        }

        public int deletePlayerTraining(List<String> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData param;

            param = new DataAccess.storedProcData();
            param.storedProcParam = "@CedJugador";
            param.storedProcParamType = SqlDbType.NChar;
            param.userParams = args[0];
            parameters.Add(param);

            param = new DataAccess.storedProcData();
            param.storedProcParam = "@FechEntren";
            param.storedProcParamType = SqlDbType.Date;
            param.userParams = args[1];
            parameters.Add(param);

            return dataAccess.executeStoreProcedure(parameters, "EliminarEntrenamientoDeJugador");
        }
    }    
}
