using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack.Model
{
    /// <summary>
    /// Class <see cref="Card"/> represents a card
    /// </summary>
    internal class Card
    {
        private string _face;
        private byte _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class, using multiple arguments
        /// </summary>
        /// <param name="suit">suit of card</param>
        /// <param name="face">face of card</param>
        /// <param name="value">value of card</param>
        public Card(string face, byte value)
        {
            _face = face;
            _value = value;
        }

        public string Face
        {
            get { return _face; }
            set { _face = value; }
        }

        public byte Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
