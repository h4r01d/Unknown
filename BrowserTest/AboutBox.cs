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
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace BrowserTest
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.labelProductName.Text = "Zecram Web Browser";
            this.labelVersion.Text = "v1.0";
            this.labelCopyright.Text = "Copyright © eXtremeTec - All Rights Reserved";
            this.labelCompanyName.Text = "eXtremeTec";
            this.textBoxDescription.Text = "";
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void aboutpress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Visible = false;
            }
        }
    }
}
