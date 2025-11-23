namespace loginFrom
{
    partial class frmLogin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.logInBt = new System.Windows.Forms.Button();
            this.logOutbtt = new System.Windows.Forms.Button();
            this.userNLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 35);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 172);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(429, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // logInBt
            // 
            this.logInBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBt.Location = new System.Drawing.Point(312, 249);
            this.logInBt.Name = "logInBt";
            this.logInBt.Size = new System.Drawing.Size(248, 40);
            this.logInBt.TabIndex = 2;
            this.logInBt.Text = "LOGIN";
            this.logInBt.UseVisualStyleBackColor = true;
            this.logInBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOutbtt
            // 
            this.logOutbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutbtt.Location = new System.Drawing.Point(312, 315);
            this.logOutbtt.Name = "logOutbtt";
            this.logOutbtt.Size = new System.Drawing.Size(248, 40);
            this.logOutbtt.TabIndex = 3;
            this.logOutbtt.Text = "LOGOUT";
            this.logOutbtt.UseVisualStyleBackColor = true;
            this.logOutbtt.Click += new System.EventHandler(this.logOutbtt_Click);
            // 
            // userNLabel
            // 
            this.userNLabel.BackColor = System.Drawing.Color.Black;
            this.userNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNLabel.Location = new System.Drawing.Point(25, 111);
            this.userNLabel.Name = "userNLabel";
            this.userNLabel.Size = new System.Drawing.Size(186, 32);
            this.userNLabel.TabIndex = 4;
            this.userNLabel.Text = "USERNAME";
            this.userNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordLabel.Location = new System.Drawing.Point(25, 175);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(186, 35);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "PASSWORD";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(925, 413);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNLabel);
            this.Controls.Add(this.logOutbtt);
            this.Controls.Add(this.logInBt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN FORM";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button logInBt;
        private System.Windows.Forms.Button logOutbtt;
        private System.Windows.Forms.Label userNLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

