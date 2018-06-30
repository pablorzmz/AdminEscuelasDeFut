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
    public partial class PlayerPaysRegister : Form
    {
        public PlayerPaysRegister()
        {
            InitializeComponent();
        }

        private void PlayerPaysRegister_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbxMonthlyRPaymentPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxMonthlyRPaymentPlayer.Checked)
            {
                dtpFechaFinMensualidad.Enabled = true;
                dtpFechaInicMensualidad.Enabled = true;
            }
            else
            {
                dtpFechaFinMensualidad.Enabled = false;
                dtpFechaInicMensualidad.Enabled = false;
            }
        }

        private void chbxAnnuityRPaymentPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAnnuityRPaymentPlayer.Checked)
            {
                dtpFechaMatricula.Enabled = true;
            }
            else
            {
                dtpFechaMatricula.Enabled = false;
            }
        }
    }
}
