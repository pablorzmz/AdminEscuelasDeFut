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
        private static Pays paysModule;
        private static Levels levelsModule;
        private static Trainings trainingsModule;
        private static Schools schoolsModule;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
        }

        /**
         * 
        **/
        public static void showPaysModule()
        {
            if ( paysModule == null )
            {
                paysModule = new Pays();
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
        public static void showLevelsModule()
        {
            if ( levelsModule == null )
            {
                levelsModule = new Levels();
                levelsModule.Show();
            }
            else
            {
                levelsModule.Focus();
            }
        }

        public static void showTrainginsModule()
        {
            if ( trainingsModule == null )
            {
                trainingsModule = new Trainings();
                trainingsModule.Show();
            }
            else
            {
                trainingsModule.Focus();
            }
        }

        public static void showSchoolsModule()
        {
            if (schoolsModule == null)
            {
                schoolsModule = new Schools();
                schoolsModule.Show();
            }
            else
            {
                schoolsModule.Focus();
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
    }
}
