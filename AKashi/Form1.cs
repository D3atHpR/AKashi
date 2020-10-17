using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKashi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://goggle.com.br");
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser1.DocumentTitle;
        }

        private void gotest_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web!=null)
            {
                web.Navigate(txtUrl.Text);

            }

        }
        WebBrowser webNewTab = null;

        private void btnTabTest_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webNewTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webNewTab.Parent = tab;
            webNewTab.Dock = DockStyle.Fill;
            webNewTab.Navigate("https://www.google.com.br");
            webNewTab.DocumentCompleted += WebNewTab_DocumentCompleted;

        }

        private void WebNewTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webNewTab.DocumentTitle;
        }    
    }
}
