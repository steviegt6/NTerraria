using Microsoft.Xna.Framework;

namespace Terraria.NTerraria.Core.Data
{
    public class PlayerClassRank
    {
        public int ClassLevel => 1;

        public int ClassIcon => 0;

        public int MaxClassLevel => 10;

        public int ClassGrade => ClassLevel == MaxClassLevel ? 1 : 0;

        public Rectangle GetRankRectangle() => new Rectangle(ClassGrade * 44, ClassIcon * 44, 42, 42);
    }
}
