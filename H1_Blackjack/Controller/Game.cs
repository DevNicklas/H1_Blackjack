using H1_Blackjack.Model;
using H1_Blackjack.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H1_Blackjack.Controller
{
    /// <summary>
    /// Class <see cref="Game"/> is the controller of the game
    /// </summary>
    internal class Game
    {
        /// <summary>
        /// Starts the game
        /// </summary>
        public void Start()
        {
            // Config
            Config config = new Config();
            config.cardsAmount = 13;
            config.cardTypes = 4;

            // Create a deck
            Deck deck = new Deck();
            deck.Create(config);

            Table table = new Table();

            // Deals 2 cards to player
            for (int i = 0; i < 2; i++)
            {
                DealCard(false, deck, table);
            }
            
            // Deals 2 cards to dealer
            for (int i = 0; i < 2; i++)
            {
                DealCard(true, deck, table);
            }

            Gui gui = new Gui();

            // Shows table and asks the user to hit or stand
            gui.ShowTable(table, true);
            gui.ShowHitOrStand();

            // Asks if the user wants to hit or stay, and handles the input from the user
            // Returns if the user has lost already or not
            bool hasLost = HitOrStand(table, deck);

            // If the user already has over 21 they've lost
            if (hasLost)
            {
                gui.ShowGameLost();
            }

            else
            {
                // Shows table
                gui.ShowTable(table, false);

                // Deals a new card to dealer until the dealer has a higher total than the player
                while(table.DealerCardTotal <= table.PlayerCardTotal)
                {
                    DealCard(true, deck, table);
                    gui.ShowTable(table, false);
                    Thread.Sleep(1000);
                }

                // Check winner

                if (table.DealerCardTotal > 21)
                {
                    gui.ShowGameWon();
                }
                else if (table.DealerCardTotal < table.PlayerCardTotal)
                {
                    gui.ShowGameWon();
                }
                else
                {
                    gui.ShowGameLost();
                }
            }
        }

        /// <summary>
        /// Asks if the user wants to hit or stay, and handles the input from the user
        /// </summary>
        /// <param name="table">table of game</param>
        /// <param name="deck">deck of game</param>
        /// <returns>A boolean. If the user has lost already or not</returns>
        public bool HitOrStand(Table table, Deck deck)
        {
            Gui gui = new Gui();

            bool hasLost = false;

            UserInput userInput = new UserInput();

            // Loops forever until something breaks it
            while (true)
            {

                // If player has over 21 then they lose
                if (table.PlayerCardTotal > 21)
                {
                    hasLost = true;
                    break;
                }

                // Reads user input
                string input = userInput.GetInput();

                // Hit
                if (input == "hit")
                {
                    DealCard(false, deck, table);
                    gui.ShowTable(table, true);
                    gui.ShowHitOrStand();
                }

                // Stand
                else if (input == "stand")
                {
                    break;
                }

                // Wrong user input
                else
                {
                    gui.ShowHitOrStandError();
                }
            }
            return hasLost;
        }

        /// <summary>
        /// Deals a card to a player or dealer
        /// </summary>
        /// <param name="toDealer">deal to dealer or player</param>
        /// <param name="deck">deck to take cards from</param>
        /// <param name="table">table to put cards on</param>
        public void DealCard(bool toDealer, Deck deck, Table table)
        {
            // Index of last card in the deck
            byte lastCardInDeck = Convert.ToByte(deck.DeckOfCards.Count - 1);

            // Deal cards to Dealer
            if (toDealer)
            {
                table.DealerCard.Add(deck.DeckOfCards[lastCardInDeck]);
                table.DealerCardTotal += deck.DeckOfCards[lastCardInDeck].Value;
            }

            // Deal cards to Player
            else
            {
                table.PlayerCard.Add(deck.DeckOfCards[lastCardInDeck]);
                table.PlayerCardTotal += deck.DeckOfCards[lastCardInDeck].Value;
            }

            // Remove card from deck
            deck.RemoveCard(lastCardInDeck);
        }
    }
}
