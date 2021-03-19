using Terraria.NTerraria.Core.Data;
using Terraria.NTerraria.Core.IDs;

namespace Terraria.NTerraria.Core.Extensions
{
    public static class PlayerExtensions
    {
        /// <summary>
        /// Returns a <see cref="GameModePlayerData"/> instance in accordance to the specified <see cref="GameModeType"/>.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="gameMode"></param>
        /// <returns></returns>
        public static GameModePlayerData GetGMPlayerData(this Player player, GameModeType gameMode = GameModeType.Action) =>
            player.StatusList[(int) gameMode];
    }
}
