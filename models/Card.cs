using System;
using System.Collections.Generic;


namespace deckOfCards
{
    public class Card
    {
        public string Stringval;
        public string Suit;
        public int Val;

        public Card(string strV, string suit, int val)
        {
            Stringval = strV;
            Suit = suit;
            Val = val;
        }
        
    }

}