﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLiteLibrary.Models;
using static BattleshipLiteLibrary.Models.Enums;

namespace BattleshipLiteLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; set; }
        public int SpotNumber { get; set; }
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;
    }
}
