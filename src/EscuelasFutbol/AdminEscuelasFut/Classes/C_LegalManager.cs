using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_LegalManager
    {
        private DataAccess dataAccess;

        public C_LegalManager()
        {
            dataAccess = new DataAccess();
        }

        public void filldtgvEncarcado(DataGridView dataGrid, List<String> parameters)
        {
            const String defaultQuery = "SELECT * FROM verInforEncargado";
            String filterQuery = "";

            if (parameters != null)
            {
                filterQuery =
                    "SELECT " +
                    "   * " +
                    "FROM " +
                    "   verInforEncargado " +
                    "WHERE " +
                    "      Cedula LIKE '%" + parameters[0] + "%' OR " +
                    "      Nombre LIKE '%" + parameters[1] + "%'";
            }
            DataTable data;
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
            dataGrid.DataSource = bindingSource;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.ReadOnly = true;
            dataGrid.AutoResizeColumns();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public int insertNewEncargado(List<String> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData paramStruct;
            String[] procParams =
            {
                "@Cedula"
                ,"@Nombre"
                ,"@Apellido1"
                ,"@Apellido2"
            };

            SqlDbType[] dataTypes =
            {
                SqlDbType.NChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
            };

            for (int index = 0; index < args.Count; ++index)
            {
                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[index];
                paramStruct.storedProcParamType = dataTypes[index];
                paramStruct.userParams = args[index];
                parameters.Add(paramStruct);
            }
            return dataAccess.executeStoreProcedure(parameters, "insertarEncargado");
        }

        public int updateEncargado(List<String> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData paramStruct;
            String[] procParams =
            {
               "@VCedula"
              ,"@VNombre"
              ,"@VApellido1"
              ,"@VApellido2"
               ,"@NCedula"
              ,"@NNombre"
              ,"@NApellido1"
              ,"@NApellido2"
            };

            SqlDbType[] dataTypes =
            {
                SqlDbType.NChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
                ,SqlDbType.NVarChar
            };

            for (int index = 0; index < args.Count; ++index)
            {
                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[index];
                paramStruct.storedProcParamType = dataTypes[index];
                paramStruct.userParams = args[index];
                parameters.Add(paramStruct);
            }

            return dataAccess.executeStoreProcedure(parameters, "actualizarEncargado");
        }

        public int deleteEncargado(List<String> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData paramStruct;
            String[] procParams =
            {
               "@Cedula"
            };
            SqlDbType[] dataTypes =
            {
                SqlDbType.NChar
            };
            for (int index = 0; index < args.Count; ++index)
            {
                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[index];
                paramStruct.storedProcParamType = dataTypes[index];
                paramStruct.userParams = args[index];
                parameters.Add(paramStruct);
            }
            return dataAccess.executeStoreProcedure(parameters, "eliminarEncargado");
        }
    }
}
