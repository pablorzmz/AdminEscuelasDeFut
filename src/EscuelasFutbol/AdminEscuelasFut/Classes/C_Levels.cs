using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut.Classes
{
    class C_Levels
    {
        private DataAccess dataAccess;

        /**
         * class constructor
         **/
        public C_Levels()
        {
            dataAccess = new DataAccess();
        }

        /**
         * Fill the DataGridView with the data from the table of levels of the database.
         **/
        public void fillLevelsDataGridView(DataGridView dgtvLevelInfo, List<String> parameters)
        {
            const String loadDefaultQuery = "SELECT * FROM Nivel";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery =
                "SELECT * FROM Nivel WHERE " +
                    "Numero like '%" + parameters[0] + "%' AND " +
                    "EdadInicio like '%" + parameters[1] + "%' AND" +
                    " EdadFin like '%" + parameters[2] + "%'";


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
            

            dgtvLevelInfo.DataSource = bindingSource;
            dgtvLevelInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtvLevelInfo.ReadOnly = true;
        }


        /**
         * Insert one level from the database
         **/
        public int insertLevel(String numLevel, String minimumAge, String maximumAge)
        {
            DataAccess.storedProcData datos = new DataAccess.storedProcData();
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();

            //First parameter
            datos.storedProcParam = "@numero";
            datos.storedProcParamType = SqlDbType.TinyInt;
            datos.userParams = numLevel;
            parameters.Add(datos);

            //Second parameter
            datos.storedProcParam = "@edadInicio";
            datos.storedProcParamType = SqlDbType.TinyInt;
            datos.userParams = minimumAge;
            parameters.Add(datos);

            //Third parameter
            datos.storedProcParam = "@edadFin";
            datos.storedProcParamType = SqlDbType.TinyInt;
            datos.userParams = maximumAge;
            parameters.Add(datos);

            return dataAccess.executeStoreProcedure(parameters, "insertarNivel");
        }

        /**
         * Remove one level from the database
         **/
        public int deleteLevel(String numLevel)
        {
            DataAccess.storedProcData datos = new DataAccess.storedProcData();
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();

            //First parameter
            datos.storedProcParam = "@numero";
            datos.storedProcParamType = SqlDbType.TinyInt;
            datos.userParams = numLevel;
            parameters.Add(datos);

            return dataAccess.executeStoreProcedure(parameters, "eliminarNivel");
        }

        /**
         * Remove one level from the database
         **/
        public int updateLevel(String oldLevelNumber, String newLevelNumber, String minimumAge, String maximumAge)
        {
            DataAccess.storedProcData datos = new DataAccess.storedProcData();
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();

            //First parameter
            datos.storedProcParam = "@numeroV";
            datos.storedProcParamType = SqlDbType.TinyInt;
            datos.userParams = oldLevelNumber;
            parameters.Add(datos);

            //First parameter
            datos.storedProcParam = "@numeroN";
            datos.storedProcParamType = SqlDbType.TinyInt;
            datos.userParams = newLevelNumber;
            parameters.Add(datos);


            //Second parameter
            datos.storedProcParam = "@edadInicio";
            datos.storedProcParamType = SqlDbType.TinyInt;
            datos.userParams = minimumAge;
            parameters.Add(datos);

            //Third parameter
            datos.storedProcParam = "@edadFin";
            datos.storedProcParamType = SqlDbType.TinyInt;
            datos.userParams = maximumAge;
            parameters.Add(datos);

            return dataAccess.executeStoreProcedure(parameters, "actualizarNivel");
        }
    }
}
