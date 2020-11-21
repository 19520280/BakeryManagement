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
    public partial class BillInfoUsrCtrl : UserControl
    {
        public BillInfoUsrCtrl()
        {
            InitializeComponent();
            this.lbTotal.Text = this.lbPrice.Text;
        }
        public string NO
        {
            get { return this.lbNO.Text; }
            set
            {
                this.lbNO.Text = value;
            }
        }
        public string ItemName
        {
            get { return this.lbName.Text; }
            set { this.lbName.Text = value; }
        }

        public string Price
        {
            get { return this.lbPrice.Text; }
            set
            {
                if (Convert.ToInt32(value) > 0)
                    this.lbPrice.Text = value;
            }
        }
        public string Note
        {
            get { return this.txbNote.Text; }
            set { this.txbNote.Text = value; }
        }
        public int QTY
        { get { return Convert.ToInt32(this.numericQTY.Value); } }
        private void ComputeTotal()
        {
            uint total = Convert.ToUInt32(Price) * Convert.ToUInt32(QTY);
            this.lbTotal.Text = Convert.ToString(total);
        }

        private void numericQTY_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void icBtnTrash_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
