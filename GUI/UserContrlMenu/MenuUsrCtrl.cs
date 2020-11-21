using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI.UserContrlMenu
{
    public partial class FoodUsrControl : UserControl
    {
        private Guna2Button currButton;
        private Panel bottomBorderBtn;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodUsrControl));
        public FoodUsrControl()
        {
            InitializeComponent();
            bottomBorderBtn = new Panel();
            bottomBorderBtn.Size = new Size(69, 2);
            bottomBorderBtn.BackColor = Styles.RGBs.pink;
            pnList.Controls.Add(bottomBorderBtn);
        }
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                //Button
                DisableButton();
                currButton = (Guna2Button)senderButton;
                currButton.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //Border Button
                bottomBorderBtn.Location = new Point(currButton.Location.X, 49);
                bottomBorderBtn.Visible = true;
                bottomBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnOrdered_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private bool click = false;
        private void icSixtrix_Click(object sender, EventArgs e)
        {
            if (!click)
            {
                this.txbSearch.Visible = true;
                this.icSistrix.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                this.icSistrix.BackColor = Color.White;
            }
            else
            {
                this.txbSearch.Visible = false;
                this.icSistrix.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
                this.icSistrix.BackColor = SystemColors.Control;
            }
            click = !click;
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
