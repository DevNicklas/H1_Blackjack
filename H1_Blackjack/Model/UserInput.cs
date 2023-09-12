using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack.Model
{
    /// <summary>
    /// Class <see cref="UserInput"/> represents all input from user
    /// </summary>
    internal class UserInput
    {
        /// <summary>
        /// Gets input from user
        /// </summary>
        /// <returns>A string. Which contains what the user has written</returns>
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
