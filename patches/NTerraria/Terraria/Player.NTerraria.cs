using System.Collections.Generic;
using Terraria.NTerraria.Core.Data;

namespace Terraria
{
    public partial class Player
    {
        public List<GameModePlayerData> StatusList =>
            new List<GameModePlayerData>
            {
                new GameModePlayerData()
            };
    }
}
