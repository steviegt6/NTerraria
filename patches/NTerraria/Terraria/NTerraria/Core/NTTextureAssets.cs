using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Initializers;

namespace Terraria.NTerraria.Core
{
    public static class NTTextureAssets
    {
        public static Asset<Texture2D> ClassIcons;

        internal static void Initialize(AssetRequestMode mode)
        {
            ClassIcons = AssetInitializer.LoadAsset<Texture2D>("N Terraria 6/Misc/intclassicons", mode);
        }
    }
}
