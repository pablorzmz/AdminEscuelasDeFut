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
    public partial class Players : Form
    {
        private PlayerTrainnings playerTrainingsTool;
        public Players()
        {
            InitializeComponent();
        }

        public void showPlayersTraingins()
        {
          playerTrainingsTool = new PlayerTrainnings();
          playerTrainingsTool.ShowDialog();
        }
        private void menuItemConsultarEntren_Click(object sender, EventArgs e)
        {
            showPlayersTraingins();
        }

        private void Players_Load(object sender, EventArgs e)
        {

        }
    }
}
