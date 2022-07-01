namespace Replacord_Gateway
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gotourl = new System.Windows.Forms.Button();
            this.url_bar = new System.Windows.Forms.TextBox();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.reload = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.gotourl);
            this.panel1.Controls.Add(this.url_bar);
            this.panel1.Controls.Add(this.search_bar);
            this.panel1.Controls.Add(this.reload);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.forward);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 2;
            // 
            // gotourl
            // 
            this.gotourl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gotourl.AutoSize = true;
            this.gotourl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gotourl.ForeColor = System.Drawing.Color.White;
            this.gotourl.Image = ((System.Drawing.Image)(resources.GetObject("gotourl.Image")));
            this.gotourl.Location = new System.Drawing.Point(424, 8);
            this.gotourl.Name = "gotourl";
            this.gotourl.Size = new System.Drawing.Size(70, 70);
            this.gotourl.TabIndex = 7;
            this.gotourl.UseVisualStyleBackColor = true;
            this.gotourl.Click += new System.EventHandler(this.gotourl_Click);
            // 
            // url_bar
            // 
            this.url_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url_bar.BackColor = System.Drawing.SystemColors.Window;
            this.url_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_bar.Location = new System.Drawing.Point(494, 23);
            this.url_bar.Name = "url_bar";
            this.url_bar.Size = new System.Drawing.Size(120, 48);
            this.url_bar.TabIndex = 6;
            this.url_bar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.url_bar_KeyPress);
            // 
            // search_bar
            // 
            this.search_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_bar.BackColor = System.Drawing.SystemColors.Window;
            this.search_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bar.Location = new System.Drawing.Point(122, 23);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(296, 48);
            this.search_bar.TabIndex = 1;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);
            this.search_bar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_bar_KeyPress);
            // 
            // reload
            // 
            this.reload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reload.AutoSize = true;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reload.Image = ((System.Drawing.Image)(resources.GetObject("reload.Image")));
            this.reload.Location = new System.Drawing.Point(620, 16);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(55, 55);
            this.reload.TabIndex = 5;
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back.AutoSize = true;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(742, 16);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(55, 55);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forward.AutoSize = true;
            this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.Location = new System.Drawing.Point(681, 16);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(55, 55);
            this.forward.TabIndex = 3;
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // home
            // 
            this.home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.Color.Black;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(0, 16);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(55, 55);
            this.home.TabIndex = 2;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 376);
            this.panel2.TabIndex = 3;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.search.AutoSize = true;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(61, 16);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(55, 62);
            this.search.TabIndex = 0;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // browser
            // 
            this.browser.AllowExternalDrop = true;
            this.browser.CreationProperties = null;
            this.browser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 72);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(800, 434);
            this.browser.Source = new System.Uri("https://zombie.codeberg.page/-/", System.UriKind.Absolute);
            this.browser.TabIndex = 1;
            this.browser.ZoomFactor = 1D;
            this.browser.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.browser_NavigationStarting);
            this.browser.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.browser_NavigationCompleted);
            this.browser.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.browser_SourceChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(491, 506);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Replacord Gateway";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 browser;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button gotourl;
        private System.Windows.Forms.TextBox url_bar;
    }
}