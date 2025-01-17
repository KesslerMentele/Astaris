using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Astaris.Content.Projectiles;
using Astaris.Content.Items.Placeables;

namespace Astaris.Content.Tiles
{
    internal class AquamarineShale : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileBrick[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileBlockLight[Type] = true;

            Main.tileSand[Type] = true;
            TileID.Sets.ForAdvancedCollision.ForSandshark[Type] = true;
            TileID.Sets.CanBeDugByShovel[Type] = true;
            TileID.Sets.Falling[Type] = true;
            TileID.Sets.Suffocate[Type] = true;

            // Tells which falling projectile to spawn when the tile should fall.
            TileID.Sets.FallingBlockProjectile[Type] = 
                new TileID.Sets.FallingBlockProjectileInfo(ModContent.ProjectileType<AquamarineShaleBallProjectile>(), 10);
            TileID.Sets.ChecksForMerge[Type] = true;
            MineResist = 1f;
            DustType = DustID.Sand;

            RegisterItemDrop(ModContent.ItemType<AquamarineGem>());
        }



    }
}
