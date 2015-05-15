using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using Website_linker.Support;

namespace Website_linker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            WebOne.Text = Proper_site(WebOne.Text);
            WebTwo.Text = Proper_site(WebTwo.Text);

            DOWNLOAD(WebOne.Text);
        }

        //USER DEFINED UTILITY
        private string Proper_site(string URL)
        {
            string fixer = null;
            string REAL = null;

            richTextBox1.Text += "\n";

            REAL = URL;

            if (REAL[0] != 'h' || REAL[0] != 'H')
            {
                if (REAL[1] != 't')
                {
                    fixer = "http://" + URL;
                    REAL = fixer;
                }
            }

            if(REAL[8] != 'w' && REAL[9] != 'w')
            {
                fixer = "http://www." + URL;
                REAL = fixer;
            }

            URL = REAL;

            return URL;
        }

        public void DOWNLOAD(string URL)
        {
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                // Or you can get the file content without saving it:
                string SITE = client.DownloadString(URL);

                Parse(SITE, URL);
                //...
            }

            
        }

        public void Parse(string Site,string URL)
        {
            foreach (LinkItem i in Websites.Find(Site,URL))
            {
                richTextBox1.Text = richTextBox1.Text +  i.ToString();
            }
        }   //parses and prints hrefs

    }
}
