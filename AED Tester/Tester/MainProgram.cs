/*
=================================================================================	
  
               Vak:	AD


	Gemaakt door: 	Robbie Roeten, Henri Arends, Mirek Nalepa, Patrick Niewold
			        Joey Pieters


	    Docenten:	Jeroen Pijpker, Rob Smit

=================================================================================
 */

using MainDLL.QPC;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MainDLL;
using MainDLL.Collection;
using MainDLL.Hash;
using MainDLL.Search;
using MainDLL.Sort;

namespace Tester
{
    public partial class MainProgram : Form
    {

        //Random number array for further use during testing.
        int[] randomNumberArray = new int[100];
        public MainProgram()
        {
            InitializeComponent();
        }

        /// <summary>
        /// From here we start the QPC and make sure we have the right formatting
        /// </summary>
        /// <param name="act">The action(function) to preform in the QPC!</param>
        private void Action(Action act)
        {
            var actionMeasurement = new ActionMeasurement();
            var massiveMeasurement = new MassiveMeasurement();

            var result = actionMeasurement.MeasureMilliseconds(act);

            result = actionMeasurement.MeasureNanoseconds(act);
            WriteToConsole("MeasurenanoSeconds result: " + result + "..");

            result = massiveMeasurement.MeasureAverageMilliseconds(act, 1000);
            WriteToConsole("Average of 1000 tests in Milliseconds: " + result + "..");
        }
        /// <summary>
        /// Clear the console of all text inside
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
        }

