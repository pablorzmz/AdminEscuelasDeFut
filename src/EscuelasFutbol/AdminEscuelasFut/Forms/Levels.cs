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
    public partial class Levels : Form
    {
        private C_Levels levelController;

        public Levels()
        {
            InitializeComponent();
            levelController = new C_Levels();
        }

        private void Levels_Load(object sender, EventArgs e)
        {
            levelController.fillLevelsDataGridView(dgtvLevelInfo, null);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbEdadInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbEdadFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<String> parameters = new List<String>();
            /*0*/parameters.Add(txbNivel.Text);
            /*1*/parameters.Add(txbEdadInicio.Text);
            /*2*/parameters.Add(txbEdadFin.Text);
            levelController.fillLevelsDataGridView(dgtvLevelInfo, parameters);
        }
    }
}
