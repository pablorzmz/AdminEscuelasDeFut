using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_Pays
    {
        private DataAccess dataAccess;

        public C_Pays() {
            dataAccess = new DataAccess();
        }

        public void fillSchoolsComboBox(ComboBox cboEscuelas) {
            dataAccess.fillComboBox(cboEscuelas, "SELECT Nombre FROM Escuela", "Elija una Escuela");
        }

        public void fillPaysDataGridView(DataGridView dgvPagosJugador, List<String> parameters) {
            const String loadDefaultQuery = "SELECT TOP 100 * FROM VistaPagosJugador";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery =
                "SELECT * FROM VistaPagosJugador WHERE " +
                    "('N° Cédula' like '%" + parameters[0] + "%' OR " +
                    "'N° Recibo' like '%" + parameters[1] + "%') AND" +
                    " Escuela = '"+ parameters[2] + "'" +
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

            dgvPagosJugador.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPagosJugador.DataSource = bindingSource;
            dgvPagosJugador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagosJugador.ReadOnly = true;

        }
    }
}
