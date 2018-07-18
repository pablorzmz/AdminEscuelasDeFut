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
        /// <summary>
        /// Control just numeric chars in text file
        /// </summary>
        /// <param name="sender">sender object from event</param>
        /// <param name="e">keypreseed event from object</param>
        /// <param name="decimals">allow of not decimal value</param>
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

        /// <summary>
        /// Control injection in textfiles 
        /// </summary>
        /// <param name="sender">sender objecto from event</param>
        /// <param name="e">event keypressed from object</param>
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

        /// <summary>
        /// Fill a buffer with a datagridviewrow content
        /// </summary>
        /// <param name="dgtv">datagridview object for reading</param>
        /// <param name="rowIndex">row index for reading</param>
        /// <param name="amountOfColumns">amount of datagridview columns</param>
        /// <param name="buffer">list of String to fill with row content</param>
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
        /// <summary>
        /// Show a messageBox with a information icon
        /// </summary>
        /// <param name="messageContent">The message to show to user</param>
        /// <param name="messageHeader">Header to show on top in dialog message</param>
        public static void showInformationMessage( String messageContent, String messageHeader)
        {
            MessageBox.Show(messageContent, messageHeader, MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        /// <summary>
        /// /// Show a messageBox with a error icon
        /// </summary>
        /// <param name="messageContent">The message to show to user</param>
        /// <param name="messageHeader">Header to show on top in dialog message</param>
        public static void showErrorMessage(String messageContent, String messageHeader)
        {
            MessageBox.Show(messageContent, messageHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// /// Show a messageBox with a warning icon
        /// </summary>
        /// <param name="messageContent">The message to show to user</param>
        /// <param name="messageHeader">Header to show on top in dialog message</param>
        public static void showWarningMessage(String messageContent, String messageHeader)
        {
            MessageBox.Show(messageContent, messageHeader, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// The message to ask to user
        /// </summary>
        /// <param name="messageContent">The message to show to user</param>
        /// <param name="messageHeader">Header to show on top in dialog message</param>
        /// <returns>True if yes option picked, false otherwise</returns>
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
