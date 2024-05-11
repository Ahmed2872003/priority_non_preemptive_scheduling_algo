using System;
using System.Windows.Forms;

namespace process_scheduling_algorithm
{


    internal static class Program
    {

        // <summary>
        // The main entry point for the application.
        // </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }

}
