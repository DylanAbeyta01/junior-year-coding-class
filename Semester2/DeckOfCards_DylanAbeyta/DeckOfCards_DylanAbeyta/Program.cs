using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards_DylanAbeyta
{
    class Program
    {
        static Deck deck = new Deck();
        static void Main(string[] args)
        {
            int input = 0;
            
            List<int> Hand = new List<int>();
            do
            {
                Console.WriteLine("*************************");
                Console.WriteLine("** 1) Rules of war");
                Console.WriteLine("** 2) Play");
                Console.WriteLine("** 3) Quit");
                Console.WriteLine("*************************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    rules();
                }
                        
                if (input == 2)
                {
                    deck.Shuffle();

                }                    

            } while (input != 3);

            Console.ReadKey(); 
          
        }

        static void player1()
        {
            List<Card> deckOne = new List<Card>();
            for (int i = 0; i < 26; i++)
            {
                deckOne.Add(deck.Draw());
                deckOne[deckOne.Count - 1].print(); 
            }           
        }
        static void player2()
        {
            List<Card> deckTwo = new List<Card>();
            for (int i = 26; i < 52; i++)
            {
                deckTwo.Add(deck.Draw());
                deckTwo[deckTwo.Count - 1].print();
            }
        }

        static void rules()
        {
            Console.WriteLine("Welcome to the card game WAR");
            Console.WriteLine("Goal: ");
            Console.WriteLine("         Obtain all the cards");
            Console.WriteLine("How to Get Cards:");
            Console.WriteLine("         Each player places down their first card and whoever has the highest card value gets to keep both cards");
            Console.WriteLine("         If theres a tie then place down 3 cards face down and the 4th card will determine who gets all the cards");
        }
                   
    }
}
