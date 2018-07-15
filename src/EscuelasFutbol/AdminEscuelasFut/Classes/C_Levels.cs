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

        public C_Levels()
        {
            dataAccess = new DataAccess();
        }
     
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

            //dgtvLevelInfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgtvLevelInfo.DataSource = bindingSource;
            dgtvLevelInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtvLevelInfo.ReadOnly = true;
        }
    }
}
