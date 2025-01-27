using Astaris.Content.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace Astaris.Content.Projectiles.Weapons;

public class RockCrystalProjectile :  ModProjectile
{
    

    
    public override void SetDefaults()
    {
        Projectile.width = 42;
        Projectile.height = 42;
        Projectile.scale = 0.5f;
        DrawOriginOffsetY = 24;
        DrawOriginOffsetX = 24;
        Projectile.friendly = true;
        Projectile.tileCollide = true;
        Projectile.ignoreWater = true;
        
        Projectile.DamageType = DamageClass.Magic;
        
        Projectile.aiStyle = -1;
        
        Projectile.timeLeft = 600;
        
    }
    
    
    public override void AI()
    {
        Projectile.ai[0]++;
        

        
        if (Projectile.ai[0] > 20f)
        {
            Projectile.velocity *= 1.01f;
        }
        else
        {
            Projectile.velocity *= 1.05f;
            if (Projectile.ai[0] >= 150f)
            {
                Projectile.Kill();
            }
        }
        Lighting.AddLight(Projectile.Center, 0.5f, 0.6f, 0.7f);

        if (Main.rand.NextBool(2))
        {
            int numToSpawn = Main.rand.Next(3);
            for (int i = 0; i < numToSpawn; i++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 
                    ModContent.DustType<RockCrystalDust>(), Projectile.velocity.X * 0.1f, 
                    Projectile.velocity.Y * 0.1f, 0, default(Color), 1f);
            }
        }
        
    }
}