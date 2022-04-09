using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class PlayerModel
    {
        private string _playerName;

        public string PlayerName
        {
            get { return _playerName; }
        }
        public int PlayerId { get; set; }
        public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();
        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();
        public int ShotCounter { get; set; }

        

        public PlayerModel(int i)
        {
            _playerName = $"Player{i.ToString()}";
            PlayerId = i;
            ShotCounter = 0;
        }

        




    }
}
