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
    public partial class SchoolLevels : Form
    {
        public SchoolLevels()
        {
            InitializeComponent();
        }

        private void SchoolLevels_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = new Size(this.Width + 100, this.Height + 100);
        }
    }
}
