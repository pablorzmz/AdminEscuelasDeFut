using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut.Forms
{
    public partial class HelpForm : Form
    {
        String text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque mauris nisl," +
            "vehicula sed gravida vitae, pellentesque id urna. Donec et metus sed est viverra semper " +
            "vel in massa. Integer sagittis erat pellentesque efficitur pretium. Aliquam cursus, felis" +
            "eu rutrum blandit, massa nibh euismod sem, eu pretium est enim eu magna. Morbi ac tortor et" +
            "justo tempor eleifend at maximus sem. Quisque vehicula placerat nibh eget semper. Proin sit " +
            "amet vehicula lectus. Praesent quis erat ut sem tincidunt ultricies a et nunc. Duis eros elit," +
            "malesuada sed turpis at, ultrices maximus quam. Duis sagittis, purus sed molestie imperdiet, " +
            "est augue finibus leo, vel semper diam orci eu leo. Praesent tincidunt cursus placerat. Donec in finibus diam.\r\n\r\n\r\n"+
            "Aliquam blandit libero eget velit luctus malesuada.Aliquam fermentum mattis odio, eu efficitur"+
            "ipsum tristique id.Cras pharetra metus in mauris ultrices bibendum.Nam vitae tincidunt enim. "+
            "Vivamus risus nisl, aliquet faucibus vehicula interdum, interdum id erat.Aenean venenatis purus"+
            "in ipsum sollicitudin cursus.Nulla at mauris ex. Aenean quis vulputate purus, vel tristique neque."+
            "Morbi pretium lacinia urna, a hendrerit sapien sodales eu.Vestibulum in vulputate tortor, quis suscipit lorem.";

      public HelpForm()
        {
            InitializeComponent();
            txtHelpText.Text = text;
            txtHelpTitleText.Text = "Ayuda";
        }
        

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
