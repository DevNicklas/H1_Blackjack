using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack.Model
{
    /// <summary>
    /// Class <see cref="Deck"/> represents a deck full of cards
    /// </summary>
    internal class Deck
    {
        private byte[] _deck = new byte[52];

        public byte[] CardDeck
        {
            get { return _deck; }
            set { _deck = value; }
        }

        public void CreateDeck()
        {
            Config config = new Config();
            config.cardsAmount = 13;
            config.cardTypes = 4;

            Random random = new Random();
            byte counter = 0;

            // Puts 52 cards in the deck
            for (int i = 0; i < config.cardsAmount; i++)
            {
                for (int j = 0; j < config.cardTypes; j++)
                {
                    _deck[counter] = (byte)random.Next(1, 12);
                    counter++;
                }
            }
        }
    }
}
