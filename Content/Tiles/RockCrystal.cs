using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ObjectData;
using static Terraria.ID.ContentSamples.CreativeHelper;
using Terraria.Enums;

namespace Astaris.Content.Tiles
{
    internal class RockCrystal : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;

            Main.tileSolid[Type] = false;
            Main.tileLavaDeath[Type] = false;
            Main.tileNoAttach[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileShine[Type] = 1150;
            Main.tileShine2[Type] = true;


            HitSound = SoundID.Shatter;
            DustType = DustID.GemDiamond;


            // PLACED ON FLOOR
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Height, 0);
            TileObjectData.newTile.StyleMultiplier = 12;
            TileObjectData.newTile.StyleWrapLimit = 3;
            TileObjectData.newTile.RandomStyleRange = 3;


            // PLACED ON CEILING
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Height, 0);
            TileObjectData.addAlternate(3);


            // PLACED ON LEFT WALL
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorLeft = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Height, 0);
            TileObjectData.addAlternate(6);

            // PLACED ON RIGHT WALL
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorRight = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Height, 0);
            TileObjectData.addAlternate(9);

            TileObjectData.addTile(Type);
        }
    }
}
