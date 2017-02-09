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

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GC.Collect();
            GC.WaitForFullGCComplete();

            System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)2;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// Make sure there is an instance of notepad running.
            //Process[] notepads = Process.GetProcessesByName("notepad");
            //if (notepads.Length == 0)
            //    Process.Start("notepad");
            //ProcessThreadCollection threads;
            ////Process[] notepads;
            //// Retrieve the Notepad processes. 
            //notepads = Process.GetProcessesByName("Notepad");
            //// Get the ProcessThread collection for the first instance
            //threads = notepads[0].Threads;
            //// Set the properties on the first ProcessThread in the collection
            //threads[0].IdealProcessor = 0;
            //threads[0].ProcessorAffinity = (IntPtr)1;

        }
    }
}
