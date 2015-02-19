namespace _07._1_Vend_Service
{
    partial class VendingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendingForm));
            this.regularSodaPicBox = new System.Windows.Forms.PictureBox();
            this.orangeSodaPicBox = new System.Windows.Forms.PictureBox();
            this.lemonSodaPicBox = new System.Windows.Forms.PictureBox();
            this.regularEjectButton = new System.Windows.Forms.Button();
            this.orangeEjectButton = new System.Windows.Forms.Button();
            this.lemonEjectButton = new System.Windows.Forms.Button();
            this.halfDollarButton = new System.Windows.Forms.Button();
            this.quarterButton = new System.Windows.Forms.Button();
            this.dimeButton = new System.Windows.Forms.Button();
            this.nickelButton = new System.Windows.Forms.Button();
            this.pleaseInsertLabel = new System.Windows.Forms.Label();
            this.totalInsertedLabel = new System.Windows.Forms.Label();
            this.totalInsertedDisplayLabel = new System.Windows.Forms.Label();
            this.ExactChangeLabel = new System.Windows.Forms.Label();
            this.CoinReturnButton = new System.Windows.Forms.Button();
            this.VendingTabControl = new System.Windows.Forms.TabControl();
            this.VendPageTab = new System.Windows.Forms.TabPage();
            this.ServicePageTab = new System.Windows.Forms.TabPage();
            this.CoinBoxGroup = new System.Windows.Forms.GroupBox();
            this.emptyInsertedCoinsCoinBoxButton = new System.Windows.Forms.Button();
            this.EmptyMainCoinBoxButton = new System.Windows.Forms.Button();
            this.InsertedCoinsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insertedCoinDisplayLabel = new System.Windows.Forms.Label();
            this.mainCoinBoxDisplayLabel = new System.Windows.Forms.Label();
            this.CoinBoxListView = new System.Windows.Forms.ListView();
            this.CoinsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CanRackGroupBox = new System.Windows.Forms.GroupBox();
            this.fillTheCanRackButton = new System.Windows.Forms.Button();
            this.CanRackListView = new System.Windows.Forms.ListView();
            this.flavorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CanNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceLockButton = new System.Windows.Forms.Button();
            this.PasswordOKButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.regularSodaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSodaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonSodaPicBox)).BeginInit();
            this.VendingTabControl.SuspendLayout();
            this.VendPageTab.SuspendLayout();
            this.ServicePageTab.SuspendLayout();
            this.CoinBoxGroup.SuspendLayout();
            this.CanRackGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regularSodaPicBox
            // 
            this.regularSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("regularSodaPicBox.Image")));
            this.regularSodaPicBox.Location = new System.Drawing.Point(25, 48);
            this.regularSodaPicBox.Name = "regularSodaPicBox";
            this.regularSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.regularSodaPicBox.TabIndex = 0;
            this.regularSodaPicBox.TabStop = false;
            // 
            // orangeSodaPicBox
            // 
            this.orangeSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("orangeSodaPicBox.Image")));
            this.orangeSodaPicBox.Location = new System.Drawing.Point(229, 48);
            this.orangeSodaPicBox.Name = "orangeSodaPicBox";
            this.orangeSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.orangeSodaPicBox.TabIndex = 1;
            this.orangeSodaPicBox.TabStop = false;
            // 
            // lemonSodaPicBox
            // 
            this.lemonSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("lemonSodaPicBox.Image")));
            this.lemonSodaPicBox.Location = new System.Drawing.Point(433, 48);
            this.lemonSodaPicBox.Name = "lemonSodaPicBox";
            this.lemonSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.lemonSodaPicBox.TabIndex = 2;
            this.lemonSodaPicBox.TabStop = false;
            // 
            // regularEjectButton
            // 
            this.regularEjectButton.Enabled = false;
            this.regularEjectButton.Location = new System.Drawing.Point(85, 281);
            this.regularEjectButton.Name = "regularEjectButton";
            this.regularEjectButton.Size = new System.Drawing.Size(75, 23);
            this.regularEjectButton.TabIndex = 3;
            this.regularEjectButton.Text = "Eject";
            this.regularEjectButton.UseVisualStyleBackColor = true;
            this.regularEjectButton.Click += new System.EventHandler(this.regularEjectButton_Click);
            // 
            // orangeEjectButton
            // 
            this.orangeEjectButton.Enabled = false;
            this.orangeEjectButton.Location = new System.Drawing.Point(298, 281);
            this.orangeEjectButton.Name = "orangeEjectButton";
            this.orangeEjectButton.Size = new System.Drawing.Size(75, 23);
            this.orangeEjectButton.TabIndex = 4;
            this.orangeEjectButton.Text = "Eject";
            this.orangeEjectButton.UseVisualStyleBackColor = true;
            this.orangeEjectButton.Click += new System.EventHandler(this.orangeEjectButton_Click);
            // 
            // lemonEjectButton
            // 
            this.lemonEjectButton.Enabled = false;
            this.lemonEjectButton.Location = new System.Drawing.Point(490, 281);
            this.lemonEjectButton.Name = "lemonEjectButton";
            this.lemonEjectButton.Size = new System.Drawing.Size(75, 23);
            this.lemonEjectButton.TabIndex = 5;
            this.lemonEjectButton.Text = "Eject";
            this.lemonEjectButton.UseVisualStyleBackColor = true;
            this.lemonEjectButton.Click += new System.EventHandler(this.lemonEjectButton_Click);
            // 
            // halfDollarButton
            // 
            this.halfDollarButton.Location = new System.Drawing.Point(25, 329);
            this.halfDollarButton.Name = "halfDollarButton";
            this.halfDollarButton.Size = new System.Drawing.Size(75, 23);
            this.halfDollarButton.TabIndex = 6;
            this.halfDollarButton.Text = "Half Dollar";
            this.halfDollarButton.UseVisualStyleBackColor = true;
            this.halfDollarButton.Click += new System.EventHandler(this.halfDollarButton_Click);
            // 
            // quarterButton
            // 
            this.quarterButton.Location = new System.Drawing.Point(106, 329);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(75, 23);
            this.quarterButton.TabIndex = 7;
            this.quarterButton.Text = "Quarter";
            this.quarterButton.UseVisualStyleBackColor = true;
            this.quarterButton.Click += new System.EventHandler(this.quarterButton_Click);
            // 
            // dimeButton
            // 
            this.dimeButton.Location = new System.Drawing.Point(187, 329);
            this.dimeButton.Name = "dimeButton";
            this.dimeButton.Size = new System.Drawing.Size(75, 23);
            this.dimeButton.TabIndex = 8;
            this.dimeButton.Text = "Dime";
            this.dimeButton.UseVisualStyleBackColor = true;
            this.dimeButton.Click += new System.EventHandler(this.dimeButton_Click);
            // 
            // nickelButton
            // 
            this.nickelButton.Location = new System.Drawing.Point(268, 329);
            this.nickelButton.Name = "nickelButton";
            this.nickelButton.Size = new System.Drawing.Size(75, 23);
            this.nickelButton.TabIndex = 9;
            this.nickelButton.Text = "Nickel";
            this.nickelButton.UseVisualStyleBackColor = true;
            this.nickelButton.Click += new System.EventHandler(this.nickelButton_Click);
            // 
            // pleaseInsertLabel
            // 
            this.pleaseInsertLabel.AutoSize = true;
            this.pleaseInsertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseInsertLabel.Location = new System.Drawing.Point(69, 3);
            this.pleaseInsertLabel.Name = "pleaseInsertLabel";
            this.pleaseInsertLabel.Size = new System.Drawing.Size(477, 33);
            this.pleaseInsertLabel.TabIndex = 10;
            this.pleaseInsertLabel.Text = "Please Insert 35 cents for a Soda";
            // 
            // totalInsertedLabel
            // 
            this.totalInsertedLabel.AutoSize = true;
            this.totalInsertedLabel.Location = new System.Drawing.Point(417, 339);
            this.totalInsertedLabel.Name = "totalInsertedLabel";
            this.totalInsertedLabel.Size = new System.Drawing.Size(72, 13);
            this.totalInsertedLabel.TabIndex = 11;
            this.totalInsertedLabel.Text = "Total Inserted";
            // 
            // totalInsertedDisplayLabel
            // 
            this.totalInsertedDisplayLabel.AutoSize = true;
            this.totalInsertedDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalInsertedDisplayLabel.Location = new System.Drawing.Point(495, 339);
            this.totalInsertedDisplayLabel.Name = "totalInsertedDisplayLabel";
            this.totalInsertedDisplayLabel.Size = new System.Drawing.Size(15, 15);
            this.totalInsertedDisplayLabel.TabIndex = 12;
            this.totalInsertedDisplayLabel.Text = "0";
            // 
            // ExactChangeLabel
            // 
            this.ExactChangeLabel.AutoSize = true;
            this.ExactChangeLabel.ForeColor = System.Drawing.Color.Red;
            this.ExactChangeLabel.Location = new System.Drawing.Point(164, 365);
            this.ExactChangeLabel.Name = "ExactChangeLabel";
            this.ExactChangeLabel.Size = new System.Drawing.Size(120, 13);
            this.ExactChangeLabel.TabIndex = 13;
            this.ExactChangeLabel.Text = "Exact Change Required";
            this.ExactChangeLabel.Visible = false;
            // 
            // CoinReturnButton
            // 
            this.CoinReturnButton.Enabled = false;
            this.CoinReturnButton.Location = new System.Drawing.Point(435, 365);
            this.CoinReturnButton.Name = "CoinReturnButton";
            this.CoinReturnButton.Size = new System.Drawing.Size(75, 23);
            this.CoinReturnButton.TabIndex = 14;
            this.CoinReturnButton.Text = "Coin Return";
            this.CoinReturnButton.UseVisualStyleBackColor = true;
            this.CoinReturnButton.Click += new System.EventHandler(this.CoinReturnButton_Click);
            // 
            // VendingTabControl
            // 
            this.VendingTabControl.Controls.Add(this.VendPageTab);
            this.VendingTabControl.Controls.Add(this.ServicePageTab);
            this.VendingTabControl.Location = new System.Drawing.Point(12, 28);
            this.VendingTabControl.Name = "VendingTabControl";
            this.VendingTabControl.SelectedIndex = 0;
            this.VendingTabControl.Size = new System.Drawing.Size(674, 418);
            this.VendingTabControl.TabIndex = 15;
            this.VendingTabControl.Click += new System.EventHandler(this.VendingTabControl_Click);
            // 
            // VendPageTab
            // 
            this.VendPageTab.Controls.Add(this.pleaseInsertLabel);
            this.VendPageTab.Controls.Add(this.CoinReturnButton);
            this.VendPageTab.Controls.Add(this.regularSodaPicBox);
            this.VendPageTab.Controls.Add(this.ExactChangeLabel);
            this.VendPageTab.Controls.Add(this.orangeSodaPicBox);
            this.VendPageTab.Controls.Add(this.totalInsertedDisplayLabel);
            this.VendPageTab.Controls.Add(this.lemonSodaPicBox);
            this.VendPageTab.Controls.Add(this.totalInsertedLabel);
            this.VendPageTab.Controls.Add(this.regularEjectButton);
            this.VendPageTab.Controls.Add(this.orangeEjectButton);
            this.VendPageTab.Controls.Add(this.nickelButton);
            this.VendPageTab.Controls.Add(this.lemonEjectButton);
            this.VendPageTab.Controls.Add(this.dimeButton);
            this.VendPageTab.Controls.Add(this.halfDollarButton);
            this.VendPageTab.Controls.Add(this.quarterButton);
            this.VendPageTab.Location = new System.Drawing.Point(4, 22);
            this.VendPageTab.Name = "VendPageTab";
            this.VendPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.VendPageTab.Size = new System.Drawing.Size(666, 392);
            this.VendPageTab.TabIndex = 0;
            this.VendPageTab.Text = "Vend";
            this.VendPageTab.UseVisualStyleBackColor = true;
            // 
            // ServicePageTab
            // 
            this.ServicePageTab.Controls.Add(this.CoinBoxGroup);
            this.ServicePageTab.Controls.Add(this.PasswordLabel);
            this.ServicePageTab.Controls.Add(this.CanRackGroupBox);
            this.ServicePageTab.Controls.Add(this.serviceLockButton);
            this.ServicePageTab.Controls.Add(this.PasswordOKButton);
            this.ServicePageTab.Controls.Add(this.PasswordTextBox);
            this.ServicePageTab.Location = new System.Drawing.Point(4, 22);
            this.ServicePageTab.Name = "ServicePageTab";
            this.ServicePageTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServicePageTab.Size = new System.Drawing.Size(666, 392);
            this.ServicePageTab.TabIndex = 1;
            this.ServicePageTab.Text = "Service";
            this.ServicePageTab.UseVisualStyleBackColor = true;
            // 
            // CoinBoxGroup
            // 
            this.CoinBoxGroup.Controls.Add(this.emptyInsertedCoinsCoinBoxButton);
            this.CoinBoxGroup.Controls.Add(this.EmptyMainCoinBoxButton);
            this.CoinBoxGroup.Controls.Add(this.InsertedCoinsListView);
            this.CoinBoxGroup.Controls.Add(this.insertedCoinDisplayLabel);
            this.CoinBoxGroup.Controls.Add(this.mainCoinBoxDisplayLabel);
            this.CoinBoxGroup.Controls.Add(this.CoinBoxListView);
            this.CoinBoxGroup.Location = new System.Drawing.Point(306, 10);
            this.CoinBoxGroup.Name = "CoinBoxGroup";
            this.CoinBoxGroup.Size = new System.Drawing.Size(339, 379);
            this.CoinBoxGroup.TabIndex = 1;
            this.CoinBoxGroup.TabStop = false;
            this.CoinBoxGroup.Text = "Coin Box";
            this.CoinBoxGroup.Visible = false;
            // 
            // emptyInsertedCoinsCoinBoxButton
            // 
            this.emptyInsertedCoinsCoinBoxButton.Location = new System.Drawing.Point(256, 210);
            this.emptyInsertedCoinsCoinBoxButton.Name = "emptyInsertedCoinsCoinBoxButton";
            this.emptyInsertedCoinsCoinBoxButton.Size = new System.Drawing.Size(75, 146);
            this.emptyInsertedCoinsCoinBoxButton.TabIndex = 12;
            this.emptyInsertedCoinsCoinBoxButton.Text = "Empty Inserted Coins Coin Box";
            this.emptyInsertedCoinsCoinBoxButton.UseVisualStyleBackColor = true;
            this.emptyInsertedCoinsCoinBoxButton.Click += new System.EventHandler(this.emptyInsertedCoinsCoinBoxButton_Click);
            // 
            // EmptyMainCoinBoxButton
            // 
            this.EmptyMainCoinBoxButton.Location = new System.Drawing.Point(256, 35);
            this.EmptyMainCoinBoxButton.Name = "EmptyMainCoinBoxButton";
            this.EmptyMainCoinBoxButton.Size = new System.Drawing.Size(75, 146);
            this.EmptyMainCoinBoxButton.TabIndex = 11;
            this.EmptyMainCoinBoxButton.Text = "Empty Main Coin Box";
            this.EmptyMainCoinBoxButton.UseVisualStyleBackColor = true;
            this.EmptyMainCoinBoxButton.Click += new System.EventHandler(this.EmptyMainCoinBoxButton_Click);
            // 
            // InsertedCoinsListView
            // 
            this.InsertedCoinsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.InsertedCoinsListView.GridLines = true;
            this.InsertedCoinsListView.Location = new System.Drawing.Point(6, 210);
            this.InsertedCoinsListView.Name = "InsertedCoinsListView";
            this.InsertedCoinsListView.Size = new System.Drawing.Size(244, 146);
            this.InsertedCoinsListView.TabIndex = 10;
            this.InsertedCoinsListView.UseCompatibleStateImageBehavior = false;
            this.InsertedCoinsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coins";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            // 
            // insertedCoinDisplayLabel
            // 
            this.insertedCoinDisplayLabel.AutoSize = true;
            this.insertedCoinDisplayLabel.Location = new System.Drawing.Point(6, 194);
            this.insertedCoinDisplayLabel.Name = "insertedCoinDisplayLabel";
            this.insertedCoinDisplayLabel.Size = new System.Drawing.Size(74, 13);
            this.insertedCoinDisplayLabel.TabIndex = 8;
            this.insertedCoinDisplayLabel.Text = "Inserted Coins";
            // 
            // mainCoinBoxDisplayLabel
            // 
            this.mainCoinBoxDisplayLabel.AutoSize = true;
            this.mainCoinBoxDisplayLabel.Location = new System.Drawing.Point(6, 19);
            this.mainCoinBoxDisplayLabel.Name = "mainCoinBoxDisplayLabel";
            this.mainCoinBoxDisplayLabel.Size = new System.Drawing.Size(75, 13);
            this.mainCoinBoxDisplayLabel.TabIndex = 7;
            this.mainCoinBoxDisplayLabel.Text = "Main Coin Box";
            // 
            // CoinBoxListView
            // 
            this.CoinBoxListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CoinsColumnHeader,
            this.NumberColumnHeader,
            this.ValueColumnHeader});
            this.CoinBoxListView.GridLines = true;
            this.CoinBoxListView.Location = new System.Drawing.Point(6, 35);
            this.CoinBoxListView.Name = "CoinBoxListView";
            this.CoinBoxListView.Size = new System.Drawing.Size(244, 146);
            this.CoinBoxListView.TabIndex = 6;
            this.CoinBoxListView.UseCompatibleStateImageBehavior = false;
            this.CoinBoxListView.View = System.Windows.Forms.View.Details;
            // 
            // CoinsColumnHeader
            // 
            this.CoinsColumnHeader.Text = "Coins";
            this.CoinsColumnHeader.Width = 120;
            // 
            // NumberColumnHeader
            // 
            this.NumberColumnHeader.Text = "Number";
            // 
            // ValueColumnHeader
            // 
            this.ValueColumnHeader.Text = "Value";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(259, 135);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // CanRackGroupBox
            // 
            this.CanRackGroupBox.Controls.Add(this.fillTheCanRackButton);
            this.CanRackGroupBox.Controls.Add(this.CanRackListView);
            this.CanRackGroupBox.Location = new System.Drawing.Point(22, 7);
            this.CanRackGroupBox.Name = "CanRackGroupBox";
            this.CanRackGroupBox.Size = new System.Drawing.Size(264, 207);
            this.CanRackGroupBox.TabIndex = 5;
            this.CanRackGroupBox.TabStop = false;
            this.CanRackGroupBox.Text = "Can Rack";
            this.CanRackGroupBox.Visible = false;
            // 
            // fillTheCanRackButton
            // 
            this.fillTheCanRackButton.Location = new System.Drawing.Point(6, 157);
            this.fillTheCanRackButton.Name = "fillTheCanRackButton";
            this.fillTheCanRackButton.Size = new System.Drawing.Size(248, 23);
            this.fillTheCanRackButton.TabIndex = 1;
            this.fillTheCanRackButton.Text = "Fill The Can Rack";
            this.fillTheCanRackButton.UseVisualStyleBackColor = true;
            this.fillTheCanRackButton.Click += new System.EventHandler(this.fillTheCanRackButton_Click);
            // 
            // CanRackListView
            // 
            this.CanRackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.flavorColumnHeader,
            this.CanNumberColumnHeader});
            this.CanRackListView.GridLines = true;
            this.CanRackListView.Location = new System.Drawing.Point(6, 19);
            this.CanRackListView.Name = "CanRackListView";
            this.CanRackListView.Size = new System.Drawing.Size(248, 132);
            this.CanRackListView.TabIndex = 0;
            this.CanRackListView.UseCompatibleStateImageBehavior = false;
            this.CanRackListView.View = System.Windows.Forms.View.Details;
            // 
            // flavorColumnHeader
            // 
            this.flavorColumnHeader.Text = "Flavor";
            this.flavorColumnHeader.Width = 120;
            // 
            // CanNumberColumnHeader
            // 
            this.CanNumberColumnHeader.Text = "Number of Cans Left";
            this.CanNumberColumnHeader.Width = 120;
            // 
            // serviceLockButton
            // 
            this.serviceLockButton.Location = new System.Drawing.Point(31, 351);
            this.serviceLockButton.Name = "serviceLockButton";
            this.serviceLockButton.Size = new System.Drawing.Size(75, 23);
            this.serviceLockButton.TabIndex = 3;
            this.serviceLockButton.Text = "Lock";
            this.serviceLockButton.UseVisualStyleBackColor = true;
            this.serviceLockButton.Visible = false;
            this.serviceLockButton.Click += new System.EventHandler(this.serviceLockButton_Click);
            // 
            // PasswordOKButton
            // 
            this.PasswordOKButton.Location = new System.Drawing.Point(433, 135);
            this.PasswordOKButton.Name = "PasswordOKButton";
            this.PasswordOKButton.Size = new System.Drawing.Size(75, 23);
            this.PasswordOKButton.TabIndex = 1;
            this.PasswordOKButton.Text = "OK";
            this.PasswordOKButton.UseVisualStyleBackColor = true;
            this.PasswordOKButton.Click += new System.EventHandler(this.PasswordOKButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(318, 132);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 0;
            this.PasswordTextBox.Text = "cs";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.VisibleChanged += new System.EventHandler(this.PasswordTextBox_VisibleChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // VendingForm
            // 
            this.AcceptButton = this.PasswordOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 485);
            this.Controls.Add(this.VendingTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VendingForm";
            this.Text = ".NET C# Vending Machine";
            this.Load += new System.EventHandler(this.VendingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regularSodaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSodaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonSodaPicBox)).EndInit();
            this.VendingTabControl.ResumeLayout(false);
            this.VendPageTab.ResumeLayout(false);
            this.VendPageTab.PerformLayout();
            this.ServicePageTab.ResumeLayout(false);
            this.ServicePageTab.PerformLayout();
            this.CoinBoxGroup.ResumeLayout(false);
            this.CoinBoxGroup.PerformLayout();
            this.CanRackGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox regularSodaPicBox;
        private System.Windows.Forms.PictureBox orangeSodaPicBox;
        private System.Windows.Forms.PictureBox lemonSodaPicBox;
        private System.Windows.Forms.Button regularEjectButton;
        private System.Windows.Forms.Button orangeEjectButton;
        private System.Windows.Forms.Button lemonEjectButton;
        private System.Windows.Forms.Button halfDollarButton;
        private System.Windows.Forms.Button quarterButton;
        private System.Windows.Forms.Button dimeButton;
        private System.Windows.Forms.Button nickelButton;
        private System.Windows.Forms.Label pleaseInsertLabel;
        private System.Windows.Forms.Label totalInsertedLabel;
        private System.Windows.Forms.Label totalInsertedDisplayLabel;
        private System.Windows.Forms.Label ExactChangeLabel;
        private System.Windows.Forms.Button CoinReturnButton;
        private System.Windows.Forms.TabControl VendingTabControl;
        private System.Windows.Forms.TabPage VendPageTab;
        private System.Windows.Forms.TabPage ServicePageTab;
        private System.Windows.Forms.Button PasswordOKButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button serviceLockButton;
        private System.Windows.Forms.GroupBox CanRackGroupBox;
        private System.Windows.Forms.ListView CanRackListView;
        private System.Windows.Forms.ColumnHeader flavorColumnHeader;
        private System.Windows.Forms.ColumnHeader CanNumberColumnHeader;
        private System.Windows.Forms.GroupBox CoinBoxGroup;
        private System.Windows.Forms.ListView CoinBoxListView;
        private System.Windows.Forms.ColumnHeader CoinsColumnHeader;
        private System.Windows.Forms.ColumnHeader NumberColumnHeader;
        private System.Windows.Forms.ColumnHeader ValueColumnHeader;
        private System.Windows.Forms.Label insertedCoinDisplayLabel;
        private System.Windows.Forms.Label mainCoinBoxDisplayLabel;
        private System.Windows.Forms.ListView InsertedCoinsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button fillTheCanRackButton;
        private System.Windows.Forms.Button emptyInsertedCoinsCoinBoxButton;
        private System.Windows.Forms.Button EmptyMainCoinBoxButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}



