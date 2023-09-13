using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack.Model
{
    /// <summary>
    /// Class <see cref="UserInput"/> represents input from user
    /// </summary>
    internal class UserInput
    {
        /// <summary>
        /// Gets a input by user
        /// </summary>
        /// <returns>A string. Input from user</returns>
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
