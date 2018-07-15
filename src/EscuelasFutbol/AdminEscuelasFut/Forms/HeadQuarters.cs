using AdminEscuelasFut.Classes;
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
    public partial class HeadQuarters : Form
    {
        private C_HeadQuarters headQuartersController;

        public HeadQuarters()
        {
            InitializeComponent();
            headQuartersController = new C_HeadQuarters();
        }

        private void HeadQuarters_Load(object sender, EventArgs e)
        {
            headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, null);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddressAdministerInstallation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> parameters = new List<String>();
            /*0*/parameters.Add(txtAddressAdministerInstallation.Text);
            /*1*/parameters.Add(txtTelephoneAdministerInstallation.Text);
            headQuartersController.fillHeadQuartersDataGridView(dgvAdministerInstallation, parameters);
        }
    }
}
