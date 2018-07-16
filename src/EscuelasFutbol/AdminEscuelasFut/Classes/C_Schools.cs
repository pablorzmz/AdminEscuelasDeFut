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

        public C_Schools()
        {
            dataAccess = new DataAccess();
            dataTableTelephones = null;
        }

        public void fillDirrInstalacionComboBox(ComboBox cmbDirrInstalacion)
        {
            dataAccess.fillComboBox(cmbDirrInstalacion, "SELECT Direccion FROM Instalacion", "Elija una Instalacion");
        }

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

            dgvSchoolM.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvSchoolM.DataSource = bindingSource;
            dgvSchoolM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchoolM.ReadOnly = true;
        }

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

        public int updateSchoolInfo(List<String> args) {
            String[] procParams =
              {
                "@nombreEscViejo"
                ,"@nombreEscNuevo"
                ,"@Lugar varchar"
                ,"@Direccion"
                ,"@tel1Viejo"
                ,"@tel1Nuevo"
                ,"@tel2Viejo"
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