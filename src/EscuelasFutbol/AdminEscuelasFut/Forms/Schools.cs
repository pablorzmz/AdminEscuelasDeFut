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
        private  HeadQuarters headQuatersModule;
        private  SchoolLevels schoolLevesManagement;
        public Schools()
        {
            InitializeComponent();
        }

        public void showHeadQuaderModule()
        {
          headQuatersModule = new HeadQuarters();
          headQuatersModule.ShowDialog();
        }
        private void menuItemAdministrarInst_Click(object sender, EventArgs e)
        {
            showHeadQuaderModule();
        }

        public void showSchooLevels()
        {
           schoolLevesManagement = new SchoolLevels();
           schoolLevesManagement.ShowDialog();
        }

        private void menuItemGestionarNiveles_Click(object sender, EventArgs e)
        {
            showSchooLevels();
        }

        private void Schools_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txtPlaceSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txtAddressSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txtInstallationNameSchoolM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }
    }
}
