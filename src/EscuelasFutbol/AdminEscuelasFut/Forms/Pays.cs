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
    public partial class Pays : Form
    {
        private  PlayerPaysRegister playerPaysRegister;
        private  PlayerPaysQuery playerPaysQuery;
        public Pays()
        {
            InitializeComponent();
        }

        private void Pays_Load(object sender, EventArgs e)
        {
 
        }

        public  void showPlayersPaysRegister()
        {
            playerPaysRegister = new PlayerPaysRegister();
            playerPaysRegister.ShowDialog();

        }
        public  void showPlayersPayQuery()
        {
            playerPaysQuery = new PlayerPaysQuery();
            playerPaysQuery.ShowDialog();

        }

        private void menuItemRegistPagJugadores_Click(object sender, EventArgs e)
        {
            showPlayersPaysRegister();
        }

        private void menuItemConsultPagJugador_Click(object sender, EventArgs e)
        {
            showPlayersPayQuery();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabCPagosGeneral_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush _textBrush;
            // Get the item from the collection.
            TabPage _tabPage = tabCPagosGeneral.TabPages[e.Index];
            // Get the real bounds for the tab rectangle.

            Rectangle _tabBounds = tabCPagosGeneral.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)

            {
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightSeaGreen, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(Color.Gray);
                e.DrawBackground();
            }
            // Use our own font.
            Font _tabFont = new Font("Segoe UI", (float)14.0, FontStyle.Regular, GraphicsUnit.Pixel);
            // Draw string. Center the text.

            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void tabCPagosGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabCPagosGeneral.SelectedIndex = 0;
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
