using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_Schools
    {
        private DataAccess dataAccess;
        private DataTable dataTableTelephones;

        /// <summary>
        /// Builder of the class C_Schools
        /// </summary>
        public C_Schools()
        {
            dataAccess = new DataAccess();
            dataTableTelephones = null;
        }

        /// <summary>
        /// Fill the DirrInstalacionComboBox with the necessary data
        /// </summary>
        /// <param name="cmbDirrInstalacion"> The comboBox that i want to fill </param>
        public void fillDirrInstalacionComboBox(ComboBox cmbDirrInstalacion)
        {
            dataAccess.fillComboBox(cmbDirrInstalacion, "SELECT Direccion FROM Instalacion", "Elija una Instalacion");
        }

        /// <summary>
        /// Fill the SchoolsDataGridView with the necessary data
        /// </summary>
        /// <param name="dgvSchoolM"> The DataGridView that i want to fill </param>
        /// <param name="parameters"> The list of parameters that filter the search </param>
        public void fillSchoolsDataGridView(DataGridView dgvSchoolM, List<String> parameters)
        {
            const String loadDefaultQuery = "SELECT TOP 100 * FROM Escuela";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery =
                "SELECT * FROM Escuela WHERE " +
                    "Nombre like '%" + parameters[0] + "%'" +
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
            
            dgvSchoolM.DataSource = bindingSource;
            dgvSchoolM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchoolM.ReadOnly = true;
        }

        /// <summary>
        /// Fill the spaces of telephone numbers
        /// </summary>
        /// <param name="nombreEsc"> The name of the school I want to fill out the phone numbers </param>
        /// <param name="tel1"> the TextBox that i want to fill </param>
        /// <param name="tel2"> the TextBox that i want to fill </param>
        public void fillSchoolTelephoneInfo(String nombreEsc, TextBox tel1, TextBox tel2)
        {
            String queryTelephoneNumbers =
                "SELECT " +
                "   Telefono " +
                "FROM " +
                "   TelefonoE " +
                "WHERE NombreEsc = '" + nombreEsc + "';";
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

        /// <summary>
        /// Method to update data
        /// </summary>
        /// <param name="args"> The list of parameters that i want to update </param>
        /// <returns> Return the status of the update </returns>
        public int updateSchoolInfo(List<String> args) {
            String[] procParams =
              {
                "@nombreEscViejo"
                ,"@tel1Viejo"
                ,"@tel2Viejo"
                ,"@nombreEscNuevo"
                ,"@Lugar"
                ,"@Direccion"
                ,"@tel1Nuevo"
                ,"@tel2Nuevo"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.VarChar
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

            return dataAccess.executeStoreProcedure(parameters, "ActualizarEscuela");
        }

        /// <summary>
        /// Method to insert data
        /// </summary>
        /// <param name="args"> The list of parameters that i want to insert </param>
        /// <returns> Return the status of the insert </returns>
        public int insertSchool(List<String> args)
        {
            String[] procParams =
              {
              "@Nombre"
              ,"@Lugar"
              ,"@Direccion"
              ,"@tel1"
              ,"@tel2"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.Char
                ,SqlDbType.Char
                ,SqlDbType.Char
                ,SqlDbType.Char
                ,SqlDbType.Char
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

            return dataAccess.executeStoreProcedure(parameters, "Registrar_Escuela");
        }

        /// <summary>
        /// Method to delete data
        /// </summary>
        /// <param name="args"> The list of parameters that i want to delete </param>
        /// <returns></returns>
        public int deleteSchool(List<String> args)
        {
            String[] procParams =
              {
              "@nombre"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.Char
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

            return dataAccess.executeStoreProcedure(parameters, "eliminarEscuela");
        }


    }
}