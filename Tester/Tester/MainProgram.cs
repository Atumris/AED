using MainDLL.QPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

        private void action(Action act)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("[Testing ActionMeasurement]");

            var actionMeasurement = new ActionMeasurement();
            var massiveMeasurement = new MassiveMeasurement();

            Console.WriteLine();
            Console.WriteLine(">>All tests are done on the RandomIteration method<<");
            var result = actionMeasurement.MeasureMilliseconds(act);
            System.Console.WriteLine("MeasureMilliseconds result: " + result);

            result = actionMeasurement.MeasureNanoseconds(act);
            System.Console.WriteLine("MeasurenanoSeconds result: " + result);

            result = massiveMeasurement.MeasureAverageMilliseconds(act, 1000);
            System.Console.WriteLine("Average of 1000 tests in Milliseconds: " + result);
            Console.WriteLine("---------------------------------------------------");
        }
        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
        }
    }
}
