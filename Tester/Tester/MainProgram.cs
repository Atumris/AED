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
using MainDLL;
using MainDLL.Collection;
using MainDLL.Hash;
using MainDLL.Search;
using MainDLL.Sort;

namespace Tester
{
    public partial class MainProgram : Form
    {

        int[] randomNumberArray = new int[100];
        public MainProgram()
        {
            InitializeComponent();
        }

        private void action(Action act)
        {
            var actionMeasurement = new ActionMeasurement();
            var massiveMeasurement = new MassiveMeasurement();

            var result = actionMeasurement.MeasureMilliseconds(act);

            result = actionMeasurement.MeasureNanoseconds(act);
            System.Console.WriteLine("MeasurenanoSeconds result: " + result);

            result = massiveMeasurement.MeasureAverageMilliseconds(act, 1000);
            System.Console.WriteLine("Average of 1000 tests in Milliseconds: " + result);
        }
        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
        }

        public void prioQue()
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

        private void btnPriorityQueue_Click(object sender, EventArgs e)
        {
            action(prioQue);
        }

        private void binSearch()
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

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            action(binSearch);
        }

        private void seqSearch()
        {
            var seq = Enumerable.Range(0, 10);

            SequenTialSearch<int> search = new SequenTialSearch<int>();

            search.SeqSearch(seq.ToArray(), 5);
        }

        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            action(seqSearch);
        }

        private void stack()
        {
            MainDLL.Collection.Stack<int> stack = new MainDLL.Collection.Stack<int>();
            for (var i = 0; i <= 10; i++)
            {
                stack.push(i);
            }
            var count = stack.count;
            stack.peek();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            action(stack);
        }

        private void binTreeSearch()
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

        private void btnBinarySearchTree_Click(object sender, EventArgs e)
        {
            action(binTreeSearch);
        }

        private void linearHash()
        {
            var test = new LinearHash<int>();
            test.Insert(2, 55637);
            test.Retrieve(2);
        }

        private void btnLinearHash_Click(object sender, EventArgs e)
        {
            action(linearHash);
        }

        private void minMax()
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

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            action(minMax);
        }

        private void bubbleSort()
        {
            BubbleSort<int> sort = new BubbleSort<int>();
            sort.Bubble(randomNumberArray);
        }
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            action(bubbleSort);
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

        private void insertionSort()
        {
            InsertionSort<int> sort = new InsertionSort<int>();
            sort.InsertSort(randomNumberArray);
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            action(insertionSort);
        }

        private void smartBubbleSort()
        {
            SmartBubbleSort<int> sbb = new SmartBubbleSort<int>();
            sbb.SmartBubble(randomNumberArray);
        }

        private void btnSmartBubbleSort_Click(object sender, EventArgs e)
        {
            action(smartBubbleSort);
        }

        private void queue()
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
        private void btnQueue_Click(object sender, EventArgs e)
        {
            action(queue);
        }

        private void bucketHash()
        {
            var table = new HashTable<int, int>(100);
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                table.Insert(i,randomNumberArray[i-1],i-1);
            }
        }


        private void btnBucketHash_Click(object sender, EventArgs e)
        {
            action(bucketHash);
        }

        private void QuadraticHash()
        {
            var table = new HashTable<int, int>(100);
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                table.InsertQuadratic(i, randomNumberArray[i - 1]);
            }
        }
        private void btnQuadraticHash_Click(object sender, EventArgs e)
        {
            
        }

        private void circularLinkedList()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                cll.Add(randomNumberArray[i - 1]);
            }
        }
        private void btnCircularLinkedList_Click(object sender, EventArgs e)
        {
            action(circularLinkedList);
        }
        private void doublyLinkedList()
        {
            DoublyLinkedList<int> cll = new DoublyLinkedList<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                cll.Add(randomNumberArray[i - 1]);
            }
        }
        private void btnDoublyLinkedList_Click(object sender, EventArgs e)
        {
            action(doublyLinkedList);
        }

        private void linkedList()
        {
            MainDLL.Collection.LinkedList<int> cll = new MainDLL.Collection.LinkedList<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                cll.Add(randomNumberArray[i - 1]);
            }
        }
        private void btnLinkedList_Click(object sender, EventArgs e)
        {
            action(linkedList);
        }


        private void doublyNode()
        {
            Deck<int> deck = new Deck<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                deck.AddLast(randomNumberArray[i - 1]);
            }
        }
        private void btnDoublyNode_Click(object sender, EventArgs e)
        {
            action(doublyNode);
        }

        /// <summary>
        /// Writes output to the console tab, and adds a new line when a double dot is found
        /// </summary>
        /// <param name="text"></param>
        public void WriteToConsole(string text)
        {
            if (txtConsole.Text.Length > 0)
            {
                txtConsole.Text += "\r\n";
            }
            txtConsole.Text += text.Replace("..", "\r\n");
        }

        private void iterator()
        {
            MainDLL.Stack<int> stack = new MainDLL.Stack<int>();
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                stack.Push(randomNumberArray[i - 1]);
            }
        }

        private void btnIterator_Click(object sender, EventArgs e)
        {
            action(iterator);
        }
    }
}
