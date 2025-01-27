using Terraria;
using Terraria.ModLoader;

namespace Astaris.Content.Dusts;

public class RockCrystalDust : ModDust
{
    public override void OnSpawn(Dust dust)
    {
        dust.noGravity = true;
        dust.noLight = true;
    }

    public override bool Update(Dust dust)
    {
        dust.position += dust.velocity;
        dust.rotation += dust.velocity.X * 0.15f;
        dust.scale *= 0.9f;
        if (dust.scale < 0.3f)
        {
            dust.active = false;
        }
        Lighting.AddLight(dust.position,0.5f, 0.6f, 0.7f );
        return false;
    }
}