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

            dgvSchoolLevels.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvSchoolLevels.DataSource = bindingSource;
            dgvSchoolLevels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchoolLevels.ReadOnly = true;
        }
    }
}
