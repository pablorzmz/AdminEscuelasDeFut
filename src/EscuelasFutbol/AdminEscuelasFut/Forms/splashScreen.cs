using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEscuelasFut
{
    public partial class splashScreen : Form
    {
        private int timeLeft;
        private Form parent;
        public splashScreen(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }


        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft < 25)
            {
                progressBar1.Increment( timeLeft );
                progressBar1.Refresh();
                timeLeft = timeLeft + 1;

            }
            else
            {
                mainTimer.Stop();
                parent.Show();
                this.Dispose();
            }
        }
        private void splashScreen_Load(object sender, EventArgs e)
        {
            timeLeft = 1;
            progressBar1.Value = 0;
            mainTimer.Start();
        }

    }
}
