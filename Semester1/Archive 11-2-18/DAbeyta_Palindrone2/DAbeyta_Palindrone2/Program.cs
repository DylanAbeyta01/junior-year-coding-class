using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta_Palindrone2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = ""; // initialize variables
            string rev = "";
            Console.WriteLine("Enter any string");
            word = Console.ReadLine(); // get input of string
            word = word.Replace(" ", ""); // Replace space with no space
            for (int i = word.Length - 1; i >= 0; i--) //put the String backwards 
            {
                rev += word[i].ToString();
            }
            if (rev == word) // compare string and reverse string
            {
                Console.WriteLine("Your string Is a Palindrome");
            }
            else
            {
                Console.WriteLine("Your string Is Not a Palindrome");
            }

        }
    }
}
