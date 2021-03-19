using Microsoft.Xna.Framework;
using Terraria.NTerraria.Core.IDs;

namespace Terraria.NTerraria.Core
{
    public static class NTCore
    {
        public static GameModeType WorldGameMode => GameModeType.Action;

        public static Color DiscoColor => new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
    }
}
