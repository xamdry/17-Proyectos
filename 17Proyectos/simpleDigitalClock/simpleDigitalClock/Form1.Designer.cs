namespace simpleDigitalClock
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
            HourL = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // HourL
            // 
            HourL.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HourL.ForeColor = Color.White;
            HourL.Location = new Point(-2, -2);
            HourL.Name = "HourL";
            HourL.Size = new Size(409, 201);
            HourL.TabIndex = 0;
            HourL.Text = "11:46:50";
            HourL.Click += HourL_Click;
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
            ClientSize = new Size(406, 133);
            Controls.Add(HourL);
            Name = "Form1";
            Text = "S Digital Hour";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label HourL;
        private System.Windows.Forms.Timer timer1;
    }
}
