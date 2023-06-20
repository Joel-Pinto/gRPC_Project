namespace ClientNew.Views
{
    partial class LoginView
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userTxtB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.pswTxtB = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkLbRegistar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(105, 84);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 21);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // userTxtB
            // 
            this.userTxtB.Location = new System.Drawing.Point(105, 108);
            this.userTxtB.Name = "userTxtB";
            this.userTxtB.Size = new System.Drawing.Size(183, 23);
            this.userTxtB.TabIndex = 1;
            this.userTxtB.Text = "Fockester";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(105, 176);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 21);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // pswTxtB
            // 
            this.pswTxtB.Location = new System.Drawing.Point(105, 200);
            this.pswTxtB.Name = "pswTxtB";
            this.pswTxtB.Size = new System.Drawing.Size(183, 23);
            this.pswTxtB.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(148, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Não tens conta?";
            // 
            // lnkLbRegistar
            // 
            this.lnkLbRegistar.AutoSize = true;
            this.lnkLbRegistar.Location = new System.Drawing.Point(192, 311);
            this.lnkLbRegistar.Name = "lnkLbRegistar";
            this.lnkLbRegistar.Size = new System.Drawing.Size(60, 15);
            this.lnkLbRegistar.TabIndex = 7;
            this.lnkLbRegistar.TabStop = true;
            this.lnkLbRegistar.Text = "Regista-te";
            this.lnkLbRegistar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbRegistar_LinkClicked);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(400, 367);
            this.Controls.Add(this.lnkLbRegistar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pswTxtB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userTxtB);
            this.Controls.Add(this.usernameLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(18)))), ((int)(((byte)(202)))));
            this.Name = "LoginView";
            this.Text = " Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label usernameLabel;
        public TextBox userTxtB;
        private Label passwordLabel;
        private TextBox pswTxtB;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private LinkLabel lnkLbRegistar;
    }
}