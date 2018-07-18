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

        /// <summary>
        /// Default class constructors
        /// </summary>
        public C_LegalManager()
        {
            dataAccess = new DataAccess();
        }
        /// <summary>
        /// Method that fills DataGridView object of legal manager UI
        /// </summary>
        /// <param name="dataGrid">DataGridView component to fill</param>
        /// <param name="parameters">List of String with the values for the filter</param>
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
        /// <summary>
        /// Method that calls a stored proc to insert a new legal manager into database
        /// </summary>
        /// <param name="args">List of strings with the values for the new legal manager</param>
        /// <returns>Returns int value result from stored proc execution</returns>
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
        /// <summary>
        /// Method that calls a stored proc to update legal manager information
        /// </summary>
        /// <param name="args">List of strings with the values the new and old values for a legal manager</param>
        /// <returns>Returns int value result from stored proc execution</returns>
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
        /// <summary>
        /// Method that calls a stored proc to delete a legal manager from database
        /// </summary>
        /// <param name="args">List of strings of the identifies of a legal manager</param>
        /// <returns>Returns int value result from stored proc execution</returns>
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
