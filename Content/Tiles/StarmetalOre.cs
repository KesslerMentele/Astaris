﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Astaris.Content.Tiles
{
	internal class StarmetalOre : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;

			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileShine[Type] = 700;
			Main.tileShine2[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 350;

			AddMapEntry(new Color(8, 35, 97), CreateMapEntryName());

			DustType = DustID.Tungsten;  // PLACEHOLDER
			HitSound = SoundID.Tink;

			MineResist = 1.5f;
			MinPick = 50;
		}
	}
}
