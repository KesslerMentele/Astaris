using Terraria.ModLoader;
using Astaris.Content.Projectiles.Weapons;
using Terraria.ID;

namespace Astaris.Content.Items.Weapons;

public class CrystalLance : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 56;
        Item.height = 22;
        
        Item.useStyle = ItemUseStyleID.Shoot;
        
        Item.DamageType = DamageClass.Magic;
        Item.noMelee = true;
        Item.mana = 12;
        Item.damage = 24;
        Item.knockBack = 2f;

        Item.useTime = 25;
        Item.useAnimation = 20;
        Item.autoReuse = true;
        
        Item.UseSound = SoundID.Item75;

        Item.shoot = ModContent.ProjectileType<RockCrystalProjectile>();
        Item.shootSpeed = 15f;
    }
}