using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_PlayerTrainnings
    {
        private DataAccess dataAccess;

        public C_PlayerTrainnings()
        {
            dataAccess = new DataAccess();
        }

        public void fillPlayerDataGridView(DataGridView dtgvTrainings, List<String> parameters)
        {
            const String loadDefaultQuery =
                "SELECT TOP 100 * FROM VerEntrenamientosJugador ORDER BY [Fecha] DESC";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery =
                "SELECT * FROM VerEntrenamientosJugador WHERE " +
                    "([Cédula] like '%" + parameters[0] + "%' OR " +
                    "[Fecha] like '%" + parameters[1] + "%') AND " +
                    "[Escuela] = '" + parameters[2] + "'" +
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
              
            dtgvTrainings.DataSource = bindingSource;
            dtgvTrainings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTrainings.ReadOnly = true;
            dtgvTrainings.AutoResizeColumns();            
            dtgvTrainings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void fillComboBoxEscuelas( ComboBox cboEscuelas )
        {
            dataAccess.fillComboBox(cboEscuelas, "SELECT Nombre FROM Escuela", "Elija una Escuela");
        }
        public void fillComboBoxFechasEntren(ComboBox cboFechasEntren)
        {
            dataAccess.fillComboBox(cboFechasEntren, "SELECT Fecha FROM Entrenamiento ORDER BY Fecha DESC", "Elija una Fecha");
        }
    }    
}
