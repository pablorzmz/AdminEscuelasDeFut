using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_SchoolLevels
    {
        private DataAccess dataAccess;

        /// <summary>
        /// Builder of the class C_SchoolLevels
        /// </summary>
        public C_SchoolLevels()
        {
            dataAccess = new DataAccess();
        }

        /// <summary>
        /// Fill the LevesComboBox with the necessary data
        /// </summary>
        /// <param name="cboNiveles"> The comboBox that i want to fill  </param>
        public void fillLevesComboBox(ComboBox cboNiveles)
        {
            dataAccess.fillComboBox(cboNiveles, "SELECT Numero FROM Nivel", "Elija un nivel");
        }

        /// <summary>
        /// Fill the SchoolsComboBox with the necessary data
        /// </summary>
        /// <param name="cboEscuelas"> The comboBox that i want to fill  </param>
        public void fillSchoolsComboBox(ComboBox cboEscuelas)
        {
            dataAccess.fillComboBox(cboEscuelas, "SELECT Nombre FROM Escuela", "Elija una Escuela");
        }

        /// <summary>
        /// Fill the SchoolsLevelsDataGridView with the necessary data
        /// </summary>
        /// <param name="dgvSchoolLevels"> The DataGridView that i want to fill </param>
        /// <param name="parameters"> The list of parameters that filter the search </param>
        public void fillSchoolsLevelsDataGridView(DataGridView dgvSchoolLevels, List<String> parameters)
        {
            const String loadDefaultQuery = "SELECT TOP 100 * FROM Tiene";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery =
                "SELECT * FROM Tiene WHERE " +
                    "NomEsc like '%" + parameters[0] + "%'" +
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
            
            dgvSchoolLevels.DataSource = bindingSource;
            dgvSchoolLevels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchoolLevels.ReadOnly = true;
        }

        /// <summary>
        /// Method to update data
        /// </summary>
        /// <param name="args"> The list of parameters that i want to update </param>
        /// <returns> Return the status of the update </returns>
        public int updateSchoolLevelsInfo( List<String> args ) {
            String[] procParams =
              {
                "@numNivelViejo"
              ,"@numNivelNuevo"
              ,"@nombreEsc"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.TinyInt
                ,SqlDbType.TinyInt
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

            return dataAccess.executeStoreProcedure(parameters, "ActualizarNivelesDeEscuela");
        }

        /// <summary>
        /// Method to insert data
        /// </summary>
        /// <param name="args"> The list of parameters that i want to insert </param>
        /// <returns> Return the status of the insert </returns>
        public int insertSchoolLevels( List<String> args ) {
            String[] procParams =
              {
              "@nombreEsc"
              ,"@numNivel"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.Char
                ,SqlDbType.TinyInt
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

            return dataAccess.executeStoreProcedure(parameters, "insertarNivelesAEscuela");
        }

        /// <summary>
        /// Method to delete data
        /// </summary>
        /// <param name="args"> The list of parameters that i want to delete </param>
        /// <returns> Return the status of the delete </returns>
        public int deleteSchoolLevels(List<String> args)
        {
            String[] procParams =
              {
              "@nombreEsc"
              ,"@numNivel"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.Char
                ,SqlDbType.TinyInt
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

            return dataAccess.executeStoreProcedure(parameters, "eliminarNivelesDeEscuela");
        }
    }
}
