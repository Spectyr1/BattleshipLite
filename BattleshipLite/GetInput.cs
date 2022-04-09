using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

namespace BattleshipLite
{
    public static class GetInput
    {
        public static void PlaceShips(PlayerModel player)
        {
            do
            {
                Console.Write($"Where would you like to place ship number {player.ShipLocations.Count + 1} of 5?");
                string location = Console.ReadLine().ToUpper();

                bool isValidLocation = SetUp.PlaceShip(player, location);

                if (!isValidLocation)
                {
                    Console.WriteLine("That is not a valid location. Please try again.");
                }
            }while(player.ShipLocations.Count < 5);
        }

        public static void SetupBoard(List<PlayerModel> players)
        {
            foreach (PlayerModel player in players)
            {
                Greetings.WelcomePlayer(player.PlayerName);

                SetUp.BuildTargetGrid(player);

                GetInput.PlaceShips(player);

                Console.Clear();

            }
        }
    }
}
