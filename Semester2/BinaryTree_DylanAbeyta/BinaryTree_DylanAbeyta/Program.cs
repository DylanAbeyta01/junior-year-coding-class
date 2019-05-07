using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            bool doesExists = false;
            BinaryTree bt = new BinaryTree();           
            bt.Insert('o');
            bt.Insert('c');        
            bt.Insert('q');
            bt.Insert('w');
            bt.Insert('z');
            bt.Insert('x');
            bt.Insert('a');
            bt.Print();

            do
            {
                Console.WriteLine("1) Search");
                Console.WriteLine("2) Remove");
                Console.WriteLine("3) Insert");
                Console.WriteLine("4) PreOrderPrint");
                Console.WriteLine("5) InOrderPrint");
                Console.WriteLine("6) PostOrderPrint");



                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Enter a letter to search for");
                    char SLet = char.Parse(Console.ReadLine());
                    Console.WriteLine(bt.Search(SLet));                   
                }

                if (input == 2)
                {
                    Console.WriteLine("Enter a letter to remove");
                    char SLet = char.Parse(Console.ReadLine());
                    doesExists = bt.Search(SLet);

                    if (doesExists == true)
                    {
                        bt.Remove(SLet);
                        bt.Print();
                    }
                    else
                        Console.WriteLine("This letter is not in the tree.");
                }

                if (input == 3)
                {
                    Console.WriteLine("Enter a letter to insert");
                    char insert = char.Parse(Console.ReadLine());
                    bt.Insert(insert);
                    bt.Print();
                }

                if (input == 4)
                {
                    bt.PreOrderPrint();
                    Console.WriteLine();
                }

                if (input == 5)
                {
                    bt.InorderPrint();
                    Console.WriteLine();
                }

                if (input == 6)
                {
                    bt.PostOrderPrint();
                    Console.WriteLine();
                }
            } while (input != 7);
           
            Console.ReadKey();
        //https://www.geeksforgeeks.org/binary-search-tree-set-2-delete/
        }
    }
}
