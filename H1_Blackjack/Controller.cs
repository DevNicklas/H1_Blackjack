using H1_Blackjack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack
{
    /// <summary>
    /// Class <see cref="Controller"/> controls the game
    /// </summary>
    internal class Controller
    {
        public void StartGame()
        {
            // Creates a deck of 52 cars
            Deck deck = new Deck();
            deck.CreateDeck();

            Table table = new Table();

            // Deals card to user
            for (int i = 0; i < 2; i++)
            {
                DealCard(false, table, deck);
            }

            // Deals card to dealer
            DealCard(true, table, deck);

            // Shows total of cards to user
            Gui gui = new Gui();
            gui.ShowTable(table.GetTotal(true), table.GetTotal(false));

            UserInput userInput = new UserInput();

            while (true)
            {
                // Ask if the user wants to hit or stay
                gui.HitOrStay();

                // Gets user input
                string readInput = userInput.GetUserInput();

                // If user writes hit
                if(readInput == "hit")
                {
                    DealCard(false, table, deck);
                    // Here i would check if the user has hit more than or equal to 21 and if not, ask again
                    // If its 21 i would check if the dealer has 21, if not then the user wins else the computer wins
                }

                // If user writes stay
                else if (readInput == "stay")
                {
                    DealCard(true, table, deck);
                    gui.ShowTable(table.GetTotal(true), table.GetTotal(false));
                    break;
                }

                else
                {
                    gui.ErrorHitOrStay();
                }

            }

            // Is here for not closing the program before hitting enter
            userInput.GetUserInput();
        }

        /// <summary>
        /// Deals a card to the table
        /// </summary>
        /// <param name="toDealer">refers to if its the dealer or user which a card will be dealt to</param>
        /// <param name="table">table to deal on</param>
        /// <param name="deck">deck to use card</param>
        public void DealCard(bool toDealer, Table table, Deck deck)
        {
            Random random = new Random();
            byte dealerRandom = (byte)random.Next(2, 12);
            byte userRandom = (byte)random.Next(2, 12);

            // Dealer table
            if (toDealer)
            {

                table.DealerCards[table.DealerCardsCount] = deck.CardDeck[dealerRandom];
                table.DealerCardsCount++;
            }

            // User table
            else
            {
                table.UserCards[table.UserCardsCount] = deck.CardDeck[userRandom];
                table.UserCardsCount++;
            }
        }
    }
}
