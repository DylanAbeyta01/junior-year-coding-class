using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_DylanAbeyta
{
    class BinaryTree
    {
        private Node Root { get; set; }
        public int Height;
        public int Count;

        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
        }

        private int CountRecursive(Node n)
        {
            throw new NotImplementedException();
        }
        public void Insert(char c)
        {
            if (Root == null)
            {
                Root = new Node(c);
            }
            else
                Insert(Root, c);
        }
        private void Insert(Node n, char c)
        {
            if (c >= n.Value && n.RightChild == null)
            {
                n.RightChild = new Node(c);
                return;
            }

            if (c < n.Value && n.LeftChild == null)
            {
                n.LeftChild = new Node(c);
                return;
            }

            if (c >= n.Value)
            {
                Insert(n.RightChild, c);
            }

            else if (c < n.Value)
            {
                Insert(n.LeftChild, c);
            }


        }

        public void Remove(char c)
        {
            if (Root == null)
            {
                return;
            }

            else
                Remove(Root, c);
        }

        private Node Remove(Node n, char c)
        {
            if (n.RightChild != null && c > n.Value)            
                Remove(n.RightChild, c);
            
            if (n.LeftChild != null && c < n.Value)           
                Remove(n.LeftChild, c);
             
            if (n.LeftChild == null)
                return n.RightChild;
            else if (n.RightChild == null)
                return n.LeftChild;

            if (c == n.Value)
            {
                char min = 'k';
                while (n.LeftChild != null)
                {
                    min = n.LeftChild.Value;
                    n = n.LeftChild;
                }
            }          
        }

        public bool Search(char c)
        {
            if (Root.Value == c)
            {
                return true;
            }
            else
                return Search(Root, c);
        }
        private bool Search(Node n, char c)
        {
            if (n.RightChild != null && c > n.Value)
            {
                return Search(n.RightChild, c);
            }

            if (n.LeftChild != null && c < n.Value)
            {
                return Search(n.LeftChild, c);
            }

            if (c == n.Value)
            {
                return true;
            }
            else
                return false;
        }
        public void Balance()
        {

        }
        public void PreOrderPrint()
        {

        }
        private void PreOrderPrint(Node n)
        {

        }
        public void InorderPrint()
        {

        }
        private void InOrderPrint(Node n)
        {

        }
        public void PostOrderPrint()
        {

        }
        private void PostOrderprint(Node n)
        {

        }
    }

}
