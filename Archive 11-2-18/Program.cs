using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta_guessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // pick a random number between 1 and 1000
                int Number1 = 0;
                Random rand = new Random();
                int Guess = 0;
                int[] Num = new int[1000];
                int i = 0;
                Num[i] = rand.Next(0, 1000);

                // tell the user the rules and tell them to guess a number
             
                // create a do-While that stops when the user guesses the right number 
                // if they guess a number greater than the random number
                // tell the user that the random number is less
                // add one to the variable counting the guesses

                // if they guess a number less that the random number 
                // tell the user that the random number is greater
                // add one to the variable counting the guesses
                do
                {

                    Console.WriteLine("I have Picked a number between 0 and 1000.");
                    Console.WriteLine("Now it is your turn to guess the number i have picked in as few guesses as possible.");
                    Console.WriteLine("After each Guess i will tell you if you are too high or too low.");
                    Console.WriteLine("What is your first Guess?");
                    Number1 = int.Parse(Console.ReadLine());
                                      
                        if (Number1 > Num[i])
                        {
                            Guess++;
                            Console.WriteLine("Sorry That is Not the Number in my head, try a Lower Number");
                            Console.WriteLine();
                        }
                        else if (Number1 < Num[i])
                        {
                            Guess++;
                            Console.WriteLine("Sorry That Is Not The Number In My Head, Try a Bigger Number");
                            Console.WriteLine();
                        }                                                                                                                                             
                } while (Number1 != Num[i]);

            // if they guess the right number then tell the user they got it 
            // print out the random number
            // stop the variable counting the guesses and print the number of guesses

            Guess++;
            Console.WriteLine("Yay!!! You Have guessed My Number");
            Console.WriteLine("It Took you " + Guess + " Guesses to Guess My Number");                             
        }
    }
}
