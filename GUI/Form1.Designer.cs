namespace GUI
{
    partial class FormCashier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashier));
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnRight = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnPayment = new System.Windows.Forms.Panel();
            this.btnNote = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTextTotal = new System.Windows.Forms.Label();
            this.layoutListBill = new System.Windows.Forms.FlowLayoutPanel();
            this.pnList = new Guna.UI2.WinForms.Guna2Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.icBtnTable = new FontAwesome.Sharp.IconButton();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnPaymentInfo = new System.Windows.Forms.Panel();
            this.lbTextNumQTY = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.txbSale = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTextSale = new System.Windows.Forms.Label();
            this.cmbStaff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.picStaff = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbTextSutotal = new System.Windows.Forms.Label();
            this.pnLeft = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnTable = new FontAwesome.Sharp.IconButton();
            this.ctrlMini = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.elipBtnTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipBtnMenu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.billInfoUsrCtrl1 = new GUI.UserContrlMenu.BillInfoUsrCtrl();
            this.billInfoUsrCtrl2 = new GUI.UserContrlMenu.BillInfoUsrCtrl();
            this.billInfoUsrCtrl3 = new GUI.UserContrlMenu.BillInfoUsrCtrl();
            this.usrCtrlTable = new GUI.UserContrlMenu.TableUsrCtrl();
            this.usrCtrlMenu = new GUI.UserContrlMenu.FoodUsrControl();
            this.lbTakeAway = new System.Windows.Forms.Label();
            this.toggleTakeAway = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnPayment.SuspendLayout();
            this.layoutListBill.SuspendLayout();
            this.pnList.SuspendLayout();
            this.pnPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Controls.Add(this.pnRight);
            this.pnMain.Controls.Add(this.pnLeft);
            this.pnMain.Controls.Add(this.pnHeader);
            this.pnMain.Location = new System.Drawing.Point(24, 0);
            this.pnMain.MaximumSize = new System.Drawing.Size(1318, 767);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShadowDecoration.Parent = this.pnMain;
            this.pnMain.Size = new System.Drawing.Size(1318, 589);
            this.pnMain.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRight.BackColor = System.Drawing.Color.Transparent;
            this.pnRight.Controls.Add(this.pnPayment);
            this.pnRight.Controls.Add(this.layoutListBill);
            this.pnRight.Controls.Add(this.pnList);
            this.pnRight.Controls.Add(this.pnPaymentInfo);
            this.pnRight.FillColor = System.Drawing.Color.White;
            this.pnRight.Location = new System.Drawing.Point(674, 45);
            this.pnRight.MaximumSize = new System.Drawing.Size(644, 731);
            this.pnRight.Name = "pnRight";
            this.pnRight.Radius = 5;
            this.pnRight.ShadowColor = System.Drawing.Color.Black;
            this.pnRight.ShadowShift = 6;
            this.pnRight.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnRight.Size = new System.Drawing.Size(644, 548);
            this.pnRight.TabIndex = 2;
            // 
            // pnPayment
            // 
            this.pnPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnPayment.BackColor = System.Drawing.Color.White;
            this.pnPayment.Controls.Add(this.guna2Button1);
            this.pnPayment.Controls.Add(this.btnPayment);
            this.pnPayment.Controls.Add(this.btnNote);
            this.pnPayment.Controls.Add(this.lbTotal);
            this.pnPayment.Controls.Add(this.lbTextTotal);
            this.pnPayment.Controls.Add(this.cmbStaff);
            this.pnPayment.Controls.Add(this.picStaff);
            this.pnPayment.Location = new System.Drawing.Point(3, 474);
            this.pnPayment.Name = "pnPayment";
            this.pnPayment.Size = new System.Drawing.Size(632, 65);
            this.pnPayment.TabIndex = 4;
            // 
            // btnNote
            // 
            this.btnNote.CheckedState.Parent = this.btnNote;
            this.btnNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNote.CustomImages.Parent = this.btnNote;
            this.btnNote.FillColor = System.Drawing.Color.Transparent;
            this.btnNote.Font = new System.Drawing.Font("Roboto", 11F);
            this.btnNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnNote.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNote.HoverState.Parent = this.btnNote;
            this.btnNote.Image = ((System.Drawing.Image)(resources.GetObject("btnNote.Image")));
            this.btnNote.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNote.Location = new System.Drawing.Point(6, 40);
            this.btnNote.Name = "btnNote";
            this.btnNote.PressedColor = System.Drawing.Color.White;
            this.btnNote.ShadowDecoration.Parent = this.btnNote;
            this.btnNote.Size = new System.Drawing.Size(89, 19);
            this.btnNote.TabIndex = 15;
            this.btnNote.Text = "Note";
            this.btnNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BorderColor = System.Drawing.Color.White;
            this.btnPayment.BorderRadius = 10;
            this.btnPayment.BorderThickness = 2;
            this.btnPayment.CheckedState.Parent = this.btnPayment;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.CustomBorderColor = System.Drawing.Color.White;
            this.btnPayment.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.CustomImages.Image")));
            this.btnPayment.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayment.CustomImages.ImageOffset = new System.Drawing.Point(50, 0);
            this.btnPayment.CustomImages.ImageSize = new System.Drawing.Size(28, 28);
            this.btnPayment.CustomImages.Parent = this.btnPayment;
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnPayment.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(150)))));
            this.btnPayment.HoverState.Parent = this.btnPayment;
            this.btnPayment.Location = new System.Drawing.Point(441, -1);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnPayment.ShadowDecoration.Parent = this.btnPayment;
            this.btnPayment.Size = new System.Drawing.Size(197, 69);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "PAY";
            this.btnPayment.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotal.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbTotal.Location = new System.Drawing.Point(259, 32);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(122, 25);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTextTotal
            // 
            this.lbTextTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextTotal.AutoSize = true;
            this.lbTextTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTextTotal.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbTextTotal.Location = new System.Drawing.Point(282, 7);
            this.lbTextTotal.Name = "lbTextTotal";
            this.lbTextTotal.Size = new System.Drawing.Size(76, 25);
            this.lbTextTotal.TabIndex = 2;
            this.lbTextTotal.Text = "TOTAL";
            this.lbTextTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutListBill
            // 
            this.layoutListBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.layoutListBill.AutoScroll = true;
            this.layoutListBill.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.layoutListBill.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.layoutListBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutListBill.BackColor = System.Drawing.SystemColors.Control;
            this.layoutListBill.Controls.Add(this.billInfoUsrCtrl1);
            this.layoutListBill.Controls.Add(this.billInfoUsrCtrl2);
            this.layoutListBill.Controls.Add(this.billInfoUsrCtrl3);
            this.layoutListBill.Location = new System.Drawing.Point(0, 51);
            this.layoutListBill.MaximumSize = new System.Drawing.Size(636, 684);
            this.layoutListBill.Name = "layoutListBill";
            this.layoutListBill.Size = new System.Drawing.Size(636, 358);
            this.layoutListBill.TabIndex = 2;
            // 
            // pnList
            // 
            this.pnList.BorderColor = System.Drawing.Color.Transparent;
            this.pnList.BorderThickness = 2;
            this.pnList.Controls.Add(this.toggleTakeAway);
            this.pnList.Controls.Add(this.lbTakeAway);
            this.pnList.Controls.Add(this.pnLine);
            this.pnList.Controls.Add(this.icBtnTable);
            this.pnList.Controls.Add(this.txbSearch);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnList.Location = new System.Drawing.Point(0, 0);
            this.pnList.Name = "pnList";
            this.pnList.ShadowDecoration.Parent = this.pnList;
            this.pnList.Size = new System.Drawing.Size(644, 51);
            this.pnList.TabIndex = 1;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnLine.Location = new System.Drawing.Point(0, 50);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(634, 1);
            this.pnLine.TabIndex = 3;
            // 
            // icBtnTable
            // 
            this.icBtnTable.BackColor = System.Drawing.Color.Transparent;
            this.icBtnTable.FlatAppearance.BorderSize = 0;
            this.icBtnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.icBtnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.icBtnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnTable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icBtnTable.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icBtnTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icBtnTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.icBtnTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icBtnTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnTable.IconSize = 17;
            this.icBtnTable.Location = new System.Drawing.Point(11, 0);
            this.icBtnTable.Name = "icBtnTable";
            this.icBtnTable.Rotation = 0D;
            this.icBtnTable.Size = new System.Drawing.Size(92, 51);
            this.icBtnTable.TabIndex = 6;
            this.icBtnTable.Text = "Table ID";
            this.icBtnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icBtnTable.UseVisualStyleBackColor = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.txbSearch.Location = new System.Drawing.Point(375, 8);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSearch.PlaceholderText = "Enter your food...";
            this.txbSearch.SelectedText = "";
            this.txbSearch.ShadowDecoration.Parent = this.txbSearch;
            this.txbSearch.Size = new System.Drawing.Size(250, 34);
            this.txbSearch.TabIndex = 5;
            // 
            // pnPaymentInfo
            // 
            this.pnPaymentInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnPaymentInfo.BackColor = System.Drawing.Color.White;
            this.pnPaymentInfo.Controls.Add(this.label1);
            this.pnPaymentInfo.Controls.Add(this.lbTextNumQTY);
            this.pnPaymentInfo.Controls.Add(this.lbPercent);
            this.pnPaymentInfo.Controls.Add(this.txbSale);
            this.pnPaymentInfo.Controls.Add(this.lbTextSale);
            this.pnPaymentInfo.Controls.Add(this.lbSubtotal);
            this.pnPaymentInfo.Controls.Add(this.lbTextSutotal);
            this.pnPaymentInfo.Location = new System.Drawing.Point(3, 409);
            this.pnPaymentInfo.Name = "pnPaymentInfo";
            this.pnPaymentInfo.Size = new System.Drawing.Size(632, 65);
            this.pnPaymentInfo.TabIndex = 3;
            this.pnPaymentInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPaymentInfo_Paint);
            // 
            // lbTextNumQTY
            // 
            this.lbTextNumQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextNumQTY.AutoSize = true;
            this.lbTextNumQTY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTextNumQTY.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextNumQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTextNumQTY.Location = new System.Drawing.Point(312, 8);
            this.lbTextNumQTY.Name = "lbTextNumQTY";
            this.lbTextNumQTY.Size = new System.Drawing.Size(46, 18);
            this.lbTextNumQTY.TabIndex = 11;
            this.lbTextNumQTY.Text = "items";
            this.lbTextNumQTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPercent
            // 
            this.lbPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercent.AutoSize = true;
            this.lbPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPercent.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.lbPercent.Location = new System.Drawing.Point(588, 34);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(19, 18);
            this.lbPercent.TabIndex = 10;
            this.lbPercent.Text = "%";
            this.lbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbSale
            // 
            this.txbSale.BorderRadius = 8;
            this.txbSale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSale.DefaultText = "";
            this.txbSale.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txbSale.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSale.DisabledState.Parent = this.txbSale;
            this.txbSale.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSale.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSale.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSale.FocusedState.ForeColor = System.Drawing.Color.White;
            this.txbSale.FocusedState.Parent = this.txbSale;
            this.txbSale.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txbSale.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.txbSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSale.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSale.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSale.HoverState.Parent = this.txbSale;
            this.txbSale.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSale.Location = new System.Drawing.Point(521, 30);
            this.txbSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSale.Name = "txbSale";
            this.txbSale.PasswordChar = '\0';
            this.txbSale.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSale.PlaceholderText = "0";
            this.txbSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbSale.SelectedText = "";
            this.txbSale.ShadowDecoration.Parent = this.txbSale;
            this.txbSale.Size = new System.Drawing.Size(60, 27);
            this.txbSale.TabIndex = 9;
            // 
            // lbTextSale
            // 
            this.lbTextSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextSale.AutoSize = true;
            this.lbTextSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTextSale.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.lbTextSale.Location = new System.Drawing.Point(9, 35);
            this.lbTextSale.Name = "lbTextSale";
            this.lbTextSale.Size = new System.Drawing.Size(60, 18);
            this.lbTextSale.TabIndex = 8;
            this.lbTextSale.Text = "Sale off";
            this.lbTextSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbStaff
            // 
            this.cmbStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStaff.AutoRoundedCorners = true;
            this.cmbStaff.BackColor = System.Drawing.Color.Transparent;
            this.cmbStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cmbStaff.BorderRadius = 12;
            this.cmbStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cmbStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cmbStaff.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.cmbStaff.FocusedState.ForeColor = System.Drawing.Color.White;
            this.cmbStaff.FocusedState.Parent = this.cmbStaff;
            this.cmbStaff.Font = new System.Drawing.Font("Roboto", 9F);
            this.cmbStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.HoverState.Parent = this.cmbStaff;
            this.cmbStaff.ItemHeight = 20;
            this.cmbStaff.Items.AddRange(new object[] {
            "Đinh Trần Văn Minh",
            "Nguyễn Thị Phương Thảo",
            "Nguyễn Viết Lưu"});
            this.cmbStaff.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cmbStaff.ItemsAppearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaff.ItemsAppearance.Parent = this.cmbStaff;
            this.cmbStaff.Location = new System.Drawing.Point(45, 6);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cmbStaff.ShadowDecoration.Parent = this.cmbStaff;
            this.cmbStaff.Size = new System.Drawing.Size(156, 26);
            this.cmbStaff.StartIndex = 0;
            this.cmbStaff.TabIndex = 14;
            this.cmbStaff.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // picStaff
            // 
            this.picStaff.Image = ((System.Drawing.Image)(resources.GetObject("picStaff.Image")));
            this.picStaff.Location = new System.Drawing.Point(12, 4);
            this.picStaff.Name = "picStaff";
            this.picStaff.ShadowDecoration.Parent = this.picStaff;
            this.picStaff.Size = new System.Drawing.Size(27, 27);
            this.picStaff.TabIndex = 13;
            this.picStaff.TabStop = false;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSubtotal.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbSubtotal.Location = new System.Drawing.Point(515, 8);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(80, 18);
            this.lbSubtotal.TabIndex = 7;
            this.lbSubtotal.Text = "Subtotal";
            this.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTextSutotal
            // 
            this.lbTextSutotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextSutotal.AutoSize = true;
            this.lbTextSutotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTextSutotal.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextSutotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTextSutotal.Location = new System.Drawing.Point(9, 8);
            this.lbTextSutotal.Name = "lbTextSutotal";
            this.lbTextSutotal.Size = new System.Drawing.Size(63, 18);
            this.lbTextSutotal.TabIndex = 6;
            this.lbTextSutotal.Text = "Subtotal";
            this.lbTextSutotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            this.pnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnLeft.Controls.Add(this.usrCtrlTable);
            this.pnLeft.Controls.Add(this.usrCtrlMenu);
            this.pnLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.pnLeft.Location = new System.Drawing.Point(0, 45);
            this.pnLeft.MaximumSize = new System.Drawing.Size(644, 731);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Radius = 5;
            this.pnLeft.ShadowColor = System.Drawing.Color.Black;
            this.pnLeft.ShadowShift = 6;
            this.pnLeft.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnLeft.Size = new System.Drawing.Size(644, 548);
            this.pnLeft.TabIndex = 1;
            // 
            // pnHeader
            // 
            this.pnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnHeader.Controls.Add(this.btnAvatar);
            this.pnHeader.Controls.Add(this.btnMenu);
            this.pnHeader.Controls.Add(this.btnTable);
            this.pnHeader.Controls.Add(this.ctrlMini);
            this.pnHeader.Controls.Add(this.ctrlMax);
            this.pnHeader.Controls.Add(this.ctrlClose);
            this.pnHeader.Location = new System.Drawing.Point(0, 4);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.ShadowDecoration.Parent = this.pnHeader;
            this.pnHeader.Size = new System.Drawing.Size(1318, 41);
            this.pnHeader.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnMenu.IconColor = System.Drawing.SystemColors.Control;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 17;
            this.btnMenu.Location = new System.Drawing.Point(107, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Rotation = 0D;
            this.btnMenu.Size = new System.Drawing.Size(92, 41);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "MENU";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTable.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnTable.IconColor = System.Drawing.SystemColors.Control;
            this.btnTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTable.IconSize = 17;
            this.btnTable.Location = new System.Drawing.Point(12, 4);
            this.btnTable.Name = "btnTable";
            this.btnTable.Rotation = 0D;
            this.btnTable.Size = new System.Drawing.Size(92, 41);
            this.btnTable.TabIndex = 5;
            this.btnTable.Text = "TABLE";
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // ctrlMini
            // 
            this.ctrlMini.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrlMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlMini.FillColor = System.Drawing.Color.Transparent;
            this.ctrlMini.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.ctrlMini.HoverState.Parent = this.ctrlMini;
            this.ctrlMini.IconColor = System.Drawing.Color.White;
            this.ctrlMini.Location = new System.Drawing.Point(1198, 0);
            this.ctrlMini.Name = "ctrlMini";
            this.ctrlMini.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.ctrlMini.ShadowDecoration.Parent = this.ctrlMini;
            this.ctrlMini.Size = new System.Drawing.Size(40, 41);
            this.ctrlMini.TabIndex = 4;
            // 
            // ctrlMax
            // 
            this.ctrlMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrlMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlMax.FillColor = System.Drawing.Color.Transparent;
            this.ctrlMax.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.ctrlMax.HoverState.Parent = this.ctrlMax;
            this.ctrlMax.IconColor = System.Drawing.Color.White;
            this.ctrlMax.Location = new System.Drawing.Point(1238, 0);
            this.ctrlMax.Name = "ctrlMax";
            this.ctrlMax.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.ctrlMax.ShadowDecoration.Parent = this.ctrlMax;
            this.ctrlMax.Size = new System.Drawing.Size(40, 41);
            this.ctrlMax.TabIndex = 3;
            // 
            // ctrlClose
            // 
            this.ctrlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlClose.FillColor = System.Drawing.Color.Transparent;
            this.ctrlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.ctrlClose.HoverState.Parent = this.ctrlClose;
            this.ctrlClose.IconColor = System.Drawing.Color.White;
            this.ctrlClose.Location = new System.Drawing.Point(1278, 0);
            this.ctrlClose.Name = "ctrlClose";
            this.ctrlClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.ctrlClose.ShadowDecoration.Parent = this.ctrlClose;
            this.ctrlClose.Size = new System.Drawing.Size(40, 41);
            this.ctrlClose.TabIndex = 2;
            // 
            // elipBtnTable
            // 
            this.elipBtnTable.BorderRadius = 8;
            this.elipBtnTable.TargetControl = this.btnTable;
            // 
            // elipBtnMenu
            // 
            this.elipBtnMenu.BorderRadius = 8;
            this.elipBtnMenu.TargetControl = this.btnMenu;
            // 
            // billInfoUsrCtrl1
            // 
            this.billInfoUsrCtrl1.ItemName = "Item name";
            this.billInfoUsrCtrl1.Location = new System.Drawing.Point(3, 3);
            this.billInfoUsrCtrl1.MaximumSize = new System.Drawing.Size(630, 66);
            this.billInfoUsrCtrl1.Name = "billInfoUsrCtrl1";
            this.billInfoUsrCtrl1.NO = "1.";
            this.billInfoUsrCtrl1.Note = "";
            this.billInfoUsrCtrl1.Price = "0";
            this.billInfoUsrCtrl1.Size = new System.Drawing.Size(630, 66);
            this.billInfoUsrCtrl1.TabIndex = 0;
            // 
            // billInfoUsrCtrl2
            // 
            this.billInfoUsrCtrl2.ItemName = "Item name";
            this.billInfoUsrCtrl2.Location = new System.Drawing.Point(3, 75);
            this.billInfoUsrCtrl2.MaximumSize = new System.Drawing.Size(630, 66);
            this.billInfoUsrCtrl2.Name = "billInfoUsrCtrl2";
            this.billInfoUsrCtrl2.NO = "1.";
            this.billInfoUsrCtrl2.Note = "";
            this.billInfoUsrCtrl2.Price = "0";
            this.billInfoUsrCtrl2.Size = new System.Drawing.Size(630, 66);
            this.billInfoUsrCtrl2.TabIndex = 1;
            // 
            // billInfoUsrCtrl3
            // 
            this.billInfoUsrCtrl3.ItemName = "Item name";
            this.billInfoUsrCtrl3.Location = new System.Drawing.Point(3, 147);
            this.billInfoUsrCtrl3.MaximumSize = new System.Drawing.Size(630, 66);
            this.billInfoUsrCtrl3.Name = "billInfoUsrCtrl3";
            this.billInfoUsrCtrl3.NO = "1.";
            this.billInfoUsrCtrl3.Note = "";
            this.billInfoUsrCtrl3.Price = "0";
            this.billInfoUsrCtrl3.Size = new System.Drawing.Size(630, 66);
            this.billInfoUsrCtrl3.TabIndex = 2;
            // 
            // usrCtrlTable
            // 
            this.usrCtrlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrCtrlTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.usrCtrlTable.Location = new System.Drawing.Point(0, 0);
            this.usrCtrlTable.MaximumSize = new System.Drawing.Size(644, 731);
            this.usrCtrlTable.Name = "usrCtrlTable";
            this.usrCtrlTable.Size = new System.Drawing.Size(644, 548);
            this.usrCtrlTable.TabIndex = 0;
            // 
            // usrCtrlMenu
            // 
            this.usrCtrlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.usrCtrlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrCtrlMenu.Location = new System.Drawing.Point(0, 0);
            this.usrCtrlMenu.MaximumSize = new System.Drawing.Size(644, 731);
            this.usrCtrlMenu.Name = "usrCtrlMenu";
            this.usrCtrlMenu.Size = new System.Drawing.Size(644, 548);
            this.usrCtrlMenu.TabIndex = 1;
            // 
            // lbTakeAway
            // 
            this.lbTakeAway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTakeAway.AutoSize = true;
            this.lbTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTakeAway.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTakeAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTakeAway.Location = new System.Drawing.Point(170, 18);
            this.lbTakeAway.Name = "lbTakeAway";
            this.lbTakeAway.Size = new System.Drawing.Size(73, 14);
            this.lbTakeAway.TabIndex = 18;
            this.lbTakeAway.Text = "Take away";
            this.lbTakeAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toggleTakeAway
            // 
            this.toggleTakeAway.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleTakeAway.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.toggleTakeAway.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleTakeAway.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleTakeAway.CheckedState.Parent = this.toggleTakeAway;
            this.toggleTakeAway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleTakeAway.Location = new System.Drawing.Point(129, 12);
            this.toggleTakeAway.Name = "toggleTakeAway";
            this.toggleTakeAway.ShadowDecoration.Parent = this.toggleTakeAway;
            this.toggleTakeAway.Size = new System.Drawing.Size(35, 20);
            this.toggleTakeAway.TabIndex = 19;
            this.toggleTakeAway.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.toggleTakeAway.UncheckedState.BorderThickness = 2;
            this.toggleTakeAway.UncheckedState.FillColor = System.Drawing.Color.White;
            this.toggleTakeAway.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleTakeAway.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.toggleTakeAway.UncheckedState.Parent = this.toggleTakeAway;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this.pnPayment;
            // 
            // btnAvatar
            // 
            this.btnAvatar.CheckedState.Parent = this.btnAvatar;
            this.btnAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvatar.CustomImages.Parent = this.btnAvatar;
            this.btnAvatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(150)))));
            this.btnAvatar.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnAvatar.ForeColor = System.Drawing.Color.White;
            this.btnAvatar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnAvatar.HoverState.Parent = this.btnAvatar;
            this.btnAvatar.Location = new System.Drawing.Point(1161, 4);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvatar.ShadowDecoration.Parent = this.btnAvatar;
            this.btnAvatar.Size = new System.Drawing.Size(30, 30);
            this.btnAvatar.TabIndex = 7;
            this.btnAvatar.Text = "Ava";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Roboto", 11F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(112, 40);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(89, 19);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "History";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(264, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1366, 625);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnMain.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnPayment.ResumeLayout(false);
            this.pnPayment.PerformLayout();
            this.layoutListBill.ResumeLayout(false);
            this.pnList.ResumeLayout(false);
            this.pnList.PerformLayout();
            this.pnPaymentInfo.ResumeLayout(false);
            this.pnPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnLeft;
        private Guna.UI2.WinForms.Guna2Panel pnHeader;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMini;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMax;
        private UserContrlMenu.TableUsrCtrl usrCtrlTable;
        private FontAwesome.Sharp.IconButton btnTable;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Guna.UI2.WinForms.Guna2Elipse elipBtnTable;
        private Guna.UI2.WinForms.Guna2Elipse elipBtnMenu;
        private UserContrlMenu.FoodUsrControl usrCtrlMenu;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnRight;
        private System.Windows.Forms.Panel pnPayment;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTextTotal;
        private System.Windows.Forms.FlowLayoutPanel layoutListBill;
        private UserContrlMenu.BillInfoUsrCtrl billInfoUsrCtrl1;
        private UserContrlMenu.BillInfoUsrCtrl billInfoUsrCtrl2;
        private UserContrlMenu.BillInfoUsrCtrl billInfoUsrCtrl3;
        private Guna.UI2.WinForms.Guna2Panel pnList;
        private System.Windows.Forms.Panel pnLine;
        private FontAwesome.Sharp.IconButton icBtnTable;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private System.Windows.Forms.Panel pnPaymentInfo;
        private System.Windows.Forms.Label lbTextNumQTY;
        private System.Windows.Forms.Label lbPercent;
        private Guna.UI2.WinForms.Guna2TextBox txbSale;
        private System.Windows.Forms.Label lbTextSale;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbTextSutotal;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStaff;
        private Guna.UI2.WinForms.Guna2PictureBox picStaff;
        private Guna.UI2.WinForms.Guna2Button btnNote;
        private System.Windows.Forms.Label lbTakeAway;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleTakeAway;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
    }
}

