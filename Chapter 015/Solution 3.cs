namespace Chapter015
{
/*
3. Write an algorithm that finds the greatest value within a binary search tree.
*/
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                return new Node(value);
            }

            if (value < root.Value)
                root.Left = InsertRec(root.Left, value);
            else if (value > root.Value)
                root.Right = InsertRec(root.Right, value);

            return root;
        }

        // Find the greatest value
        public int FindMax()
        {
            if (Root == null)
                throw new InvalidOperationException("Tree is empty.");

            Node current = Root;
            while (current.Right != null)
            {
                current = current.Right; // Keep going right
            }
            return current.Value; // Last right node is max
        }
    }
}
