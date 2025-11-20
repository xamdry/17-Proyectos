namespace currencyConverter
{
    partial class currencyConverter
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
            bttCurrency = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // bttCurrency
            // 
            bttCurrency.BackColor = Color.MintCream;
            bttCurrency.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bttCurrency.Location = new Point(0, 0);
            bttCurrency.Name = "bttCurrency";
            bttCurrency.Size = new Size(1011, 106);
            bttCurrency.TabIndex = 0;
            bttCurrency.Text = "Currency Converter";
            bttCurrency.UseVisualStyleBackColor = false;
            bttCurrency.Click += bttCurrency_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Bottom;
            webView21.Location = new Point(0, 105);
            webView21.Name = "webView21";
            webView21.Size = new Size(1011, 418);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            // 
            // currencyConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 523);
            Controls.Add(webView21);
            Controls.Add(bttCurrency);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "currencyConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bttCurrency;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
