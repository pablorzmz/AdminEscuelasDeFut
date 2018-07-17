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
        private C_Pays paysController;
        private  PlayerPaysQuery playerPaysQuery;
        private DataAccess dataAccess;

        public Pays()
        {
            InitializeComponent();
            paysController = new C_Pays();
        }

        private void Pays_Load(object sender, EventArgs e)
        {
            cmbInitalMonth.Enabled = false;
            cmbFinalMonth.Enabled = false;
            paysController.fillSchoolsComboBox(this.cboEscuelas);
            paysController.fillMonthsComboBox(this.cmbInitalMonth, 'I');
            paysController.fillMonthsComboBox(this.cmbFinalMonth, 'F');
        }

        private void cleanInput()
        {
            txtAmountRPaymentPlayer.Text = "";
            txtIDRPaymentPlayer.Text = "";
            txtNameRPaymentPlayer.Text = "";
            txtReceiptNumberRPaymentPlayer.Text = "";
            txbDetail.Text = "";
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
                cmbInitalMonth.Enabled = true;
                cmbFinalMonth.Enabled = true;
            }
            else
            {
                cmbInitalMonth.Enabled = false;
                cmbFinalMonth.Enabled = false;
            }
        }

        private void chbxAnnuityRPaymentPlayer_CheckedChanged(object sender, EventArgs e)
        {
            /*if (chbxAnnuityRPaymentPlayer.Checked)
            {
                dtpFechaMatricula.Enabled = true;
            }
            else
            {
                dtpFechaMatricula.Enabled = false;
            }*/
        }

        private void txtNameRPaymentPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

       

        private void txtAmountRPaymentPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txtReceiptNumberRPaymentPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboEscuelas.SelectedIndex == 0) {
                MessageBox.Show("Debe seleccionar una escuela");
            } else {
                List<String> parameters = new List<String>();
                /*0*/
                parameters.Add(txtIDRPaymentPlayer.Text);
                /*1*/
                parameters.Add(txtReceiptNumberRPaymentPlayer.Text);
                /*2*/
                parameters.Add(cboEscuelas.SelectedItem.ToString());
                paysController.fillPaysDataGridView(dgvPagosJugador, parameters);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            paysController.fillIDPlayerDataGridView(dgvPagosJugador);
        }

        private void btnRegisterRPaymentPlayer_Click(object sender, EventArgs e)
        {
            if (cboEscuelas.SelectedIndex == 0)
            {
                MessageBox.Show("El valor para la escuela del jugador es inválido");
                cboEscuelas.Focus();
            }
            else if (txtReceiptNumberRPaymentPlayer.Text == "")
            {
                MessageBox.Show("El valor para el numero de recibo es inválido");
                txtReceiptNumberRPaymentPlayer.Focus();
            }
            else if (txtAmountRPaymentPlayer.Text == "")
            {
                MessageBox.Show("El valor para el monto es invalido");
                txtAmountRPaymentPlayer.Focus();

            }
            else if (ckbxMonthlyRPaymentPlayer.CheckState == CheckState.Unchecked && chbxAnnuityRPaymentPlayer.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Debe seleccionar, al menos, un tipo de pago");
                ckbxMonthlyRPaymentPlayer.Focus();
                chbxAnnuityRPaymentPlayer.Focus();
            }
            else if (txtIDRPaymentPlayer.Text == "")
            {
                MessageBox.Show("El valor para la cedula del jugador es invalido");
                txtIDRPaymentPlayer.Focus();
            }else if (ckbxMonthlyRPaymentPlayer.CheckState == CheckState.Checked && (cmbInitalMonth.SelectedIndex == 0 || cmbFinalMonth.SelectedIndex == 0))
            {
                MessageBox.Show("Debe seleccionar mes de inicio y mes final");
                cmbInitalMonth.Focus();
                cmbFinalMonth.Focus();
            }
            else
            {
                bool r = Utilities.showQuestionMessage("¿Desea insertar el nuevo registro del pago: " +
                       "\nCédula: " + txtIDRPaymentPlayer.Text + "\nRecibo: " + txtReceiptNumberRPaymentPlayer.Text + "\nMonto: " + txtAmountRPaymentPlayer.Text, "Insertar nuevo pago");
                if (r)
                {
                    List<String> args = new List<string>();

                    if (ckbxMonthlyRPaymentPlayer.CheckState == CheckState.Checked || chbxAnnuityRPaymentPlayer.CheckState == CheckState.Checked)
                    {
                        /*0*/
                        args.Add(cboEscuelas.SelectedItem.ToString());
                        /*1*/
                        args.Add(txtReceiptNumberRPaymentPlayer.Text);
                        /*2*/
                        args.Add(dtpFechaMatricula.Value.ToString("yyyy-MM-dd"));
                        /*3*/
                        args.Add(txtAmountRPaymentPlayer.Text);
                        /*4*/
                        args.Add(txbDetail.Text);
                        /*5*/
                        args.Add(txtIDRPaymentPlayer.Text);

                        if (ckbxMonthlyRPaymentPlayer.CheckState == CheckState.Checked && chbxAnnuityRPaymentPlayer.CheckState == CheckState.Checked)
                        {
                            args.Add("2");
                        }
                        else if (ckbxMonthlyRPaymentPlayer.CheckState == CheckState.Checked && chbxAnnuityRPaymentPlayer.CheckState == CheckState.Unchecked)
                        {
                            args.Add("1");
                        }
                        else
                        {
                            args.Add("0");

                        }
                        int result = paysController.insertNewPay(args);

                        if (result == 0)
                        {
                            MessageBox.Show("Datos válidos");
                            if (ckbxMonthlyRPaymentPlayer.CheckState == CheckState.Checked)
                            {
                                string initialMonth = cmbInitalMonth.Text;
                                string finalMonth = cmbFinalMonth.Text;
                                args.Clear();
                                /*0*/
                                args.Add(cboEscuelas.SelectedItem.ToString());
                                /*1*/
                                args.Add(txtReceiptNumberRPaymentPlayer.Text);
                                int year = dtpFechaMatricula.Value.Year;
                                paysController.insertNewMonthPay(args, initialMonth, finalMonth, year);
                            }
                            args.Clear();
                            args.Add(txtIDRPaymentPlayer.Text);
                            args.Add("");
                            args.Add(cboEscuelas.SelectedItem.ToString());
                            paysController.fillPaysDataGridView(dgvPagosJugador, args);
                            cleanInput();
                            MessageBox.Show("Pago registrados correctamente");
                        }
                        else {
                            if (result == Utilities.DUPLICATED_KEY)
                            {
                                Utilities.showErrorMessage("El registro que desea insertar ya se encuentra en la base de datos", "No se pudo registrar el pago");
                            } else if (result == 547) {
                                Utilities.showErrorMessage("El numero de cedula ingresado es incorrecto", "No se pudo registrar el pago");
                            }
                            else
                            {
                                Utilities.showErrorMessage("Error(" + result + ") al registrar el jugador", "Excepción al registrar jugador");
                            }
                        }
                    }
                }
            }
        }

        private void Pays_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool r = Utilities.showQuestionMessage("¿Desea salir del módulo de pagos?",
               "Módulo de pagos");
            if (!r)
            {
                e.Cancel = true;
            }
        }

        private void dgvPagosJugador_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<String> buffer = new List<string>();
            Utilities.readCurrentRowFromDataGridView(dgvPagosJugador, e.RowIndex, dgvPagosJugador.ColumnCount, buffer);
            if (buffer.Count < 6)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvPagosJugador.RowCount - 1)
                {
                    txtIDRPaymentPlayer.Text = buffer[0];
                    txtNameRPaymentPlayer.Text = buffer[1];
                }
            }
            else
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvPagosJugador.RowCount - 1)
                {
                    txtIDRPaymentPlayer.Text = buffer[1];
                    txtReceiptNumberRPaymentPlayer.Text = buffer[2];
                    txtNameRPaymentPlayer.Text = buffer[0];
                    txtAmountRPaymentPlayer.Text = buffer[4];
                    txbDetail.Text = buffer[5];
                    cboEscuelas.SelectedItem = buffer[6];
                }
            }
        }

        private void txtIDRPaymentPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txtAmountRPaymentPlayer_TextChanged(object sender, KeyPressEventArgs e)
        {
            Utilities.validateNumbers(sender, e, false);
        }

        private void txbDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }

        private void txtNameRPaymentPlayer_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utilities.controlSQLInjection(sender, e);
        }
    }
}
