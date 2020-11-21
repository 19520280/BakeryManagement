namespace GUI.UserContrlMenu
{
    partial class FoodUsrControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodUsrControl));
            this.pnList = new Guna.UI2.WinForms.Guna2Panel();
            this.icSistrix = new FontAwesome.Sharp.IconPictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.layoutListFood = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.foodInfoUsrCtrl1 = new GUI.UserContrlMenu.FoodInfoUsrCtrl();
            this.pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icSistrix)).BeginInit();
            this.layoutListFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnList
            // 
            this.pnList.BorderColor = System.Drawing.Color.Transparent;
            this.pnList.BorderThickness = 2;
            this.pnList.Controls.Add(this.icSistrix);
            this.pnList.Controls.Add(this.pnLine);
            this.pnList.Controls.Add(this.btnAll);
            this.pnList.Controls.Add(this.txbSearch);
            this.pnList.Location = new System.Drawing.Point(0, 0);
            this.pnList.Name = "pnList";
            this.pnList.ShadowDecoration.Parent = this.pnList;
            this.pnList.Size = new System.Drawing.Size(644, 51);
            this.pnList.TabIndex = 0;
            // 
            // icSistrix
            // 
            this.icSistrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.icSistrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icSistrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icSistrix.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.icSistrix.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icSistrix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icSistrix.IconSize = 25;
            this.icSistrix.Location = new System.Drawing.Point(589, 15);
            this.icSistrix.Name = "icSistrix";
            this.icSistrix.Size = new System.Drawing.Size(25, 25);
            this.icSistrix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icSistrix.TabIndex = 6;
            this.icSistrix.TabStop = false;
            this.icSistrix.WaitOnLoad = true;
            this.icSistrix.Click += new System.EventHandler(this.icSixtrix_Click);
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnLine.Location = new System.Drawing.Point(0, 50);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(644, 1);
            this.pnLine.TabIndex = 3;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BorderColor = System.Drawing.Color.Transparent;
            this.btnAll.CheckedState.Parent = this.btnAll;
            this.btnAll.CustomImages.Parent = this.btnAll;
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAll.FillColor = System.Drawing.Color.Transparent;
            this.btnAll.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnAll.HoverState.Parent = this.btnAll;
            this.btnAll.Location = new System.Drawing.Point(0, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.PressedColor = System.Drawing.Color.Transparent;
            this.btnAll.ShadowDecoration.BorderRadius = 0;
            this.btnAll.ShadowDecoration.Parent = this.btnAll;
            this.btnAll.Size = new System.Drawing.Size(69, 51);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.TextOffset = new System.Drawing.Point(0, 4);
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSearch.BorderRadius = 15;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultText = "";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.Parent = this.txbSearch;
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSearch.FocusedState.Parent = this.txbSearch;
            this.txbSearch.Font = new System.Drawing.Font("Roboto", 9F);
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSearch.HoverState.Parent = this.txbSearch;
            this.txbSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbSearch.IconLeft")));
            this.txbSearch.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.txbSearch.Location = new System.Drawing.Point(375, 10);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSearch.PlaceholderText = "Enter your food...";
            this.txbSearch.SelectedText = "";
            this.txbSearch.ShadowDecoration.Parent = this.txbSearch;
            this.txbSearch.Size = new System.Drawing.Size(250, 34);
            this.txbSearch.TabIndex = 5;
            this.txbSearch.Visible = false;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // layoutListFood
            // 
            this.layoutListFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.layoutListFood.BackColor = System.Drawing.Color.Transparent;
            this.layoutListFood.Controls.Add(this.foodInfoUsrCtrl1);
            this.layoutListFood.Location = new System.Drawing.Point(0, 50);
            this.layoutListFood.MaximumSize = new System.Drawing.Size(644, 684);
            this.layoutListFood.Name = "layoutListFood";
            this.layoutListFood.Size = new System.Drawing.Size(644, 498);
            this.layoutListFood.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // foodInfoUsrCtrl1
            // 
            this.foodInfoUsrCtrl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodInfoUsrCtrl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodInfoUsrCtrl1.ItemName = "Item Name";
            this.foodInfoUsrCtrl1.Location = new System.Drawing.Point(3, 3);
            this.foodInfoUsrCtrl1.MaximumSize = new System.Drawing.Size(115, 180);
            this.foodInfoUsrCtrl1.MinimumSize = new System.Drawing.Size(115, 130);
            this.foodInfoUsrCtrl1.Name = "foodInfoUsrCtrl1";
            this.foodInfoUsrCtrl1.PicFood = null;
            this.foodInfoUsrCtrl1.Price = "Price";
            this.foodInfoUsrCtrl1.Size = new System.Drawing.Size(115, 130);
            this.foodInfoUsrCtrl1.TabIndex = 0;
            // 
            // FoodUsrControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.layoutListFood);
            this.MaximumSize = new System.Drawing.Size(644, 731);
            this.Name = "FoodUsrControl";
            this.Size = new System.Drawing.Size(644, 548);
            this.pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icSistrix)).EndInit();
            this.layoutListFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnList;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private System.Windows.Forms.FlowLayoutPanel layoutListFood;
        private System.Windows.Forms.Panel pnLine;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private FontAwesome.Sharp.IconPictureBox icSistrix;
        private FoodInfoUsrCtrl foodInfoUsrCtrl1;
    }
}
