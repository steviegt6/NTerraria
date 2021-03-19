using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.NTerraria.Core.Data.Structures;
using Terraria.NTerraria.Core.IDs;

namespace Terraria.NTerraria.Core.Data
{
    /// <summary>
    /// An instanced class containing a <see cref="Player"/>'s status and other statistics.
    /// </summary>
    public class GameModePlayerData
    {
        public int Level => 1;

        public int FreeModeRank => 0;

        public PlayerClassData Class => new PlayerClassData();

        public GameModeType GameMode => GameModeType.RPGRegular;

        public Color LevelColor => ProcessLevelAsColor(Level);

        private static List<LevelColorThreshold> internalThresholds = new List<LevelColorThreshold>
        {
            new LevelColorThreshold(140, Color.Red),
            new LevelColorThreshold(120, NTCore.DiscoColor),
            new LevelColorThreshold(100, Color.Gold),
            new LevelColorThreshold(80, Color.Silver),
            new LevelColorThreshold(60, Color.Blue),
            new LevelColorThreshold(40, Color.Green),
            new LevelColorThreshold(20, Color.Purple),
            new LevelColorThreshold(10, Color.White),
            new LevelColorThreshold(0, Color.Gray)
        };

        public static List<LevelColorThreshold> ColorThresholds
        {
            get => internalThresholds.OrderByDescending(threshold => threshold.minLevel).ToList();
            set => internalThresholds = value;
        }

        public Color ProcessLevelAsColor() => ProcessLevelAsColor(Level);

        public static Color ProcessLevelAsColor(int level)
        {
            foreach (LevelColorThreshold threshold in ColorThresholds.Where(threshold => level >= threshold.minLevel))
                return threshold.levelColor;

            return Color.Gray;
        }
    }
}
