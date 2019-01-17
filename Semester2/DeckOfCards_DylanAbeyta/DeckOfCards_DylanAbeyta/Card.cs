using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards_DylanAbeyta
{
    enum Face { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
    enum Suit { Hearts, Diamonds, Spades, Clubs}

    class Card
    {               
        public static Dictionary<Face, int> CardValues = new Dictionary<Face, int>()
        {
            {Face.Two, 2 },
            {Face.Three, 3 },
            {Face.Four, 4 },
            {Face.Five, 5 },
            {Face.Six, 6 },
            {Face.Seven, 7 },
            {Face.Eight, 8 },
            {Face.Nine, 9 },
            {Face.Ten, 10 },
            {Face.Jack, 11 },
            {Face.Queen, 12 },
            {Face.King, 13 },
            {Face.Ace, 14 },

        };
        private Suit suit;
        private Face face;

        public Card(Suit suit, Face face)
        {
            this.suit = suit;
            this.face = face;
        }

        public void print()
        {
            string SymbolOC = null;
                Console.WriteLine("---------------------------");
                Console.WriteLine("|   " + SymbolOC + "  |");
                Console.WriteLine("---------------------------");
            
        }

    }
}
