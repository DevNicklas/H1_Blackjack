using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack.Model
{
    /// <summary>
    /// Class <see cref="Table"/> represents the table which holds the cards of the dealer and user
    /// </summary>
    internal class Table
    {
        private List<Card> _dealerCards = new List<Card>();
        private List<Card> _playerCards = new List<Card>();
        private byte _dealerCardsTotal;
        private byte _playerCardsTotal; 

        public List<Card> DealerCard
        {
            get { return _dealerCards; }
            set { _dealerCards = value; }
        }

        public List<Card> PlayerCard
        {
            get { return _playerCards; }
            set { _playerCards = value; }
        }

        public byte DealerCardTotal
        {
            get { return _dealerCardsTotal; }
            set { _dealerCardsTotal = value; }
        }

        public byte PlayerCardTotal
        {
            get { return _playerCardsTotal; }
            set { _playerCardsTotal = value; }
        }
    }
}
