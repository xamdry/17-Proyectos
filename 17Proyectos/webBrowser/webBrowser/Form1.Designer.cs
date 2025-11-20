namespace webBrowser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            toolStrip1 = new ToolStrip();
            btBack = new ToolStripButton();
            BtForward = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cLocation = new ToolStripComboBox();
            btGo = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btRefresh = new ToolStripButton();
            btHome = new ToolStripButton();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btBack, BtForward, toolStripSeparator1, cLocation, btGo, btRefresh, btHome });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btBack
            // 
            btBack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btBack.Image = (Image)resources.GetObject("btBack.Image");
            btBack.ImageTransparentColor = Color.Magenta;
            btBack.Name = "btBack";
            btBack.Size = new Size(44, 25);
            btBack.Text = "Back";
            btBack.Click += btBack_Click;
            // 
            // BtForward
            // 
            BtForward.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BtForward.Image = (Image)resources.GetObject("BtForward.Image");
            BtForward.ImageTransparentColor = Color.Magenta;
            BtForward.Name = "BtForward";
            BtForward.Size = new Size(67, 25);
            BtForward.Text = "Forward";
            BtForward.Click += BtForward_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // cLocation
            // 
            cLocation.AutoCompleteSource = AutoCompleteSource.AllUrl;
            cLocation.Name = "cLocation";
            cLocation.Size = new Size(121, 28);
            cLocation.KeyDown += cLocation_KeyDown;
            // 
            // btGo
            // 
            btGo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btGo.Image = (Image)resources.GetObject("btGo.Image");
            btGo.ImageTransparentColor = Color.Magenta;
            btGo.Name = "btGo";
            btGo.Size = new Size(32, 25);
            btGo.Text = "Go";
            btGo.Click += btGo_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 28);
            webView21.Name = "webView21";
            webView21.Size = new Size(800, 422);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            // 
            // btRefresh
            // 
            btRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btRefresh.Image = (Image)resources.GetObject("btRefresh.Image");
            btRefresh.ImageTransparentColor = Color.Magenta;
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(62, 25);
            btRefresh.Text = "Refresh";
            btRefresh.Click += btRefresh_Click;
            // 
            // btHome
            // 
            btHome.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btHome.Image = (Image)resources.GetObject("btHome.Image");
            btHome.ImageTransparentColor = Color.Magenta;
            btHome.Name = "btHome";
            btHome.Size = new Size(54, 25);
            btHome.Text = "Home";
            btHome.Click += btHome_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView21);
            Controls.Add(toolStrip1);
            Name = "frmMain";
            Text = "XAM";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btBack;
        private ToolStripButton BtForward;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox cLocation;
        private ToolStripButton btGo;
        private ContextMenuStrip contextMenuStrip1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ToolStripButton btRefresh;
        private ToolStripButton btHome;
    }
}
