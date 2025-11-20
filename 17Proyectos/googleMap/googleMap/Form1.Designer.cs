namespace googleMap
{
    partial class Frm
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
            splitContainer1 = new SplitContainer();
            btSeearch = new Button();
            countryL = new Label();
            stateL = new Label();
            cityL = new Label();
            streetL = new Label();
            textBoxCity = new TextBox();
            textBoxState = new TextBox();
            textBoxCountry = new TextBox();
            textBoxStreet = new TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btSeearch);
            splitContainer1.Panel1.Controls.Add(countryL);
            splitContainer1.Panel1.Controls.Add(stateL);
            splitContainer1.Panel1.Controls.Add(cityL);
            splitContainer1.Panel1.Controls.Add(streetL);
            splitContainer1.Panel1.Controls.Add(textBoxCity);
            splitContainer1.Panel1.Controls.Add(textBoxState);
            splitContainer1.Panel1.Controls.Add(textBoxCountry);
            splitContainer1.Panel1.Controls.Add(textBoxStreet);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(webView21);
            splitContainer1.Size = new Size(1361, 725);
            splitContainer1.SplitterDistance = 240;
            splitContainer1.TabIndex = 0;
            // 
            // btSeearch
            // 
            btSeearch.BackColor = Color.MidnightBlue;
            btSeearch.ForeColor = Color.White;
            btSeearch.Location = new Point(12, 478);
            btSeearch.Name = "btSeearch";
            btSeearch.Size = new Size(220, 29);
            btSeearch.TabIndex = 8;
            btSeearch.Text = "Search";
            btSeearch.UseVisualStyleBackColor = false;
            btSeearch.Click += btSeearch_Click;
            // 
            // countryL
            // 
            countryL.AutoSize = true;
            countryL.Location = new Point(12, 377);
            countryL.Name = "countryL";
            countryL.Size = new Size(60, 20);
            countryL.TabIndex = 7;
            countryL.Text = "Country";
            // 
            // stateL
            // 
            stateL.AutoSize = true;
            stateL.Location = new Point(12, 292);
            stateL.Name = "stateL";
            stateL.Size = new Size(43, 20);
            stateL.TabIndex = 6;
            stateL.Text = "State";
            // 
            // cityL
            // 
            cityL.AutoSize = true;
            cityL.Location = new Point(12, 208);
            cityL.Name = "cityL";
            cityL.Size = new Size(34, 20);
            cityL.TabIndex = 5;
            cityL.Text = "City";
            cityL.Click += label2_Click;
            // 
            // streetL
            // 
            streetL.AutoSize = true;
            streetL.Location = new Point(12, 131);
            streetL.Name = "streetL";
            streetL.Size = new Size(48, 20);
            streetL.TabIndex = 4;
            streetL.Text = "Street";
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCity.Location = new Point(12, 231);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(220, 27);
            textBoxCity.TabIndex = 3;
            // 
            // textBoxState
            // 
            textBoxState.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxState.Location = new Point(12, 315);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(220, 27);
            textBoxState.TabIndex = 2;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCountry.Location = new Point(12, 400);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(220, 27);
            textBoxCountry.TabIndex = 1;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxStreet.Location = new Point(12, 154);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(220, 27);
            textBoxStreet.TabIndex = 0;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(1117, 725);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 725);
            Controls.Add(splitContainer1);
            Name = "Frm";
            Text = "Map";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btSeearch;
        private Label countryL;
        private Label stateL;
        private Label cityL;
        private Label streetL;
        private TextBox textBoxCity;
        private TextBox textBoxState;
        private TextBox textBoxCountry;
        private TextBox textBoxStreet;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
