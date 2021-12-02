using System;
using System.Collections.Generic;


namespace deckOfCards
{
    public class Deck
    {
        public List<Card> Cards;
        public string[] cardVals = new string[]{"Ace", "2", "3", "4", "5", "6", "7", "8","9","10","Jack","Queen","King"};
        public string[] suits = new string[]{"Clubs", "Diamonds", "Hearts", "Spades"};
        public Deck(){
            this.Cards = new List<Card>{};
        }
        public void newDeck()
        {
            Console.WriteLine($"\n------ Deck Created ------");
            if(this.Cards.Count > 0){
                this.Cards.Clear();
            }
            int count = 0;
            foreach(string cv in this.cardVals)
            {
                count++;
                foreach(string s in this.suits)
                {
                    Cards.Add(new Card(cv, s, count));
                }
            }
            int total = Cards.Count;
            Console.WriteLine($"Deck of {total} Created!");
        }
        public void resetDeck()
        {
            Console.WriteLine($"\n------ Deck Reset ------");
            this.Cards.Clear();
            Console.WriteLine("Deck has been Reset!");
            this.newDeck();
        }
        public void dealDeck()
        {
            Console.WriteLine($"\n------ Dealing Card ------");
            int topdeck = this.Cards.Count - 1;
            Card topcard = this.Cards[topdeck];
            Console.WriteLine($"{topcard.Suit} of {topcard.Val} Dealt.");
            this.Cards.Remove(topcard);
            Console.WriteLine($"{this.Cards.Count} Total Cards Remaining.");
        }

        public void shuffleDeck()
        {
            Random rand = new Random();
            int idx = 0;
            Console.WriteLine($"\n------ Shuffle ------");
            while (idx < Cards.Count)
            {
                Card temp = Cards[idx];
                Card newIdx = Cards[rand.Next(0,Cards.Count)];
                Cards[idx] = newIdx;
                newIdx = temp;
                idx++;
            }
            Console.WriteLine($"Deck of {Cards.Count} has been Shuffled!");
        }

    }
}