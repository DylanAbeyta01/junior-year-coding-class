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
            bt.Insert('p');
            bt.Insert('f');
            bt.Insert('t');
            bt.Insert('j');
            bt.Insert('k');
            bt.Insert('i');
            bt.Insert('s');
            bt.Insert('q');
            bt.Insert('w');
            bt.Insert('z');
            bt.Insert('x');
            bt.Print();

            do
            {
                Console.WriteLine("1) Search");
                Console.WriteLine("2) Remove");
                Console.WriteLine("3) Insert");
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
                    }
                }

                if (input == 3)
                {
                    Console.WriteLine("Enter a letter to insert");
                }
            } while (input != 5);
           
            Console.ReadKey();
        //https://www.geeksforgeeks.org/binary-search-tree-set-2-delete/
        }
    }
}
