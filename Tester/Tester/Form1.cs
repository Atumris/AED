using MainDLL;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MainDLL.H04;
namespace Tester
{
    public partial class Form1 : Form
    {
        static readonly object _object = new object();

        public Form1()
        {
            InitializeComponent();

            //affinity testen
            System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)2;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;


            int[] arr = {0, 1, 2, 3, 4, 5};
            CheckMax  
        }
        /**
         * Test voor de timer
         */
        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();


            QueryPerformance QPC = new QueryPerformance();
            

            lock (_object)
            {
                Thread thread = new Thread(QPC.Start);
                thread.Priority = ThreadPriority.Highest;
                Console.WriteLine("Hello World!");
                QPC.Stop();
                Console.WriteLine(QPC.Duration(1) + " ms");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            Console.WriteLine(QPC.Duration(1) + " ms");
        }
    }
}
