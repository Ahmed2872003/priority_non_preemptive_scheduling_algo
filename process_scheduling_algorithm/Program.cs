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
            //List<Process> ps = new List<Process>() {
            //        new Process(0, 10, 3),
            //        new Process(0, 1, 1),
            //        new Process(0, 2, 4),
            //        new Process(0, 1, 5),
            //        new Process(0, 5, 2),
            //};

            //Scheduling_Algo.Result res = Scheduling_Algo.Priority(ref ps, Scheduling_Algo.Type.NonPreemptive);


            //foreach (Process p in ps)
            //{
            //    Console.WriteLine(p.ToString());
            //}

            //Console.WriteLine(res.ToString());









            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }

}
