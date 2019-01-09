using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[25];

            words[0] = "picnic";
            words[1] = "ball";
            words[2] = "honesty";
            words[3] = "surprise";
            words[4] = "planet";
            words[5] = "noise";
            words[6] = "purple";
            words[7] = "flower";
            words[8] = "blade";
            words[9] = "logical";
            words[10] = "pipe";
            words[11] = "bat";
            words[12] = "wizard";
            words[13] = "drift";
            words[14] = "rock";
            words[15] = "climb";
            words[16] = "computer";
            words[17] = "weekend";
            words[18] = "lizard";
            words[19] = "hamster";
            words[20] = "container";
            words[21] = "happy";
            words[22] = "needle";
            words[23] = "avacado";
            words[24] = "choke";

            Console.WriteLine("Welcome to Hangman! In The game, you need to try to guess the word i am thinking of while ");
            Console.WriteLine("getting only 6 or less guesses wrong. After you guess a letter i will tell you if it is wrong.");
            Console.WriteLine("If you get it right, i will input that letter into its correct position");
                      
            string guess = "";
            Random rand = new Random();                      
            int k = rand.Next(0, 25);
            string magicWord = words[k];
            int correct = 0;
            int incorrect = 0;
            List<char> guesses = new List<char>();
            bool isvalid = true;

            do
            {
                Console.WriteLine("What letter would you like to guess (enter quit to exit)");
                guess = Console.ReadLine();
                int errors = 0;
                guesses.Add(guess[0]);
                int length = magicWord.Length;               
                Console.WriteLine(magicWord);
                isvalid = true;

                for (int i = 0; i < magicWord.Length; i++)
                {                   
                    if (guesses.Contains(magicWord[i]))
                    {
                        Console.Write(magicWord[i] + " ");
                        correct++; //counts how many letter are correct
                    }
                    else
                    {
                        Console.Write("_");
                        errors++;
                        isvalid = false;
                    }                    
                }
                if (!magicWord.Contains(guess))
                {
                    incorrect++;
                }
                for (int i = 0; i < guesses.Count; i++)
                {
                    if (!magicWord.Contains(guess))
                    {
                        Console.WriteLine();
                        Console.Write("incorrect letter : " + guesses[i]);
                    }
                }

                Console.WriteLine("\nYou have " + (6 - incorrect) + " incorrect guesses left");
                Console.WriteLine();
                if (incorrect >= 6)
                {
                    Console.WriteLine("Sorry you Are out of guesses, the word that you were trying to guess was: " + magicWord);
                    break;
                }

                if (isvalid == true)
                {
                    break;
                }
                        
            } while (magicWord.Length != ((correct - incorrect) / 2));



            if (incorrect >= 6)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Yay, you have guessed the word with less then 6 incorrect guesses.");
            }
        }
    }
}
