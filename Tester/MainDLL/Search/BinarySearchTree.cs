using System;
using System.Collections.Generic;

/// <summary>
/// Implementation of a generic binary search tree.
/// </summary>
/// <typeparam name="T">The type of element to store in the collection.</typeparam>
public class BinarySearchTree<T> : ICollection<T> {

	BinarySearchTreeNode mRoot;	// the root node, which is the starting point for traversal	
	IComparer<T> mComparer;		// the comparator used for sorting the tree	
	int mCount;					// internal element count, for performance

	/// <summary>
	/// Gets or sets the comparator used for sorting the BinarySearchTree.
	/// </summary>
	protected IComparer<T> Comparer {
		get {
			return mComparer;
		}
		set {
			if (value == null) throw new ArgumentNullException("value");
			if (mCount > 0) throw new InvalidOperationException("Cannot change the comparator while the collection is non-empty");
			mComparer = value;
		}
	}

	/// <summary>
	/// Gets the number of elements in the BinarySearchTree.
	/// </summary>
	public int Count {
		get {
			return mCount;
		}
	}

	/// <summary>
	/// Gets an IEnumerable that can be used with the foreach statement to iterate through the collection.
	/// </summary>
	public IEnumerable<T> InOrder {
		get {
			BinarySearchTreeNode prev = null;
			BinarySearchTreeNode current = mRoot;
			BinarySearchTreeNode next = null;

			while (current != null) {
				if ((prev == null) || (prev == current.Parent)) {
					prev = current;
					next = current.LesserChild;
				}

				if ((next == null) || (prev == current.LesserChild)) {
					yield return current.Value;
					prev = current;
					next = current.GreaterChild;
				}

				if ((next == null) || (prev == current.GreaterChild)) {
					prev = current;
					next = current.Parent;
				}

				current = next;
			}
		}
	}

	/// <summary>
	/// Gets an IEnumerable that can be used with the foreach statement to iterate through the collection using the pre-order strategy. 
	/// Pre-order (node, left, right) can be used to clone the collection with the same arrangement of nodes.
	/// </summary>
	public IEnumerable<T> PreOrder {
		get {
			BinarySearchTreeNode prev = null;
			BinarySearchTreeNode current = mRoot;
			BinarySearchTreeNode next = null;

			while (current != null) {
				if ((prev == null) || (prev == current.Parent)) {
					yield return current.Value;
					prev = current;
					next = current.LesserChild;
				}

				if ((next == null) || (prev == current.LesserChild)) {
					prev = current;
					next = current.GreaterChild;
				}

				if ((next == null) || (prev == current.GreaterChild)) {
					prev = current;
					next = current.Parent;
				}

				current = next;
			}
		}
	}

	/// <summary>
	/// Gets an IEnumerable that can be used with the foreach statement to iterate through the collection in reverse order.
	/// </summary>
	public IEnumerable<T> ReverseOrder {
		get {
			BinarySearchTreeNode prev = null;
			BinarySearchTreeNode current = mRoot;
			BinarySearchTreeNode next = null;

			while (current != null) {
				if ((prev == null) || (prev == current.Parent)) {
					prev = current;
					next = current.GreaterChild;
				}

				if ((next == null) || (prev == current.GreaterChild)) {
					yield return current.Value;
					prev = current;
					next = current.LesserChild;
				}

				if ((next == null) || (prev == current.LesserChild)) {
					prev = current;
					next = current.Parent;
				}

				current = next;
			}
		}
	}

	/// <summary>
	/// Initialises a new instance of the BinarySearchTree class.
	/// </summary>
	public BinarySearchTree() {
		mCount = 0;
		mComparer = Comparer<T>.Default;
		mRoot = null;
	}

	/// <summary>
	/// Initialises a new instance of the BinarySearchTree class and adds the elements from the specified enumerable object.
	/// </summary>
	/// <param name="values">The set of elements to copy to this BinarySearchTree.</param>
	public BinarySearchTree(IEnumerable<T> values) : this() {
		foreach (T item in values) Add(item);
	}

	/// <summary>
	/// Initialises a new instance of the BinarySearchTree class and adds the elements from another BinarySearchTree.
	/// </summary>
	/// <param name="BinarySearchTree">The BinarySearchTree whose elements will be copied to this BinarySearchTree.</param>
	public BinarySearchTree(BinarySearchTree<T> BinarySearchTree) : this() {
		// use pre-order to preserve the structure of the tree
		foreach (T item in BinarySearchTree.PreOrder) Add(item);
	}

	/// <summary>
	/// Adds an element to the BinarySearchTree.
	/// </summary>
	/// <param name="item">The item that will be added to the collection.</param>
	public void Add(T item) {
		BinarySearchTreeNode node = new BinarySearchTreeNode(item);

		if (mRoot != null) {
			BinarySearchTreeNode dest = mRoot;
			while (dest != null) {
				int result = mComparer.Compare(item, dest.Value);
				if (result < 0) {
					if (dest.LesserChild != null) {
						dest = dest.LesserChild;
					}
					else {
						dest.LesserChild = node;
						node.Parent = dest;
						break;
					}
				}
				else {
					if (dest.GreaterChild != null) {
						dest = dest.GreaterChild;
					}
					else {
						dest.GreaterChild = node;
						node.Parent = dest;
						break;
					}
				}
			}
		}
		else {
			mRoot = node;
		}

		mCount++;
	}

