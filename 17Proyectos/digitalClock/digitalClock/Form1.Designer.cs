namespace digitalClock
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            hourMinute = new Label();
            secondsL = new Label();
            dayL = new Label();
            weekL = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // hourMinute
            // 
            hourMinute.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic);
            hourMinute.ForeColor = Color.Transparent;
            hourMinute.Location = new Point(12, 11);
            hourMinute.Name = "hourMinute";
            hourMinute.Size = new Size(316, 115);
            hourMinute.TabIndex = 0;
            hourMinute.Text = "10 : 00";
            hourMinute.Click += hourMinute_Click;
            // 
            // secondsL
            // 
            secondsL.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic);
            secondsL.ForeColor = Color.Transparent;
            secondsL.Location = new Point(305, 11);
            secondsL.Name = "secondsL";
            secondsL.Size = new Size(153, 115);
            secondsL.TabIndex = 1;
            secondsL.Text = "10";
            // 
            // dayL
            // 
            dayL.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic);
            dayL.ForeColor = Color.Transparent;
            dayL.Location = new Point(12, 126);
            dayL.Name = "dayL";
            dayL.Size = new Size(555, 115);
            dayL.TabIndex = 2;
            dayL.Text = "Oct 17 2025";
            // 
            // weekL
            // 
            weekL.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic);
            weekL.ForeColor = Color.Transparent;
            weekL.Location = new Point(12, 241);
            weekL.Name = "weekL";
            weekL.Size = new Size(408, 115);
            weekL.TabIndex = 3;
            weekL.Text = "Monday";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(698, 454);
            Controls.Add(weekL);
            Controls.Add(dayL);
            Controls.Add(secondsL);
            Controls.Add(hourMinute);
            Name = "Form1";
            Text = "Digital Clock";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label hourMinute;
        private Label secondsL;
        private Label dayL;
        private Label weekL;
        private System.Windows.Forms.Timer timer1;
    }
}
