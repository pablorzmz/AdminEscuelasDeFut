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

        public DataAccess()
        {
            database = new Connection();
        }
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
                MessageBox.Show(ex.Message);
            }
            return data;
        }

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
    }
}
