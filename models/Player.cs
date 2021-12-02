using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            Name = name;
            this.Hand = new List<Card>{};
        }
        public Card Draw(Deck target)
        {
            Console.WriteLine($"\n------ Drawing Card ------");
            Card Drawn = target.Cards[target.Cards.Count-1];
            Console.WriteLine($"Player {Name} Drew {Drawn.Suit} of {Drawn.Stringval}");
            this.Hand.Add(Drawn);
            target.Cards.Remove(Drawn);
            Console.WriteLine($"{target.Cards.Count} Total Cards Remaining.");
            return Drawn;
        }
        
        public Card Discard(int idx)
        {
            if(idx > this.Hand.Count-1)
            {
                Console.WriteLine($"Index Not in Hand! Try a value between 0 and {this.Hand.Count}!");
                return null;
            }
            else
            {
                Card disCard = this.Hand[idx];
                Console.WriteLine($"Player {this.Name} discoarded {disCard.Suit} of {disCard.Stringval}");
                this.Hand.Remove(disCard);
                return disCard;
            }
        }
    }
}