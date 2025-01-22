using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Astaris.Content.Tiles;

public class StarlightAltar : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        
        TileID.Sets.DisableSmartCursor[Type] = true;
        
        
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.newTile.CoordinateHeights = new[] {16, 16, 16};
        TileObjectData.newTile.CoordinatePaddingFix = new Point16(0, 2);
        TileObjectData.addTile(Type);
        
        AddMapEntry(new Color(224,188,69), CreateMapEntryName());
    }
}