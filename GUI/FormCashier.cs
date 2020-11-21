using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCashier : Form
    {
        private IconButton currButton;
        public FormCashier()
        {
            InitializeComponent();
        }
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                //Button
                DisableButton();
                currButton = (IconButton)senderButton;
                currButton.ForeColor = Styles.RGBs.pink;
                currButton.IconColor = Styles.RGBs.pink;
                currButton.BackColor = SystemColors.Control;
                currButton.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            }
        }
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.ForeColor = SystemColors.Control;
                currButton.IconColor = SystemColors.Control;
                currButton.BackColor = Styles.RGBs.dark;
                currButton.FlatAppearance.MouseOverBackColor = Styles.RGBs.pink;
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.usrCtrlTable.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            ActivateButton(sender);
            this.usrCtrlMenu.BringToFront();
        }

        private void lbPercent_Click(object sender, EventArgs e)
        {

        }

        private void pnPaymentInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNote_Click(object sender, EventArgs e)
        {

        }
    }
}
