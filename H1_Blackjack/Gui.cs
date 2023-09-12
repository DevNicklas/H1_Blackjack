using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack
{
    /// <summary>
    /// Class <see cref="Gui"/> represents the graphical user interface, which is the console window
    /// </summary>
    internal class Gui
    {
        public void HitOrStay()
        {
            Console.WriteLine("Vil du 'hit' eller 'stay'?");
        }

        public void ErrorHitOrStay()
        {
            Console.WriteLine("Du skal enten skrive hit eller stay\n");
        }

        public void ShowTable(byte dealerCardsTotal, byte userCardsTotal)
        {
            Console.WriteLine($"Du har: {userCardsTotal}");
            Console.WriteLine($"Dealer har: {dealerCardsTotal}");
        }
    }
}
