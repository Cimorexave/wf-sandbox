using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoBlockingTask;
            worker.RunWorkerCompleted += worker_WorkerIsFinished;
        }

        private void worker_DoBlockingTask(object sender, DoWorkEventArgs e)
        {
            BlockingTask(1000);
        }
        private void worker_WorkerIsFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = true;
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
            // Start the progress bar
            progressBar1.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                progressBar1.PerformStep();
                progressBar1.Update();
            }
            // Run task async in background worker
            worker.RunWorkerAsync();
        }
    }
}
