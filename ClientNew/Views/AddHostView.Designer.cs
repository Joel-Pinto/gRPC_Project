namespace ClientNew.Views
{
    partial class AddHostView
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
            this.btnSubmitHost = new System.Windows.Forms.Button();
            this.lblIntroduzirIP = new System.Windows.Forms.Label();
            this.txtBoxHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmitHost
            // 
            this.btnSubmitHost.Location = new System.Drawing.Point(167, 96);
            this.btnSubmitHost.Name = "btnSubmitHost";
            this.btnSubmitHost.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitHost.TabIndex = 0;
            this.btnSubmitHost.Text = "Validar";
            this.btnSubmitHost.UseVisualStyleBackColor = true;
            this.btnSubmitHost.Click += new System.EventHandler(this.btnSubmitHost_Click);
            // 
            // lblIntroduzirIP
            // 
            this.lblIntroduzirIP.AutoSize = true;
            this.lblIntroduzirIP.Location = new System.Drawing.Point(26, 51);
            this.lblIntroduzirIP.Name = "lblIntroduzirIP";
            this.lblIntroduzirIP.Size = new System.Drawing.Size(178, 15);
            this.lblIntroduzirIP.TabIndex = 1;
            this.lblIntroduzirIP.Text = "Introduza o Endereço Local Host";
            // 
            // txtBoxHost
            // 
            this.txtBoxHost.Location = new System.Drawing.Point(210, 48);
            this.txtBoxHost.Name = "txtBoxHost";
            this.txtBoxHost.Size = new System.Drawing.Size(181, 23);
            this.txtBoxHost.TabIndex = 2;
            // 
            // AddHostView
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 194);
            this.Controls.Add(this.txtBoxHost);
            this.Controls.Add(this.lblIntroduzirIP);
            this.Controls.Add(this.btnSubmitHost);
            this.Name = "AddHostView";
            this.Text = "PopUpView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSubmitHost;
        private Label lblIntroduzirIP;
        public TextBox txtBoxHost;
    }
}