namespace ClientNew
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBoughtTickets = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDiscover = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMostWatched = new System.Windows.Forms.ListBox();
            this.inWalletTxtBox = new System.Windows.Forms.TextBox();
            this.walletLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.btnBoughtTickets);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 576);
            this.panel1.TabIndex = 0;
            // 
            // btnBoughtTickets
            // 
            this.btnBoughtTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoughtTickets.FlatAppearance.BorderSize = 0;
            this.btnBoughtTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoughtTickets.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBoughtTickets.ForeColor = System.Drawing.Color.White;
            this.btnBoughtTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoughtTickets.Location = new System.Drawing.Point(0, 170);
            this.btnBoughtTickets.Name = "btnBoughtTickets";
            this.btnBoughtTickets.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBoughtTickets.Size = new System.Drawing.Size(183, 50);
            this.btnBoughtTickets.TabIndex = 4;
            this.btnBoughtTickets.Text = "Bought Tickets";
            this.btnBoughtTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoughtTickets.UseVisualStyleBackColor = true;
            this.btnBoughtTickets.Click += new System.EventHandler(this.btnBoughtTickets_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(183, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 70);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(183, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 70);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theaters For All";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discover";
            // 
            // lstDiscover
            // 
            this.lstDiscover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.lstDiscover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDiscover.ForeColor = System.Drawing.Color.Transparent;
            this.lstDiscover.FormattingEnabled = true;
            this.lstDiscover.ItemHeight = 21;
            this.lstDiscover.Location = new System.Drawing.Point(222, 123);
            this.lstDiscover.Name = "lstDiscover";
            this.lstDiscover.Size = new System.Drawing.Size(691, 172);
            this.lstDiscover.TabIndex = 3;
            this.lstDiscover.SelectedIndexChanged += new System.EventHandler(this.lstDiscover_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(222, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Most Watched";
            // 
            // lstMostWatched
            // 
            this.lstMostWatched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.lstMostWatched.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMostWatched.ForeColor = System.Drawing.Color.Transparent;
            this.lstMostWatched.FormattingEnabled = true;
            this.lstMostWatched.ItemHeight = 21;
            this.lstMostWatched.Location = new System.Drawing.Point(222, 380);
            this.lstMostWatched.Name = "lstMostWatched";
            this.lstMostWatched.Size = new System.Drawing.Size(691, 172);
            this.lstMostWatched.TabIndex = 6;
            // 
            // inWalletTxtBox
            // 
            this.inWalletTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.inWalletTxtBox.ForeColor = System.Drawing.Color.Transparent;
            this.inWalletTxtBox.Location = new System.Drawing.Point(813, 24);
            this.inWalletTxtBox.Name = "inWalletTxtBox";
            this.inWalletTxtBox.Size = new System.Drawing.Size(100, 23);
            this.inWalletTxtBox.TabIndex = 20;
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.ForeColor = System.Drawing.Color.White;
            this.walletLabel.Location = new System.Drawing.Point(765, 28);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(40, 15);
            this.walletLabel.TabIndex = 19;
            this.walletLabel.Text = "Wallet";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(951, 576);
            this.Controls.Add(this.inWalletTxtBox);
            this.Controls.Add(this.walletLabel);
            this.Controls.Add(this.lstMostWatched);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstDiscover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        public Button btnBoughtTickets;
        public Button btnSearch;
        public Button btnHome;
        private Panel panel2;
        private Label label1;
        private Label label2;
        public ListBox lstDiscover;
        private Label label3;
        public ListBox lstMostWatched;
        public TextBox inWalletTxtBox;
        private Label walletLabel;
    }
}