using Chapter015;

BinarySearchTree bst = new BinarySearchTree();

// Insert some values
int[] values = { 1, 5, 9, 2, 4, 10, 6, 3, 8 };
foreach (int v in values)
{
    bst.Insert(v);
}

// Find greatest value
int max = bst.FindMax();
Console.WriteLine("Greatest value in BST: " + max);
