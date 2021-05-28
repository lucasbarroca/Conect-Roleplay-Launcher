using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Conect_Roleplay_Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMain());

            App myApp = new App();
            myApp.Run(args);
        }
    }

    public class App : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public App()
        {
            // Make this a single-instance application
            this.IsSingleInstance = true;
            this.EnableVisualStyles = true;
        }

        protected override void OnCreateMainForm()
        {
            // Create an instance of the main form 
            // and set it in the application; 
            // but don't try to run() it.
            this.MainForm = new FrmMain();
        }
    }
}
