using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLiteLibrary.Models;

namespace BattleshipLiteLibrary
{
    public static class SetUp
    {
        public static List<PlayerModel> BuildPlayers(int numberOfPlayers)
        {
            List<PlayerModel> result = new List<PlayerModel>();

            for (int j = 0; j < numberOfPlayers; j++)
            {
                PlayerModel player = new PlayerModel(j + 1);
                result.Add(player);
            }
            return result;
        }

        public static void BuildTargetGrid(PlayerModel player)
        {
            List<string> Letters = new List<string> { "A", "B", "C", "D", "E"};

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5};

            foreach (string letter in Letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(player, letter, number);
                }
            }
        }

        private static void AddGridSpot(PlayerModel player, string letter, int number)
        {
            GridSpotModel gridSpot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = Enums.GridSpotStatus.Empty
            };
        }

        public static bool PlaceShip(PlayerModel player, string location)
        {
            throw new NotImplementedException();
        }
    }
}
