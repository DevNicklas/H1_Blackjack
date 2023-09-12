using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack.Model
{
    /// <summary>
    /// Class <see cref="Table"/> represents the table which the cards of the dealer and the user is on
    /// </summary>
    internal class Table
    {
        private byte[] _dealerCards = new byte[21];
        private byte _dealerCardsCount = 0;
        private byte[] _userCards = new byte[21];
        private byte _userCardsCount = 0;

        public byte[] DealerCards
        {
            get { return _dealerCards; }
            set { _dealerCards = value; }
        }

        public byte[] UserCards
        {
            get { return _userCards; }
            set { _userCards = value; }
        }

        public byte DealerCardsCount
        {
            get { return _dealerCardsCount; }
            set { _dealerCardsCount = value; }
        }

        public byte UserCardsCount
        {
            get { return _userCardsCount; }
            set { _userCardsCount = value; }
        }

        /// <summary>
        /// Gets total sum of cards of a player
        /// </summary>
        /// <param name="isDealer">is a player or not</param>
        /// <returns>A byte. Is the total sum of cards of a player</returns>
        public byte GetTotal(bool isDealer)
        {
            byte total = 0;

            // Total sum of dealer cards
            if(isDealer)
            {
                for (int i = 0; i < _dealerCardsCount; i++)
                {
                    total += _dealerCards[i];
                }
            }

            // Total sum of user cards
            else
            {
                for (int i = 0; i < _userCardsCount; i++)
                {
                    total += _userCards[i];
                }
            }

            return total;
        }

    }
}
