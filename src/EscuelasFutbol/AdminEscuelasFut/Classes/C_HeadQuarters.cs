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
    }
}
