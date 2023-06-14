using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_sandbox
{
    public partial class Form2 : Form
    {
        private BackgroundWorker worker;
        public Form2()
        {
            InitializeComponent();
            worker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true,
            };
            #pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            worker.ProgressChanged += worker_ProgressChanged;
            worker.DoWork += worker_DoBlockingTask;
            worker.RunWorkerCompleted += worker_WorkerIsFinished;
            #pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Trace.WriteLine($"HERE. Progress: {e.ProgressPercentage}");
            progressBar1.Value = e.ProgressPercentage;
        }
        private void worker_DoBlockingTask(object sender, DoWorkEventArgs e)
        {
            BlockingTask(1000);
            worker.ReportProgress(50);
        }
        private void worker_WorkerIsFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BlockingTask(1000);
        }
        private static void BlockingTask(int numberOfTimes)
        {
            for (int times = 0; times < numberOfTimes; times++)
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        int k = i * i;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            //for (int i = 0; i < 100; i++)
            //{
            //    progressBar1.Value = i + 1;
            //}
            // Run task async in background worker
            worker.RunWorkerAsync();
        }
    }
}
