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

        public C_SchoolLevels()
        {
            dataAccess = new DataAccess();
        }

        public void fillLevesComboBox(ComboBox cboNiveles)
        {
            dataAccess.fillComboBox(cboNiveles, "SELECT Numero FROM Nivel", "Elija un nivel");
        }

        public void fillSchoolsComboBox(ComboBox cboEscuelas)
        {
            dataAccess.fillComboBox(cboEscuelas, "SELECT Nombre FROM Escuela", "Elija una Escuela");
        }

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
