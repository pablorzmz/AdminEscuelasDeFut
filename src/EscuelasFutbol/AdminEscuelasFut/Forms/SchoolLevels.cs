﻿using System;
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
        private C_SchoolLevels schoolLevelsController;
        private List<String> dataTemp;

        public SchoolLevels()
        {
            InitializeComponent();
            schoolLevelsController = new C_SchoolLevels();
            dataTemp = new List<string>();
        }

        private void SchoolLevels_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = new Size(this.Width + 100, this.Height + 100);
            schoolLevelsController.fillLevesComboBox(this.cmbSchoolLevel);
            schoolLevelsController.fillSchoolsComboBox(this.cmbSchoolName);
            schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMinimumAgeSchoolLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txtMaximumAgeSchoolLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void cleanInput()
        {
            cmbSchoolName.SelectedItem = 0;
            cmbSchoolLevel.SelectedItem = 0;
        }

        private void btnConsultar_MouseClick(object sender, MouseEventArgs e)
        {
            List<String> parameters = new List<String>();
            parameters.Add(cmbSchoolName.SelectedItem.ToString());
            schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, parameters);
        }

        private void dgvSchoolLevels_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cleanInput();
            if (e.RowIndex >= 0 && e.RowIndex < dgvSchoolLevels.RowCount - 1)
            {
                List<String> buffer = new List<string>();
                Utilities.readCurrentRowFromDataGridView(dgvSchoolLevels, e.RowIndex, dgvSchoolLevels.ColumnCount, buffer);
                cmbSchoolName.SelectedItem = buffer[0];
                int levelNumber = int.Parse(buffer[1]);
                cmbSchoolLevel.SelectedIndex = levelNumber;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (cmbSchoolName.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar una Escuela válida");
                cmbSchoolName.Focus();
                error = true;
            }
            if (cmbSchoolLevel.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar un Nivel válido");
                cmbSchoolLevel.Focus();
                error = true;
            }
            if (!error)
            {
                List<String> args = new List<string>();
                args.Add(cmbSchoolName.SelectedItem.ToString());
                args.Add(cmbSchoolLevel.SelectedItem.ToString());
                int result = schoolLevelsController.insertSchoolLevels(args);
                if (result == 0)
                {
                    MessageBox.Show("Insercion Exitosa");
                    cleanInput();
                    schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
                }
                else
                {
                    MessageBox.Show("Error número: " + result.ToString());
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (cmbSchoolName.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar una Escuela válida");
                cmbSchoolName.Focus();
                error = true;
            }
            if (cmbSchoolLevel.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar un Nivel válido");
                cmbSchoolLevel.Focus();
                error = true;
            }
            if (!error)
            {
                List<String> args = new List<string>();
                args.Add(cmbSchoolName.SelectedItem.ToString());
                args.Add(cmbSchoolLevel.SelectedItem.ToString());
                int result = schoolLevelsController.deleteSchoolLevels(args);
                if (result == 0)
                {
                    MessageBox.Show("Borrado Exitoso");
                    cleanInput();
                    schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
                }
                else
                {
                    MessageBox.Show("Error número: " + result.ToString());
                }
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            setVisibleBtn(false);
            dataTemp.Add(cmbSchoolLevel.SelectedItem.ToString());
        }

        public void setVisibleBtn(bool visible)
        {
            btnBorrar.Visible = visible;
            btnConsultar.Visible = visible;
            btnRegistrar.Visible = visible;
            btnActualizar.Visible = visible;

            btnGuardar.Visible = !visible;
            btnDescartar.Visible = !visible;
            cmbSchoolName.Enabled = visible;
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            cleanInput();
            setVisibleBtn(true);
            dataTemp.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataTemp.Add(cmbSchoolLevel.SelectedItem.ToString());
            dataTemp.Add(cmbSchoolName.SelectedItem.ToString());
            schoolLevelsController.updateSchoolLevelsInfo(dataTemp);
            schoolLevelsController.fillSchoolsLevelsDataGridView(dgvSchoolLevels, null);
            dataTemp.Clear();
            setVisibleBtn(true);
        }

        
    }
}
