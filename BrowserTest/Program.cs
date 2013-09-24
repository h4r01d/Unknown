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
using System.Linq;
using System.Windows.Forms;

namespace BrowserTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zecram());
        }
        /*public void functionx()
        {
            string connection = "@Data Source=E:\\IFSP\\PJS\\BrowserTest\\BrowserTest\\MyDatabase#1.sdf";
        }*/
    }
}
