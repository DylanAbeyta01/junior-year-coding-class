using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePractice_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = CheckForPrime(27427);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        static bool CheckForPrime(int n, int divisor = 2)
        {
            if (n % divisor == 0)
                return false;

            if (divisor == (n - 1))
                return true;

            return CheckForPrime(n, divisor + 1);
        }
    }
}
