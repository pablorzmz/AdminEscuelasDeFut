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

        public C_Schools()
        {
            dataAccess = new DataAccess();
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
    }
}