namespace ClientNew.Views
{
    partial class RegistarView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registar";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(99, 121);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(243, 23);
            this.txtBoxUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(99, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(99, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(99, 194);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(243, 23);
            this.txtBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(99, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Localização";
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(99, 271);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(243, 23);
            this.txtBoxLocation.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(99, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data de Nascimento";
            // 
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(99, 348);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(200, 23);
            this.dateBirthday.TabIndex = 8;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(157, 416);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistar.TabIndex = 9;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // RegistarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(445, 495);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.label1);
            this.Name = "RegistarView";
            this.Text = "RegistarView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBoxUsername;
        private Label label2;
        private Label label3;
        private TextBox txtBoxName;
        private Label label4;
        private TextBox txtBoxLocation;
        private Label label5;
        private DateTimePicker dateBirthday;
        private Button btnRegistar;
    }
}