using MainDLL;
using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MainDLL.H04;
using MainDLL.H02;
namespace Tester
{
    public partial class Form1 : Form
    {
        static readonly object _object = new object();

        public Form1()
        {
            InitializeComponent();

            
            ArrayList<int> arr = new ArrayList<int>();

            //affinity testen
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)2;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;

            arr.Add(8);
            arr.Add(5);
            arr.Add(9);
            arr.Add(20);
            arr.Add(55);
            arr.Add(30919785);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            //arr = {8, 5, 9, 20, 55, 30919785, 1, 2, 3};
            MinMax<int> minMax = new MinMax<int>();

            //test minmax functions
            Console.WriteLine(minMax.Max(arr.ToArray()));
            Console.WriteLine(minMax.Min(arr.ToArray()));

            int[] findMinMax = minMax.FindMinMax(arr.ToArray());
            Console.WriteLine(findMinMax[0] + " " + findMinMax[1]);
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
