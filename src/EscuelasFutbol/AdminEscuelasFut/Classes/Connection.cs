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
        private const String user = "Su Carnet";
        private const String password = "Su contraseña";
        private const String database = "DB_ERROR404";
        private const String connectionString = "Data Source=10.1.4.55;User ID=" + user + ";Password=" + password + "; Initial Catalog=" + database + "; Integrated Security=false";
        
        /**
         * Method for testing databse connection access         
         */
        public void testConnection()
        {
            SqlConnection sqlConnecion = new SqlConnection( connectionString );
            sqlConnecion.Open();
            if ( sqlConnecion.State == ConnectionState.Open )
            {
                MessageBox.Show( "Connected to " + database );
                sqlConnecion.Close();
            }
            else
            {
                MessageBox.Show( "Fail to connecto to " + database );
            }
        }
    }
}
