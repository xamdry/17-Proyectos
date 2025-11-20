namespace notePad
{
    partial class frmFile
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
            findBt = new Button();
            cancelBt = new Button();
            textFindWhat = new Label();
            textBox1 = new TextBox();
            checkMatch = new CheckBox();
            groupBox1 = new GroupBox();
            radioUp = new RadioButton();
            radioDown = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // findBt
            // 
            findBt.Location = new Point(349, 19);
            findBt.Name = "findBt";
            findBt.Size = new Size(94, 29);
            findBt.TabIndex = 0;
            findBt.Text = "Find Next";
            findBt.UseVisualStyleBackColor = true;
            findBt.Click += findBt_Click;
            // 
            // cancelBt
            // 
            cancelBt.Location = new Point(349, 80);
            cancelBt.Name = "cancelBt";
            cancelBt.Size = new Size(94, 29);
            cancelBt.TabIndex = 1;
            cancelBt.Text = "Cancel";
            cancelBt.UseVisualStyleBackColor = true;
            // 
            // textFindWhat
            // 
            textFindWhat.AutoSize = true;
            textFindWhat.Location = new Point(26, 19);
            textFindWhat.Name = "textFindWhat";
            textFindWhat.Size = new Size(79, 20);
            textFindWhat.TabIndex = 2;
            textFindWhat.Text = "Find What:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 16);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 34);
            textBox1.TabIndex = 3;
            // 
            // checkMatch
            // 
            checkMatch.AutoSize = true;
            checkMatch.Location = new Point(26, 123);
            checkMatch.Name = "checkMatch";
            checkMatch.Size = new Size(107, 24);
            checkMatch.TabIndex = 4;
            checkMatch.Text = "Match Case";
            checkMatch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioDown);
            groupBox1.Controls.Add(radioUp);
            groupBox1.Location = new Point(129, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Direction";
            // 
            // radioUp
            // 
            radioUp.AutoSize = true;
            radioUp.Location = new Point(16, 37);
            radioUp.Name = "radioUp";
            radioUp.Size = new Size(49, 24);
            radioUp.TabIndex = 0;
            radioUp.TabStop = true;
            radioUp.Text = "Up";
            radioUp.UseVisualStyleBackColor = true;
            // 
            // radioDown
            // 
            radioDown.AutoSize = true;
            radioDown.Location = new Point(71, 37);
            radioDown.Name = "radioDown";
            radioDown.Size = new Size(69, 24);
            radioDown.TabIndex = 1;
            radioDown.TabStop = true;
            radioDown.Text = "Down";
            radioDown.UseVisualStyleBackColor = true;
            // 
            // frmFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 450);
            Controls.Add(groupBox1);
            Controls.Add(checkMatch);
            Controls.Add(textBox1);
            Controls.Add(textFindWhat);
            Controls.Add(cancelBt);
            Controls.Add(findBt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFile";
            Text = "Find";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button findBt;
        private Button cancelBt;
        private Label textFindWhat;
        private TextBox textBox1;
        private CheckBox checkMatch;
        private GroupBox groupBox1;
        private RadioButton radioDown;
        private RadioButton radioUp;
    }
}