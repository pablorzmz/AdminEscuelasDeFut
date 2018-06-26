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
    }
}
