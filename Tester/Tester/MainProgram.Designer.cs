namespace Tester
{
    partial class MainProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFunctions = new System.Windows.Forms.TabPage();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.btnSequentialSearch = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.btnBinarySearchTree = new System.Windows.Forms.Button();
            this.groupQueue = new System.Windows.Forms.GroupBox();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnPriorityQueue = new System.Windows.Forms.Button();
            this.groupHash = new System.Windows.Forms.GroupBox();
            this.btnLinearHash = new System.Windows.Forms.Button();
            this.btnBucketHash = new System.Windows.Forms.Button();
            this.btnQuadraticHash = new System.Windows.Forms.Button();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.btnCircularLinkedList = new System.Windows.Forms.Button();
            this.btnDoublyLinkedList = new System.Windows.Forms.Button();
            this.btnLinkedList = new System.Windows.Forms.Button();
            this.groupSort = new System.Windows.Forms.GroupBox();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnSmartBubbleSort = new System.Windows.Forms.Button();
            this.groupEtc = new System.Windows.Forms.GroupBox();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnDoublyNode = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnIterator = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnTestAll = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabFunctions.SuspendLayout();
            this.groupSearch.SuspendLayout();
            this.groupQueue.SuspendLayout();
            this.groupHash.SuspendLayout();
            this.groupList.SuspendLayout();
            this.groupSort.SuspendLayout();
            this.groupEtc.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabFunctions);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(908, 594);
            this.tabControl.TabIndex = 0;
            // 
            // tabFunctions
            // 
            this.tabFunctions.Controls.Add(this.btnTestAll);
            this.tabFunctions.Controls.Add(this.groupSearch);
            this.tabFunctions.Controls.Add(this.groupQueue);
            this.tabFunctions.Controls.Add(this.groupHash);
            this.tabFunctions.Controls.Add(this.groupList);
            this.tabFunctions.Controls.Add(this.groupSort);
            this.tabFunctions.Controls.Add(this.groupEtc);
            this.tabFunctions.Location = new System.Drawing.Point(4, 22);
            this.tabFunctions.Name = "tabFunctions";
            this.tabFunctions.Padding = new System.Windows.Forms.Padding(3);
            this.tabFunctions.Size = new System.Drawing.Size(900, 568);
            this.tabFunctions.TabIndex = 0;
            this.tabFunctions.Text = "Functions";
            this.tabFunctions.UseVisualStyleBackColor = true;
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.btnSequentialSearch);
            this.groupSearch.Controls.Add(this.btnBinarySearch);
            this.groupSearch.Controls.Add(this.btnBinarySearchTree);
            this.groupSearch.Location = new System.Drawing.Point(212, 126);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(254, 113);
            this.groupSearch.TabIndex = 22;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search";
            // 
            // btnSequentialSearch
            // 
            this.btnSequentialSearch.Location = new System.Drawing.Point(7, 19);
            this.btnSequentialSearch.Name = "btnSequentialSearch";
            this.btnSequentialSearch.Size = new System.Drawing.Size(109, 23);
            this.btnSequentialSearch.TabIndex = 5;
            this.btnSequentialSearch.Text = "Sequential Search";
            this.btnSequentialSearch.UseVisualStyleBackColor = true;
            this.btnSequentialSearch.Click += new System.EventHandler(this.btnSequentialSearch_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(6, 47);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(109, 23);
            this.btnBinarySearch.TabIndex = 3;
            this.btnBinarySearch.Text = "Binary Search";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // btnBinarySearchTree
            // 
            this.btnBinarySearchTree.Location = new System.Drawing.Point(7, 76);
            this.btnBinarySearchTree.Name = "btnBinarySearchTree";
            this.btnBinarySearchTree.Size = new System.Drawing.Size(109, 23);
            this.btnBinarySearchTree.TabIndex = 17;
            this.btnBinarySearchTree.Text = "BinarySearch Tree";
            this.btnBinarySearchTree.UseVisualStyleBackColor = true;
            this.btnBinarySearchTree.Click += new System.EventHandler(this.btnBinarySearchTree_Click);
            // 
            // groupQueue
            // 
            this.groupQueue.Controls.Add(this.btnQueue);
            this.groupQueue.Controls.Add(this.btnPriorityQueue);
            this.groupQueue.Location = new System.Drawing.Point(213, 6);
            this.groupQueue.Name = "groupQueue";
            this.groupQueue.Size = new System.Drawing.Size(253, 113);
            this.groupQueue.TabIndex = 21;
            this.groupQueue.TabStop = false;
            this.groupQueue.Text = "Queue";
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(6, 19);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(109, 23);
            this.btnQueue.TabIndex = 6;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnPriorityQueue
            // 
            this.btnPriorityQueue.Location = new System.Drawing.Point(6, 45);
            this.btnPriorityQueue.Name = "btnPriorityQueue";
            this.btnPriorityQueue.Size = new System.Drawing.Size(109, 23);
            this.btnPriorityQueue.TabIndex = 7;
            this.btnPriorityQueue.Text = "Priority Queue";
            this.btnPriorityQueue.UseVisualStyleBackColor = true;
            this.btnPriorityQueue.Click += new System.EventHandler(this.btnPriorityQueue_Click);
            // 
            // groupHash
            // 
            this.groupHash.Controls.Add(this.btnLinearHash);
            this.groupHash.Controls.Add(this.btnBucketHash);
            this.groupHash.Controls.Add(this.btnQuadraticHash);
            this.groupHash.Location = new System.Drawing.Point(6, 245);
            this.groupHash.Name = "groupHash";
            this.groupHash.Size = new System.Drawing.Size(200, 111);
            this.groupHash.TabIndex = 20;
            this.groupHash.TabStop = false;
            this.groupHash.Text = "Hash";
            // 
            // btnLinearHash
            // 
            this.btnLinearHash.Location = new System.Drawing.Point(6, 19);
            this.btnLinearHash.Name = "btnLinearHash";
            this.btnLinearHash.Size = new System.Drawing.Size(109, 23);
            this.btnLinearHash.TabIndex = 10;
            this.btnLinearHash.Text = "Linear Hash";
            this.btnLinearHash.UseVisualStyleBackColor = true;
            this.btnLinearHash.Click += new System.EventHandler(this.btnLinearHash_Click);
            // 
            // btnBucketHash
            // 
            this.btnBucketHash.Location = new System.Drawing.Point(6, 48);
            this.btnBucketHash.Name = "btnBucketHash";
            this.btnBucketHash.Size = new System.Drawing.Size(109, 23);
            this.btnBucketHash.TabIndex = 9;
            this.btnBucketHash.Text = "Bucket Hash";
            this.btnBucketHash.UseVisualStyleBackColor = true;
            this.btnBucketHash.Click += new System.EventHandler(this.btnBucketHash_Click);
            // 
            // btnQuadraticHash
            // 
            this.btnQuadraticHash.Location = new System.Drawing.Point(6, 77);
            this.btnQuadraticHash.Name = "btnQuadraticHash";
            this.btnQuadraticHash.Size = new System.Drawing.Size(109, 23);
            this.btnQuadraticHash.TabIndex = 11;
            this.btnQuadraticHash.Text = "Quadratic Hash";
            this.btnQuadraticHash.UseVisualStyleBackColor = true;
            this.btnQuadraticHash.Click += new System.EventHandler(this.btnQuadraticHash_Click);
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.btnCircularLinkedList);
            this.groupList.Controls.Add(this.btnDoublyLinkedList);
            this.groupList.Controls.Add(this.btnLinkedList);
            this.groupList.Location = new System.Drawing.Point(6, 125);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(200, 114);
            this.groupList.TabIndex = 19;
            this.groupList.TabStop = false;
            this.groupList.Text = "List";
            // 
            // btnCircularLinkedList
            // 
            this.btnCircularLinkedList.Location = new System.Drawing.Point(6, 77);
            this.btnCircularLinkedList.Name = "btnCircularLinkedList";
            this.btnCircularLinkedList.Size = new System.Drawing.Size(109, 23);
            this.btnCircularLinkedList.TabIndex = 12;
            this.btnCircularLinkedList.Text = "Circular Linked List";
            this.btnCircularLinkedList.UseVisualStyleBackColor = true;
            this.btnCircularLinkedList.Click += new System.EventHandler(this.btnCircularLinkedList_Click);
            // 
            // btnDoublyLinkedList
            // 
            this.btnDoublyLinkedList.Location = new System.Drawing.Point(6, 49);
            this.btnDoublyLinkedList.Name = "btnDoublyLinkedList";
            this.btnDoublyLinkedList.Size = new System.Drawing.Size(109, 23);
            this.btnDoublyLinkedList.TabIndex = 13;
            this.btnDoublyLinkedList.Text = "Doubly Linked List";
            this.btnDoublyLinkedList.UseVisualStyleBackColor = true;
            this.btnDoublyLinkedList.Click += new System.EventHandler(this.btnDoublyLinkedList_Click);
            // 
            // btnLinkedList
            // 
            this.btnLinkedList.Location = new System.Drawing.Point(6, 20);
            this.btnLinkedList.Name = "btnLinkedList";
            this.btnLinkedList.Size = new System.Drawing.Size(109, 23);
            this.btnLinkedList.TabIndex = 16;
            this.btnLinkedList.Text = "LinkedList";
            this.btnLinkedList.UseVisualStyleBackColor = true;
            this.btnLinkedList.Click += new System.EventHandler(this.btnLinkedList_Click);
            // 
            // groupSort
            // 
            this.groupSort.Controls.Add(this.btnBubbleSort);
            this.groupSort.Controls.Add(this.btnInsertionSort);
            this.groupSort.Controls.Add(this.btnSmartBubbleSort);
            this.groupSort.Location = new System.Drawing.Point(6, 6);
            this.groupSort.Name = "groupSort";
            this.groupSort.Size = new System.Drawing.Size(200, 113);
            this.groupSort.TabIndex = 18;
            this.groupSort.TabStop = false;
            this.groupSort.Text = "Sort";
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(6, 19);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(109, 23);
            this.btnBubbleSort.TabIndex = 0;
            this.btnBubbleSort.Text = "BubbleSort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(6, 71);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(109, 23);
            this.btnInsertionSort.TabIndex = 1;
            this.btnInsertionSort.Text = "InsertionSort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnSmartBubbleSort
            // 
            this.btnSmartBubbleSort.Location = new System.Drawing.Point(6, 45);
            this.btnSmartBubbleSort.Name = "btnSmartBubbleSort";
            this.btnSmartBubbleSort.Size = new System.Drawing.Size(109, 23);
            this.btnSmartBubbleSort.TabIndex = 2;
            this.btnSmartBubbleSort.Text = "SmartBubbleSort";
            this.btnSmartBubbleSort.UseVisualStyleBackColor = true;
            this.btnSmartBubbleSort.Click += new System.EventHandler(this.btnSmartBubbleSort_Click);
            // 
            // groupEtc
            // 
            this.groupEtc.Controls.Add(this.btnMinMax);
            this.groupEtc.Controls.Add(this.btnDoublyNode);
            this.groupEtc.Controls.Add(this.btnStack);
            this.groupEtc.Controls.Add(this.btnIterator);
            this.groupEtc.Location = new System.Drawing.Point(219, 245);
            this.groupEtc.Name = "groupEtc";
            this.groupEtc.Size = new System.Drawing.Size(247, 111);
            this.groupEtc.TabIndex = 23;
            this.groupEtc.TabStop = false;
            this.groupEtc.Text = "Etc";
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(6, 19);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(109, 23);
            this.btnMinMax.TabIndex = 4;
            this.btnMinMax.Text = "MinMax";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnDoublyNode
            // 
            this.btnDoublyNode.Location = new System.Drawing.Point(6, 48);
            this.btnDoublyNode.Name = "btnDoublyNode";
            this.btnDoublyNode.Size = new System.Drawing.Size(109, 23);
            this.btnDoublyNode.TabIndex = 14;
            this.btnDoublyNode.Text = "Doubly Node";
            this.btnDoublyNode.UseVisualStyleBackColor = true;
            this.btnDoublyNode.Click += new System.EventHandler(this.btnDoublyNode_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(6, 77);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(109, 23);
            this.btnStack.TabIndex = 8;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnIterator
            // 
            this.btnIterator.Location = new System.Drawing.Point(121, 19);
            this.btnIterator.Name = "btnIterator";
            this.btnIterator.Size = new System.Drawing.Size(109, 23);
            this.btnIterator.TabIndex = 15;
            this.btnIterator.Text = "Iterator";
            this.btnIterator.UseVisualStyleBackColor = true;
            this.btnIterator.Click += new System.EventHandler(this.btnIterator_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearConsole);
            this.tabPage2.Controls.Add(this.txtConsole);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Console";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearConsole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearConsole.Location = new System.Drawing.Point(7, 539);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(887, 23);
            this.btnClearConsole.TabIndex = 1;
            this.btnClearConsole.Text = "Clear Console";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.Color.Navy;
            this.txtConsole.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.SystemColors.Window;
            this.txtConsole.Location = new System.Drawing.Point(7, 7);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(887, 526);
            this.txtConsole.TabIndex = 0;
            // 
            // btnTestAll
            // 
            this.btnTestAll.Location = new System.Drawing.Point(473, 7);
            this.btnTestAll.Name = "btnTestAll";
            this.btnTestAll.Size = new System.Drawing.Size(298, 112);
            this.btnTestAll.TabIndex = 24;
            this.btnTestAll.Text = "Test all!";
            this.btnTestAll.UseVisualStyleBackColor = true;
            this.btnTestAll.Click += new System.EventHandler(this.btnTestAll_Click);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 618);
            this.Controls.Add(this.tabControl);
            this.Name = "MainProgram";
            this.Text = "List";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.tabControl.ResumeLayout(false);
            this.tabFunctions.ResumeLayout(false);
            this.groupSearch.ResumeLayout(false);
            this.groupQueue.ResumeLayout(false);
            this.groupHash.ResumeLayout(false);
            this.groupList.ResumeLayout(false);
            this.groupSort.ResumeLayout(false);
            this.groupEtc.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFunctions;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnSmartBubbleSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.Button btnBinarySearchTree;
        private System.Windows.Forms.Button btnLinkedList;
        private System.Windows.Forms.Button btnIterator;
        private System.Windows.Forms.Button btnDoublyNode;
        private System.Windows.Forms.Button btnDoublyLinkedList;
        private System.Windows.Forms.Button btnCircularLinkedList;
        private System.Windows.Forms.Button btnQuadraticHash;
        private System.Windows.Forms.Button btnLinearHash;
        private System.Windows.Forms.Button btnBucketHash;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnPriorityQueue;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnSequentialSearch;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnBinarySearch;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.GroupBox groupSort;
        private System.Windows.Forms.GroupBox groupQueue;
        private System.Windows.Forms.GroupBox groupHash;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.GroupBox groupEtc;
        private System.Windows.Forms.Button btnTestAll;
    }
}