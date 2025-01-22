
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace Astaris.Content.Projectiles.Weapons;

public class RockCrystalBulletProjectile : ModProjectile 
{
    public override void SetStaticDefaults()
    {
        ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
        ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
    }

    public override void SetDefaults()
    {
        Projectile.width = 8;
        Projectile.height = 8;
        Projectile.scale = 1f;
        
        
        Projectile.aiStyle = 1;
        Projectile.friendly = true;
        Projectile.hostile = false;
        
        
        Projectile.penetrate = 5;
        Projectile.timeLeft = 600;
        Projectile.alpha = 255;
        Projectile.light = 0.5f;
        
        Projectile.ignoreWater = true;
        Projectile.tileCollide = true;
        
        Projectile.extraUpdates = 1;
        
        
        AIType = ProjectileID.Bullet;
        
        DrawOriginOffsetY = 2;
        
        // TODO: Get hitbox at tip of sprite
        // See: https://github.com/tModLoader/tModLoader/wiki/Basic-Projectile#rotation
        Projectile.spriteDirection = Projectile.direction;
        
    }

    public override void AI()
    {
        Projectile.rotation = Projectile.velocity.ToRotation();
    }
}