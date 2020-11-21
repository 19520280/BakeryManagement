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
    public partial class TableUsrCtrl : UserControl
    {
        public Guna2Button currButton;
        public Panel bottomBorderBtn;
        public TableUsrCtrl()
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

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

    }
}
