using Astaris.Content.Items;
using Astaris.Content.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Astaris.Content.Projectiles
{
    public abstract class AquamarineShaleBallProjectile : ModProjectile
    {
        public override string Texture => "Astaris/Content/Projectiles/AquamarineShaleBallProjectile";

        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.FallingBlockDoesNotFallThroughPlatforms[Type] = true;
            ProjectileID.Sets.ForcePlateDetection[Type] = true;
        }
    }

    public class AquamarineShaleBallFallingProjectile : AquamarineShaleBallProjectile
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            ProjectileID.Sets.FallingBlockTileItem[Type] = new(ModContent.TileType<AquamarineShale>(), ModContent.ItemType<AquamarineGem>());
        }

        public override void SetDefaults()
        {
            // The falling projectile when compared to the sandgun projectile is hostile.
            Projectile.CloneDefaults(ProjectileID.EbonsandBallFalling);
        }
    }
}
