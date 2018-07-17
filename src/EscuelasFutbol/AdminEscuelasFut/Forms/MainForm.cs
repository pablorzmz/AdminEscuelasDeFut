using System;
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
            splashScreen s = new splashScreen( this );            
            s.Show();
            this.Hide();
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

            trainingsModule = new Trainings();
            schoolsModule   = new Schools();
            playersModule   = new Players();
            paysModule      = new Pays();
            levelsModule    = new Levels();
            
            trainingsModule.MdiParent = this;
            schoolsModule.MdiParent   = this;
            playersModule.MdiParent   = this;
            paysModule.MdiParent      = this;
            levelsModule.MdiParent    = this;
            Connection c = new Connection();
            c.testConnection();
        }

        /**
         * 
        **/
        public void showPaysModule()
        {
            if ( paysModule.IsDisposed )
            {
                paysModule = new Pays();
                paysModule.MdiParent = this;                                
            }
            paysModule.Show();
            paysModule.Focus();
        }

        /**
         * 
        **/
        public void showLevelsModule()
        {
            if ( levelsModule.IsDisposed )
            {
                levelsModule = new Levels();
                levelsModule.MdiParent = this;  
            }

            levelsModule.Show();
            levelsModule.Focus();
        }

        public void showTrainginsModule()
        {
            if ( trainingsModule.IsDisposed )
            {
                trainingsModule = new Trainings();
                trainingsModule.MdiParent = this;
            }
            trainingsModule.Show();
            trainingsModule.Focus();
        }

        public void showSchoolsModule()
        {
            if (schoolsModule.IsDisposed )
            {
                schoolsModule = new Schools();
                schoolsModule.MdiParent = this;                
            }

            schoolsModule.Show();
            schoolsModule.Focus();
        }
        public void showPlayersModule()
        {
            if (playersModule.IsDisposed )
            {
                playersModule = new Players();
                playersModule.MdiParent = this;                
            }

            playersModule.Show();
            playersModule.Focus();
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
            bool result = Utilities.showQuestionMessage("¿Desea salir de la aplicación?", "Salir del sistema");
            if (result)
                this.Close();
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool result = Utilities.showQuestionMessage("¿Desea salir de la aplicación?", "Salir del sistema");
            if (!result)
            {
                e.Cancel = true;
            }
        }       
    }
}
