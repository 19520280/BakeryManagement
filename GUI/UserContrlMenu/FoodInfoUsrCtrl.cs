using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.UserContrlMenu
{
    public partial class FoodInfoUsrCtrl : UserControl
    {
        public FoodInfoUsrCtrl()
        {
            InitializeComponent();
        }
        public Image PicFood
        {
            get { return this.picFood.Image; }
            set { this.picFood.Image = value; }
        }
        public string ItemName
        {
            get { return this.lbName.Text; }
            set { this.lbName.Text = value; }
        }
        public string Price
        {
            get { return this.lbPrice.Text; }
            set { this.lbPrice.Text = value; }
        }
        public void Activate()
        {
            this.BackColor = Styles.RGBs.blue;
            this.lbName.ForeColor = Color.White;
            this.lbPrice.ForeColor = Color.White;
        }
        public void Disable()
        {
            this.BackColor = SystemColors.Control;
            this.lbName.ForeColor = Color.White;
            this.lbPrice.ForeColor = Color.White;
        }
    }
}
