using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    class Utilities
    {
        public static int DUPLICATED_KEY = 2627;
        /*
         * @todo Control just numeric chars in text file
         * @param sender: sender object from event
         * @param e: keypreseed event from object
         * @param decimal: allow of not decimal values
        */        
        public static void validateNumbers(object sender, KeyPressEventArgs e, bool decimals)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (decimals)
                {
                    if (e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                return;
            }
        }

        /*
        * @todo: Control injection in textfiles 
        * @param sender:  sender objecto from event
        * @ e: event keypressed from object
        */
        public static void controlSQLInjection( object sender, KeyPressEventArgs e )
        {
            if (char.IsLetter(e.KeyChar) == false )
            {
                if (e.KeyChar != 8 && e.KeyChar != ' ' )
                {
                    e.Handled = true;
                    return;
                }                
            }
            List<char> invalidChars = new List<char>();
            invalidChars.Add(';');
            invalidChars.Add('=');
            invalidChars.Add('!');
            invalidChars.Add('*');
            invalidChars.Add('\\');
            invalidChars.Add('/');
            invalidChars.Add('+');
            invalidChars.Add('-');
            invalidChars.Add('(');
            invalidChars.Add(')');
            invalidChars.Add(':');
            bool invalid = false;
            for (int x = 0; x < invalidChars.Count; ++x)
            {                
                if (e.KeyChar == invalidChars[x])
                {
                    invalid = true;
                    break;
                }
            }
            if (invalid)
            {
                e.Handled = true;
            }
            /*else
            {
                //e.Handled = false;
            }
            */
        }

        /*
        * @todo: Fill a buffer with a datagridviewrow content
        * @param dgtv:  datagridview object for reading
        * @param rowIndex: row index for reading
        * @param amountOfColumns: amount of datagridview columns
        * @param buffer: list of String to fill with row content
        */
        public static void readCurrentRowFromDataGridView( DataGridView dgtv, int rowIndex,int amountOfColumns, List<String> buffer )
        {
            DataGridViewRow row = dgtv.Rows[rowIndex];
            String value = "";
            for (int c = 0; c < amountOfColumns; ++c)
            {
                value = row.Cells[c].Value.ToString();
                buffer.Add( value );
            }
        }
        /*
         * @param messageContent: The message to show to user
         * @param messageHeader: Header to show on top in dialog message
         */
        public static void showInformationMessage( String messageContent, String messageHeader)
        {
            MessageBox.Show(messageContent, messageHeader, MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        /*
         * @param messageContent: The message to show to user
         * @param messageHeader: Header to show on top in dialog message
        */
        public static void showErrorMessage(String messageContent, String messageHeader)
        {
            MessageBox.Show(messageContent, messageHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /*
         * @param messageContent: The message to show to user
         * @param messageHeader: Header to show on top in dialog message
        */
        public static void showWarningMessage(String messageContent, String messageHeader)
        {
            MessageBox.Show(messageContent, messageHeader, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /*
         * @param messageContent: The message to show to user
         * @param messageHeader: Header to show on top in dialog message
         * @return: Return true, if user picked Yes, false otherwise
        */
        public static bool showQuestionMessage(String messageContent, String messageHeader)
        {
            DialogResult result = MessageBox.Show(messageContent, messageHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
