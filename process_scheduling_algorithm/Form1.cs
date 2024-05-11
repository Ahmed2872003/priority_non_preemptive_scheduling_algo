using process_scheduling_algorithm.Models;
using process_scheduling_algorithm.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace process_scheduling_algorithm
{
    public partial class Form1 : Form
    {
        private List<Process> processes = null;
        private int i = 1;
        private int numOfProcesses;
        public Form1()
        {
            InitializeComponent();
        }


        private void startBtn_Click(object sender, System.EventArgs e)
        {
            if (NOPTB.Text == "") showErrMessage("Please enter a positive integer");

            else if (!int.TryParse(NOPTB.Text, out numOfProcesses) || numOfProcesses <= 0) showErrMessage("Number of processes must be a positive integer.");
            else
            {
                panel1.Enabled = false;

                panel2.Enabled = true;

                ShowDetailsBtn.Visible = false;

                processes = new List<Process>(numOfProcesses);

                i = 1;

                processCounterLabel.Text = "Process (" + 1 + ") Data";

            }

        }

        private void showErrMessage(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            Reset_Panel2_TB();

            panel2.Enabled = false;

            panel1.Enabled = true;

            processCounterLabel.Text = "Process Data";

            processes = null;

            i = 1;
        }

        private void Reset_Panel2_TB()
        {
            ATTB.Text = BTTB.Text = PTB.Text = "";
        }


        private void createBtn_Click(object sender, System.EventArgs e)
        {
            int AT, BT, P;

            if (!int.TryParse(ATTB.Text, out AT) || AT < 0) showErrMessage("Arrival time must be a positive Integer");
            else if (!int.TryParse(BTTB.Text, out BT) || BT < 0) showErrMessage("Burst time must be a positive Integer");
            else if (!int.TryParse(PTB.Text, out P) || P < 0) showErrMessage("Priority must be a positive Integer");
            else
            {
                if (i <= numOfProcesses)
                {
                    Console.WriteLine("Created");
                    Process p = new Process(AT, BT, P);

                    processes.Add(p);

                    Reset_Panel2_TB();

                    ++i;

                    if (i <= numOfProcesses)
                        processCounterLabel.Text = "Process (" + i + ") Data";
                    else
                    {
                        panel1.Enabled = true;

                        panel2.Enabled = false;

                        Reset_Panel2_TB();

                        ShowDetailsBtn.Visible = true;



                    }

                }

            }
        }

        private void ShowDetailsBtn_Click(object sender, EventArgs e)
        {
            Scheduling_Algo.Result res = Scheduling_Algo.Priority(ref processes, Scheduling_Algo.Type.NonPreemptive);


            string HTMLPage = GanttChart.Generete(processes, res);

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set properties for the dialog
            saveFileDialog.Title = "Save HTML File";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "HTML Files (*.html)|*.html";
            saveFileDialog.FileName = "Gantt chart-" + Guid.NewGuid().ToString() + ".html";

            DialogResult result = saveFileDialog.ShowDialog();

            // Check if the user clicked the OK button
            if (result == DialogResult.OK)
            {
                string saveFilePath = saveFileDialog.FileName;


                File.WriteAllText(saveFilePath, HTMLPage);

                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }
    }
}
