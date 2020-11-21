namespace GUI
{
    partial class FormHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnCashier = new Guna.UI2.WinForms.Guna2Button();
            this.btnManager = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel
            // 
            this.guna2ShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel.Controls.Add(this.btnClose);
            this.guna2ShadowPanel.Controls.Add(this.btnManager);
            this.guna2ShadowPanel.Controls.Add(this.btnCashier);
            this.guna2ShadowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.guna2ShadowPanel.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel.Name = "guna2ShadowPanel";
            this.guna2ShadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel.ShadowShift = 0;
            this.guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel.Size = new System.Drawing.Size(361, 319);
            this.guna2ShadowPanel.TabIndex = 0;
            // 
            // btnCashier
            // 
            this.btnCashier.BorderColor = System.Drawing.Color.White;
            this.btnCashier.CheckedState.Parent = this.btnCashier;
            this.btnCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashier.CustomImages.Parent = this.btnCashier;
            this.btnCashier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCashier.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold);
            this.btnCashier.ForeColor = System.Drawing.Color.White;
            this.btnCashier.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.btnCashier.HoverState.Parent = this.btnCashier;
            this.btnCashier.Image = ((System.Drawing.Image)(resources.GetObject("btnCashier.Image")));
            this.btnCashier.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCashier.Location = new System.Drawing.Point(88, 46);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.btnCashier.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnCashier.ShadowDecoration.Depth = 100;
            this.btnCashier.ShadowDecoration.Enabled = true;
            this.btnCashier.ShadowDecoration.Parent = this.btnCashier;
            this.btnCashier.Size = new System.Drawing.Size(197, 73);
            this.btnCashier.TabIndex = 0;
            this.btnCashier.Text = "CASHIER";
            this.btnCashier.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnCashier.UseTransparentBackground = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnManager
            // 
            this.btnManager.BorderColor = System.Drawing.Color.White;
            this.btnManager.CheckedState.Parent = this.btnManager;
            this.btnManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManager.CustomImages.Parent = this.btnManager;
            this.btnManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnManager.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.btnManager.HoverState.Parent = this.btnManager;
            this.btnManager.Image = ((System.Drawing.Image)(resources.GetObject("btnManager.Image")));
            this.btnManager.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManager.Location = new System.Drawing.Point(88, 140);
            this.btnManager.Name = "btnManager";
            this.btnManager.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.btnManager.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btnManager.ShadowDecoration.Depth = 100;
            this.btnManager.ShadowDecoration.Enabled = true;
            this.btnManager.ShadowDecoration.Parent = this.btnManager;
            this.btnManager.Size = new System.Drawing.Size(197, 73);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "MANAGER";
            this.btnManager.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnManager.UseTransparentBackground = true;
            this.btnManager.Click += new System.EventHandler(this.btnManger_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(129, 229);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Transparent;
            this.btnClose.ShadowDecoration.Depth = 69;
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(115, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 319);
            this.Controls.Add(this.guna2ShadowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.guna2ShadowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel;
        private Guna.UI2.WinForms.Guna2Button btnCashier;
        private Guna.UI2.WinForms.Guna2Button btnManager;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}