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
            BinaryTree bt = new BinaryTree();
            bt.Insert('a');
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
            Console.WriteLine("Enter a letter to search for");
            char SLet = char.Parse(Console.ReadLine());
            bt.Search(SLet);
            Console.ReadKey();

        }
    }
}
