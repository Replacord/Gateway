using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using EasyTabs;
using System.IO;

namespace Replacord_Gateway
{
    public partial class Form1 : Form
    {


        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        

        private void search_Click(object sender, EventArgs e)
        {

            browser.CoreWebView2.Navigate("https://duckduckgo.com/?q=" + search_bar.Text + "&va=b&t=hr&hps=1&ia=web");

        }

        private void search_bar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                browser.CoreWebView2.Navigate("https://duckduckgo.com/?q=" + search_bar.Text + "&va=b&t=hr&hps=1&ia=web");
            }

        }

        private void home_Click(object sender, EventArgs e)
        {
            //browser.Source = new Uri("https://zombie.codeberg.page/-/");
            browser.CoreWebView2.Navigate("https://zombie.codeberg.page/-/");
        }

        public string gettabtitle() 
        {

            string name = browser.CoreWebView2.DocumentTitle.ToString();
            return name;

        }

        private void forward_Click(object sender, EventArgs e)
        {
            browser.CoreWebView2.GoForward();
        }

        private void back_Click(object sender, EventArgs e)
        {
            browser.CoreWebView2.GoBack();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            browser.CoreWebView2.Reload();
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {

        }

        private void browser_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
 
        }

        private void browser_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            this.ParentTabs.SelectedTab.Caption = gettabtitle();
            url_bar.Text = browser.Source.ToString().Replace("https://zombie.codeberg.page/-/", "gateway://home");
        }

        private void gotourl_Click(object sender, EventArgs e)
        {
            string url = url_bar.Text.Replace("gateway://home", "https://zombie.codeberg.page/-/");
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute);
            if (isUri == true) {
                browser.CoreWebView2.Navigate(url);
            
            }
        }

        private void url_bar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string url = url_bar.Text.Replace("gateway://home", "https://zombie.codeberg.page/-/");
                if (url.StartsWith("http://") || url.StartsWith("https://"))
                {
                    bool isUri = Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute);
                    if (isUri == true)
                    {

                        browser.CoreWebView2.Navigate(url);

                    }
                }
                else
                {
                    bool isUri = Uri.IsWellFormedUriString("https://"+url, UriKind.RelativeOrAbsolute);
                    if (isUri == true)
                    {

                        browser.CoreWebView2.Navigate("https://"+url);

                    }
                }
            }
            }

        private void browser_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {

        }
    }
}