        /// <summary>
        /// Priority Queue test
        /// </summary>
        public void PrioQue()
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
        }

        /// <summary>
        /// Priority queue button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPriorityQueue_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Priority Queue Test");
            WriteToConsole(@"===========================");

            Action(PrioQue);
        }

        /// <summary>
        /// BinarySearch test
        /// </summary>
        private void BinSearch()
        {
            var seq = Enumerable.Range(0, 1000);
            BinarySearch binsrch = new BinarySearch();
            binsrch.BinSearch(10, seq.ToArray());
            binsrch.BinSearch(43, seq.ToArray());
            binsrch.BinSearch(644, seq.ToArray());
            binsrch.BinSearch(999, seq.ToArray());
            binsrch.BinSearch(100, seq.ToArray());
            binsrch.BinSearch(1, seq.ToArray());

            binsrch.BinSearch(1001, seq.ToArray());
            binsrch.BinSearch(4300, seq.ToArray());
            binsrch.BinSearch(64400, seq.ToArray());
            binsrch.BinSearch(99900, seq.ToArray());
            binsrch.BinSearch(10000, seq.ToArray());
            binsrch.BinSearch(100000, seq.ToArray());
        }

        /// <summary>
        /// BinarySearch test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Binairy Search test");
            WriteToConsole(@"===========================");

            Action(BinSearch);
        }

        /// <summary>
        /// Sequential search action
        /// </summary>
        private void SeqSearch()
        {
            var seq = Enumerable.Range(0, 10);

            SequenTialSearch<int> search = new SequenTialSearch<int>();

            search.SeqSearch(seq.ToArray(), 5);
        }

        /// <summary>
        /// Sequential search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Sequential Search Test");
            WriteToConsole(@"===========================");

            Action(SeqSearch);
        }

        /// <summary>
        /// Stack test
        /// </summary>
        private void Stack()
        {
            MainDLL.Collection.Stack<int> stack = new MainDLL.Collection.Stack<int>();
            for (var i = 0; i <= 10; i++)
            {
                stack.push(i);
            }
            var count = stack.count;
            stack.peek();
        }

        /// <summary>
        /// Stack test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStack_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Stack Test");
            WriteToConsole(@"===========================");

            Action(Stack);
        }


        /// <summary>
        /// Binary Tree Search test
        /// </summary>
        private void BinTreeSearch()
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
            BinarySearchTree.Delete(45);

            // TEST POSTORDER / PREORDER / INORDER
            BinarySearchTree.PostOrder(BinarySearchTree.root);

            // FIND NODE
            //Console.Write(BinarySearchTree.FindNode(45).Data);
        }

        /// <summary>
        /// BinaryTreeTest button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinarySearchTree_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Binairy Search Tree Test");
            WriteToConsole(@"===========================");


            Action(BinTreeSearch);
        }

        /// <summary>
        /// Linear hash test
        /// </summary>
        private void LinearHash()
        {
            var test = new LinearHash<int>();
            test.Insert(2, 55637);
            test.Retrieve(2);
        }

        /// <summary>
        /// Linear hash button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLinearHash_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Linear Hash Test");
            WriteToConsole(@"===========================");

            Action(LinearHash);
        }

        /// <summary>
        /// MinMax test
        /// </summary>
        private void MinMax()
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

        /// <summary>
        /// MinMax button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinMax_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Min Max Test");
            WriteToConsole(@"===========================");

            Action(MinMax);
        }

        /// <summary>
        /// BubbleSort test
        /// </summary>
        private void BubbleSort()
        {
            BubbleSort<int> sort = new BubbleSort<int>();
            sort.Bubble(randomNumberArray);
        }

        /// <summary>
        /// BubbleSort test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"BubbleSort Test");
            WriteToConsole(@"===========================");

            Action(BubbleSort);
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            int Min = 0;
            int Max = 289;
            Random randNum = new Random();
            for (int i = 0; i < randomNumberArray.Length; i++)
            {
                randomNumberArray[i] = randNum.Next(Min, Max);
            }
        }

        /// <summary>
        /// InsertionSort test
        /// </summary>
        private void InsertionSort()
        {
            InsertionSort<int> sort = new InsertionSort<int>();
            sort.InsertSort(randomNumberArray);
        }

        /// <summary>
        /// InsertionSort Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"InsertionSort Test");
            WriteToConsole(@"===========================");

            Action(InsertionSort);
        }

        /// <summary>
        /// Smart Bubble Sort test
        /// </summary>
        private void SmartBubbleSort()
        {
            SmartBubbleSort<int> sbb = new SmartBubbleSort<int>();
            sbb.SmartBubble(randomNumberArray);
        }

        /// <summary>
        /// Smart Bubble Sort test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSmartBubbleSort_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Smart Bubblesort Test");
            WriteToConsole(@"===========================");

            Action(SmartBubbleSort);
        }

        /// <summary>
        /// Queue test
        /// </summary>
        private void Queue()
        {
            var test = new MainDLL.Collection.Queue<int>();
            test.EnQueue(0);
            test.EnQueue(0);
            test.EnQueue(42);
            test.EnQueue(42);
            test.EnQueue(2);
            test.EnQueue(2);
            test.EnQueue(0);
            test.EnQueue(4298);
            test.EnQueue(55);
            test.EnQueue(82);
            test.EnQueue(16);
        }

        /// <summary>
        /// Queue test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueue_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Queue Test");
            WriteToConsole(@"===========================");

            Action(Queue);
        }

        /// <summary>
        /// Bucket hash test
        /// </summary>
        private void BucketHash()
        {
            var table = new HashTable<int, int>(100);
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                table.Insert(i,randomNumberArray[i-1],i-1);
            }
        }

        /// <summary>
        /// Bucket hash test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBucketHash_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Bucket Hash Test");
            WriteToConsole(@"===========================");

            Action(BucketHash);
        }

        /// <summary>
        /// Quadratic hash test
        /// </summary>
        private void QuadraticHash()
        {
            var table = new HashTable<int, int>(100);
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                table.InsertQuadratic(i, randomNumberArray[i - 1]);
            }
        }
        /// <summary>
        /// Quadratic hash test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuadraticHash_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Quadratic Hash Test");
            WriteToConsole(@"===========================");

            Action(QuadraticHash);
        }

        /// <summary>
        /// Circular linked list test
        /// </summary>
        private void CircularLinkedList()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                cll.Add(randomNumberArray[i - 1]);
            }
        }

        /// <summary>
        /// Circular linked list test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCircularLinkedList_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Circular Linked List test");
            WriteToConsole(@"===========================");

            Action(CircularLinkedList);
        }

        /// <summary>
        /// Doubly linked test
        /// </summary>
        private void DoublyLinkedList()
        {
            DoublyLinkedList<int> cll = new DoublyLinkedList<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                cll.Add(randomNumberArray[i - 1]);
            }
        }

        /// <summary>
        /// Doubly linked List test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoublyLinkedList_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Doubly List Test");
            WriteToConsole(@"===========================");

            Action(DoublyLinkedList);
        }

        /// <summary>
        /// Linked list test
        /// </summary>
        private void LinkedList()
        {
            var cll = new LinkedList<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                cll.Add(randomNumberArray[i - 1]);
            }
        }

        /// <summary>
        /// Linked list test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLinkedList_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Linked List Test");
            WriteToConsole(@"===========================");

            Action(LinkedList);
        }

        /// <summary>
        /// Doubly node test
        /// </summary>
        private void DoublyNode()
        {
            Deck<int> deck = new Deck<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                deck.AddLast(randomNumberArray[i - 1]);
            }
        }
        /// <summary>
        /// Doubly Node test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoublyNode_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Doubly Node Test");
            WriteToConsole(@"===========================");

            Action(DoublyNode);
        }

        /// <summary>
        /// Writes output to the console tab, and adds a new line when a double dot is found
        /// </summary>
        /// <param name="text"></param>
        private void WriteToConsole(string text)
        {
            if (txtConsole.Text.Length > 0)
            {
                txtConsole.Text += "\r\n";
            }
            txtConsole.Text += text.Replace("..", "\r\n");
        }

        /// <summary>
        /// Iterator test
        /// </summary>
        private void Iterator()
        {
            MainDLL.Stack<int> stack = new MainDLL.Stack<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                stack.Push(randomNumberArray[i - 1]);
            }
        }

        /// <summary>
        /// Iterator test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIterator_Click(object sender, EventArgs e)
        {
            WriteToConsole(@"===========================");
            WriteToConsole(@"Iterator Test");
            WriteToConsole(@"===========================");

            Action(Iterator);
        }

        /// <summary>
        /// Test all, this button tests all the functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(@"This can freeze your computer. Are you sure?", @"Deathwish", MessageBoxButtons.YesNo);
            txtConsole.Text = "";
            MessageBox.Show(@"This could take a couple of minutes");
            if (dialogResult == DialogResult.Yes)
            {
                Thread.Sleep(1000);
                tabControl.SelectTab(1);
                WriteToConsole(@"===========================");
                WriteToConsole(@"BubbleSort Test");
                WriteToConsole(@"===========================");

                Action(BubbleSort);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Smart Bubblesort Test");
                WriteToConsole(@"===========================");

                Action(SmartBubbleSort);
                WriteToConsole(@"===========================");
                WriteToConsole(@"InsertionSort Test");
                WriteToConsole(@"===========================");

                Action(InsertionSort);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Queue Test");
                WriteToConsole(@"===========================");

                Action(Queue);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Priority Queue Test");
                WriteToConsole(@"===========================");

                Action(PrioQue);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Linked List Test");
                WriteToConsole(@"===========================");

                Action(LinkedList);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Doubly List Test");
                WriteToConsole(@"===========================");

                Action(DoublyLinkedList);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Circular Linked List test");
                WriteToConsole(@"===========================");

                Action(CircularLinkedList);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Sequential Search Test");
                WriteToConsole(@"===========================");

                Action(SeqSearch);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Binairy Search test");
                WriteToConsole(@"===========================");

                Action(BinSearch);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Binairy Search Tree Test");
                WriteToConsole(@"===========================");

                Action(BinTreeSearch);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Linear Hash Test");
                WriteToConsole(@"===========================");

                Action(LinearHash);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Bucket Hash Test");
                WriteToConsole(@"===========================");

                Action(BucketHash);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Quadratic Hash Test");
                WriteToConsole(@"===========================");

                Action(QuadraticHash);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Min Max Test");
                WriteToConsole(@"===========================");

                Action(MinMax);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Doubly Node Test");
                WriteToConsole(@"===========================");

                Action(DoublyNode);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Stack Test");
                WriteToConsole(@"===========================");

                Action(Stack);
                WriteToConsole(@"===========================");
                WriteToConsole(@"Iterator Test");
                WriteToConsole(@"===========================");

                Action(Iterator);

            }
        }
    }
}
