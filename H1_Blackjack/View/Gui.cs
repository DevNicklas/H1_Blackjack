using H1_Blackjack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack.View
{
    /// <summary>
    /// Class <see cref="Gui"/> represents all graphical used in the game
    /// </summary>
    internal class Gui
    {
        /// <summary>
        /// Writes out cards on the table
        /// </summary>
        /// <param name="table">table which the cards is on</param>
        /// <param name="hideDealerCard">does or doesn't hide one dealer card</param>
        public void ShowTable(Table table, bool hideDealerCard)
        {
            Console.Clear();

            // Hides one dealer card
            if(hideDealerCard)
            {
                Console.Write("Dealer: [" + table.DealerCard[0].Face + "] [?]\t Total: " + table.DealerCard[0].Value);
            }

            // Doesn't hide a dealer card
            else
            {
                Console.Write("Dealer: ");

                foreach (Card card in table.DealerCard)
                {
                    Console.Write("[" + card.Face + "] ");
                }

                Console.Write("\t Total: " + table.DealerCardTotal);
            }

            // User cards
            Console.Write("\nUser: ");

            foreach(Card card in table.PlayerCard)
            {
                Console.Write("[" + card.Face + "] ");
            }

            Console.WriteLine("\t Total: " + table.PlayerCardTotal);
        }
        
        /// <summary>
        /// Asks the user to hit or stand
        /// </summary>
        public void ShowHitOrStand()
        {
            Console.WriteLine("\nVil du hit eller stand?");
        }

        /// <summary>
        /// Writes a error message if the user gives a wrong input
        /// </summary>
        public void ShowHitOrStandError()
        {
            Console.WriteLine("Du skrev noget forkert input, prøv igen\n");
        }

        /// <summary>
        /// Writes that the user lost
        /// </summary>
        public void ShowGameLost()
        {
            Console.WriteLine("Du tabte imod dealeren, desværre");
        }
        
        /// <summary>
        /// Writes that the user won
        /// </summary>
        public void ShowGameWon()
        {
            Console.WriteLine("Du er vild, du vandt imod dealeren");
        }
    }
}
