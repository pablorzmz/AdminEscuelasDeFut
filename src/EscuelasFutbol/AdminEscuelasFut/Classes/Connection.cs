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
        private const String user = "";
        private const String password = "";
        private const String database = "DB_ERROR404";
        private const String connectionString = "Data Source=10.1.4.55;User ID=" + user + ";Password=" + password + "; Initial Catalog=" + database + "; Integrated Security=false";
        private SqlConnection sqlConnection;

        public Connection()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public SqlConnection getValidConnection()
        {
            return sqlConnection;
        }

        /**
         * Method for testing databse connection access         
         */
        public void testConnection()
        {
            openConnection();
            if (sqlConnection.State == ConnectionState.Open )
            {
                MessageBox.Show( "Connected to " + database );
                closeConnection();
            }
            else
            {
                MessageBox.Show( "Fail to connecto to " + database );
            }
        }

        public void openConnection()
        {
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();
        }

        public void closeConnection()
        {            
            if (sqlConnection != null)
                sqlConnection.Close();
        }

    }
}
