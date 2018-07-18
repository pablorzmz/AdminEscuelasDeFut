using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AdminEscuelasFut
{
    class DataAccess
    {
        private Connection database;

        /// <summary>
        /// Default class constructor
        /// </summary>
        public DataAccess()
        {
            database = new Connection();
        }
        /// <summary>
        /// Generic method for fill a ComboBox Component with a set of data from a column result of a query
        /// </summary>
        /// <param name="cbo">ComboBox component to fill with query result</param>
        /// <param name="query">String value to the query to execute</param>
        /// <param name="item_0">String value for add a item 0 to the combo box, example: "Pick a id number"</param>
        public void fillComboBox(ComboBox cbo, String query, String item_0)
        {
            SqlDataReader data = null;
            try
            {
                database.openConnection();
                data = executeQuery(query);
                if (data != null)
                {
                    cbo.Items.Add(item_0);
                    while (data.Read())
                    {
                        cbo.Items.Add(data.GetValue(0));
                    }
                    cbo.SelectedIndex = 0;
                }
                database.closeConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Generic methos to execute a query on data base
        /// </summary>
        /// <param name="query">String for the query</param>
        /// <returns>SqlData adapter with the source result of the executed query</returns>
        public SqlDataReader executeQuery(String query)
        {
            SqlDataReader data = null;
            SqlCommand command = null;
            try
            {
                //Ejecuta la consulta sql recibida por parámetro y la carga en un datareader
                command = new SqlCommand(query, database.getValidConnection());
                data = command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                //Utilities.showErrorMessage(ex.Message,"Sql Exception");
            }
            return data;
        }
        /// <summary>
        /// Method that returns a data table with 'clean' source data from data base
        /// </summary>
        /// <param name="consulta">String value of the query to execute</param>
        /// <returns>Returns a valid data table with the date result of query execution</returns>
        public DataTable getTableFromQuery(String consulta)
        {
            database.openConnection();
            SqlCommand comando = new SqlCommand(consulta, database.getValidConnection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            database.closeConnection();
            return table;
        }
        /// <summary>
        /// Struct used for each parameter needed in a stored procedur
        /// </summary>
        public struct storedProcData
        {
            public String storedProcParam;
            public SqlDbType storedProcParamType;
            public String userParams;
        }
        /// <summary>
        /// Generic methos for executing a stored procedure in the database
        /// </summary>
        /// <param name="storedProcData">List of storedProcData objecto as stored proc arguments</param>
        /// <param name="storeProcName">String with the stored proc name value</param>
        /// <returns></returns>
        public int executeStoreProcedure( List<storedProcData> storedProcData ,String storeProcName)
        {
            int error = 0;            
            SqlConnection con = database.getValidConnection();
            using ( con )
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand(storeProcName, con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        for (int index = 0; index < storedProcData.Count; ++index)
                        {
                            cmd.Parameters.Add
                                (storedProcData[index].storedProcParam,
                                storedProcData[index].storedProcParamType).Value
                                = storedProcData[index].userParams;
                        }                        
                        //Se ejecuta el procedimiento almacenado
                        database.openConnection();                        
                        cmd.ExecuteNonQuery();
                        database.closeConnection();
                        return error;
                    }
                    catch (SqlException ex)
                    {
                       ///MessageBox.Show(ex.Message);
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }
    }
}
