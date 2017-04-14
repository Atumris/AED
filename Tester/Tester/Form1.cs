using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using MainDLL;
using MainDLL.Collection;
using MainDLL.Sort;
using MainDLL.Search;
using MainDLL.Hash;
using System.Linq;
using MainDLL.QPC;

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
            // seq

            //test minmax functions
            MinMax<int> minMax = new MinMax<int>();

            Console.WriteLine(minMax.Max(arr.ToArray()));
            Console.WriteLine(minMax.Min(arr.ToArray()));


            int[] findMinMax = minMax.FindMinMax(arr.ToArray());
            Console.WriteLine(findMinMax[0] + " " + findMinMax[1]);


            //test bubblesort
            BubbleSort<int> bubble = new BubbleSort<int>();
            Console.WriteLine(@"Without bubblesort");
            foreach (var ar in arr.ToArray())
            {
                Console.WriteLine(ar);
            }

            Console.WriteLine(@"With bubblesort");
            int[] bubblearr = bubble.Bubble(arr.ToArray());

            foreach (var ar in bubblearr)
            {
                Console.WriteLine(ar);
            }

            //Queue test
            Console.WriteLine(@"==========================");
            Console.WriteLine(@"Queue Test");
            Console.WriteLine(@"==========================");
            Console.WriteLine();

            Queue<String> que = new Queue<String>();

            que.EnQueue("If it work correct the next test will say: I am blue");
            que.EnQueue("I am blue");

            Console.WriteLine(@"==========================");
            Console.WriteLine(@"Test Peek and Dequeue");
            Console.WriteLine(@"==========================");
            Console.WriteLine(que.Peek());
            Console.WriteLine();
            que.DeQueue();

            Console.WriteLine(@"==========================");
            Console.WriteLine(@"Test Peek 2");
            Console.WriteLine(@"==========================");
            Console.WriteLine(que.Peek());
            Console.WriteLine();

            Console.WriteLine(@"==========================");
            Console.WriteLine(@"Test Clear Queue");
            Console.WriteLine(@"==========================");
            que.ClearQueue();
            if (que.Length() == 0)
            {
                Console.WriteLine(@"Que is cleared");
            }
            else
            {
                Console.WriteLine(@"Clear failed");
            }
        }
        /**
         * Test voor de timer
         */
        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();


            HiPerfCounter QPC = new HiPerfCounter();


            lock (_object)
            {
                Thread thread = new Thread(QPC.Start);
                thread.Priority = ThreadPriority.Highest;
                Console.WriteLine("Hello World!");
                QPC.Stop();
                MessageBox.Show(QPC.Duration.ToString());
                Console.WriteLine(QPC.Duration + " ms");
            }
        }
        HiPerfCounter QPC = new HiPerfCounter();

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();



            Thread thread = new Thread(QPC.Start);
            thread.Priority = ThreadPriority.Highest;


            //QPC.Start();
            ////Thread.BeginThreadAffinity();
            thread.Start();
            Console.WriteLine("Hello World!");
            QPC.Stop();
            ////Thread.EndThreadAffinity();
            Console.WriteLine(QPC.Duration + " ms");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList<int> arr = new ArrayList<int>();
            for (int i = 0; i < 1000; i++)
            {
                arr.Add(i);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            QPC.Start();
            for (int i = 0; i < arr.Length(); i++)
            {
                arr.RemoveAt(i);
            }
            QPC.Start();
            MessageBox.Show(QPC.Duration.ToString());
        }

        //Priority queue test
        private void button4_Click(object sender, EventArgs e)
        {
            var test = new PriorityQueue<int>();
            test.EnQueue(0, 1);
            test.EnQueue(0, 1);
            test.EnQueue(42, 1);
            test.EnQueue(42, 1);
            test.EnQueue(2, 1);
            test.EnQueue(2, 1);
            test.EnQueue(0, 1);
            test.EnQueue(4298, 1);
            test.EnQueue(55, 1);
            test.EnQueue(82, 1);
            test.EnQueue(16, 1);


            Console.WriteLine(@"===========================");
            Console.WriteLine(@"Priority Queue Test");
            Console.WriteLine(@"Items: " + test.Length());
            Console.WriteLine(@"===========================");

            foreach (var bla in test.ToArray())
            {
                Console.WriteLine(bla.Priority);
            }
        }

        private void seqSearch_btn_Click(object sender, EventArgs e)
        {
            var seq = Enumerable.Range(0, 10);

            SequenTialSearch<int> search = new SequenTialSearch<int>();

            Console.WriteLine(search.SeqSearch(seq.ToArray(), 5));
        }

        private void btn_binSearch_Click(object sender, EventArgs e)
        {
            var seq = Enumerable.Range(0, 1000);
            BinarySearch binsrch = new BinarySearch();
            Console.WriteLine(binsrch.BinSearch(10, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(43, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(644, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(999, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(100, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(1, seq.ToArray()));

            Console.WriteLine(binsrch.BinSearch(1001, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(4300, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(64400, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(99900, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(10000, seq.ToArray()));
            Console.WriteLine(binsrch.BinSearch(100000, seq.ToArray()));
        }

        private void Stacktest_btn_Click(object sender, EventArgs e)
        {
            MainDLL.Collection.Stack<int> stack = new MainDLL.Collection.Stack<int>();
            for(var i = 0; i <= 10; i++)
            {
                stack.push(i);
            }
        }

        private void BtnLinearHash_Click(object sender, EventArgs e)
        {
            var test = new LinearHash<int>();
            test.Insert(2, 55637);
            Console.WriteLine(test.Retrieve(2));

        }

        private void BinarySearchTreeBtn_Click(object sender, EventArgs e)
        {

            BinarySearchTree<int> BinarySearchTree = new BinarySearchTree<int>();
            // TEST ADDING ELEMENTS
            BinarySearchTree.Add(50);
            BinarySearchTree.Add(40);
            BinarySearchTree.Add(60);
            BinarySearchTree.Add(20);
            BinarySearchTree.Add(45);
            BinarySearchTree.Add(55);
            BinarySearchTree.Add(65);

            //Console.Write(BinarySearchTree.Find(20).Data);

            // TEST DELETE
            Console.Write(BinarySearchTree.Delete(45));

            // TEST POSTORDER / PREORDER / INORDER
            BinarySearchTree.PostOrder(BinarySearchTree.root);

            // FIND NODE
            //Console.Write(BinarySearchTree.FindNode(45).Data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("[Testing ActionMeasurement]");

            var actionMeasurement = new ActionMeasurement();
            var massiveMeasurement = new MassiveMeasurement();

            Console.WriteLine();
            Console.WriteLine(">>All tests are done on the RandomIteration method<<");
            var result = actionMeasurement.MeasureMilliseconds(minmax);
            System.Console.WriteLine("MeasureMilliseconds result: " + result);

            result = actionMeasurement.MeasureNanoseconds(minmax);
            System.Console.WriteLine("MeasurenanoSeconds result: " + result);

            result = massiveMeasurement.MeasureAverageMilliseconds(minmax, 1000);
            System.Console.WriteLine("Average of 1000 tests in Milliseconds: " + result);
            Console.WriteLine("---------------------------------------------------");


        }

        private void minmax()
        {
            ArrayList<int> arr = new ArrayList<int>();
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
            // seq

            //test minmax functions

            MinMax<int> minMax = new MinMax<int>();

            //Console.WriteLine(minMax.Max(arr.ToArray()));
            //Console.WriteLine(minMax.Min(arr.ToArray()));


            int[] findMinMax = minMax.FindMinMax(arr.ToArray());
            var asdf = findMinMax[0] + " " + findMinMax[1];
        }
    }
}
