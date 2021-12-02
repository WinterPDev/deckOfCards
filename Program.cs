using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck first = new Deck();
            first.newDeck();
            first.resetDeck();
            first.dealDeck();
            first.shuffleDeck();
            Player pc = new Player("Winter");
            pc.Draw(first);
            pc.Discard(1);
        }
    }
}