	/// <summary>
	/// Clears all elements from the BinarySearchTree.
	/// </summary>
	public void Clear() {
		mRoot = null;
		mCount = 0;
	}

	/// <summary>
	/// Determines whether the specified element is in the BinarySearchTree.
	/// </summary>
	/// <param name="item">The item to find.</param>
	/// <returns>True if the item is in the collection, otherwise false.</returns>
	public bool Contains(T item) {
		return (Find(item) != null);
	}

	/// <summary>
	/// Copies all the elements in the BinarySearchTree into a compatible array, starting at the specified index.
	/// </summary>
	/// <param name="array">A compatible array to copy the elements from this BinarySearchTree into.</param>
	/// <param name="arrayIndex">The array index from which to start copying.</param>
	public void CopyTo(T[] array, int arrayIndex) {
		if (array == null) throw new ArgumentNullException("array");
		if ((arrayIndex < 0) || (arrayIndex >= array.Length)) throw new ArgumentOutOfRangeException("arrayIndex");
		if (mCount < array.Length - arrayIndex) throw new ArgumentException("Array is too small", "array");

		foreach (T item in this) array[arrayIndex++] = item;
	}

	/// <summary>
	/// Gets an enumerator that can be used to iterate through the BinarySearchTree.
	/// </summary>
	/// <returns></returns>
	public IEnumerator<T> GetEnumerator() {
		foreach (T element in InOrder) yield return element;
	}

	/// <summary>
	/// Removes the first occurrence of the specified element from the BinarySearchTree.
	/// </summary>
	/// <param name="item">The element to remove from the collection.</param>
	/// <returns>True if the element was found, otherwise false.</returns>
	public bool Remove(T item) {
		BinarySearchTreeNode node = Find(item);
		return Remove(node);
	}

	#region Helper Methods

	BinarySearchTreeNode Find(T item) {
		// binary search
		BinarySearchTreeNode node = mRoot;

		while (node != null) {
			int result = mComparer.Compare(item, node.Value);
			if (result == 0)
				return node;
			else if (result < 0)
				node = node.LesserChild;
			else
				node = node.GreaterChild;
		}

		return null;
	}

	bool Remove(BinarySearchTreeNode node) {
		if (node != null) {
			BinarySearchTreeNode successor;

			if ((node.LesserChild == null) && (node.GreaterChild == null)) {
				// no children, no successor
				successor = null;
			}
			else if (node.GreaterChild == null) {
				successor = node.LesserChild;
			}
			else if (node.LesserChild == null) {
				successor = node.GreaterChild;
			}
			else {
				// successor is the leftmost node on the right branch
				successor = node.GreaterChild;
				while (successor.LesserChild != null) successor = successor.LesserChild;

				// swap value with successor, then delete successor
				node.Value = successor.Value;
				return Remove(successor);
			}

			if (node.Parent != null) {
				// deleted node's parent now points to the successor
				if (node.Parent.GreaterChild == node) node.Parent.GreaterChild = successor;
				if (node.Parent.LesserChild == node) node.Parent.LesserChild = successor;
			}

			// successor's new parent is the deleted node's parent
			if (successor != null) successor.Parent = node.Parent;

			// successor becomes the new root
			if (node == mRoot) mRoot = successor;

			mCount--;
			return true;
		}

		return false;
	}

	#endregion

	#region Explicit Interface Implementations

	bool ICollection<T>.IsReadOnly {
		get {
			return false;
		}
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}

	#endregion

	/// <summary>
	/// Represents a node in the binary search tree, comprising of the element and the 3 links to neighbouring nodes.
	/// </summary>
	private class BinarySearchTreeNode {

		T mValue;
		BinarySearchTreeNode mParent;
		BinarySearchTreeNode mLesserChild;
		BinarySearchTreeNode mGreaterChild;

		/// <summary>
		/// Gets or sets the BinarySearchTree. BinarySearchTreeNode whose element is greater than this node's element.
		/// </summary>
		public BinarySearchTreeNode GreaterChild {
			get { return mGreaterChild; }
			set { mGreaterChild = value; }
		}

		/// <summary>
		/// Gets or sets the BinarySearchTree. BinarySearchTreeNode whose element is less than this node's element.
		/// </summary>
		public BinarySearchTreeNode LesserChild {
			get { return mLesserChild; }
			set { mLesserChild = value; }
		}

		/// <summary>
		/// Gets or sets the BinarySearchTree. BinarySearchTreeNode that links to this node.
		/// </summary>
		public BinarySearchTreeNode Parent {
			get { return mParent; }
			set { mParent = value; }
		}

		/// <summary>
		/// Gets or sets the element contained within this BinarySearchTree. BinarySearchTreeNode.
		/// </summary>
		public T Value {
			get { return mValue; }
			set { mValue = value; }
		}

		/// <summary>
		/// Initialises a new instance of the BinarySearchTree. BinarySearchTreeNode class, wrapping the specified element.
		/// </summary>
		/// <param name="value"></param>
		public BinarySearchTreeNode(T value) {
			mValue = value;
			mParent = mGreaterChild = mLesserChild = null;
		}
	}
}