using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_Trainings
    {
        private DataAccess dataAccess;
        /// <summary>
        ///  Default class constructor
        /// </summary>
        public C_Trainings()
        {
            dataAccess = new DataAccess();
        }
        /// <summary>
        /// Method that calls a stored proc for deleting a player training record from database
        /// </summary>
        /// <param name="args">List of strings with values for deleting a player training record from data base</param>
        /// <returns>Returns the integer code result of the stored proc execution</returns>
        public int deleteTraining(List<String> args)
        {
            List<DataAccess.storedProcData> procParams = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData parameter;

            parameter.storedProcParam = "@fecha";
            parameter.storedProcParamType = SqlDbType.Date;
            parameter.userParams = args[0];
            procParams.Add(parameter);

            return dataAccess.executeStoreProcedure(procParams, "eliminarEntrenamiento"); ;
        }
        /// <summary>
        /// Method that calls a stored proc for updating a player training record from database
        /// </summary>
        /// <param name="args">List of strings with the new and values for updating a player training record from data base</param>
        /// <returns>Returns the integer code result of the stored proc execution</returns>
        public int updateTraining(List<String> args)
        {
            List<DataAccess.storedProcData> procParams = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData parameter;

            parameter = new DataAccess.storedProcData();
            parameter.storedProcParam = "@fechaV";
            parameter.storedProcParamType = SqlDbType.Date;
            parameter.userParams = args[0];
            procParams.Add(parameter);

            parameter = new DataAccess.storedProcData();
            parameter.storedProcParam = "@fechaN";
            parameter.storedProcParamType = SqlDbType.Date;
            parameter.userParams = args[1];
            procParams.Add(parameter);

            parameter = new DataAccess.storedProcData();
            parameter.storedProcParam = "@horaN";
            parameter.storedProcParamType = SqlDbType.Time;
            parameter.userParams = args[2];
            procParams.Add(parameter);

            return dataAccess.executeStoreProcedure(procParams, "actualizarEntrenamiento");
        }
        /// <summary>
        /// Method that calls a stored proc for inserting a player training record from database
        /// </summary>
        /// <param name="args">List of strings with the new to insert a new player training record into data base</param>
        /// <returns>Returns the integer code result of the stored proc execution</returns>
        public int insertNewTraining(List<String> args)
        {
            List<DataAccess.storedProcData> procParams = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData parameter;

            parameter = new DataAccess.storedProcData();
            parameter.storedProcParam = "@fecha";
            parameter.storedProcParamType = SqlDbType.Date;
            parameter.userParams = args[0];
            procParams.Add(parameter);

            parameter = new DataAccess.storedProcData();
            parameter.storedProcParam = "@hora";
            parameter.storedProcParamType = SqlDbType.Time;
            parameter.userParams = args[1];
            procParams.Add(parameter);

            return dataAccess.executeStoreProcedure(procParams, "registrarEntrenamiento");
        }
        /// <summary>
        /// Method  that fills a DataGridView component with player trainings record from data base
        /// </summary>
        /// <param name="dtgvTrainings">DataGridView component to fill</param>
        /// <param name="parameters">List of strings with values for the query filter</param>
        public void filldataGridViewTrainings(DataGridView dtgvTrainings, List<String> parameters)
        {
            const String defaultQuery = "SELECT * FROM Entrenamiento";
            String filterQuery = "";
            DataTable data;

            if (parameters != null)
            {
                filterQuery =
                    "SELECT " +
                "      * " +
                "FROM " +
                "      Entrenamiento " +
                "WHERE " +
                "      Fecha like '%" + parameters[0] + "%' OR " +
                "      Hora like '%" + parameters[0] + "%'";
            }
            if (filterQuery == "")
            {
                data = dataAccess.getTableFromQuery(defaultQuery);
            }
            else
            {
                data = dataAccess.getTableFromQuery(filterQuery);
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = data;

            dtgvTrainings.DataSource = bindingSource;
            dtgvTrainings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTrainings.ReadOnly = true;
            dtgvTrainings.AutoResizeColumns();
            dtgvTrainings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
