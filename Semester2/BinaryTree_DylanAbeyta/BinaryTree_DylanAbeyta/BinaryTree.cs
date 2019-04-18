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
            if (c >=  n.Value && n.RightChild == null)
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
        public bool Remove(char c)
        {
            throw new NotImplementedException();

        }
        private bool Remove(Node n, char c)
        {
            throw new NotImplementedException();

        }
        public bool Search(char c)
        {

            throw new NotImplementedException();

        }
        private bool Search(Node n, char c)
        {
            throw new NotImplementedException();
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
