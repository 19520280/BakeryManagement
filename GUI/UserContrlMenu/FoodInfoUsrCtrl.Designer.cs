namespace GUI.UserContrlMenu
{
    partial class FoodInfoUsrCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.picFood = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.shadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // shadowPanel
            // 
            this.shadowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.shadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel.Controls.Add(this.lbName);
            this.shadowPanel.Controls.Add(this.picFood);
            this.shadowPanel.Controls.Add(this.lbPrice);
            this.shadowPanel.FillColor = System.Drawing.Color.White;
            this.shadowPanel.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel.MaximumSize = new System.Drawing.Size(115, 180);
            this.shadowPanel.MinimumSize = new System.Drawing.Size(115, 130);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanel.ShadowShift = 4;
            this.shadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.shadowPanel.Size = new System.Drawing.Size(115, 130);
            this.shadowPanel.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbName.Location = new System.Drawing.Point(3, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(107, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Item Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFood
            // 
            this.picFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picFood.FillColor = System.Drawing.Color.DimGray;
            this.picFood.Location = new System.Drawing.Point(2, 2);
            this.picFood.MaximumSize = new System.Drawing.Size(111, 115);
            this.picFood.MinimumSize = new System.Drawing.Size(111, 70);
            this.picFood.Name = "picFood";
            this.picFood.ShadowDecoration.Parent = this.picFood;
            this.picFood.Size = new System.Drawing.Size(111, 70);
            this.picFood.TabIndex = 0;
            this.picFood.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbPrice.Location = new System.Drawing.Point(4, 98);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(107, 22);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "0";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodInfoUsrCtrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.shadowPanel);
            this.MaximumSize = new System.Drawing.Size(115, 180);
            this.MinimumSize = new System.Drawing.Size(115, 130);
            this.Name = "FoodInfoUsrCtrl";
            this.Size = new System.Drawing.Size(115, 130);
            this.shadowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel shadowPanel;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2PictureBox picFood;
        private System.Windows.Forms.Label lbPrice;
    }
}
