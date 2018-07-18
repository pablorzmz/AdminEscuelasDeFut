using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class C_Pays
    {
        private DataAccess dataAccess;


        /// <summary>
        /// Constructor of C_Pays (Controller of pays form).
        /// </summary>
        public C_Pays() {
            dataAccess = new DataAccess();
        }

        /// <summary>
        /// Fill the combobox with schools.
        /// </summary>
        /// <param name="cboEscuelas"></param> Used to fill it.
        public void fillSchoolsComboBox(ComboBox cboEscuelas) {
            dataAccess.fillComboBox(cboEscuelas, "SELECT Nombre FROM Escuela", "Elija una Escuela");
        }

        /// <summary>
        /// Fill the combox with months (Initial or Final).  
        /// </summary>
        /// <param name="cboMonths"></param>  Used to fill it.
        /// <param name="which"></param> Used to know if the combobox is the initial month or the final month.
        public void fillMonthsComboBox(ComboBox cboMonths, char which) {
            if (which == 'I')
            {
                cboMonths.Items.Add("Mes de inicio");
            }
            else
            {
                cboMonths.Items.Add("Mes final");

            }
            cboMonths.Items.Add("ENE");
            cboMonths.Items.Add("FEB");
            cboMonths.Items.Add("MAR");
            cboMonths.Items.Add("ABR");
            cboMonths.Items.Add("MAY");
            cboMonths.Items.Add("JUN");
            cboMonths.Items.Add("JUL");
            cboMonths.Items.Add("AGO");
            cboMonths.Items.Add("SEP");
            cboMonths.Items.Add("OCT");
            cboMonths.Items.Add("NOV");
            cboMonths.Items.Add("DIC");
            cboMonths.SelectedIndex = 0;
        }

        /// <summary>
        /// Insert a new payment in the database.
        /// </summary>
        /// <param name="args"></param>   Used to pass values ​​to the stored procedure insertarPagoJugador.
        /// <returns>(0, if the insert is correct)</returns>.
        public int insertNewPay(List<String> args)
        {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData paramStruct;

            String[] procParams =
              {
                 "@nombreEscuela"
                ,"@numeroRecibo"
                ,"@Fecha"
                ,"@Monto"
                ,"@Detalle"
                ,"@Cedula"
                ,"@Tipo"
                        };
            SqlDbType[] dataTypes =
            {
                SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.Date
                ,SqlDbType.Int
                ,SqlDbType.VarChar
                ,SqlDbType.Char
                ,SqlDbType.TinyInt

            };
            
            for (int index = 0; index < args.Count; ++index)
            {
                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[index];
                paramStruct.storedProcParamType = dataTypes[index];
                paramStruct.userParams = args[index];
                parameters.Add(paramStruct);
            }

           return dataAccess.executeStoreProcedure(parameters, "insertarPagoJugador");
        }

        /// <summary>
        ///Insert monthly payments from the initial month to the final month.
        /// </summary>
        /// <param name="args"></param>  Used to pass values ​​to the stored procedure insertarPagoJugador.
        /// <param name="initM"></param> Used to know what the initial month is.
        /// <param name="finM"></param> Used to know what the final month is.
        /// <param name="year"></param> Used to know what is the year of the payment date.
        public void insertNewMonthPay(List<String> args, string initM, string finM, int year) {
            List<DataAccess.storedProcData> parameters = new List<DataAccess.storedProcData>();
            DataAccess.storedProcData paramStruct;
            String[] procParams = 
             {
                 "@escuela"
                ,"@numRecibo"
                ,"@mes"
                ,"@ano"
             };
            SqlDbType[] dataTypes =
            {
                SqlDbType.VarChar
                ,SqlDbType.VarChar
                ,SqlDbType.Char
                , SqlDbType.Char

            };
            for (int index = 0; index < args.Count; ++index)
            {
                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[index];
                paramStruct.storedProcParamType = dataTypes[index];
                paramStruct.userParams = args[index];
                parameters.Add(paramStruct);
            }
            string[] months = { "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC" };
            int initMonth = 0;
            for (int i = 0; i < 12; i++)
            {
                if (initM == months[i]) {
                    initMonth = i;
                    break;
                }   
            }
            int iterator = initMonth;
            iterator--;
            do
            {
                iterator++;
                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[2];
                paramStruct.storedProcParamType = dataTypes[2];
                paramStruct.userParams = months[iterator%12];
                parameters.Add(paramStruct);


                paramStruct = new DataAccess.storedProcData();
                paramStruct.storedProcParam = procParams[3];
                paramStruct.storedProcParamType = dataTypes[3];
                if (iterator % 12 >= initMonth)
                {
                    paramStruct.userParams = year.ToString();
                }
                else {
                    paramStruct.userParams = (year+1).ToString();
                }
                parameters.Add(paramStruct);
                dataAccess.executeStoreProcedure(parameters, "InsertarPagoMes");
                parameters.RemoveAt(2);
                parameters.RemoveAt(2);
            } while (months[iterator%12] != finM);
        }

        /// <summary>
        /// Fill the data table with the information of the "VistaInfoCedulasJugador" view.
        /// </summary>
        /// <param name="dgvPagosJugador"></param> Used to fill it with the data.
        public void fillIDPlayerDataGridView(DataGridView dgvPagosJugador) {
            const String loadQuery = "SELECT * FROM VistaInfoCedulasJugador ORDER BY Nombre";
            DataTable dataTable = null;
            dataTable = dataAccess.getTableFromQuery(loadQuery);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            
            dgvPagosJugador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagosJugador.DataSource = bindingSource;
            dgvPagosJugador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagosJugador.ReadOnly = true;
        }

        /// <summary>
        /// Fill the data table with the information of the "VistaPagosJugador" view.
        /// </summary>
        /// <param name="dgvPagosJugador"></param>  Used to fill it with the data.
        /// <param name="parameters"></param> It is used to filter by the parameters inserted by the user.
        public void fillPaysDataGridView(DataGridView dgvPagosJugador, List<String> parameters) {
            const String loadDefaultQuery = "SELECT TOP 100 * FROM VistaPagosJugador";
            String filterQuery = "";
            if (parameters != null)
            {
                if (parameters[0] != "") {
                    filterQuery =
                    "SELECT * FROM VistaPagosJugador WHERE " + "[N° Cedula] = '"+ parameters[0] + "' AND Escuela = '" + parameters[2] + "'" +
                        " ORDER BY 'N° Recibo' DESC";
                }
                else {
                    filterQuery =
                    "SELECT * FROM VistaPagosJugador WHERE " + " Escuela = '" + parameters[2] + "'" +
                        " ORDER BY 'N° Recibo' DESC";
                }           
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
            dgvPagosJugador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagosJugador.DataSource = bindingSource;
            dgvPagosJugador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagosJugador.ReadOnly = true;

        }
    }
}
