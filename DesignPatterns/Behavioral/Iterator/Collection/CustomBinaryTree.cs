using System.Collections;

namespace DesignPatterns.Behavioral.Iterator.Collection
{
    public class CustomBinaryTree : IEnumerable
    {
        private IEnumerator _currentEnumerator;
        public TreeNode RootNode;

        public void ChangeIterator(IEnumerator inputIterator)
        {
            this._currentEnumerator = inputIterator;
        }

        public void AddValue(int inputValue)
        {
            if (RootNode == null)
            {
                TreeNode root = new TreeNode(inputValue);
                this.RootNode = root;
                return;
            }
            if (RootNode != null)
            {
                AddChild(RootNode,inputValue);
            }
        }

        private void AddChild(TreeNode parent, int inputValue)
        {
            if (inputValue < parent.NodeValue)
            {
                if (parent.LeftChild == null)
                {
                    TreeNode newbornNode = new TreeNode(inputValue);
                    parent.LeftChild = newbornNode;
                    return;
                }
                if (parent.LeftChild != null)
                {
                    AddChild(parent.LeftChild, inputValue);
                }
            }
            if (inputValue >= parent.NodeValue)
            {
                if (parent.RightChild == null)
                {
                    TreeNode newbornNode = new TreeNode(inputValue);
                    parent.RightChild = newbornNode;
                    return;
                }
                if (parent.RightChild != null)
                {
                    AddChild(parent.RightChild, inputValue);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this._currentEnumerator;
        }
    }
}