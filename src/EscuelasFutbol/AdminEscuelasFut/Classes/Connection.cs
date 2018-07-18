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
    class Connection
    {
        private const String user = "grupoerror";
        private const String password = "sqlantro";
        private const String database = "DB_ERROR404";
        private const String connectionString = "Data Source=10.1.4.55;User ID=" + user + ";Password=" + password + "; Initial Catalog=" + database + "; Integrated Security=false";
        private SqlConnection sqlConnection;

        /// <summary>
        /// Default class constructor
        /// </summary>
        public Connection()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        /// <summary>
        /// Return the sqlconection objecto for executing queries to database
        /// </summary>
        /// <returns></returns>
        public SqlConnection getValidConnection()
        {
            return sqlConnection;
        }
        /// <summary>
        /// For testing connection to database
        /// </summary>        
        public void testConnection()
        {
            openConnection();
            if (sqlConnection.State == ConnectionState.Open )
            {                
                closeConnection();
            }
            else
            {
                MessageBox.Show( "Fail to connecto to " + database );
            }
        }
        /// <summary>
        /// Method to open connection with a previus declared connection string
        /// </summary>
        public void openConnection()
        {
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();
        }
        /// <summary>
        /// Method to close connection to database
        /// </summary>
        public void closeConnection()
        {            
            if (sqlConnection != null)
                sqlConnection.Close();
        }

    }
}
