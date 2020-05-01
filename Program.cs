using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleInstaller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MessageBox.Show("Main");


            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = @"C:\Program Files (x86)\Skan CPX Virtual Assistant";
            proc.FileName = "SkanWatchDog.exe";
            proc.Verb = "runas";
            Process.Start(proc);

            //Process p = new Process();
            //p.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Skan CPX Virtual Assistant";
            ////p.StartInfo.WorkingDirectory = @"E:\Temp";


            //p.StartInfo.UseShellExecute = true;
            //p.StartInfo.RedirectStandardOutput = false;
            //p.StartInfo.FileName = "SkanWatchDog.exe";
            //p.Start();
            MessageBox.Show("Starting");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
