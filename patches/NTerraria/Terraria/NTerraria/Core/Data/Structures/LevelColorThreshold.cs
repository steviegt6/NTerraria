using Microsoft.Xna.Framework;

namespace Terraria.NTerraria.Core.Data.Structures
{
    public struct LevelColorThreshold
    {
        public int minLevel;
        public Color levelColor;

        public LevelColorThreshold(int minLevel, Color levelColor)
        {
            this.minLevel = minLevel;
            this.levelColor = levelColor;
        }
    }
}
