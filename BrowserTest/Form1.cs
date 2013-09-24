/////////////////////////////////////////////////////////////
////                                                     ////
//// Zecram Web Browser                                  ////
//// v1.0                                                ////
//// Programado por:                                     ////
//// *Harold Rodrigues Silva.                            ////
////                                                     ////
/////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
namespace BrowserTest
{
    public partial class Zecram : Form
    {
        public int CONT=2,i,r=0;
        public string[] A = new string[500];
        public byte countnavigation=0;
        string connectionx = "@Data Source=E:\\IFSP\\PJS\\BrowserTest\\BrowserTest\\MyDatabase#1.sdf";
        public Zecram()
        {
            InitializeComponent();
            sitelabel.Text = "Initialized";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(maskedTextBox1.Text);
            timer.Start();
        }
        private void pressX(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Application.Exit();
            }
                if (e.KeyChar == 13)
                {
                    button3.PerformClick();
                }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }
        private void Zecram_Load(object sender, EventArgs e)
        {
            if (CONT <= 2)
            {
                refreshbutton.PerformClick();
            }
            CONT++;
        }
        private void sairESCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sairESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aka = new AboutBox();
            aka.Show();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            i += 1;
            maskedTextBox1.Text = webBrowser1.Url.ToString();
            A[i] = webBrowser1.Url.ToString();
            r++;
            countnavigation+=1;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (webBrowser1.AllowNavigation)
                {
                    progressbar.Value = progressbar.Value + 5;
                }
                else
                {
                    progressbar.Value = 0;
                }
            }
            catch (Exception)
            {
                timer.Stop();
                progressbar.Value = 0;
            }
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void nextbutton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void Xprocess(object sender, WebBrowserNavigatingEventArgs e)
        {
            try
            {
                if (webBrowser1.AllowNavigation)
                {
                    progressbar.Value = progressbar.Value + 5;
                }
                else
                {
                    progressbar.Value = 0;
                }
            }
            catch (Exception)
            {
                timer.Stop();
                progressbar.Value = 0;
            }
            finally
            {
                progressbar.Value = 0;
            }
        }
        private void refreshbutton_Click(object sender, EventArgs e)
        {
            timer.Start();
            maskedTextBox1.Text = "https://www.google.com.br/";
            webBrowser1.Navigate("https://www.google.com.br/");
        }
    }
}