namespace GUI.UserContrlMenu
{
    partial class TableUsrCtrl
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
            this.pnList = new Guna.UI2.WinForms.Guna2Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.btnEmpty = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrdered = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.layoutListTable = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnList
            // 
            this.pnList.BorderColor = System.Drawing.Color.Transparent;
            this.pnList.BorderThickness = 2;
            this.pnList.Controls.Add(this.pnLine);
            this.pnList.Controls.Add(this.btnEmpty);
            this.pnList.Controls.Add(this.btnOrdered);
            this.pnList.Controls.Add(this.btnAll);
            this.pnList.Location = new System.Drawing.Point(0, 0);
            this.pnList.Name = "pnList";
            this.pnList.ShadowDecoration.Parent = this.pnList;
            this.pnList.Size = new System.Drawing.Size(644, 51);
            this.pnList.TabIndex = 0;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnLine.Location = new System.Drawing.Point(0, 50);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(644, 1);
            this.pnLine.TabIndex = 3;
            // 
            // btnEmpty
            // 
            this.btnEmpty.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpty.BorderColor = System.Drawing.Color.Transparent;
            this.btnEmpty.CheckedState.Parent = this.btnEmpty;
            this.btnEmpty.CustomImages.Parent = this.btnEmpty;
            this.btnEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmpty.FillColor = System.Drawing.Color.Transparent;
            this.btnEmpty.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnEmpty.HoverState.Parent = this.btnEmpty;
            this.btnEmpty.Location = new System.Drawing.Point(138, 0);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.PressedColor = System.Drawing.Color.Transparent;
            this.btnEmpty.ShadowDecoration.BorderRadius = 0;
            this.btnEmpty.ShadowDecoration.Parent = this.btnEmpty;
            this.btnEmpty.Size = new System.Drawing.Size(69, 51);
            this.btnEmpty.TabIndex = 5;
            this.btnEmpty.Text = "Empty";
            this.btnEmpty.TextOffset = new System.Drawing.Point(0, 4);
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnOrdered
            // 
            this.btnOrdered.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdered.BorderColor = System.Drawing.Color.Transparent;
            this.btnOrdered.CheckedState.Parent = this.btnOrdered;
            this.btnOrdered.CustomImages.Parent = this.btnOrdered;
            this.btnOrdered.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrdered.FillColor = System.Drawing.Color.Transparent;
            this.btnOrdered.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnOrdered.HoverState.Parent = this.btnOrdered;
            this.btnOrdered.Location = new System.Drawing.Point(69, 0);
            this.btnOrdered.Name = "btnOrdered";
            this.btnOrdered.PressedColor = System.Drawing.Color.Transparent;
            this.btnOrdered.ShadowDecoration.BorderRadius = 0;
            this.btnOrdered.ShadowDecoration.Parent = this.btnOrdered;
            this.btnOrdered.Size = new System.Drawing.Size(69, 51);
            this.btnOrdered.TabIndex = 4;
            this.btnOrdered.Text = "Ordered";
            this.btnOrdered.TextOffset = new System.Drawing.Point(0, 4);
            this.btnOrdered.Click += new System.EventHandler(this.btnOrdered_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BorderColor = System.Drawing.Color.Transparent;
            this.btnAll.CheckedState.Parent = this.btnAll;
            this.btnAll.CustomImages.Parent = this.btnAll;
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAll.FillColor = System.Drawing.Color.Transparent;
            this.btnAll.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // layoutListTable
            // 
            this.layoutListTable.BackColor = System.Drawing.SystemColors.Control;
            this.layoutListTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutListTable.Location = new System.Drawing.Point(0, 0);
            this.layoutListTable.MaximumSize = new System.Drawing.Size(644, 684);
            this.layoutListTable.Name = "layoutListTable";
            this.layoutListTable.Size = new System.Drawing.Size(644, 501);
            this.layoutListTable.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // TableUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.layoutListTable);
            this.MaximumSize = new System.Drawing.Size(644, 731);
            this.Name = "TableUsrCtrl";
            this.Size = new System.Drawing.Size(644, 548);
            this.pnList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnList;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private System.Windows.Forms.FlowLayoutPanel layoutListTable;
        private System.Windows.Forms.Panel pnLine;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnEmpty;
        private Guna.UI2.WinForms.Guna2Button btnOrdered;
    }
}
