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
        /*
         *Se llama en el evento KeyPressed de los componentes.
         * Es para controlar solo valores numéricos enteros o decimales.
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

        public static void controlSQLInjection( object sender, KeyPressEventArgs e )
        {
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
            else
            {
                e.Handled = false;
            }
        }
    }
}
