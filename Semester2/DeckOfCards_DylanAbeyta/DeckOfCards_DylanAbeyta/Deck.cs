using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards_DylanAbeyta
{ 
    class Deck
    {
        List<Card> DiscardD = new List<Card>();
        List<Card> deck = new List<Card>();
         
        public Deck()
        {
            foreach (var face in Enum.GetValues(typeof(Face)))
            {
                foreach (var suit in Enum.GetValues(typeof(Suit)))
                {
                    deck.Add(new Card((Suit)suit, (Face)face));
                }

            }
        }

        public void Shuffle()
        {
            Random random = new Random();            
            deck = deck.OrderBy(t => random.Next()).ToList();
        }

        public Card Draw()
        {
            Card temp = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);       
            return temp;
        }

        public void Discard(Card C)
        {

        }

        public void PrintDeck()
        {

        }

        public void PrintDiscard()
        {

        }
            
    }
}
