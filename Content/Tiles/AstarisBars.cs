using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.Localization;
using Terraria.ID;

namespace Astaris.Content.Tiles
{
	internal class AstarisBars : ModTile
	{
		public override void SetStaticDefaults()
		{

			Main.tileSolid[Type] = true;
			Main.tileSolidTop[Type] = true;
            Main.tileShine[Type] = 700;
            Main.tileShine2[Type] = true;
            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);

			AddMapEntry(new Color(200, 200, 200), Language.GetText("MapObject.MetalBar"));
		}
	}
}
