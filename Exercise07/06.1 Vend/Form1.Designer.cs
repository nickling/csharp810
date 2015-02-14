namespace _06._1_Vend
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
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Regular");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Orange");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Lemon");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Half Dollar");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Quarter");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Dime");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Nickel");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Slug");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Half Dollar");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Quarter");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Dime");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Nickel");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Slug");
            this.tabControlVending = new System.Windows.Forms.TabControl();
            this.tabPageVend = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.CoinReturnButton = new System.Windows.Forms.Button();
            this.ExactChangeLabel = new System.Windows.Forms.Label();
            this.totalInsertedDisplayLabel = new System.Windows.Forms.Label();
            this.totalInsertedLabel = new System.Windows.Forms.Label();
            this.pleaseInsertLabel = new System.Windows.Forms.Label();
            this.nickelButton = new System.Windows.Forms.Button();
            this.dimeButton = new System.Windows.Forms.Button();
            this.quarterButton = new System.Windows.Forms.Button();
            this.halfDollarButton = new System.Windows.Forms.Button();
            this.lemonEjectButton = new System.Windows.Forms.Button();
            this.orangeEjectButton = new System.Windows.Forms.Button();
            this.regularEjectButton = new System.Windows.Forms.Button();
            this.lemonSodaPicBox = new System.Windows.Forms.PictureBox();
            this.orangeSodaPicBox = new System.Windows.Forms.PictureBox();
            this.regularSodaPicBox = new System.Windows.Forms.PictureBox();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.listViewServiceCansRemaining = new System.Windows.Forms.ListView();
            this.ListView_CanFlavor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView_CansRemaining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_ServiceCans = new System.Windows.Forms.GroupBox();
            this.buttonRefillCans = new System.Windows.Forms.Button();
            this.groupBox_CoinBox = new System.Windows.Forms.GroupBox();
            this.listView_mainCoinbox = new System.Windows.Forms.ListView();
            this.main_coins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.main_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.main_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_InsertedCoinbox = new System.Windows.Forms.ListView();
            this.inserted_coins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inserted_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inserted_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMainCoinBox = new System.Windows.Forms.Label();
            this.labelInsertedCoinBox = new System.Windows.Forms.Label();
            this.buttonEmptyMainCoinBox = new System.Windows.Forms.Button();
            this.buttonEmptyInsertedCoinBox = new System.Windows.Forms.Button();
            this.tabControlVending.SuspendLayout();
            this.tabPageVend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonSodaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSodaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularSodaPicBox)).BeginInit();
            this.tabPageService.SuspendLayout();
            this.groupBox_ServiceCans.SuspendLayout();
            this.groupBox_CoinBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVending
            // 
            this.tabControlVending.Controls.Add(this.tabPageVend);
            this.tabControlVending.Controls.Add(this.tabPageService);
            this.tabControlVending.Location = new System.Drawing.Point(37, 39);
            this.tabControlVending.Name = "tabControlVending";
            this.tabControlVending.SelectedIndex = 0;
            this.tabControlVending.Size = new System.Drawing.Size(666, 452);
            this.tabControlVending.TabIndex = 0;
            // 
            // tabPageVend
            // 
            this.tabPageVend.Controls.Add(this.button1);
            this.tabPageVend.Controls.Add(this.CoinReturnButton);
            this.tabPageVend.Controls.Add(this.ExactChangeLabel);
            this.tabPageVend.Controls.Add(this.totalInsertedDisplayLabel);
            this.tabPageVend.Controls.Add(this.totalInsertedLabel);
            this.tabPageVend.Controls.Add(this.pleaseInsertLabel);
            this.tabPageVend.Controls.Add(this.nickelButton);
            this.tabPageVend.Controls.Add(this.dimeButton);
            this.tabPageVend.Controls.Add(this.quarterButton);
            this.tabPageVend.Controls.Add(this.halfDollarButton);
            this.tabPageVend.Controls.Add(this.lemonEjectButton);
            this.tabPageVend.Controls.Add(this.orangeEjectButton);
            this.tabPageVend.Controls.Add(this.regularEjectButton);
            this.tabPageVend.Controls.Add(this.lemonSodaPicBox);
            this.tabPageVend.Controls.Add(this.orangeSodaPicBox);
            this.tabPageVend.Controls.Add(this.regularSodaPicBox);
            this.tabPageVend.Location = new System.Drawing.Point(4, 22);
            this.tabPageVend.Name = "tabPageVend";
            this.tabPageVend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVend.Size = new System.Drawing.Size(658, 426);
            this.tabPageVend.TabIndex = 0;
            this.tabPageVend.Text = "Vend";
            this.tabPageVend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CoinReturnButton
            // 
            this.CoinReturnButton.Enabled = false;
            this.CoinReturnButton.Location = new System.Drawing.Point(438, 390);
            this.CoinReturnButton.Name = "CoinReturnButton";
            this.CoinReturnButton.Size = new System.Drawing.Size(75, 23);
            this.CoinReturnButton.TabIndex = 30;
            this.CoinReturnButton.Text = "Coin Return";
            this.CoinReturnButton.UseVisualStyleBackColor = true;
            this.CoinReturnButton.Click += new System.EventHandler(this.CoinReturnButton_Click);
            // 
            // ExactChangeLabel
            // 
            this.ExactChangeLabel.AutoSize = true;
            this.ExactChangeLabel.ForeColor = System.Drawing.Color.Red;
            this.ExactChangeLabel.Location = new System.Drawing.Point(167, 390);
            this.ExactChangeLabel.Name = "ExactChangeLabel";
            this.ExactChangeLabel.Size = new System.Drawing.Size(120, 13);
            this.ExactChangeLabel.TabIndex = 29;
            this.ExactChangeLabel.Text = "Exact Change Required";
            this.ExactChangeLabel.Visible = false;
            // 
            // totalInsertedDisplayLabel
            // 
            this.totalInsertedDisplayLabel.AutoSize = true;
            this.totalInsertedDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalInsertedDisplayLabel.Location = new System.Drawing.Point(498, 364);
            this.totalInsertedDisplayLabel.Name = "totalInsertedDisplayLabel";
            this.totalInsertedDisplayLabel.Size = new System.Drawing.Size(15, 15);
            this.totalInsertedDisplayLabel.TabIndex = 28;
            this.totalInsertedDisplayLabel.Text = "0";
            // 
            // totalInsertedLabel
            // 
            this.totalInsertedLabel.AutoSize = true;
            this.totalInsertedLabel.Location = new System.Drawing.Point(420, 364);
            this.totalInsertedLabel.Name = "totalInsertedLabel";
            this.totalInsertedLabel.Size = new System.Drawing.Size(72, 13);
            this.totalInsertedLabel.TabIndex = 27;
            this.totalInsertedLabel.Text = "Total Inserted";
            // 
            // pleaseInsertLabel
            // 
            this.pleaseInsertLabel.AutoSize = true;
            this.pleaseInsertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseInsertLabel.Location = new System.Drawing.Point(72, 28);
            this.pleaseInsertLabel.Name = "pleaseInsertLabel";
            this.pleaseInsertLabel.Size = new System.Drawing.Size(477, 33);
            this.pleaseInsertLabel.TabIndex = 26;
            this.pleaseInsertLabel.Text = "Please Insert 35 cents for a Soda";
            // 
            // nickelButton
            // 
            this.nickelButton.Location = new System.Drawing.Point(271, 354);
            this.nickelButton.Name = "nickelButton";
            this.nickelButton.Size = new System.Drawing.Size(75, 23);
            this.nickelButton.TabIndex = 25;
            this.nickelButton.Text = "Nickel";
            this.nickelButton.UseVisualStyleBackColor = true;
            this.nickelButton.Click += new System.EventHandler(this.nickelButton_Click);
            // 
            // dimeButton
            // 
            this.dimeButton.Location = new System.Drawing.Point(190, 354);
            this.dimeButton.Name = "dimeButton";
            this.dimeButton.Size = new System.Drawing.Size(75, 23);
            this.dimeButton.TabIndex = 24;
            this.dimeButton.Text = "Dime";
            this.dimeButton.UseVisualStyleBackColor = true;
            this.dimeButton.Click += new System.EventHandler(this.dimeButton_Click);
            // 
            // quarterButton
            // 
            this.quarterButton.Location = new System.Drawing.Point(109, 354);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(75, 23);
            this.quarterButton.TabIndex = 23;
            this.quarterButton.Text = "Quarter";
            this.quarterButton.UseVisualStyleBackColor = true;
            this.quarterButton.Click += new System.EventHandler(this.quarterButton_Click);
            // 
            // halfDollarButton
            // 
            this.halfDollarButton.Location = new System.Drawing.Point(28, 354);
            this.halfDollarButton.Name = "halfDollarButton";
            this.halfDollarButton.Size = new System.Drawing.Size(75, 23);
            this.halfDollarButton.TabIndex = 22;
            this.halfDollarButton.Text = "Half Dollar";
            this.halfDollarButton.UseVisualStyleBackColor = true;
            this.halfDollarButton.Click += new System.EventHandler(this.halfDollarButton_Click);
            // 
            // lemonEjectButton
            // 
            this.lemonEjectButton.Enabled = false;
            this.lemonEjectButton.Location = new System.Drawing.Point(493, 306);
            this.lemonEjectButton.Name = "lemonEjectButton";
            this.lemonEjectButton.Size = new System.Drawing.Size(75, 23);
            this.lemonEjectButton.TabIndex = 21;
            this.lemonEjectButton.Text = "Eject";
            this.lemonEjectButton.UseVisualStyleBackColor = true;
            this.lemonEjectButton.Click += new System.EventHandler(this.lemonEjectButton_Click);
            // 
            // orangeEjectButton
            // 
            this.orangeEjectButton.Enabled = false;
            this.orangeEjectButton.Location = new System.Drawing.Point(301, 306);
            this.orangeEjectButton.Name = "orangeEjectButton";
            this.orangeEjectButton.Size = new System.Drawing.Size(75, 23);
            this.orangeEjectButton.TabIndex = 20;
            this.orangeEjectButton.Text = "Eject";
            this.orangeEjectButton.UseVisualStyleBackColor = true;
            this.orangeEjectButton.Click += new System.EventHandler(this.orangeEjectButton_Click);
            // 
            // regularEjectButton
            // 
            this.regularEjectButton.Enabled = false;
            this.regularEjectButton.Location = new System.Drawing.Point(88, 306);
            this.regularEjectButton.Name = "regularEjectButton";
            this.regularEjectButton.Size = new System.Drawing.Size(75, 23);
            this.regularEjectButton.TabIndex = 19;
            this.regularEjectButton.Text = "Eject";
            this.regularEjectButton.UseVisualStyleBackColor = true;
            this.regularEjectButton.Click += new System.EventHandler(this.regularEjectButton_Click);
            // 
            // lemonSodaPicBox
            // 
            this.lemonSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("lemonSodaPicBox.Image")));
            this.lemonSodaPicBox.Location = new System.Drawing.Point(436, 73);
            this.lemonSodaPicBox.Name = "lemonSodaPicBox";
            this.lemonSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.lemonSodaPicBox.TabIndex = 18;
            this.lemonSodaPicBox.TabStop = false;
            // 
            // orangeSodaPicBox
            // 
            this.orangeSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("orangeSodaPicBox.Image")));
            this.orangeSodaPicBox.Location = new System.Drawing.Point(232, 73);
            this.orangeSodaPicBox.Name = "orangeSodaPicBox";
            this.orangeSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.orangeSodaPicBox.TabIndex = 17;
            this.orangeSodaPicBox.TabStop = false;
            // 
            // regularSodaPicBox
            // 
            this.regularSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("regularSodaPicBox.Image")));
            this.regularSodaPicBox.Location = new System.Drawing.Point(28, 73);
            this.regularSodaPicBox.Name = "regularSodaPicBox";
            this.regularSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.regularSodaPicBox.TabIndex = 16;
            this.regularSodaPicBox.TabStop = false;
            // 
            // tabPageService
            // 
            this.tabPageService.Controls.Add(this.groupBox_CoinBox);
            this.tabPageService.Controls.Add(this.groupBox_ServiceCans);
            this.tabPageService.Location = new System.Drawing.Point(4, 22);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(658, 426);
            this.tabPageService.TabIndex = 1;
            this.tabPageService.Text = "Service";
            this.tabPageService.UseVisualStyleBackColor = true;
            // 
            // listViewServiceCansRemaining
            // 
            this.listViewServiceCansRemaining.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListView_CanFlavor,
            this.ListView_CansRemaining});
            this.listViewServiceCansRemaining.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.listViewServiceCansRemaining.Location = new System.Drawing.Point(6, 14);
            this.listViewServiceCansRemaining.Name = "listViewServiceCansRemaining";
            this.listViewServiceCansRemaining.Size = new System.Drawing.Size(215, 86);
            this.listViewServiceCansRemaining.TabIndex = 0;
            this.listViewServiceCansRemaining.UseCompatibleStateImageBehavior = false;
            this.listViewServiceCansRemaining.View = System.Windows.Forms.View.Details;
            // 
            // ListView_CanFlavor
            // 
            this.ListView_CanFlavor.Text = "Flavor";
            this.ListView_CanFlavor.Width = 94;
            // 
            // ListView_CansRemaining
            // 
            this.ListView_CansRemaining.Tag = "Cans Remaining";
            this.ListView_CansRemaining.Text = "Cans Remaining";
            this.ListView_CansRemaining.Width = 110;
            // 
            // groupBox_ServiceCans
            // 
            this.groupBox_ServiceCans.Controls.Add(this.buttonRefillCans);
            this.groupBox_ServiceCans.Controls.Add(this.listViewServiceCansRemaining);
            this.groupBox_ServiceCans.Location = new System.Drawing.Point(19, 242);
            this.groupBox_ServiceCans.Name = "groupBox_ServiceCans";
            this.groupBox_ServiceCans.Size = new System.Drawing.Size(244, 151);
            this.groupBox_ServiceCans.TabIndex = 1;
            this.groupBox_ServiceCans.TabStop = false;
            this.groupBox_ServiceCans.Text = "Can Rack";
            // 
            // buttonRefillCans
            // 
            this.buttonRefillCans.Location = new System.Drawing.Point(6, 106);
            this.buttonRefillCans.Name = "buttonRefillCans";
            this.buttonRefillCans.Size = new System.Drawing.Size(215, 23);
            this.buttonRefillCans.TabIndex = 1;
            this.buttonRefillCans.Text = "Refill cans";
            this.buttonRefillCans.UseVisualStyleBackColor = true;
            // 
            // groupBox_CoinBox
            // 
            this.groupBox_CoinBox.Controls.Add(this.buttonEmptyInsertedCoinBox);
            this.groupBox_CoinBox.Controls.Add(this.buttonEmptyMainCoinBox);
            this.groupBox_CoinBox.Controls.Add(this.labelInsertedCoinBox);
            this.groupBox_CoinBox.Controls.Add(this.labelMainCoinBox);
            this.groupBox_CoinBox.Controls.Add(this.listView_InsertedCoinbox);
            this.groupBox_CoinBox.Controls.Add(this.listView_mainCoinbox);
            this.groupBox_CoinBox.Location = new System.Drawing.Point(19, 28);
            this.groupBox_CoinBox.Name = "groupBox_CoinBox";
            this.groupBox_CoinBox.Size = new System.Drawing.Size(410, 197);
            this.groupBox_CoinBox.TabIndex = 2;
            this.groupBox_CoinBox.TabStop = false;
            this.groupBox_CoinBox.Text = "Coin Box";
            // 
            // listView_mainCoinbox
            // 
            this.listView_mainCoinbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.main_coins,
            this.main_qty,
            this.main_value});
            this.listView_mainCoinbox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21});
            this.listView_mainCoinbox.Location = new System.Drawing.Point(11, 43);
            this.listView_mainCoinbox.Name = "listView_mainCoinbox";
            this.listView_mainCoinbox.Size = new System.Drawing.Size(186, 110);
            this.listView_mainCoinbox.TabIndex = 0;
            this.listView_mainCoinbox.UseCompatibleStateImageBehavior = false;
            this.listView_mainCoinbox.View = System.Windows.Forms.View.Details;
            // 
            // main_coins
            // 
            this.main_coins.Text = "Coins";
            // 
            // main_qty
            // 
            this.main_qty.Text = "Qty";
            this.main_qty.Width = 62;
            // 
            // main_value
            // 
            this.main_value.Text = "Value";
            // 
            // listView_InsertedCoinbox
            // 
            this.listView_InsertedCoinbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.inserted_coins,
            this.inserted_qty,
            this.inserted_value});
            this.listView_InsertedCoinbox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26});
            this.listView_InsertedCoinbox.Location = new System.Drawing.Point(203, 43);
            this.listView_InsertedCoinbox.Name = "listView_InsertedCoinbox";
            this.listView_InsertedCoinbox.Size = new System.Drawing.Size(186, 110);
            this.listView_InsertedCoinbox.TabIndex = 1;
            this.listView_InsertedCoinbox.UseCompatibleStateImageBehavior = false;
            this.listView_InsertedCoinbox.View = System.Windows.Forms.View.Details;
            // 
            // inserted_coins
            // 
            this.inserted_coins.Text = "Coins";
            // 
            // inserted_qty
            // 
            this.inserted_qty.Text = "Qty";
            this.inserted_qty.Width = 62;
            // 
            // inserted_value
            // 
            this.inserted_value.Text = "Value";
            // 
            // labelMainCoinBox
            // 
            this.labelMainCoinBox.AutoSize = true;
            this.labelMainCoinBox.Location = new System.Drawing.Point(11, 31);
            this.labelMainCoinBox.Name = "labelMainCoinBox";
            this.labelMainCoinBox.Size = new System.Drawing.Size(75, 13);
            this.labelMainCoinBox.TabIndex = 2;
            this.labelMainCoinBox.Text = "Main Coin Box";
            // 
            // labelInsertedCoinBox
            // 
            this.labelInsertedCoinBox.AutoSize = true;
            this.labelInsertedCoinBox.Location = new System.Drawing.Point(203, 27);
            this.labelInsertedCoinBox.Name = "labelInsertedCoinBox";
            this.labelInsertedCoinBox.Size = new System.Drawing.Size(74, 13);
            this.labelInsertedCoinBox.TabIndex = 3;
            this.labelInsertedCoinBox.Text = "Inserted Coins";
            // 
            // buttonEmptyMainCoinBox
            // 
            this.buttonEmptyMainCoinBox.Location = new System.Drawing.Point(14, 159);
            this.buttonEmptyMainCoinBox.Name = "buttonEmptyMainCoinBox";
            this.buttonEmptyMainCoinBox.Size = new System.Drawing.Size(183, 23);
            this.buttonEmptyMainCoinBox.TabIndex = 4;
            this.buttonEmptyMainCoinBox.Text = "Empty Main Coin Box";
            this.buttonEmptyMainCoinBox.UseVisualStyleBackColor = true;
            // 
            // buttonEmptyInsertedCoinBox
            // 
            this.buttonEmptyInsertedCoinBox.Location = new System.Drawing.Point(206, 159);
            this.buttonEmptyInsertedCoinBox.Name = "buttonEmptyInsertedCoinBox";
            this.buttonEmptyInsertedCoinBox.Size = new System.Drawing.Size(183, 23);
            this.buttonEmptyInsertedCoinBox.TabIndex = 5;
            this.buttonEmptyInsertedCoinBox.Text = "Empty Inserted Coins";
            this.buttonEmptyInsertedCoinBox.UseVisualStyleBackColor = true;
            // 
            // VendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 503);
            this.Controls.Add(this.tabControlVending);
            this.Name = "VendingForm";
            this.Text = ".NET C# Vending Machine";
            this.Load += new System.EventHandler(this.VendingForm_Load);
            this.tabControlVending.ResumeLayout(false);
            this.tabPageVend.ResumeLayout(false);
            this.tabPageVend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonSodaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSodaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularSodaPicBox)).EndInit();
            this.tabPageService.ResumeLayout(false);
            this.groupBox_ServiceCans.ResumeLayout(false);
            this.groupBox_CoinBox.ResumeLayout(false);
            this.groupBox_CoinBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVending;
        private System.Windows.Forms.TabPage tabPageVend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CoinReturnButton;
        private System.Windows.Forms.Label ExactChangeLabel;
        private System.Windows.Forms.Label totalInsertedDisplayLabel;
        private System.Windows.Forms.Label totalInsertedLabel;
        private System.Windows.Forms.Label pleaseInsertLabel;
        private System.Windows.Forms.Button nickelButton;
        private System.Windows.Forms.Button dimeButton;
        private System.Windows.Forms.Button quarterButton;
        private System.Windows.Forms.Button halfDollarButton;
        private System.Windows.Forms.Button lemonEjectButton;
        private System.Windows.Forms.Button orangeEjectButton;
        private System.Windows.Forms.Button regularEjectButton;
        private System.Windows.Forms.PictureBox lemonSodaPicBox;
        private System.Windows.Forms.PictureBox orangeSodaPicBox;
        private System.Windows.Forms.PictureBox regularSodaPicBox;
        private System.Windows.Forms.TabPage tabPageService;
        private System.Windows.Forms.GroupBox groupBox_ServiceCans;
        private System.Windows.Forms.Button buttonRefillCans;
        private System.Windows.Forms.ListView listViewServiceCansRemaining;
        private System.Windows.Forms.ColumnHeader ListView_CanFlavor;
        private System.Windows.Forms.ColumnHeader ListView_CansRemaining;
        private System.Windows.Forms.GroupBox groupBox_CoinBox;
        private System.Windows.Forms.ListView listView_InsertedCoinbox;
        private System.Windows.Forms.ColumnHeader inserted_coins;
        private System.Windows.Forms.ColumnHeader inserted_qty;
        private System.Windows.Forms.ColumnHeader inserted_value;
        private System.Windows.Forms.ListView listView_mainCoinbox;
        private System.Windows.Forms.ColumnHeader main_coins;
        private System.Windows.Forms.ColumnHeader main_qty;
        private System.Windows.Forms.ColumnHeader main_value;
        private System.Windows.Forms.Button buttonEmptyMainCoinBox;
        private System.Windows.Forms.Label labelInsertedCoinBox;
        private System.Windows.Forms.Label labelMainCoinBox;
        private System.Windows.Forms.Button buttonEmptyInsertedCoinBox;

    }
}

