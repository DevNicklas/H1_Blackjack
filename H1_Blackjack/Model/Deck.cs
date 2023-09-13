using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack.Model
{
    /// <summary>
    /// Class <see cref="Deck"/> represents a shuffled deck with 52 cards
    /// </summary>
    internal class Deck
    {
        private List<Card> _deck = new List<Card>();

        public List<Card> DeckOfCards
        {
            get { return _deck; }
            set { _deck = value; }
        }

        /// <summary>
        /// Creates a shuffled deck
        /// </summary>
        /// <param name="config">config of program</param>
        public void Create(Config config)
        {
            #region Cards
            Card cardTwo = new Card("2", 2);
            Card cardThree = new Card("3", 3);
            Card cardFour = new Card("4", 4);
            Card cardFive = new Card("5", 5);
            Card cardSix = new Card("6", 6);
            Card cardSeven = new Card("7", 7);
            Card cardEight = new Card("8", 8);
            Card cardNine = new Card("9", 9);
            Card cardTen= new Card("10", 10);
            Card cardJack = new Card("J", 10);
            Card cardQueen = new Card("Q", 10);
            Card cardKing = new Card("K", 10);
            Card cardAce = new Card("A", 11);
            #endregion

            // List of cards
            List<Card> cards = new List<Card>()
            {
                cardTwo, cardThree, cardFour, cardFive, cardSix, cardSeven, cardEight, 
                cardNine, cardTen, cardJack, cardQueen, cardKing, cardAce
            };

            Random random = new Random();

            // Adds cards into the deck
            for (int i = 0; i < config.cardsAmount; i++)
            {
                for(int j = 0; j < config.cardTypes; j++)
                {
                    _deck.Add(cards[random.Next(1,14)-1]);
                }
            }
        }

        /// <summary>
        /// Removes a card from the deck by card number
        /// </summary>
        /// <param name="cardNumber">index of card in the deck</param>
        public void RemoveCard(byte cardNumber)
        {
            _deck.RemoveAt(cardNumber);
        }

    }
}
