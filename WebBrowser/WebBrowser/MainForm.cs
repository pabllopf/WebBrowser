using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void goForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(url.Text)) 
            {
                webBrowser.Navigate(url.Text);
            }
        }

        private void url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13) 
            {
                webBrowser.Navigate(url.Text);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com/");
        }
    }
}
