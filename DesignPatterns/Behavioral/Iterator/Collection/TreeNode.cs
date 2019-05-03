namespace DesignPatterns.Behavioral.Iterator.Collection
{
    public class TreeNode
    {
        public int NodeValue { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }

        public TreeNode(int inputValue, TreeNode leftChild = null, TreeNode rightChild = null)
        {
            this.NodeValue = inputValue;
            if (leftChild != null)
            {
                this.LeftChild = leftChild;
            }
            if (rightChild != null)
            {
                this.RightChild = rightChild;
            }
        }
    }
}