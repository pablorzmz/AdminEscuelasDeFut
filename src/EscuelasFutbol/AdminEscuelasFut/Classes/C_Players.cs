using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_Players
    {
        private DataAccess dataAccess;

        public C_Players()
        {
            dataAccess = new DataAccess();
        }

        public void fillLevesComboBox( ComboBox cboNiveles )
        {
            dataAccess.fillComboBox(cboNiveles, "SELECT Numero FROM Nivel", "Elija un nivel");
        }

        public void fillPlayerDataGridView( DataGridView dtgvPlayers, List<String> parameters )
        {
            const String loadDefaultQuery = "SELECT * FROM VistaInformacionJugador";
            String filterQuery = "";
            if (parameters != null)
            {
                filterQuery = 
                "SELECT * FROM VistaInformacionJugador WHERE " +
                    "CedJugador like '%" + parameters[0] + "%' OR " +
                    "NombreJugador like '%" + parameters[1] + "%'" +                 
                    "";            
            }            
            DataTable dataTable = null;
            if (parameters == null)
            {
                dataTable = dataAccess.getTableFromQuery(loadDefaultQuery);
            }
            else
            {
                dataTable = dataAccess.getTableFromQuery( filterQuery );
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dtgvPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dtgvPlayers.DataSource = bindingSource;
            dtgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvPlayers.ReadOnly = true;
        }
    }
}
