using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    public partial class Schools : Form
    {
        private static HeadQuarters headQuatersModule;
        public Schools()
        {
            InitializeComponent();
        }

        public static void showHeadQuaderModule()
        {
            if (headQuatersModule == null)
            {
                headQuatersModule = new HeadQuarters();
                headQuatersModule.ShowDialog();
            }
            else
            {
                headQuatersModule.Focus();
            }
        }
        private void menuItemAdministrarInst_Click(object sender, EventArgs e)
        {
            showHeadQuaderModule();
        }
    }
}
