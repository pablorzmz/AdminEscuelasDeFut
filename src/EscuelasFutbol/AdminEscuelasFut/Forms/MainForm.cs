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
    public partial class MainForm : Form
    {
        private  Pays paysModule;
        private  Levels levelsModule;
        private  Trainings trainingsModule;
        private  Schools schoolsModule;
        private  Players playersModule;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.IsMdiContainer = true;
            MdiClient ctlMDI;
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        /**
         * 
        **/
        public void showPaysModule()
        {
            if ( paysModule == null )
            {
                paysModule = new Pays();
                paysModule.MdiParent = this;                
                paysModule.Show();
            }
            else
            {
                paysModule.Focus();
            }
        }

        /**
         * 
        **/
        public void showLevelsModule()
        {
            if ( levelsModule == null )
            {
                levelsModule = new Levels();
                levelsModule.MdiParent = this;
                levelsModule.Show();
            }
            else
            {
                levelsModule.Focus();
            }
        }

        public void showTrainginsModule()
        {
            if ( trainingsModule == null )
            {
                trainingsModule = new Trainings();
                trainingsModule.MdiParent = this;
                trainingsModule.Show();
            }
            else
            {
                trainingsModule.Focus();
            }
        }

        public void showSchoolsModule()
        {
            if (schoolsModule == null)
            {
                schoolsModule = new Schools();
                schoolsModule.MdiParent = this;
                schoolsModule.Show();
            }
            else
            {
                schoolsModule.Focus();
            }
        }
        public void showPlayersModule()
        {
            if (playersModule == null)
            {
                playersModule = new Players();
                playersModule.MdiParent = this;
                playersModule.Show();
            }
            else
            {
                playersModule.Focus();
            }
        }

        private void menuItemPagos_Click(object sender, EventArgs e)
        {
            showPaysModule();
        }

        private void menuItemNiveles_Click(object sender, EventArgs e)
        {
            showLevelsModule();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void entrenamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showTrainginsModule();
        }

        private void escuelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSchoolsModule();
        }

        private void menuItemJugadores_Click(object sender, EventArgs e)
        {
            showPlayersModule();
        }
    }
}
