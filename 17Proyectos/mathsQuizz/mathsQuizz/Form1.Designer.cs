namespace mathsQuizz
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
            timeLabel = new Label();
            timaLeft = new Label();
            plusLeftLabel = new Label();
            plusSign = new Label();
            sum = new NumericUpDown();
            equalLabel = new Label();
            plusRightLabel = new Label();
            minusLeftLabel = new Label();
            minusSign = new Label();
            diference = new NumericUpDown();
            equalSign2 = new Label();
            minusRightLabel = new Label();
            timesRightLabel = new Label();
            equalsign3 = new Label();
            product = new NumericUpDown();
            multiplySigns = new Label();
            timesLeftLabel = new Label();
            dividedRightLabel = new Label();
            equalSign4 = new Label();
            quotient = new NumericUpDown();
            dividedSign = new Label();
            dividedLeftLabel = new Label();
            stratBtt = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(648, 154);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 50);
            timeLabel.TabIndex = 0;
            // 
            // timaLeft
            // 
            timaLeft.AutoSize = true;
            timaLeft.Location = new Point(707, 97);
            timaLeft.Name = "timaLeft";
            timaLeft.Size = new Size(71, 20);
            timaLeft.TabIndex = 1;
            timaLeft.Text = "Time Left";
            timaLeft.Click += timaLeft_Click;
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plusLeftLabel.Location = new Point(41, 48);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusLeftLabel.Click += plusLeftLabel_Click;
            // 
            // plusSign
            // 
            plusSign.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plusSign.Location = new Point(164, 48);
            plusSign.Name = "plusSign";
            plusSign.Size = new Size(60, 50);
            plusSign.TabIndex = 3;
            plusSign.Text = "+";
            plusSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Location = new Point(501, 67);
            sum.Name = "sum";
            sum.Size = new Size(76, 27);
            sum.TabIndex = 2;
            sum.Enter += answer_Enter;
            // 
            // equalLabel
            // 
            equalLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equalLabel.Location = new Point(395, 48);
            equalLabel.Name = "equalLabel";
            equalLabel.Size = new Size(60, 50);
            equalLabel.TabIndex = 7;
            equalLabel.Text = "=";
            equalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plusRightLabel.Location = new Point(284, 48);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 8;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minusLeftLabel.Location = new Point(41, 135);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 9;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusSign
            // 
            minusSign.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minusSign.Location = new Point(164, 135);
            minusSign.Name = "minusSign";
            minusSign.Size = new Size(60, 50);
            minusSign.TabIndex = 10;
            minusSign.Text = "-";
            minusSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // diference
            // 
            diference.Location = new Point(501, 154);
            diference.Name = "diference";
            diference.Size = new Size(76, 27);
            diference.TabIndex = 3;
            // 
            // equalSign2
            // 
            equalSign2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equalSign2.Location = new Point(395, 135);
            equalSign2.Name = "equalSign2";
            equalSign2.Size = new Size(60, 50);
            equalSign2.TabIndex = 12;
            equalSign2.Text = "=";
            equalSign2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minusRightLabel.Location = new Point(284, 135);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 13;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timesRightLabel.Location = new Point(284, 206);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 18;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equalsign3
            // 
            equalsign3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equalsign3.Location = new Point(395, 206);
            equalsign3.Name = "equalsign3";
            equalsign3.Size = new Size(60, 50);
            equalsign3.TabIndex = 17;
            equalsign3.Text = "=";
            equalsign3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Location = new Point(501, 225);
            product.Name = "product";
            product.Size = new Size(76, 27);
            product.TabIndex = 4;
            // 
            // multiplySigns
            // 
            multiplySigns.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multiplySigns.Location = new Point(164, 206);
            multiplySigns.Name = "multiplySigns";
            multiplySigns.Size = new Size(60, 50);
            multiplySigns.TabIndex = 15;
            multiplySigns.Text = "x";
            multiplySigns.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timesLeftLabel.Location = new Point(41, 206);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 14;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dividedRightLabel.Location = new Point(284, 286);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 23;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equalSign4
            // 
            equalSign4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equalSign4.Location = new Point(395, 286);
            equalSign4.Name = "equalSign4";
            equalSign4.Size = new Size(60, 50);
            equalSign4.TabIndex = 22;
            equalSign4.Text = "=";
            equalSign4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Location = new Point(501, 305);
            quotient.Name = "quotient";
            quotient.Size = new Size(76, 27);
            quotient.TabIndex = 5;
            // 
            // dividedSign
            // 
            dividedSign.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dividedSign.Location = new Point(164, 286);
            dividedSign.Name = "dividedSign";
            dividedSign.Size = new Size(60, 50);
            dividedSign.TabIndex = 20;
            dividedSign.Text = "÷";
            dividedSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dividedLeftLabel.Location = new Point(41, 286);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 19;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stratBtt
            // 
            stratBtt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stratBtt.Location = new Point(639, 286);
            stratBtt.Name = "stratBtt";
            stratBtt.Size = new Size(226, 50);
            stratBtt.TabIndex = 1;
            stratBtt.Text = "Start Quizz";
            stratBtt.UseVisualStyleBackColor = true;
            stratBtt.Click += stratBtt_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 375);
            Controls.Add(stratBtt);
            Controls.Add(dividedRightLabel);
            Controls.Add(equalSign4);
            Controls.Add(quotient);
            Controls.Add(dividedSign);
            Controls.Add(dividedLeftLabel);
            Controls.Add(timesRightLabel);
            Controls.Add(equalsign3);
            Controls.Add(product);
            Controls.Add(multiplySigns);
            Controls.Add(timesLeftLabel);
            Controls.Add(minusRightLabel);
            Controls.Add(equalSign2);
            Controls.Add(diference);
            Controls.Add(minusSign);
            Controls.Add(minusLeftLabel);
            Controls.Add(plusRightLabel);
            Controls.Add(equalLabel);
            Controls.Add(sum);
            Controls.Add(plusSign);
            Controls.Add(plusLeftLabel);
            Controls.Add(timaLeft);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Math Quizz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)diference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label timaLeft;
        private Label plusLeftLabel;
        private Label plusSign;
        private Label label4;
        private NumericUpDown sum;
        private Label equalLabel;
        private Label plusRightLabel;
        private Label minusLeftLabel;
        private Label minusSign;
        private NumericUpDown diference;
        private Label equalSign2;
        private Label minusRightLabel;
        private Label timesRightLabel;
        private Label equalsign3;
        private NumericUpDown product;
        private Label multiplySigns;
        private Label timesLeftLabel;
        private Label dividedRightLabel;
        private Label equalSign4;
        private NumericUpDown quotient;
        private Label dividedSign;
        private Label dividedLeftLabel;
        private Button stratBtt;
        private System.Windows.Forms.Timer timer1;
    }
}
