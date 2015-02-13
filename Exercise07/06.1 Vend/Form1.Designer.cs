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
            this.tabControlVending.SuspendLayout();
            this.tabPageVend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonSodaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSodaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularSodaPicBox)).BeginInit();
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
            this.tabPageService.Location = new System.Drawing.Point(4, 22);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(658, 426);
            this.tabPageService.TabIndex = 1;
            this.tabPageService.Text = "Service";
            this.tabPageService.UseVisualStyleBackColor = true;
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

    }
}

