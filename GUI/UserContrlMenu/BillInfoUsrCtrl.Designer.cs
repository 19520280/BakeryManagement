namespace GUI.UserContrlMenu
{
    partial class BillInfoUsrCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillInfoUsrCtrl));
            this.lbNO = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txbNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.numericQTY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbTotal = new System.Windows.Forms.Label();
            this.icBtnTrash = new FontAwesome.Sharp.IconButton();
            this.shadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericQTY)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNO
            // 
            this.lbNO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNO.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbNO.Location = new System.Drawing.Point(0, 2);
            this.lbNO.Name = "lbNO";
            this.lbNO.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbNO.Size = new System.Drawing.Size(28, 51);
            this.lbNO.TabIndex = 0;
            this.lbNO.Text = "1.";
            this.lbNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNO.UseCompatibleTextRendering = true;
            this.lbNO.UseMnemonic = false;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbName.Location = new System.Drawing.Point(36, 2);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbName.Size = new System.Drawing.Size(204, 39);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Item name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.UseCompatibleTextRendering = true;
            this.lbName.UseMnemonic = false;
            // 
            // txbNote
            // 
            this.txbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNote.BorderRadius = 10;
            this.txbNote.BorderThickness = 0;
            this.txbNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNote.DefaultText = "";
            this.txbNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNote.DisabledState.Parent = this.txbNote;
            this.txbNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNote.FillColor = System.Drawing.SystemColors.Control;
            this.txbNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNote.FocusedState.FillColor = System.Drawing.Color.White;
            this.txbNote.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbNote.FocusedState.Parent = this.txbNote;
            this.txbNote.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNote.HoverState.FillColor = System.Drawing.Color.White;
            this.txbNote.HoverState.Parent = this.txbNote;
            this.txbNote.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbNote.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbNote.IconLeft")));
            this.txbNote.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txbNote.Location = new System.Drawing.Point(36, 33);
            this.txbNote.Name = "txbNote";
            this.txbNote.PasswordChar = '\0';
            this.txbNote.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbNote.PlaceholderText = "Note";
            this.txbNote.SelectedText = "";
            this.txbNote.ShadowDecoration.Parent = this.txbNote;
            this.txbNote.Size = new System.Drawing.Size(204, 25);
            this.txbNote.TabIndex = 4;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbPrice.Location = new System.Drawing.Point(248, 10);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbPrice.Size = new System.Drawing.Size(129, 39);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "0";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPrice.UseCompatibleTextRendering = true;
            this.lbPrice.UseMnemonic = false;
            // 
            // numericQTY
            // 
            this.numericQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericQTY.BackColor = System.Drawing.Color.Transparent;
            this.numericQTY.BorderRadius = 10;
            this.numericQTY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericQTY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numericQTY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numericQTY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numericQTY.DisabledState.Parent = this.numericQTY;
            this.numericQTY.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numericQTY.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numericQTY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.numericQTY.FocusedState.Parent = this.numericQTY;
            this.numericQTY.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericQTY.ForeColor = System.Drawing.Color.DimGray;
            this.numericQTY.Location = new System.Drawing.Point(383, 10);
            this.numericQTY.Name = "numericQTY";
            this.numericQTY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericQTY.ShadowDecoration.Parent = this.numericQTY;
            this.numericQTY.Size = new System.Drawing.Size(84, 39);
            this.numericQTY.TabIndex = 6;
            this.numericQTY.ThousandsSeparator = true;
            this.numericQTY.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.numericQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQTY.ValueChanged += new System.EventHandler(this.numericQTY_ValueChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTotal.Location = new System.Drawing.Point(475, 10);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbTotal.Size = new System.Drawing.Size(108, 39);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "Total";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTotal.UseCompatibleTextRendering = true;
            this.lbTotal.UseMnemonic = false;
            // 
            // icBtnTrash
            // 
            this.icBtnTrash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icBtnTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icBtnTrash.FlatAppearance.BorderSize = 0;
            this.icBtnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnTrash.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icBtnTrash.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.icBtnTrash.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icBtnTrash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnTrash.IconSize = 20;
            this.icBtnTrash.Location = new System.Drawing.Point(592, 10);
            this.icBtnTrash.Name = "icBtnTrash";
            this.icBtnTrash.Rotation = 0D;
            this.icBtnTrash.Size = new System.Drawing.Size(32, 39);
            this.icBtnTrash.TabIndex = 8;
            this.icBtnTrash.UseVisualStyleBackColor = true;
            this.icBtnTrash.Click += new System.EventHandler(this.icBtnTrash_Click);
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadowPanel.FillColor = System.Drawing.SystemColors.Control;
            this.shadowPanel.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel.MaximumSize = new System.Drawing.Size(630, 66);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanel.ShadowDepth = 50;
            this.shadowPanel.ShadowShift = 2;
            this.shadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.shadowPanel.Size = new System.Drawing.Size(630, 66);
            this.shadowPanel.TabIndex = 9;
            // 
            // BillInfoUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.icBtnTrash);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.numericQTY);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txbNote);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbNO);
            this.Controls.Add(this.shadowPanel);
            this.MaximumSize = new System.Drawing.Size(630, 66);
            this.Name = "BillInfoUsrCtrl";
            this.Size = new System.Drawing.Size(630, 66);
            ((System.ComponentModel.ISupportInitialize)(this.numericQTY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNO;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2TextBox txbNote;
        private System.Windows.Forms.Label lbPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericQTY;
        private System.Windows.Forms.Label lbTotal;
        private FontAwesome.Sharp.IconButton icBtnTrash;
        private Guna.UI2.WinForms.Guna2ShadowPanel shadowPanel;
    }
}
