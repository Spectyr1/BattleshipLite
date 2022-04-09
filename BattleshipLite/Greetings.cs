using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    public static class Greetings
    {

        public static void WelcomeToGame()
        {
            Console.WriteLine("Welcome to Battleship Lite. Current version is a 2 player battle simulation\n" +
                                "based on the popular game \"Battleship\" by Matel.");
            Console.WriteLine();
            Console.Write("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WelcomePlayer(string player)
        {
            Console.WriteLine($"Hello {player}, Lets get started with setting up the board for play.");
            Console.WriteLine("Be sure to ensure that your opponent isn't watching!");
        }

        public static void WinnerMessage(string winner, int shotCount)
        {
            Console.WriteLine($"Congratulations {winner}!!!! You WIN.");
            Console.WriteLine($"You fired a total of {shotCount} shots.");
        }

    }
}
