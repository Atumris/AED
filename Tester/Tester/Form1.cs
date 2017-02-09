using MainDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)5;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();


            QueryPerformance QPC = new QueryPerformance();
            Thread thread = new Thread(QPC.Start);
            thread.Priority = ThreadPriority.Highest;

            
            //QPC.Start();
            ////Thread.BeginThreadAffinity();
            thread.Start();
            Console.WriteLine("Hello World!");
            QPC.Stop();
            ////Thread.EndThreadAffinity();
            Console.WriteLine(QPC.Duration(1).ToString() + " s");
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
    }
}
