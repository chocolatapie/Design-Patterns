using System;
using System.Collections.Generic;
using DesignPatterns.Behavioral.Iterator.Collection;

namespace DesignPatterns.Behavioral.Iterator.Iterators
{
    class PreOrderIterator : AbstractIterator
    {
        private int _index = -1;
        private List<TreeNode> _nodes;

        public override object Current
        {
            get
            {
                if (_index == -1 || _index >= _nodes.Count)
                    throw new InvalidOperationException();
                return _nodes[_index];
            }
        }

        public PreOrderIterator(TreeNode root)
        {
            CollectAllNodes(root);
        }

        public override bool MoveNext()
        {
            if (_index < _nodes.Count - 1)
            {
                _index++;
                return true;
            }
            else
                return false;
        }

        public override void Reset()
        {
            this._index = -1;
        }

        private void CollectAllNodes(TreeNode inputRoot)
        {
            _nodes = new List<TreeNode>();
            PreOrderTraverse(inputRoot);
        }

        private void PreOrderTraverse(TreeNode inputNode)
        {
            if (inputNode == null)
                return;
            _nodes.Add(inputNode);
            PreOrderTraverse(inputNode.LeftChild);
            PreOrderTraverse(inputNode.RightChild);
        }
    }
}
