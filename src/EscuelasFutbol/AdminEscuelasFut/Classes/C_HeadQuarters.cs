using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut.Classes
{
    class C_HeadQuarters
    {
        private DataAccess dataAccess;

        public C_HeadQuarters()
        {
            dataAccess = new DataAccess();
        }

        public void fillHeadQuartersDataGridView(DataGridView dgtvHeadQuarterInfo, List<String> parameters)
        {
            const String loadDefaultQuery = "SELECT * FROM Instalacion";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery =
                "SELECT* FROM Instalacion WHERE " +
                    "Direccion like '%" + parameters[0] + "%' AND " +
                    "Telefono like '%" + parameters[1] + "%'";

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
     
            dgtvHeadQuarterInfo.DataSource = bindingSource;
            dgtvHeadQuarterInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtvHeadQuarterInfo.ReadOnly = true;
        }

        public int insertHeadQuarter(String address, String telephone)
        {
            DataAccess.storedProcData datos = new DataAccess.storedProcData();
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();

            //First parameter
            datos.storedProcParam = "@Direccion";
            datos.storedProcParamType = SqlDbType.VarChar;
            datos.userParams = address;
            parameters.Add(datos);

            //Second parameter
            datos.storedProcParam = "@Telefono";
            datos.storedProcParamType = SqlDbType.VarChar;
            datos.userParams = telephone;
            parameters.Add(datos);

            return dataAccess.executeStoreProcedure(parameters, "Registrar_Instalacion");
        }

        public int deleteHeadQuarter(String address)
        {
            DataAccess.storedProcData datos = new DataAccess.storedProcData();
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();

            //First parameter
            datos.storedProcParam = "@direccion";
            datos.storedProcParamType = SqlDbType.VarChar;
            datos.userParams = address;
            parameters.Add(datos);

            return dataAccess.executeStoreProcedure(parameters, "eliminarInstalacion");
        }

        public int updateHeadQuarter(String oldAddress, String newAddress, String telephone)
        {
            DataAccess.storedProcData datos = new DataAccess.storedProcData();
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();

            //First parameter
            datos.storedProcParam = "@DireccionV";
            datos.storedProcParamType = SqlDbType.VarChar;
            datos.userParams = oldAddress;
            parameters.Add(datos);

            //First parameter
            datos.storedProcParam = "@DireccionN";
            datos.storedProcParamType = SqlDbType.VarChar;
            datos.userParams = newAddress;
            parameters.Add(datos);

            //Second parameter
            datos.storedProcParam = "@Telefono";
            datos.storedProcParamType = SqlDbType.VarChar;
            datos.userParams = telephone;
            parameters.Add(datos);

            return dataAccess.executeStoreProcedure(parameters, "actualizarInstalacion");
        }
    }
}
