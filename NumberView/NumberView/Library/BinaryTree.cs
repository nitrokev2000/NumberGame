using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberView
{
    public class BinaryTree
    {
        private BinaryTreeNode root;
        public BinaryTree()
        {
            root = null;
        }
        public void insert(char c)
        {
            addNode(c, ref root);
        }
        private void addNode(char c, ref BinaryTreeNode rptr)
        {
            if (rptr == null)
                rptr = new BinaryTreeNode(c);
            else if (rptr.left == null)
                addNode(c, ref rptr.left);
            else if (rptr.right == null)
                addNode(c, ref rptr.right);
            else
                addNode(c, ref rptr.left);
        }

        public void removeNode(char c)
        {
            deleteNode(c, ref root);
        }

        private void deleteNode(char c, ref BinaryTreeNode root)
        {
            if (root == null)
            { }
            else
            {
                if (root.left.id != c)
                {
                    deleteNode(c, ref root.left);
                }
                else if (root.right.id != c)
                {
                    deleteNode(c, ref root.right);
                }
                else if (root.left.id == c)
                {
                    root.left = root.left.left;
                }
                else if (root.right.id == c)
                {
                    root.right = root.right.right;
                }
            }

        }
    }

    public class BinaryTreeNode
    {
        public char id { get; set; }
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public BinaryTreeNode()
        {
            left = right = null;
        }
        public BinaryTreeNode(char _id)
        {
            id = _id;
            left = right = null;
        }
    }
}
