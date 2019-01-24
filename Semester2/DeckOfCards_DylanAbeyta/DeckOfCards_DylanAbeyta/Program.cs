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
        static List<Card> deckOne = new List<Card>();
        static List<Card> deckTwo = new List<Card>();
        static int ender = 0;
        static int count1 = 0;
        static int count2 = 0;

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
                    for (int i = 0; i < 26; i++)
                    {
                        deckOne.Add(deck.Draw());
                        count1++;
                    }
                    for (int i = 26; i < 52; i++)
                    {
                        deckTwo.Add(deck.Draw());
                        count2++;
                    }
                    do
                    {
                        string input2 = "";                        
                        ender = player1();
                        ender = player2();
                        int result = deckOne[deckOne.Count - 1].Compare(deckTwo[deckTwo.Count - 1]);
                        if (result == 1)
                        {
                            Console.WriteLine("Player one wins");
                            Console.WriteLine();
                            AdditionToOne();
                        }
                        if (result == -1)
                        {
                            Console.WriteLine("Player two wins");
                            Console.WriteLine();
                            AdditionToTwo();
                        }
                        if (result == 2)
                        {
                            Card c = deckOne[deckOne.Count - 1];
                            deckOne.RemoveAt(deckOne.Count - 1);
                            deckOne.Insert(0, c);
                        }
                                
                        Console.WriteLine("Do you want to keep playing? y or n");
                        input2 = Console.ReadLine();
                        
                        if (input2[0] == 'y' || input2[0] == 'Y')
                        {
                            ender = 5;
                        }

                        if (input2[0] == 'n' || input2[0] == 'N')
                        {
                            ender = 4;
                        }

                    } while (ender != 4);
                    break;
                }                    

            } while (input != 3);

            Console.ReadKey(); 
          
        }

        static int player1()
        {
            int endGame = 0;
      
            Console.WriteLine("Player One: ");
            deckOne[deckOne.Count - 1].print();
            if (count1 > 1)
            {
                endGame = 5;
                Console.WriteLine("Player one has " + count1 + " cards left");
                return 5;
            }
            if (count1 == 1)
            {
                endGame = 5;
                Console.WriteLine("Player one has " + count1 + " card left");
                return 5;
            }
            if (count2 == 52)
            {
                endGame = 4;
                Console.WriteLine("Player Two has won the game");
                return 4;
            }
           
            return 0;

        }
        static int player2()
        {
            int endGame = 0;

            Console.WriteLine("Player Two:");
            deckTwo[deckTwo.Count - 1].print();
            if (count2 > 1)
            {
                endGame = 5;
                Console.WriteLine("Player two has " + count2 + " cards left");
                return 5;
            }
            if (count2 == 1)
            {
                endGame = 5;
                Console.WriteLine("Player two has " + count2 + " card left");
                return 5;
            }
            if (count2 == 0)
            {
                endGame = 4;
                Console.WriteLine("Player One has won the game");
                return 4;
            }
           
            return 0;
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

        static void AdditionToOne()
        {
            Card c = deckOne[deckOne.Count - 1];
            deckOne.RemoveAt(deckOne.Count - 1);
            deckOne.Insert(0, deckTwo[deckTwo.Count - 1]);
            deckOne.Insert(0, c);
            deckTwo.RemoveAt(deckTwo.Count - 1);
            count2--;
            count1++;
        }

        static void AdditionToTwo()
        {
            Card c = deckTwo[deckTwo.Count - 1];
            deckTwo.RemoveAt(deckTwo.Count - 1);
            deckTwo.Insert(0, deckOne[deckOne.Count - 1]);
            deckTwo.Insert(0, c);
            deckOne.RemoveAt(deckOne.Count - 1);
            count1--;
            count2++;

        }
    }
}

