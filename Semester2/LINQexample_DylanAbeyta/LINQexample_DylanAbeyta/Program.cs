using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexample_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> L2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };

            // if L2 has a number that is in L1 has then it adds it to a new list called sublist
            // uses intersect (more correct)
            List<int> intersect = L1.Intersect(L2).ToList();         
            for (int i = 0; i < intersect.Count; i++)
            {
                Console.Write(intersect[i] + ", ");
            }

            // if L2 has a number that is in L1 has then it adds it to a new list called sublist
            // uses where (not as correct as intersect)
            List<int> sublist = L1.Where(L2.Contains).ToList();
            Console.WriteLine();
            for (int i = 0; i < sublist.Count; i++)
            {
                Console.Write(sublist[i] + ", ");
            }


            // uses where to add numbers to list if the numbers are higher than or equal to 5
            List<int> new1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> newnew = new1.Where(t => t >= 5 == true).ToList();          
            Console.WriteLine();
            for (int i = 0; i < newnew.Count; i++)
            {
                Console.Write(newnew[i] + ", ");
            }

            Console.ReadLine();
        }
    }
}
